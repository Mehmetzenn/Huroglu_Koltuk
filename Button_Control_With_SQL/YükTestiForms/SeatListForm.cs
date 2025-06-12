using Button_Control_With_SQL.Models;
using Button_Control_With_SQL.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Button_Control_With_SQL
{
    public partial class SeatListForm : Form
    {
        private readonly SeatService _seatService;
        private List<Seat> _seats;
        private PlcService plcService = new PlcService();
        private Timer plcTimer;

        public SeatListForm(string connectionString)
        {
            InitializeComponent();
            _seatService = new SeatService(connectionString);
        }

        private void SeatListForm_Load(object sender, EventArgs e)
        {
            // PLC bağlantı kontrolü
            plcTimer = new Timer();
            plcTimer.Interval = 100;
            plcTimer.Tick += PlcTimer_Tick;
            plcTimer.Start();
            SetupDataGridView();
            LoadSeats();

            try
            {
                bool connected = plcService.Connect("192.168.0.1"); // IP'yi buradan değiştir
                if (!connected)
                {
                    MessageBox.Show("PLC'ye bağlanılamadı.");
                    return;
                }

                DataKalici data = plcService.ReadDataKalici();
                VerileriFormaYaz(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri okunamadı: " + ex.Message);
            }
        }
        private void PlcTimer_Tick(object sender, EventArgs e)
        {
            if (IsPlcReachable("192.168.0.1"))
            {
                if (!plcService.IsConnected())
                {
                    plcService.Connect("192.168.0.1", 0, 1); // Slot bilgisi vs.
                }

                label12.Text = "●";
                label12.ForeColor = Color.Green;

                try
                {
                    // Her saniyede bir PLC'den veri oku ve forma yaz
                    DataKalici data = plcService.ReadDataKalici();
                    VerileriFormaYaz(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PLC'den veri okunamadı:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                label12.Text = "●";
                label12.ForeColor = Color.Red;

                plcService.Disconnect(); // Bu metot varsa bağlantıyı kopar
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
        private void SetupDataGridView()
        {
            dataGridViewSeats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSeats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSeats.MultiSelect = false;
            dataGridViewSeats.ReadOnly = true;
            dataGridViewSeats.AllowUserToAddRows = false;
            dataGridViewSeats.AllowUserToDeleteRows = false;
        }

        private void LoadSeats()
        {
            try
            {
                _seats = _seatService.GetAllSeats();
                dataGridViewSeats.DataSource = null;
                dataGridViewSeats.DataSource = _seats;
                FormatGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Koltukları yüklerken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerileriFormaYaz(DataKalici data)
        {
            lblKuvvetSetDegeri.Text = data.KuvvetSetDegeri.ToString();

            lblBosTakiAsagiHizSet.Text = data.BosTakiAsagiHizSet.ToString();
            lblYuktekiHizSet.Text = data.YuktekiHizSet.ToString();
            lblYukarıHizSet.Text = data.YukarıHizSet.ToString();

            lblBasmaYukDegeri.Text = data.BasmaYukDegeri.ToString();
            lblKalkmaYukDegeri.Text = data.KalkmaYukDegeri.ToString();


            lblTestTekrarSayisi.Text = data.TestTekrarSayisi.ToString(); ;
            lblYukeBasmaZamani.Text = data.YukeBasmaZamani.ToString();
            lblBostaYukarıKalkma.Text = data.BostaYukarıKalkma.ToString();
        }
        private void FormatGridHeaders()
        {
            if (dataGridViewSeats.Columns["Name"] != null)
                dataGridViewSeats.Columns["Name"].HeaderText = "Reçete Adı";

            if (dataGridViewSeats.Columns["MaxPozisyon"] != null)
                dataGridViewSeats.Columns["MaxPozisyon"].HeaderText = "Max Poz.";

            if (dataGridViewSeats.Columns["MinPozisyon"] != null)
                dataGridViewSeats.Columns["MinPozisyon"].HeaderText = "Min Poz.";

            if (dataGridViewSeats.Columns["KuvvetSetDegeri"] != null)
                dataGridViewSeats.Columns["KuvvetSetDegeri"].HeaderText = "Kuvvet Set";

            if (dataGridViewSeats.Columns["MaxKuvvet"] != null)
                dataGridViewSeats.Columns["MaxKuvvet"].HeaderText = "Max Kuvvet";

            if (dataGridViewSeats.Columns["BosTakiAsagiHizSet"] != null)
                dataGridViewSeats.Columns["BosTakiAsagiHizSet"].HeaderText = "Boş Aşağı Hız";

            if (dataGridViewSeats.Columns["YuktekiHizSet"] != null)
                dataGridViewSeats.Columns["YuktekiHizSet"].HeaderText = "Yükte Hız";

            if (dataGridViewSeats.Columns["YukarıHizSet"] != null)
                dataGridViewSeats.Columns["YukarıHizSet"].HeaderText = "Yukarı Hız";

            if (dataGridViewSeats.Columns["ManHizSet"] != null)
                dataGridViewSeats.Columns["ManHizSet"].HeaderText = "Manuel Hız";

            if (dataGridViewSeats.Columns["BasmaYukDegeri"] != null)
                dataGridViewSeats.Columns["BasmaYukDegeri"].HeaderText = "Basma Yük";

            if (dataGridViewSeats.Columns["KalkmaYukDegeri"] != null)
                dataGridViewSeats.Columns["KalkmaYukDegeri"].HeaderText = "Kalkma Yük";

            if (dataGridViewSeats.Columns["YukeBasmaZamani"] != null)
                dataGridViewSeats.Columns["YukeBasmaZamani"].HeaderText = "Basma Süresi";

            if (dataGridViewSeats.Columns["TestTekrarSayisi"] != null)
                dataGridViewSeats.Columns["TestTekrarSayisi"].HeaderText = "Tekrar";

            if (dataGridViewSeats.Columns["BostaYukarıKalkma"] != null)
                dataGridViewSeats.Columns["BostaYukarıKalkma"].HeaderText = "Boş Yukarı Kalkma";

            if (dataGridViewSeats.Columns["KuvvetKalibrasyonCarpani"] != null)
                dataGridViewSeats.Columns["KuvvetKalibrasyonCarpani"].HeaderText = "Kalibrasyon Çarpanı";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSeats();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var newSeat = new Seat();
            var editForm = new SeatEditForm(_seatService, newSeat);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadSeats();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSeats.SelectedRows.Count > 0)
            {
                var selectedSeat = (Seat)dataGridViewSeats.SelectedRows[0].DataBoundItem;
                var editForm = new SeatEditForm(_seatService, selectedSeat);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadSeats();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSeats.SelectedRows.Count > 0)
            {
                var selectedSeat = (Seat)dataGridViewSeats.SelectedRows[0].DataBoundItem;
                var confirm = MessageBox.Show(
                    $"'{selectedSeat.Name}' isimli koltuğu silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _seatService.DeleteSeat(selectedSeat.Id);
                        LoadSeats();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Silme işlemi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (_seats == null) return;

            var filteredSeats = _seats;

            if (!string.IsNullOrEmpty(searchText))
            {
                filteredSeats = _seats.Where(s =>
                    s.Name != null && s.Name.ToLower().Contains(searchText)
                ).ToList();
            }

            dataGridViewSeats.DataSource = null;
            dataGridViewSeats.DataSource = filteredSeats;
            FormatGridHeaders();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var selectedSeat = (Seat)dataGridViewSeats.SelectedRows[0].DataBoundItem;
            try
            {
                var data = plcService.ReadDataKalici();
                data.KuvvetSetDegeri = selectedSeat.KuvvetSetDegeri;
                data.BosTakiAsagiHizSet = selectedSeat.BosTakiAsagiHizSet;
                data.YuktekiHizSet = selectedSeat.YuktekiHizSet;
                data.YukarıHizSet = selectedSeat.YukarıHizSet;
                data.BasmaYukDegeri = selectedSeat.BasmaYukDegeri;
                data.KalkmaYukDegeri = selectedSeat.KalkmaYukDegeri;
                data.TestTekrarSayisi = selectedSeat.TestTekrarSayisi;
                data.YukeBasmaZamani = selectedSeat.YukeBasmaZamani;
                data.BostaYukarıKalkma = selectedSeat.BostaYukarıKalkma;
           
                

                // PLC'ye yaz
                plcService.WriteDataKalici(data);
                MessageBox.Show("Veriler başarıyla PLC'ye yazıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Bir veya daha fazla alanda sayı formatı hatalı:\n" + fex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC'ye veri yazılırken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
