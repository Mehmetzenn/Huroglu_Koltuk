using Button_Control_With_SQL.Models;
using Button_Control_With_SQL.Services;
using System;
using System.Windows.Forms;

namespace Button_Control_With_SQL
{
    public partial class SeatEditForm : Form
    {
        private readonly SeatService _seatService;
        private readonly Seat _seat;

        public SeatEditForm(SeatService seatService, Seat seat)
        {
            InitializeComponent();
            _seatService = seatService;
            _seat = seat ?? throw new ArgumentNullException(nameof(seat));
            InitializeForm();
        }

        private void InitializeForm()
        {
            Text = _seat.Id > 0 ? "Koltuk Düzenle" : "Yeni Koltuk Ekle";

            if (_seat.Id > 0) // Edit mode
            {
                txtName.Text = _seat.Name;

                // Kuvvet ayarları
                numKuvvetSetDegeri.Value = (decimal)_seat.KuvvetSetDegeri;

                // Hız ayarları
                numBosTakiAsagiHizSet.Value = (decimal)_seat.BosTakiAsagiHizSet;
                numYuktekiHizSet.Value = (decimal)_seat.YuktekiHizSet;
                numYukariHizSet.Value = (decimal)_seat.YukarıHizSet;

                // Yük ayarları
                numBasmaYukDegeri.Value = (decimal)_seat.BasmaYukDegeri;
                numKalkmaYukDegeri.Value = (decimal)_seat.KalkmaYukDegeri;

                // Zaman ayarları
                numYukeBasmaZamani.Value = _seat.YukeBasmaZamani;
                numBostaYukariKalkma.Value = _seat.BostaYukarıKalkma;

                // Test ayarları
                numTestTekrarSayisi.Value = _seat.TestTekrarSayisi;
            }
            else // New seat - default values
            {
                // Kuvvet ayarları
                numKuvvetSetDegeri.Value = 50m;

                // Hız ayarları
                numBosTakiAsagiHizSet.Value = 10m;
                numYuktekiHizSet.Value = 5m;
                numYukariHizSet.Value = 10m;

                // Yük ayarları
                numBasmaYukDegeri.Value = 80m;
                numKalkmaYukDegeri.Value = 20m;

                // Zaman ayarları
                numYukeBasmaZamani.Value = 5;
                numBostaYukariKalkma.Value = 3;

                // Test ayarları
                numTestTekrarSayisi.Value = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                UpdateSeatFromForm();

                if (_seat.Id > 0)
                {
                    _seatService.UpdateSeat(_seat);
                    MessageBox.Show("Koltuk bilgileri başarıyla güncellendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _seatService.AddSeat(_seat);
                    MessageBox.Show("Yeni koltuk başarıyla eklendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Koltuk adı boş olamaz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            return true;
        }

        private void UpdateSeatFromForm()
        {
            // Temel bilgiler
            _seat.Name = txtName.Text.Trim();

            // Kuvvet ayarları
            _seat.KuvvetSetDegeri = (float)numKuvvetSetDegeri.Value;

            // Hız ayarları
            _seat.BosTakiAsagiHizSet = (float)numBosTakiAsagiHizSet.Value;
            _seat.YuktekiHizSet = (float)numYuktekiHizSet.Value;
            _seat.YukarıHizSet = (float)numYukariHizSet.Value;

            // Yük ayarları
            _seat.BasmaYukDegeri = (float)numBasmaYukDegeri.Value;
            _seat.KalkmaYukDegeri = (float)numKalkmaYukDegeri.Value;

            // Zaman ayarları
            _seat.YukeBasmaZamani = (int)numYukeBasmaZamani.Value;
            _seat.BostaYukarıKalkma = (int)numBostaYukariKalkma.Value;

            // Test ayarları
            _seat.TestTekrarSayisi = (int)numTestTekrarSayisi.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}