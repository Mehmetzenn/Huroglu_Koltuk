using Sharp7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Control_With_SQL.Forms
{
    public partial class Settings : Form
    {
        S7Client plc = new S7Client();
        private PlcService plcService = new PlcService();
        private System.Windows.Forms.Timer plcTimer;
        private System.Windows.Forms.Timer readTimer;
        private System.Windows.Forms.Timer writeTimer;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            bool connected = plcService.Connect("192.168.0.1", 0, 1);
            label29.Text = connected ? "PLC bağlantısı başarılı" : "Bağlantı hatası: ";
            label29.ForeColor = connected ? Color.Green : Color.Red;

            // PLC bağlantı kontrolü için timer
            plcTimer = new System.Windows.Forms.Timer();
            plcTimer.Interval = 3000;
            plcTimer.Tick += PlcTimer_Tick;
            plcTimer.Start();

            //Read 
            readTimer = new System.Windows.Forms.Timer();
            readTimer.Interval = 1000;
            readTimer.Tick += ReadTimer_Tick;
            readTimer.Start();

            ////Write
            //writeTimer = new System.Windows.Forms.Timer();
            //writeTimer.Interval = 1000;
            //writeTimer.Tick += WriteTimer_Tick;
            //writeTimer.Start();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (float.TryParse(textBox4.Text, out float newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.KuvvetSetDegeri = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (float.TryParse(textBox6.Text, out float newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.BosTakiAsagiHizSet = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (float.TryParse(textBox7.Text, out float newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.YuktekiHizSet = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (float.TryParse(textBox8.Text, out float newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.YukarıHizSet = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (float.TryParse(textBox10.Text, out float newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.BasmaYukDegeri = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (float.TryParse(textBox11.Text, out float newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.KalkmaYukDegeri = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (int.TryParse(textBox12.Text, out int newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.TestTekrarSayisi = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (int.TryParse(textBox13.Text, out int newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.YukeBasmaZamani = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (!plcService.IsConnected()) return;

            if (int.TryParse(textBox14.Text, out int newValue))
            {
                try
                {
                    var data = plcService.ReadDataKalici();
                    data.BostaYukarıKalkma = newValue;
                    plcService.WriteDataKalici(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC iletişim hatası: " + ex.Message);
                }
            }
        }




        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            if (!plcService.IsConnected())
                return;

            try
            {
                var result = plcService.ReadDataKalici();

 
                label18.Text = result.KuvvetSetDegeri.ToString();
                label20.Text = result.BosTakiAsagiHizSet.ToString();
                label21.Text = result.YuktekiHizSet.ToString();
                label22.Text = result.YukarıHizSet.ToString();
                label24.Text = result.BasmaYukDegeri.ToString();
                label25.Text = result.KalkmaYukDegeri.ToString();
                label26.Text = result.TestTekrarSayisi.ToString();
                label27.Text = result.YukeBasmaZamani.ToString();
                label28.Text = result.BostaYukarıKalkma.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Okuma hatası: {ex.Message}", "PLC Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlcTimer_Tick(object sender, EventArgs e)
        {
            if (IsPlcReachable("192.168.0.1"))
            {
                if (!plc.Connected)
                {
                    plc.ConnectTo("192.168.0.1", 0, 1);
                }

                label29.Text = "●";
                label29.ForeColor = Color.Green;
            }
            else
            {
                label29.Text = "●";
                label29.ForeColor = Color.Red;
                if (plc.Connected)
                {
                    plc.Disconnect(); // bağlantı gerçekten kopmuşsa
                }
            }
        }

        private bool IsPlcReachable(string ip)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, 500); // 500ms timeout
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}