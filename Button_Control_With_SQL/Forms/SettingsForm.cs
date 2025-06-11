using Button_Control_With_SQL.Models;
using Button_Control_With_SQL.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class SettingsForm : Form
{
    private readonly SeatService _seatService;
    private List<Seat> _seats;
    private PlcService plcService = new PlcService();

    public SettingsForm()
    {
        InitializeComponent();
        string connectionString = $@"Data Source={Application.StartupPath}\veritabani.db;Version=3;";
        _seatService = new SeatService(connectionString);
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
        bool connected = plcService.Connect("192.168.0.1", 0, 1);
        LoadSeatsIntoComboBox();


    }

    private void LoadSeatsIntoComboBox()
    {
        try
        {
            _seats = _seatService.GetAllSeats();
            comboBoxSeats.Items.Clear();

            foreach (var seat in _seats)
            {
                comboBoxSeats.Items.Add(seat.Name);
            }

            if (comboBoxSeats.Items.Count > 0)
                comboBoxSeats.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Seat'leri yüklerken hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void comboBoxSeats_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxSeats.SelectedIndex < 0) return;

        var selectedSeat = _seats[comboBoxSeats.SelectedIndex];

        labelYukeBasmaZamaniValue.Text = selectedSeat.YukeBasmaZamani.ToString();
        labelKuvvetSetDegeriValue.Text = selectedSeat.KuvvetSetDegeri.ToString("F2");
        labelBosTakiAsagiHizSetValue.Text = selectedSeat.BosTakiAsagiHizSet.ToString("F2");
        labelYuktekiHizSetValue.Text = selectedSeat.YuktekiHizSet.ToString("F2");
        labelYukarıHizSetValue.Text = selectedSeat.YukarıHizSet.ToString("F2");
        labelBasmaYukDegeriValue.Text = selectedSeat.BasmaYukDegeri.ToString("F2");
        labelKalkmaYukDegeriValue.Text = selectedSeat.KalkmaYukDegeri.ToString("F2");
        labelTestTekrarSayisiValue.Text = selectedSeat.TestTekrarSayisi.ToString();
        labelBostaYukarıKalkmaValue.Text = selectedSeat.BostaYukarıKalkma.ToString();

    }

    private void button4_Click(object sender, EventArgs e)
    {
        try
        {
            var data = new DataKalici
            {
                ActualPozisyon = float.Parse(labelActualPozisyonValue.Text),

                KuvvetSetDegeri = float.Parse(labelKuvvetSetDegeriValue.Text),
                BosTakiAsagiHizSet = float.Parse(labelBosTakiAsagiHizSetValue.Text),
                YuktekiHizSet = float.Parse(labelYuktekiHizSetValue.Text),
                YukarıHizSet = float.Parse(labelYukarıHizSetValue.Text),
                BasmaYukDegeri = float.Parse(labelBasmaYukDegeriValue.Text),
                KalkmaYukDegeri = float.Parse(labelKalkmaYukDegeriValue.Text),
                TestTekrarSayisi = int.Parse(labelTestTekrarSayisiValue.Text),
                YukeBasmaZamani = int.Parse(labelYukeBasmaZamaniValue.Text),
                BostaYukarıKalkma = int.Parse(labelBostaYukarıKalkmaValue.Text),
            };

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
