using Button_Control_With_SQL;
using Button_Control_With_SQL.Forms;
using S7.Net;
using Sharp7;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Button_Control_With_SQL.PozisyonTestiForms
{
    public partial class PozisyonPage : Form
    {
        private PlcService plcService = new PlcService();
        private Timer plcTimer;
        private Timer clockTimer;
        private Timer chartTimer;
        private Timer testStateTimer;

        public PozisyonPage()
        {
            InitializeComponent();
        }

        private void PozisyonPage_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

            bool connected = plcService.Connect("192.168.0.1", 0, 1);
            label12.Text = connected ? "PLC bağlantısı başarılı" : "Bağlantı hatası";
            label12.ForeColor = connected ? Color.Green : Color.Red;
            label4.Visible = false;

            chart1.Series.Clear();
            chart1.Series.Add("RandomValues");
            chart1.Series["RandomValues"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["RandomValues"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.Title = "Zaman";
            chart1.ChartAreas[0].AxisY.Title = "Kuvvet";

            button1.Visible = false;

            clockTimer = new Timer { Interval = 200 };
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();

            plcTimer = new Timer { Interval = 3000 };
            plcTimer.Tick += PlcTimer_Tick;
            plcTimer.Start();

            chartTimer = new Timer { Interval = 100 };
            chartTimer.Tick += ChartTimer_Tick;

            testStateTimer = new Timer { Interval = 100 };
            testStateTimer.Tick += TestStateTimer_Tick;
            testStateTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
            if (!plcService.IsConnected())
            {
                label2.Text = label15.Text = "Hata!";
                return;
            }

            try
            {
                var data = plcService.ReadDataGecici();
                var data2 = plcService.ReadDataKalici();

                if (data == null || data2 == null)
                {
                    label2.Text = label15.Text = "Veri alınamadı!";
                    return;
                }
                label5.Text = data2.ActualPozisyon.ToString("F1") + " mm";
                label2.Text = data.ActualKuvvet.ToString("F2") + " kg";
                label15.Text = data.ActualTestSayisi.ToString() + " adet";
                label3.Text = data2.ManHizSet.ToString("F2") + " mm/s";
                label4.Visible = button1.Visible = data.AcilStopButton;
                label4.Text = data.AcilStopButton ? "Acil Stop Buttonu Reset İçin Onaylayınız!!" : string.Empty;
            }
            catch (Exception ex)
            {
                label2.Text = "Okuma hatası: " + ex.Message;
                label15.Text = "Hata!";
            }
        }

        private void TestStateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var data = plcService.ReadDataGecici();
                if (data == null) return;

                if (data.TestDevamEdiyor && !chartTimer.Enabled)
                    chartTimer.Start();
                else if (!data.TestDevamEdiyor && chartTimer.Enabled)
                    chartTimer.Stop();
            }
            catch
            {
                chartTimer.Stop();
            }
        }

        private void ChartTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var value = plcService.ReadDataGecici();
                if (value == null) return;

                double kuvvet = value.ActualKuvvet;
                DateTime now = DateTime.Now;
                chart1.Invoke((MethodInvoker)(() =>
                {
                    chart1.Series["RandomValues"].Points.AddXY(now.ToOADate(), kuvvet);
                }));
            }
            catch (Exception ex)
            {
                chartTimer.Stop();
                MessageBox.Show("Grafik veri okuma hatası: " + ex.Message);
            }
        }

        private void PlcTimer_Tick(object sender, EventArgs e)
        {
            if (IsPlcReachable("192.168.0.1"))
            {
                if (!plcService.IsConnected())
                    plcService.Connect("192.168.0.1", 0, 1);

                label12.Text = "●";
                label12.ForeColor = Color.Green;
            }
            else
            {
                label12.Text = "●";
                label12.ForeColor = Color.Red;
                plcService.Disconnect();
            }
        }

        private bool IsPlcReachable(string ip)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, 500);
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }

        private void SetButtonState(Action<dynamic> action)
        {
            if (!plcService.IsConnected())
            {
                MessageBox.Show("PLC bağlantısı yok!");
                return;
            }

            try
            {
                var data = plcService.ReadDataGecici();
                if (data == null) return;
                action(data);
                plcService.WriteDataGecici(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC yazma hatası: " + ex.Message);
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e) => SetButtonState(d => { d.StartButton = true; d.TestDevamEdiyor = true; });

        private void button4_MouseUp(object sender, MouseEventArgs e) => SetButtonState(d => d.StartButton = false);

        private void button5_Click(object sender, EventArgs e) => SetButtonState(d => d.StopButton = true);

        private void button8_MouseDown(object sender, MouseEventArgs e) => SetButtonState(d => d.AsagiButton = true);

        private void button8_MouseUp(object sender, MouseEventArgs e) => SetButtonState(d => d.AsagiButton = false);

        private void button7_MouseDown(object sender, MouseEventArgs e) => SetButtonState(d => d.YukariButton = true);

        private void button7_MouseUp(object sender, MouseEventArgs e) => SetButtonState(d => d.YukariButton = false);

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={Application.StartupPath}\veritabani.db;Version=3;";
            var seatListForm = new SeatListForm(connectionString);
            seatListForm.Show();
        }

        private void button10_Click(object sender, EventArgs e) => SetButtonState(d => d.AcilStopButton = true);

        private void button1_Click(object sender, EventArgs e) => SetButtonState(d => d.AcilStopButton = false);

        private void button6_Click(object sender, EventArgs e) => new Settings().Show();

        private void button4_Click(object sender, EventArgs e) => chart1.Series["RandomValues"].Points.Clear();

        private void button2_Click(object sender, EventArgs e)
        {
            var raporForm = new ReportForm();
            if (chart1.Series.Count > 0 && chart1.Series[0].Points.Count > 0)
                raporForm.SetChartData(chart1.Series[0]);
            else
                MessageBox.Show("Grafikte gösterilecek veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            raporForm.Show();
        }
    }
}
