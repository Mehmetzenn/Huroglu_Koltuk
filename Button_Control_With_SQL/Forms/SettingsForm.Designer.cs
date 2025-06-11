partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.ComboBox comboBoxSeats;

    private System.Windows.Forms.Label labelYukeBasmaZamani;
    private System.Windows.Forms.Label labelYukeBasmaZamaniValue;

    private System.Windows.Forms.Label labelActualPozisyon;
    private System.Windows.Forms.Label labelActualPozisyonValue;

    private System.Windows.Forms.Label labelMaxPozisyon;
    private System.Windows.Forms.Label labelMaxPozisyonValue;

    private System.Windows.Forms.Label labelMinPozisyon;
    private System.Windows.Forms.Label labelMinPozisyonValue;

    private System.Windows.Forms.Label labelKuvvetSetDegeri;
    private System.Windows.Forms.Label labelKuvvetSetDegeriValue;

    private System.Windows.Forms.Label labelMaxKuvvet;
    private System.Windows.Forms.Label labelMaxKuvvetValue;

    private System.Windows.Forms.Label labelBosTakiAsagiHizSet;
    private System.Windows.Forms.Label labelBosTakiAsagiHizSetValue;

    private System.Windows.Forms.Label labelYuktekiHizSet;
    private System.Windows.Forms.Label labelYuktekiHizSetValue;

    private System.Windows.Forms.Label labelYukarıHizSet;
    private System.Windows.Forms.Label labelYukarıHizSetValue;

    private System.Windows.Forms.Label labelManHizSet;
    private System.Windows.Forms.Label labelManHizSetValue;

    private System.Windows.Forms.Label labelBasmaYukDegeri;
    private System.Windows.Forms.Label labelBasmaYukDegeriValue;

    private System.Windows.Forms.Label labelKalkmaYukDegeri;
    private System.Windows.Forms.Label labelKalkmaYukDegeriValue;

    private System.Windows.Forms.Label labelTestTekrarSayisi;
    private System.Windows.Forms.Label labelTestTekrarSayisiValue;

    private System.Windows.Forms.Label labelBostaYukarıKalkma;
    private System.Windows.Forms.Label labelBostaYukarıKalkmaValue;

    private System.Windows.Forms.Label labelKuvvetKalibrasyonCarpani;
    private System.Windows.Forms.Label labelKuvvetKalibrasyonCarpaniValue;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.comboBoxSeats = new System.Windows.Forms.ComboBox();
            this.labelYukeBasmaZamani = new System.Windows.Forms.Label();
            this.labelYukeBasmaZamaniValue = new System.Windows.Forms.Label();
            this.labelActualPozisyon = new System.Windows.Forms.Label();
            this.labelActualPozisyonValue = new System.Windows.Forms.Label();
            this.labelMaxPozisyon = new System.Windows.Forms.Label();
            this.labelMaxPozisyonValue = new System.Windows.Forms.Label();
            this.labelMinPozisyon = new System.Windows.Forms.Label();
            this.labelMinPozisyonValue = new System.Windows.Forms.Label();
            this.labelKuvvetSetDegeri = new System.Windows.Forms.Label();
            this.labelKuvvetSetDegeriValue = new System.Windows.Forms.Label();
            this.labelMaxKuvvet = new System.Windows.Forms.Label();
            this.labelMaxKuvvetValue = new System.Windows.Forms.Label();
            this.labelBosTakiAsagiHizSet = new System.Windows.Forms.Label();
            this.labelBosTakiAsagiHizSetValue = new System.Windows.Forms.Label();
            this.labelYuktekiHizSet = new System.Windows.Forms.Label();
            this.labelYuktekiHizSetValue = new System.Windows.Forms.Label();
            this.labelYukarıHizSet = new System.Windows.Forms.Label();
            this.labelYukarıHizSetValue = new System.Windows.Forms.Label();
            this.labelManHizSet = new System.Windows.Forms.Label();
            this.labelManHizSetValue = new System.Windows.Forms.Label();
            this.labelBasmaYukDegeri = new System.Windows.Forms.Label();
            this.labelBasmaYukDegeriValue = new System.Windows.Forms.Label();
            this.labelKalkmaYukDegeri = new System.Windows.Forms.Label();
            this.labelKalkmaYukDegeriValue = new System.Windows.Forms.Label();
            this.labelTestTekrarSayisi = new System.Windows.Forms.Label();
            this.labelTestTekrarSayisiValue = new System.Windows.Forms.Label();
            this.labelBostaYukarıKalkma = new System.Windows.Forms.Label();
            this.labelBostaYukarıKalkmaValue = new System.Windows.Forms.Label();
            this.labelKuvvetKalibrasyonCarpani = new System.Windows.Forms.Label();
            this.labelKuvvetKalibrasyonCarpaniValue = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSeats
            // 
            this.comboBoxSeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeats.FormattingEnabled = true;
            this.comboBoxSeats.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSeats.Name = "comboBoxSeats";
            this.comboBoxSeats.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSeats.TabIndex = 0;
            this.comboBoxSeats.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeats_SelectedIndexChanged);
            // 
            // labelYukeBasmaZamani
            // 
            this.labelYukeBasmaZamani.AutoSize = true;
            this.labelYukeBasmaZamani.Location = new System.Drawing.Point(12, 50);
            this.labelYukeBasmaZamani.Name = "labelYukeBasmaZamani";
            this.labelYukeBasmaZamani.Size = new System.Drawing.Size(108, 13);
            this.labelYukeBasmaZamani.TabIndex = 1;
            this.labelYukeBasmaZamani.Text = "Yüke Basma Zamanı:";
            // 
            // labelYukeBasmaZamaniValue
            // 
            this.labelYukeBasmaZamaniValue.AutoSize = true;
            this.labelYukeBasmaZamaniValue.Location = new System.Drawing.Point(180, 50);
            this.labelYukeBasmaZamaniValue.Name = "labelYukeBasmaZamaniValue";
            this.labelYukeBasmaZamaniValue.Size = new System.Drawing.Size(10, 13);
            this.labelYukeBasmaZamaniValue.TabIndex = 2;
            this.labelYukeBasmaZamaniValue.Text = "-";
            // 
            // labelActualPozisyon
            // 
            this.labelActualPozisyon.AutoSize = true;
            this.labelActualPozisyon.Location = new System.Drawing.Point(12, 80);
            this.labelActualPozisyon.Name = "labelActualPozisyon";
            this.labelActualPozisyon.Size = new System.Drawing.Size(85, 13);
            this.labelActualPozisyon.TabIndex = 3;
            this.labelActualPozisyon.Text = "Actual Pozisyon:";
            // 
            // labelActualPozisyonValue
            // 
            this.labelActualPozisyonValue.AutoSize = true;
            this.labelActualPozisyonValue.Location = new System.Drawing.Point(180, 80);
            this.labelActualPozisyonValue.Name = "labelActualPozisyonValue";
            this.labelActualPozisyonValue.Size = new System.Drawing.Size(10, 13);
            this.labelActualPozisyonValue.TabIndex = 4;
            this.labelActualPozisyonValue.Text = "-";
            // 
            // labelMaxPozisyon
            // 
            this.labelMaxPozisyon.AutoSize = true;
            this.labelMaxPozisyon.Location = new System.Drawing.Point(12, 110);
            this.labelMaxPozisyon.Name = "labelMaxPozisyon";
            this.labelMaxPozisyon.Size = new System.Drawing.Size(75, 13);
            this.labelMaxPozisyon.TabIndex = 5;
            this.labelMaxPozisyon.Text = "Max Pozisyon:";
            // 
            // labelMaxPozisyonValue
            // 
            this.labelMaxPozisyonValue.AutoSize = true;
            this.labelMaxPozisyonValue.Location = new System.Drawing.Point(180, 110);
            this.labelMaxPozisyonValue.Name = "labelMaxPozisyonValue";
            this.labelMaxPozisyonValue.Size = new System.Drawing.Size(10, 13);
            this.labelMaxPozisyonValue.TabIndex = 6;
            this.labelMaxPozisyonValue.Text = "-";
            // 
            // labelMinPozisyon
            // 
            this.labelMinPozisyon.AutoSize = true;
            this.labelMinPozisyon.Location = new System.Drawing.Point(12, 140);
            this.labelMinPozisyon.Name = "labelMinPozisyon";
            this.labelMinPozisyon.Size = new System.Drawing.Size(72, 13);
            this.labelMinPozisyon.TabIndex = 7;
            this.labelMinPozisyon.Text = "Min Pozisyon:";
            // 
            // labelMinPozisyonValue
            // 
            this.labelMinPozisyonValue.AutoSize = true;
            this.labelMinPozisyonValue.Location = new System.Drawing.Point(180, 140);
            this.labelMinPozisyonValue.Name = "labelMinPozisyonValue";
            this.labelMinPozisyonValue.Size = new System.Drawing.Size(10, 13);
            this.labelMinPozisyonValue.TabIndex = 8;
            this.labelMinPozisyonValue.Text = "-";
            // 
            // labelKuvvetSetDegeri
            // 
            this.labelKuvvetSetDegeri.AutoSize = true;
            this.labelKuvvetSetDegeri.Location = new System.Drawing.Point(12, 170);
            this.labelKuvvetSetDegeri.Name = "labelKuvvetSetDegeri";
            this.labelKuvvetSetDegeri.Size = new System.Drawing.Size(97, 13);
            this.labelKuvvetSetDegeri.TabIndex = 9;
            this.labelKuvvetSetDegeri.Text = "Kuvvet Set Değeri:";
            // 
            // labelKuvvetSetDegeriValue
            // 
            this.labelKuvvetSetDegeriValue.AutoSize = true;
            this.labelKuvvetSetDegeriValue.Location = new System.Drawing.Point(180, 170);
            this.labelKuvvetSetDegeriValue.Name = "labelKuvvetSetDegeriValue";
            this.labelKuvvetSetDegeriValue.Size = new System.Drawing.Size(10, 13);
            this.labelKuvvetSetDegeriValue.TabIndex = 10;
            this.labelKuvvetSetDegeriValue.Text = "-";
            // 
            // labelMaxKuvvet
            // 
            this.labelMaxKuvvet.AutoSize = true;
            this.labelMaxKuvvet.Location = new System.Drawing.Point(12, 200);
            this.labelMaxKuvvet.Name = "labelMaxKuvvet";
            this.labelMaxKuvvet.Size = new System.Drawing.Size(67, 13);
            this.labelMaxKuvvet.TabIndex = 11;
            this.labelMaxKuvvet.Text = "Max Kuvvet:";
            // 
            // labelMaxKuvvetValue
            // 
            this.labelMaxKuvvetValue.AutoSize = true;
            this.labelMaxKuvvetValue.Location = new System.Drawing.Point(180, 200);
            this.labelMaxKuvvetValue.Name = "labelMaxKuvvetValue";
            this.labelMaxKuvvetValue.Size = new System.Drawing.Size(10, 13);
            this.labelMaxKuvvetValue.TabIndex = 12;
            this.labelMaxKuvvetValue.Text = "-";
            // 
            // labelBosTakiAsagiHizSet
            // 
            this.labelBosTakiAsagiHizSet.AutoSize = true;
            this.labelBosTakiAsagiHizSet.Location = new System.Drawing.Point(12, 230);
            this.labelBosTakiAsagiHizSet.Name = "labelBosTakiAsagiHizSet";
            this.labelBosTakiAsagiHizSet.Size = new System.Drawing.Size(118, 13);
            this.labelBosTakiAsagiHizSet.TabIndex = 13;
            this.labelBosTakiAsagiHizSet.Text = "Boş Taki Aşağı Hız Set:";
            // 
            // labelBosTakiAsagiHizSetValue
            // 
            this.labelBosTakiAsagiHizSetValue.AutoSize = true;
            this.labelBosTakiAsagiHizSetValue.Location = new System.Drawing.Point(180, 230);
            this.labelBosTakiAsagiHizSetValue.Name = "labelBosTakiAsagiHizSetValue";
            this.labelBosTakiAsagiHizSetValue.Size = new System.Drawing.Size(10, 13);
            this.labelBosTakiAsagiHizSetValue.TabIndex = 14;
            this.labelBosTakiAsagiHizSetValue.Text = "-";
            // 
            // labelYuktekiHizSet
            // 
            this.labelYuktekiHizSet.AutoSize = true;
            this.labelYuktekiHizSet.Location = new System.Drawing.Point(12, 260);
            this.labelYuktekiHizSet.Name = "labelYuktekiHizSet";
            this.labelYuktekiHizSet.Size = new System.Drawing.Size(83, 13);
            this.labelYuktekiHizSet.TabIndex = 15;
            this.labelYuktekiHizSet.Text = "Yükteki Hız Set:";
            // 
            // labelYuktekiHizSetValue
            // 
            this.labelYuktekiHizSetValue.AutoSize = true;
            this.labelYuktekiHizSetValue.Location = new System.Drawing.Point(180, 260);
            this.labelYuktekiHizSetValue.Name = "labelYuktekiHizSetValue";
            this.labelYuktekiHizSetValue.Size = new System.Drawing.Size(10, 13);
            this.labelYuktekiHizSetValue.TabIndex = 16;
            this.labelYuktekiHizSetValue.Text = "-";
            // 
            // labelYukarıHizSet
            // 
            this.labelYukarıHizSet.AutoSize = true;
            this.labelYukarıHizSet.Location = new System.Drawing.Point(12, 290);
            this.labelYukarıHizSet.Name = "labelYukarıHizSet";
            this.labelYukarıHizSet.Size = new System.Drawing.Size(77, 13);
            this.labelYukarıHizSet.TabIndex = 17;
            this.labelYukarıHizSet.Text = "Yukarı Hız Set:";
            // 
            // labelYukarıHizSetValue
            // 
            this.labelYukarıHizSetValue.AutoSize = true;
            this.labelYukarıHizSetValue.Location = new System.Drawing.Point(180, 290);
            this.labelYukarıHizSetValue.Name = "labelYukarıHizSetValue";
            this.labelYukarıHizSetValue.Size = new System.Drawing.Size(10, 13);
            this.labelYukarıHizSetValue.TabIndex = 18;
            this.labelYukarıHizSetValue.Text = "-";
            // 
            // labelManHizSet
            // 
            this.labelManHizSet.AutoSize = true;
            this.labelManHizSet.Location = new System.Drawing.Point(12, 320);
            this.labelManHizSet.Name = "labelManHizSet";
            this.labelManHizSet.Size = new System.Drawing.Size(68, 13);
            this.labelManHizSet.TabIndex = 19;
            this.labelManHizSet.Text = "Man Hız Set:";
            // 
            // labelManHizSetValue
            // 
            this.labelManHizSetValue.AutoSize = true;
            this.labelManHizSetValue.Location = new System.Drawing.Point(180, 320);
            this.labelManHizSetValue.Name = "labelManHizSetValue";
            this.labelManHizSetValue.Size = new System.Drawing.Size(10, 13);
            this.labelManHizSetValue.TabIndex = 20;
            this.labelManHizSetValue.Text = "-";
            // 
            // labelBasmaYukDegeri
            // 
            this.labelBasmaYukDegeri.AutoSize = true;
            this.labelBasmaYukDegeri.Location = new System.Drawing.Point(12, 350);
            this.labelBasmaYukDegeri.Name = "labelBasmaYukDegeri";
            this.labelBasmaYukDegeri.Size = new System.Drawing.Size(98, 13);
            this.labelBasmaYukDegeri.TabIndex = 21;
            this.labelBasmaYukDegeri.Text = "Basma Yük Değeri:";
            // 
            // labelBasmaYukDegeriValue
            // 
            this.labelBasmaYukDegeriValue.AutoSize = true;
            this.labelBasmaYukDegeriValue.Location = new System.Drawing.Point(180, 350);
            this.labelBasmaYukDegeriValue.Name = "labelBasmaYukDegeriValue";
            this.labelBasmaYukDegeriValue.Size = new System.Drawing.Size(10, 13);
            this.labelBasmaYukDegeriValue.TabIndex = 22;
            this.labelBasmaYukDegeriValue.Text = "-";
            // 
            // labelKalkmaYukDegeri
            // 
            this.labelKalkmaYukDegeri.AutoSize = true;
            this.labelKalkmaYukDegeri.Location = new System.Drawing.Point(12, 380);
            this.labelKalkmaYukDegeri.Name = "labelKalkmaYukDegeri";
            this.labelKalkmaYukDegeri.Size = new System.Drawing.Size(101, 13);
            this.labelKalkmaYukDegeri.TabIndex = 23;
            this.labelKalkmaYukDegeri.Text = "Kalkma Yük Değeri:";
            // 
            // labelKalkmaYukDegeriValue
            // 
            this.labelKalkmaYukDegeriValue.AutoSize = true;
            this.labelKalkmaYukDegeriValue.Location = new System.Drawing.Point(180, 380);
            this.labelKalkmaYukDegeriValue.Name = "labelKalkmaYukDegeriValue";
            this.labelKalkmaYukDegeriValue.Size = new System.Drawing.Size(10, 13);
            this.labelKalkmaYukDegeriValue.TabIndex = 24;
            this.labelKalkmaYukDegeriValue.Text = "-";
            // 
            // labelTestTekrarSayisi
            // 
            this.labelTestTekrarSayisi.AutoSize = true;
            this.labelTestTekrarSayisi.Location = new System.Drawing.Point(12, 410);
            this.labelTestTekrarSayisi.Name = "labelTestTekrarSayisi";
            this.labelTestTekrarSayisi.Size = new System.Drawing.Size(95, 13);
            this.labelTestTekrarSayisi.TabIndex = 25;
            this.labelTestTekrarSayisi.Text = "Test Tekrar Sayısı:";
            // 
            // labelTestTekrarSayisiValue
            // 
            this.labelTestTekrarSayisiValue.AutoSize = true;
            this.labelTestTekrarSayisiValue.Location = new System.Drawing.Point(180, 410);
            this.labelTestTekrarSayisiValue.Name = "labelTestTekrarSayisiValue";
            this.labelTestTekrarSayisiValue.Size = new System.Drawing.Size(10, 13);
            this.labelTestTekrarSayisiValue.TabIndex = 26;
            this.labelTestTekrarSayisiValue.Text = "-";
            // 
            // labelBostaYukarıKalkma
            // 
            this.labelBostaYukarıKalkma.AutoSize = true;
            this.labelBostaYukarıKalkma.Location = new System.Drawing.Point(12, 440);
            this.labelBostaYukarıKalkma.Name = "labelBostaYukarıKalkma";
            this.labelBostaYukarıKalkma.Size = new System.Drawing.Size(108, 13);
            this.labelBostaYukarıKalkma.TabIndex = 27;
            this.labelBostaYukarıKalkma.Text = "Boşta Yukarı Kalkma:";
            // 
            // labelBostaYukarıKalkmaValue
            // 
            this.labelBostaYukarıKalkmaValue.AutoSize = true;
            this.labelBostaYukarıKalkmaValue.Location = new System.Drawing.Point(180, 440);
            this.labelBostaYukarıKalkmaValue.Name = "labelBostaYukarıKalkmaValue";
            this.labelBostaYukarıKalkmaValue.Size = new System.Drawing.Size(10, 13);
            this.labelBostaYukarıKalkmaValue.TabIndex = 28;
            this.labelBostaYukarıKalkmaValue.Text = "-";
            // 
            // labelKuvvetKalibrasyonCarpani
            // 
            this.labelKuvvetKalibrasyonCarpani.AutoSize = true;
            this.labelKuvvetKalibrasyonCarpani.Location = new System.Drawing.Point(12, 470);
            this.labelKuvvetKalibrasyonCarpani.Name = "labelKuvvetKalibrasyonCarpani";
            this.labelKuvvetKalibrasyonCarpani.Size = new System.Drawing.Size(140, 13);
            this.labelKuvvetKalibrasyonCarpani.TabIndex = 29;
            this.labelKuvvetKalibrasyonCarpani.Text = "Kuvvet Kalibrasyon Çarpanı:";
            // 
            // labelKuvvetKalibrasyonCarpaniValue
            // 
            this.labelKuvvetKalibrasyonCarpaniValue.AutoSize = true;
            this.labelKuvvetKalibrasyonCarpaniValue.Location = new System.Drawing.Point(180, 470);
            this.labelKuvvetKalibrasyonCarpaniValue.Name = "labelKuvvetKalibrasyonCarpaniValue";
            this.labelKuvvetKalibrasyonCarpaniValue.Size = new System.Drawing.Size(10, 13);
            this.labelKuvvetKalibrasyonCarpaniValue.TabIndex = 30;
            this.labelKuvvetKalibrasyonCarpaniValue.Text = "-";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(55, 518);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 81);
            this.button4.TabIndex = 31;
            this.button4.Text = "Koltuk Değerleri Ata";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(295, 624);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelKuvvetKalibrasyonCarpaniValue);
            this.Controls.Add(this.labelKuvvetKalibrasyonCarpani);
            this.Controls.Add(this.labelBostaYukarıKalkmaValue);
            this.Controls.Add(this.labelBostaYukarıKalkma);
            this.Controls.Add(this.labelTestTekrarSayisiValue);
            this.Controls.Add(this.labelTestTekrarSayisi);
            this.Controls.Add(this.labelKalkmaYukDegeriValue);
            this.Controls.Add(this.labelKalkmaYukDegeri);
            this.Controls.Add(this.labelBasmaYukDegeriValue);
            this.Controls.Add(this.labelBasmaYukDegeri);
            this.Controls.Add(this.labelManHizSetValue);
            this.Controls.Add(this.labelManHizSet);
            this.Controls.Add(this.labelYukarıHizSetValue);
            this.Controls.Add(this.labelYukarıHizSet);
            this.Controls.Add(this.labelYuktekiHizSetValue);
            this.Controls.Add(this.labelYuktekiHizSet);
            this.Controls.Add(this.labelBosTakiAsagiHizSetValue);
            this.Controls.Add(this.labelBosTakiAsagiHizSet);
            this.Controls.Add(this.labelMaxKuvvetValue);
            this.Controls.Add(this.labelMaxKuvvet);
            this.Controls.Add(this.labelKuvvetSetDegeriValue);
            this.Controls.Add(this.labelKuvvetSetDegeri);
            this.Controls.Add(this.labelMinPozisyonValue);
            this.Controls.Add(this.labelMinPozisyon);
            this.Controls.Add(this.labelMaxPozisyonValue);
            this.Controls.Add(this.labelMaxPozisyon);
            this.Controls.Add(this.labelActualPozisyonValue);
            this.Controls.Add(this.labelActualPozisyon);
            this.Controls.Add(this.labelYukeBasmaZamaniValue);
            this.Controls.Add(this.labelYukeBasmaZamani);
            this.Controls.Add(this.comboBoxSeats);
            this.Name = "SettingsForm";
            this.Text = "Koltuk Ayarları";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.Button button4;
}
