using System.Windows.Forms;

namespace PlcFormUygulama
{
    partial class DenemeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblKuvvetSetDegeri = new System.Windows.Forms.Label();
            this.lblBosTakiAsagiHizSet = new System.Windows.Forms.Label();
            this.lblYuktekiHizSet = new System.Windows.Forms.Label();
            this.lblYukarıHizSet = new System.Windows.Forms.Label();
            this.lblBasmaYukDegeri = new System.Windows.Forms.Label();
            this.lblKalkmaYukDegeri = new System.Windows.Forms.Label();
            this.lblTestTekrarSayisi = new System.Windows.Forms.Label();
            this.lblYukeBasmaZamani = new System.Windows.Forms.Label();
            this.lblBostaYukarıKalkma = new System.Windows.Forms.Label();
            this.pnlVeriler = new System.Windows.Forms.Panel();
            this.pnlVeriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKuvvetSetDegeri
            // 
            this.lblKuvvetSetDegeri.AutoSize = true;
            this.lblKuvvetSetDegeri.Location = new System.Drawing.Point(63, 9);
            this.lblKuvvetSetDegeri.Name = "lblKuvvetSetDegeri";
            this.lblKuvvetSetDegeri.Size = new System.Drawing.Size(106, 13);
            this.lblKuvvetSetDegeri.TabIndex = 3;
            this.lblKuvvetSetDegeri.Text = "Kuvvet Set Değeri: 0";
            // 
            // lblBosTakiAsagiHizSet
            // 
            this.lblBosTakiAsagiHizSet.AutoSize = true;
            this.lblBosTakiAsagiHizSet.Location = new System.Drawing.Point(175, 9);
            this.lblBosTakiAsagiHizSet.Name = "lblBosTakiAsagiHizSet";
            this.lblBosTakiAsagiHizSet.Size = new System.Drawing.Size(127, 13);
            this.lblBosTakiAsagiHizSet.TabIndex = 5;
            this.lblBosTakiAsagiHizSet.Text = "Boş Takı Aşağı Hız Set: 0";
            this.lblBosTakiAsagiHizSet.Click += new System.EventHandler(this.lblBosTakiAsagiHizSet_Click);
            // 
            // lblYuktekiHizSet
            // 
            this.lblYuktekiHizSet.AutoSize = true;
            this.lblYuktekiHizSet.Location = new System.Drawing.Point(309, 9);
            this.lblYuktekiHizSet.Name = "lblYuktekiHizSet";
            this.lblYuktekiHizSet.Size = new System.Drawing.Size(92, 13);
            this.lblYuktekiHizSet.TabIndex = 6;
            this.lblYuktekiHizSet.Text = "Yükteki Hız Set: 0";
            // 
            // lblYukarıHizSet
            // 
            this.lblYukarıHizSet.AutoSize = true;
            this.lblYukarıHizSet.Location = new System.Drawing.Point(407, 9);
            this.lblYukarıHizSet.Name = "lblYukarıHizSet";
            this.lblYukarıHizSet.Size = new System.Drawing.Size(86, 13);
            this.lblYukarıHizSet.TabIndex = 7;
            this.lblYukarıHizSet.Text = "Yukarı Hız Set: 0";
            // 
            // lblBasmaYukDegeri
            // 
            this.lblBasmaYukDegeri.AutoSize = true;
            this.lblBasmaYukDegeri.Location = new System.Drawing.Point(499, 9);
            this.lblBasmaYukDegeri.Name = "lblBasmaYukDegeri";
            this.lblBasmaYukDegeri.Size = new System.Drawing.Size(107, 13);
            this.lblBasmaYukDegeri.TabIndex = 9;
            this.lblBasmaYukDegeri.Text = "Basma Yük Değeri: 0";
            // 
            // lblKalkmaYukDegeri
            // 
            this.lblKalkmaYukDegeri.AutoSize = true;
            this.lblKalkmaYukDegeri.Location = new System.Drawing.Point(612, 9);
            this.lblKalkmaYukDegeri.Name = "lblKalkmaYukDegeri";
            this.lblKalkmaYukDegeri.Size = new System.Drawing.Size(110, 13);
            this.lblKalkmaYukDegeri.TabIndex = 10;
            this.lblKalkmaYukDegeri.Text = "Kalkma Yük Değeri: 0";
            // 
            // lblTestTekrarSayisi
            // 
            this.lblTestTekrarSayisi.AutoSize = true;
            this.lblTestTekrarSayisi.Location = new System.Drawing.Point(851, 9);
            this.lblTestTekrarSayisi.Name = "lblTestTekrarSayisi";
            this.lblTestTekrarSayisi.Size = new System.Drawing.Size(104, 13);
            this.lblTestTekrarSayisi.TabIndex = 12;
            this.lblTestTekrarSayisi.Text = "Test Tekrar Sayısı: 0";
            // 
            // lblYukeBasmaZamani
            // 
            this.lblYukeBasmaZamani.AutoSize = true;
            this.lblYukeBasmaZamani.Location = new System.Drawing.Point(728, 9);
            this.lblYukeBasmaZamani.Name = "lblYukeBasmaZamani";
            this.lblYukeBasmaZamani.Size = new System.Drawing.Size(117, 13);
            this.lblYukeBasmaZamani.TabIndex = 13;
            this.lblYukeBasmaZamani.Text = "Yüke Basma Zamanı: 0";
            // 
            // lblBostaYukarıKalkma
            // 
            this.lblBostaYukarıKalkma.AutoSize = true;
            this.lblBostaYukarıKalkma.Location = new System.Drawing.Point(961, 9);
            this.lblBostaYukarıKalkma.Name = "lblBostaYukarıKalkma";
            this.lblBostaYukarıKalkma.Size = new System.Drawing.Size(117, 13);
            this.lblBostaYukarıKalkma.TabIndex = 14;
            this.lblBostaYukarıKalkma.Text = "Boşta Yukarı Kalkma: 0";
            // 
            // pnlVeriler
            // 
            this.pnlVeriler.Controls.Add(this.lblBostaYukarıKalkma);
            this.pnlVeriler.Controls.Add(this.lblYukeBasmaZamani);
            this.pnlVeriler.Controls.Add(this.lblTestTekrarSayisi);
            this.pnlVeriler.Controls.Add(this.lblKuvvetSetDegeri);
            this.pnlVeriler.Controls.Add(this.lblKalkmaYukDegeri);
            this.pnlVeriler.Controls.Add(this.lblBosTakiAsagiHizSet);
            this.pnlVeriler.Controls.Add(this.lblBasmaYukDegeri);
            this.pnlVeriler.Controls.Add(this.lblYuktekiHizSet);
            this.pnlVeriler.Controls.Add(this.lblYukarıHizSet);
            this.pnlVeriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVeriler.Location = new System.Drawing.Point(0, 0);
            this.pnlVeriler.Name = "pnlVeriler";
            this.pnlVeriler.Size = new System.Drawing.Size(1106, 130);
            this.pnlVeriler.TabIndex = 15;
            this.pnlVeriler.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVeriler_Paint_1);
            // 
            // DenemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 130);
            this.Controls.Add(this.pnlVeriler);
            this.Name = "DenemeForm";
            this.Text = "PLC Veri Görüntüleme";
            this.Load += new System.EventHandler(this.DenemeForm_Load);
            this.pnlVeriler.ResumeLayout(false);
            this.pnlVeriler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblKuvvetSetDegeri;
        private Label lblBosTakiAsagiHizSet;
        private Label lblYuktekiHizSet;
        private Label lblYukarıHizSet;
        private Label lblBasmaYukDegeri;
        private Label lblKalkmaYukDegeri;
        private Label lblTestTekrarSayisi;
        private Label lblYukeBasmaZamani;
        private Label lblBostaYukarıKalkma;
        private Panel pnlVeriler;
    }
}