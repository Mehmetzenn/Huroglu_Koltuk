using System;
using System.Windows.Forms;

namespace PlcFormUygulama
{
    public partial class DenemeForm : Form
    {
        private PlcService plcService = new PlcService();

        public DenemeForm()
        {
            InitializeComponent();
        }

        private void DenemeForm_Load(object sender, EventArgs e)
        {
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

        private void pnlVeriler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBosTakiAsagiHizSet_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxPozisyon_Click(object sender, EventArgs e)
        {

        }

        private void pnlVeriler_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
