namespace Button_Control_With_SQL
{
    partial class SeatListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSeats = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTestSayisi = new System.Windows.Forms.Label();
            this.lblBostaYukarıKalkma = new System.Windows.Forms.Label();
            this.lblYukeBasmaZamani = new System.Windows.Forms.Label();
            this.lblTestTekrarSayisi = new System.Windows.Forms.Label();
            this.lblKuvvetSetDegeri = new System.Windows.Forms.Label();
            this.lblKalkmaYukDegeri = new System.Windows.Forms.Label();
            this.lblBosTakiAsagiHizSet = new System.Windows.Forms.Label();
            this.lblBasmaYukDegeri = new System.Windows.Forms.Label();
            this.lblYuktekiHizSet = new System.Windows.Forms.Label();
            this.lblYukarıHizSet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSeats
            // 
            this.dataGridViewSeats.AllowUserToAddRows = false;
            this.dataGridViewSeats.AllowUserToDeleteRows = false;
            this.dataGridViewSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSeats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSeats.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSeats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSeats.ColumnHeadersHeight = 40;
            this.dataGridViewSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSeats.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSeats.EnableHeadersVisualStyles = false;
            this.dataGridViewSeats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewSeats.Location = new System.Drawing.Point(20, 245);
            this.dataGridViewSeats.Margin = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.dataGridViewSeats.Name = "dataGridViewSeats";
            this.dataGridViewSeats.ReadOnly = true;
            this.dataGridViewSeats.RowHeadersVisible = false;
            this.dataGridViewSeats.RowTemplate.Height = 30;
            this.dataGridViewSeats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeats.Size = new System.Drawing.Size(1871, 716);
            this.dataGridViewSeats.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(20, 981);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(150, 981);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(280, 981);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(1764, 981);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 40);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Yeni Ekle";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 60);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete Listesi";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(193, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(786, 39);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.button4.Location = new System.Drawing.Point(1665, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 54);
            this.button4.TabIndex = 7;
            this.button4.Text = "Koltuğu PLC Yaz!";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTestSayisi
            // 
            this.lblTestSayisi.AutoSize = true;
            this.lblTestSayisi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestSayisi.Location = new System.Drawing.Point(18, 91);
            this.lblTestSayisi.Name = "lblTestSayisi";
            this.lblTestSayisi.Size = new System.Drawing.Size(169, 37);
            this.lblTestSayisi.TabIndex = 8;
            this.lblTestSayisi.Text = "Reçete Ara..";
            // 
            // lblBostaYukarıKalkma
            // 
            this.lblBostaYukarıKalkma.AutoSize = true;
            this.lblBostaYukarıKalkma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblBostaYukarıKalkma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBostaYukarıKalkma.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBostaYukarıKalkma.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblBostaYukarıKalkma.Location = new System.Drawing.Point(1789, 207);
            this.lblBostaYukarıKalkma.Name = "lblBostaYukarıKalkma";
            this.lblBostaYukarıKalkma.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblBostaYukarıKalkma.Size = new System.Drawing.Size(76, 37);
            this.lblBostaYukarıKalkma.TabIndex = 23;
            this.lblBostaYukarıKalkma.Text = "10";
            // 
            // lblYukeBasmaZamani
            // 
            this.lblYukeBasmaZamani.AutoSize = true;
            this.lblYukeBasmaZamani.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblYukeBasmaZamani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYukeBasmaZamani.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukeBasmaZamani.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblYukeBasmaZamani.Location = new System.Drawing.Point(1448, 208);
            this.lblYukeBasmaZamani.Name = "lblYukeBasmaZamani";
            this.lblYukeBasmaZamani.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblYukeBasmaZamani.Size = new System.Drawing.Size(76, 37);
            this.lblYukeBasmaZamani.TabIndex = 22;
            this.lblYukeBasmaZamani.Text = "10";
            // 
            // lblTestTekrarSayisi
            // 
            this.lblTestTekrarSayisi.AutoSize = true;
            this.lblTestTekrarSayisi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTestTekrarSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestTekrarSayisi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestTekrarSayisi.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTestTekrarSayisi.Location = new System.Drawing.Point(1614, 208);
            this.lblTestTekrarSayisi.Name = "lblTestTekrarSayisi";
            this.lblTestTekrarSayisi.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblTestTekrarSayisi.Size = new System.Drawing.Size(76, 37);
            this.lblTestTekrarSayisi.TabIndex = 21;
            this.lblTestTekrarSayisi.Text = "10";
            // 
            // lblKuvvetSetDegeri
            // 
            this.lblKuvvetSetDegeri.AutoSize = true;
            this.lblKuvvetSetDegeri.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKuvvetSetDegeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKuvvetSetDegeri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKuvvetSetDegeri.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKuvvetSetDegeri.Location = new System.Drawing.Point(419, 206);
            this.lblKuvvetSetDegeri.Name = "lblKuvvetSetDegeri";
            this.lblKuvvetSetDegeri.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblKuvvetSetDegeri.Size = new System.Drawing.Size(76, 37);
            this.lblKuvvetSetDegeri.TabIndex = 15;
            this.lblKuvvetSetDegeri.Text = "10";
            // 
            // lblKalkmaYukDegeri
            // 
            this.lblKalkmaYukDegeri.AutoSize = true;
            this.lblKalkmaYukDegeri.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKalkmaYukDegeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalkmaYukDegeri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalkmaYukDegeri.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKalkmaYukDegeri.Location = new System.Drawing.Point(1271, 208);
            this.lblKalkmaYukDegeri.Name = "lblKalkmaYukDegeri";
            this.lblKalkmaYukDegeri.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblKalkmaYukDegeri.Size = new System.Drawing.Size(76, 37);
            this.lblKalkmaYukDegeri.TabIndex = 20;
            this.lblKalkmaYukDegeri.Text = "10";
            // 
            // lblBosTakiAsagiHizSet
            // 
            this.lblBosTakiAsagiHizSet.AutoSize = true;
            this.lblBosTakiAsagiHizSet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblBosTakiAsagiHizSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBosTakiAsagiHizSet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBosTakiAsagiHizSet.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblBosTakiAsagiHizSet.Location = new System.Drawing.Point(587, 206);
            this.lblBosTakiAsagiHizSet.Name = "lblBosTakiAsagiHizSet";
            this.lblBosTakiAsagiHizSet.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblBosTakiAsagiHizSet.Size = new System.Drawing.Size(76, 37);
            this.lblBosTakiAsagiHizSet.TabIndex = 16;
            this.lblBosTakiAsagiHizSet.Text = "10";
            // 
            // lblBasmaYukDegeri
            // 
            this.lblBasmaYukDegeri.AutoSize = true;
            this.lblBasmaYukDegeri.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblBasmaYukDegeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBasmaYukDegeri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasmaYukDegeri.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblBasmaYukDegeri.Location = new System.Drawing.Point(1097, 208);
            this.lblBasmaYukDegeri.Name = "lblBasmaYukDegeri";
            this.lblBasmaYukDegeri.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblBasmaYukDegeri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBasmaYukDegeri.Size = new System.Drawing.Size(76, 37);
            this.lblBasmaYukDegeri.TabIndex = 19;
            this.lblBasmaYukDegeri.Text = "10";
            // 
            // lblYuktekiHizSet
            // 
            this.lblYuktekiHizSet.AutoSize = true;
            this.lblYuktekiHizSet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblYuktekiHizSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYuktekiHizSet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuktekiHizSet.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblYuktekiHizSet.Location = new System.Drawing.Point(758, 208);
            this.lblYuktekiHizSet.Name = "lblYuktekiHizSet";
            this.lblYuktekiHizSet.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblYuktekiHizSet.Size = new System.Drawing.Size(76, 37);
            this.lblYuktekiHizSet.TabIndex = 17;
            this.lblYuktekiHizSet.Text = "10";
            // 
            // lblYukarıHizSet
            // 
            this.lblYukarıHizSet.AutoSize = true;
            this.lblYukarıHizSet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblYukarıHizSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYukarıHizSet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukarıHizSet.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblYukarıHizSet.Location = new System.Drawing.Point(925, 208);
            this.lblYukarıHizSet.Name = "lblYukarıHizSet";
            this.lblYukarıHizSet.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lblYukarıHizSet.Size = new System.Drawing.Size(76, 37);
            this.lblYukarıHizSet.TabIndex = 18;
            this.lblYukarıHizSet.Text = "11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(19, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Aktif Plc Verileri : ";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(234, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 51);
            this.label12.TabIndex = 25;
            this.label12.Text = "●";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeatListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBostaYukarıKalkma);
            this.Controls.Add(this.lblYukeBasmaZamani);
            this.Controls.Add(this.lblTestTekrarSayisi);
            this.Controls.Add(this.lblKuvvetSetDegeri);
            this.Controls.Add(this.lblKalkmaYukDegeri);
            this.Controls.Add(this.lblBosTakiAsagiHizSet);
            this.Controls.Add(this.lblBasmaYukDegeri);
            this.Controls.Add(this.lblYuktekiHizSet);
            this.Controls.Add(this.lblYukarıHizSet);
            this.Controls.Add(this.lblTestSayisi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewSeats);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(1027, 699);
            this.Name = "SeatListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koltuk Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SeatListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSeats;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTestSayisi;
        private System.Windows.Forms.Label lblBostaYukarıKalkma;
        private System.Windows.Forms.Label lblYukeBasmaZamani;
        private System.Windows.Forms.Label lblTestTekrarSayisi;
        private System.Windows.Forms.Label lblKuvvetSetDegeri;
        private System.Windows.Forms.Label lblKalkmaYukDegeri;
        private System.Windows.Forms.Label lblBosTakiAsagiHizSet;
        private System.Windows.Forms.Label lblBasmaYukDegeri;
        private System.Windows.Forms.Label lblYuktekiHizSet;
        private System.Windows.Forms.Label lblYukarıHizSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
    }
}