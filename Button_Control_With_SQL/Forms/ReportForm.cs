using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
using System.IO;

namespace Button_Control_With_SQL.Forms
{
    public partial class ReportForm : Form
    {
        private PlcService plcService = new PlcService();

        public ReportForm()
        {
            InitializeComponent();
        }

        public void SetChartData(Series sourceSeries)
        {
            chartReport.Series.Clear();

            Series newSeries = new Series("Kuvvet")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Time
            };

            foreach (var point in sourceSeries.Points)
            {
                newSeries.Points.AddXY(point.XValue, point.YValues[0]);
            }

            chartReport.Series.Add(newSeries);
            chartReport.ChartAreas.Clear();

            ChartArea area = new ChartArea
            {
                AxisX = { LabelStyle = { Format = "HH:mm:ss" }, Title = "Zaman" },
                AxisY = { Title = "Kuvvet" }
            };

            chartReport.ChartAreas.Add(area);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            bool connected = plcService.Connect("192.168.0.1", 0, 1);
            // Bağlantı kontrolü ve mesaj gösterimi yapılabilir.
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                var data = plcService.ReadDataKalici();

                // Kullanıcıdan alınan bilgiler
                string productType = txtProductType.Text;
                string fileName = txtFileName.Text;
                string customer = txtCustomer.Text;
                string tester = txtTester.Text;
                string raporNo = txtReportNo.Text;
                string productName = txtProductName.Text;
                string drawingNumber = txtDrawingNo.Text;
                string aim = txtAim.Text;
                string titleOfTest = txtTitleOfText.Text;
                string substitutionValue = txtSubstitution.Text;

                // Dosya yolları
                string orijinalDosyaYolu = @"C:\Users\Mehmet\Downloads\Deneme.xlsx";
                string yeniDosyaYolu = Path.Combine(@"C:\Users\Mehmet\Downloads", $"{fileName}.xlsx");
                DateTime dateTimeNow = DateTime.Now;

                using (var workbook = new XLWorkbook(orijinalDosyaYolu))
                {
                    var worksheet = workbook.Worksheet("CUSHION ENDURANCE");

                    // Tarih
                    worksheet.Range("AJ1:AN1").Merge();
                    worksheet.Cell("AJ1").Value = dateTimeNow;

                    // Temel bilgiler
                    worksheet.Cell("AH4").Value = productType;
                    worksheet.Cell("AF5").Value = customer;
                    worksheet.Cell("AF7").Value = tester;
                    worksheet.Range("AG6:AK6").Merge();
                    worksheet.Cell("AG6").Value = dateTimeNow;
                    worksheet.Cell("AM2").Value = raporNo;
                    worksheet.Range("AK3:AL3").Merge();
                    worksheet.Cell("AK3").Value = "Page 5";
                    worksheet.Range("A4:N4").Merge();
                    worksheet.Cell("A4").Value = $"Product Name: {productName}";
                    worksheet.Cell("F5").Value = drawingNumber;
                    worksheet.Cell("C6").Value = aim;
                    worksheet.Cell("F7").Value = titleOfTest;

                    // Test parametreleri
                    worksheet.Cell("C13").Value = $"b) Load: {data.KuvvetSetDegeri}";
                    worksheet.Cell("F16").Value = data.TestTekrarSayisi;

                    // Substitution değerleri
                    for (int row = 29; row <= 35; row++)
                    {
                        worksheet.Cell($"AE{row}").Value = substitutionValue;
                    }

                    worksheet.Cell("B31").Value = $"* The defection of the seat shall be below than {substitutionValue} mm";

                    // Kaydet
                    workbook.SaveAs(yeniDosyaYolu);
                }

                MessageBox.Show("Rapor başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }
    }
}
