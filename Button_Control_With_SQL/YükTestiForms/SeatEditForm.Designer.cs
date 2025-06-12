namespace Button_Control_With_SQL
{
    partial class SeatEditForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numKuvvetSetDegeri = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numBosTakiAsagiHizSet = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numYuktekiHizSet = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numYukariHizSet = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numBasmaYukDegeri = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numKalkmaYukDegeri = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numYukeBasmaZamani = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numTestTekrarSayisi = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numBostaYukariKalkma = new System.Windows.Forms.NumericUpDown();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKuvvetSetDegeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBosTakiAsagiHizSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYuktekiHizSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYukariHizSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBasmaYukDegeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKalkmaYukDegeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYukeBasmaZamani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestTekrarSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBostaYukariKalkma)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(803, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Koltuk Ekle - Güncelle";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.Controls.Add(this.tableLayoutPanel1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 60);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(10);
            this.panelBody.Size = new System.Drawing.Size(803, 371);
            this.panelBody.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numKuvvetSetDegeri, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBosTakiAsagiHizSet, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numYuktekiHizSet, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numYukariHizSet, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numBasmaYukDegeri, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numKalkmaYukDegeri, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numYukeBasmaZamani, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.numTestTekrarSayisi, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.numBostaYukariKalkma, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(3, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 25);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(394, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kuvvet Set Değeri:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numKuvvetSetDegeri
            // 
            this.numKuvvetSetDegeri.DecimalPlaces = 2;
            this.numKuvvetSetDegeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numKuvvetSetDegeri.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numKuvvetSetDegeri.Location = new System.Drawing.Point(394, 33);
            this.numKuvvetSetDegeri.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKuvvetSetDegeri.Name = "numKuvvetSetDegeri";
            this.numKuvvetSetDegeri.Size = new System.Drawing.Size(386, 25);
            this.numKuvvetSetDegeri.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Boş Takı Aşağı Hız Set:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numBosTakiAsagiHizSet
            // 
            this.numBosTakiAsagiHizSet.DecimalPlaces = 2;
            this.numBosTakiAsagiHizSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBosTakiAsagiHizSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numBosTakiAsagiHizSet.Location = new System.Drawing.Point(3, 103);
            this.numBosTakiAsagiHizSet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBosTakiAsagiHizSet.Name = "numBosTakiAsagiHizSet";
            this.numBosTakiAsagiHizSet.Size = new System.Drawing.Size(385, 25);
            this.numBosTakiAsagiHizSet.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(394, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Yükteki Hız Set:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numYuktekiHizSet
            // 
            this.numYuktekiHizSet.DecimalPlaces = 2;
            this.numYuktekiHizSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numYuktekiHizSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numYuktekiHizSet.Location = new System.Drawing.Point(394, 103);
            this.numYuktekiHizSet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numYuktekiHizSet.Name = "numYuktekiHizSet";
            this.numYuktekiHizSet.Size = new System.Drawing.Size(386, 25);
            this.numYuktekiHizSet.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(385, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yukarı Hız Set:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numYukariHizSet
            // 
            this.numYukariHizSet.DecimalPlaces = 2;
            this.numYukariHizSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numYukariHizSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numYukariHizSet.Location = new System.Drawing.Point(3, 173);
            this.numYukariHizSet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numYukariHizSet.Name = "numYukariHizSet";
            this.numYukariHizSet.Size = new System.Drawing.Size(385, 25);
            this.numYukariHizSet.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(394, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(386, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Basma Yük Değeri:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numBasmaYukDegeri
            // 
            this.numBasmaYukDegeri.DecimalPlaces = 2;
            this.numBasmaYukDegeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBasmaYukDegeri.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numBasmaYukDegeri.Location = new System.Drawing.Point(394, 173);
            this.numBasmaYukDegeri.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBasmaYukDegeri.Name = "numBasmaYukDegeri";
            this.numBasmaYukDegeri.Size = new System.Drawing.Size(386, 25);
            this.numBasmaYukDegeri.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(385, 30);
            this.label12.TabIndex = 22;
            this.label12.Text = "Kalkma Yük Değeri:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numKalkmaYukDegeri
            // 
            this.numKalkmaYukDegeri.DecimalPlaces = 2;
            this.numKalkmaYukDegeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numKalkmaYukDegeri.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numKalkmaYukDegeri.Location = new System.Drawing.Point(3, 243);
            this.numKalkmaYukDegeri.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKalkmaYukDegeri.Name = "numKalkmaYukDegeri";
            this.numKalkmaYukDegeri.Size = new System.Drawing.Size(385, 25);
            this.numKalkmaYukDegeri.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(394, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(386, 30);
            this.label13.TabIndex = 24;
            this.label13.Text = "Yüke Basma Zamanı:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numYukeBasmaZamani
            // 
            this.numYukeBasmaZamani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numYukeBasmaZamani.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numYukeBasmaZamani.Location = new System.Drawing.Point(394, 243);
            this.numYukeBasmaZamani.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numYukeBasmaZamani.Name = "numYukeBasmaZamani";
            this.numYukeBasmaZamani.Size = new System.Drawing.Size(386, 25);
            this.numYukeBasmaZamani.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(3, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(385, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "Test Tekrar Sayısı:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTestTekrarSayisi
            // 
            this.numTestTekrarSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTestTekrarSayisi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numTestTekrarSayisi.Location = new System.Drawing.Point(3, 313);
            this.numTestTekrarSayisi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTestTekrarSayisi.Name = "numTestTekrarSayisi";
            this.numTestTekrarSayisi.Size = new System.Drawing.Size(385, 25);
            this.numTestTekrarSayisi.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(394, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(386, 30);
            this.label15.TabIndex = 28;
            this.label15.Text = "Boşta Yukarı Kalkma:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numBostaYukariKalkma
            // 
            this.numBostaYukariKalkma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBostaYukariKalkma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numBostaYukariKalkma.Location = new System.Drawing.Point(394, 313);
            this.numBostaYukariKalkma.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBostaYukariKalkma.Name = "numBostaYukariKalkma";
            this.numBostaYukariKalkma.Size = new System.Drawing.Size(386, 25);
            this.numBostaYukariKalkma.TabIndex = 29;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 431);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(803, 50);
            this.panelFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(691, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(585, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SeatEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 481);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "SeatEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koltuk Düzenle";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKuvvetSetDegeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBosTakiAsagiHizSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYuktekiHizSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYukariHizSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBasmaYukDegeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKalkmaYukDegeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYukeBasmaZamani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestTekrarSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBostaYukariKalkma)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numKuvvetSetDegeri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBosTakiAsagiHizSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numYuktekiHizSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numYukariHizSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numBasmaYukDegeri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numKalkmaYukDegeri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numYukeBasmaZamani;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numTestTekrarSayisi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numBostaYukariKalkma;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}