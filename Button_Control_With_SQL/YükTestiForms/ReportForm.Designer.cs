namespace Button_Control_With_SQL.Forms
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnRaporOlustur;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnRaporOlustur = new System.Windows.Forms.Button();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblReportNo = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtReportNo = new System.Windows.Forms.TextBox();
            this.txtDrawingNo = new System.Windows.Forms.TextBox();
            this.txtAim = new System.Windows.Forms.TextBox();
            this.lblDrawingNo = new System.Windows.Forms.Label();
            this.lblAim = new System.Windows.Forms.Label();
            this.lblTitleOfText = new System.Windows.Forms.Label();
            this.txtTitleOfText = new System.Windows.Forms.TextBox();
            this.txtSubstitution = new System.Windows.Forms.TextBox();
            this.lblSubstitution = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblTester = new System.Windows.Forms.Label();
            this.txtTester = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductType.Location = new System.Drawing.Point(30, 30);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(122, 21);
            this.lblProductType.TabIndex = 0;
            this.lblProductType.Text = "Product Type : ";
            // 
            // txtProductType
            // 
            this.txtProductType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductType.Location = new System.Drawing.Point(205, 27);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(150, 29);
            this.txtProductType.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(30, 62);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 21);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer :";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCustomer.Location = new System.Drawing.Point(205, 62);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(150, 29);
            this.txtCustomer.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(30, 97);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(128, 21);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name :";
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRaporOlustur.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRaporOlustur.FlatAppearance.BorderSize = 0;
            this.btnRaporOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporOlustur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRaporOlustur.ForeColor = System.Drawing.Color.White;
            this.btnRaporOlustur.Location = new System.Drawing.Point(873, 27);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(180, 50);
            this.btnRaporOlustur.TabIndex = 6;
            this.btnRaporOlustur.Text = "Rapor Oluştur";
            this.btnRaporOlustur.UseVisualStyleBackColor = false;
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // chartReport
            // 
            this.chartReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartReport.BorderlineColor = System.Drawing.Color.Gray;
            this.chartReport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartReport.Location = new System.Drawing.Point(30, 295);
            this.chartReport.Name = "chartReport";
            this.chartReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartReport.Size = new System.Drawing.Size(1023, 403);
            this.chartReport.TabIndex = 7;
            this.chartReport.Text = "chart1";
            // 
            // lblReportNo
            // 
            this.lblReportNo.AutoSize = true;
            this.lblReportNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReportNo.Location = new System.Drawing.Point(30, 135);
            this.lblReportNo.Name = "lblReportNo";
            this.lblReportNo.Size = new System.Drawing.Size(100, 21);
            this.lblReportNo.TabIndex = 8;
            this.lblReportNo.Text = "Report No : ";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductName.Location = new System.Drawing.Point(205, 97);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 29);
            this.txtProductName.TabIndex = 9;
            // 
            // txtReportNo
            // 
            this.txtReportNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtReportNo.Location = new System.Drawing.Point(205, 132);
            this.txtReportNo.Name = "txtReportNo";
            this.txtReportNo.Size = new System.Drawing.Size(150, 29);
            this.txtReportNo.TabIndex = 10;
            // 
            // txtDrawingNo
            // 
            this.txtDrawingNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDrawingNo.Location = new System.Drawing.Point(205, 167);
            this.txtDrawingNo.Name = "txtDrawingNo";
            this.txtDrawingNo.Size = new System.Drawing.Size(150, 29);
            this.txtDrawingNo.TabIndex = 11;
            // 
            // txtAim
            // 
            this.txtAim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAim.Location = new System.Drawing.Point(563, 167);
            this.txtAim.Name = "txtAim";
            this.txtAim.Size = new System.Drawing.Size(150, 29);
            this.txtAim.TabIndex = 12;
            // 
            // lblDrawingNo
            // 
            this.lblDrawingNo.AutoSize = true;
            this.lblDrawingNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDrawingNo.Location = new System.Drawing.Point(30, 170);
            this.lblDrawingNo.Name = "lblDrawingNo";
            this.lblDrawingNo.Size = new System.Drawing.Size(115, 21);
            this.lblDrawingNo.TabIndex = 13;
            this.lblDrawingNo.Text = "Drawimg No :";
            // 
            // lblAim
            // 
            this.lblAim.AutoSize = true;
            this.lblAim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAim.Location = new System.Drawing.Point(422, 170);
            this.lblAim.Name = "lblAim";
            this.lblAim.Size = new System.Drawing.Size(53, 21);
            this.lblAim.TabIndex = 14;
            this.lblAim.Text = "Aim : ";
            // 
            // lblTitleOfText
            // 
            this.lblTitleOfText.AutoSize = true;
            this.lblTitleOfText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleOfText.Location = new System.Drawing.Point(422, 135);
            this.lblTitleOfText.Name = "lblTitleOfText";
            this.lblTitleOfText.Size = new System.Drawing.Size(114, 21);
            this.lblTitleOfText.TabIndex = 15;
            this.lblTitleOfText.Text = "Title Of Text : ";
            // 
            // txtTitleOfText
            // 
            this.txtTitleOfText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTitleOfText.Location = new System.Drawing.Point(563, 132);
            this.txtTitleOfText.Name = "txtTitleOfText";
            this.txtTitleOfText.Size = new System.Drawing.Size(150, 29);
            this.txtTitleOfText.TabIndex = 16;
            // 
            // txtSubstitution
            // 
            this.txtSubstitution.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSubstitution.Location = new System.Drawing.Point(563, 97);
            this.txtSubstitution.Name = "txtSubstitution";
            this.txtSubstitution.Size = new System.Drawing.Size(150, 29);
            this.txtSubstitution.TabIndex = 17;
            // 
            // lblSubstitution
            // 
            this.lblSubstitution.AutoSize = true;
            this.lblSubstitution.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubstitution.Location = new System.Drawing.Point(422, 100);
            this.lblSubstitution.Name = "lblSubstitution";
            this.lblSubstitution.Size = new System.Drawing.Size(112, 21);
            this.lblSubstitution.TabIndex = 18;
            this.lblSubstitution.Text = "Substitution :";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFileName.Location = new System.Drawing.Point(563, 62);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(150, 29);
            this.txtFileName.TabIndex = 19;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFileName.Location = new System.Drawing.Point(422, 65);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(95, 21);
            this.lblFileName.TabIndex = 20;
            this.lblFileName.Text = "File Name :";
            // 
            // lblTester
            // 
            this.lblTester.AutoSize = true;
            this.lblTester.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTester.Location = new System.Drawing.Point(422, 30);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(63, 21);
            this.lblTester.TabIndex = 21;
            this.lblTester.Text = "Tester :";
            // 
            // txtTester
            // 
            this.txtTester.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTester.Location = new System.Drawing.Point(563, 27);
            this.txtTester.Name = "txtTester";
            this.txtTester.Size = new System.Drawing.Size(150, 29);
            this.txtTester.TabIndex = 22;
            // 
            // ReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 718);
            this.Controls.Add(this.txtTester);
            this.Controls.Add(this.lblTester);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblSubstitution);
            this.Controls.Add(this.txtSubstitution);
            this.Controls.Add(this.txtTitleOfText);
            this.Controls.Add(this.lblTitleOfText);
            this.Controls.Add(this.lblAim);
            this.Controls.Add(this.lblDrawingNo);
            this.Controls.Add(this.txtAim);
            this.Controls.Add(this.txtDrawingNo);
            this.Controls.Add(this.txtReportNo);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblReportNo);
            this.Controls.Add(this.chartReport);
            this.Controls.Add(this.btnRaporOlustur);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtProductType);
            this.Controls.Add(this.lblProductType);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MinimumSize = new System.Drawing.Size(960, 650);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Formu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblReportNo;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtReportNo;
        private System.Windows.Forms.TextBox txtDrawingNo;
        private System.Windows.Forms.TextBox txtAim;
        private System.Windows.Forms.Label lblDrawingNo;
        private System.Windows.Forms.Label lblAim;
        private System.Windows.Forms.Label lblTitleOfText;
        private System.Windows.Forms.TextBox txtTitleOfText;
        private System.Windows.Forms.TextBox txtSubstitution;
        private System.Windows.Forms.Label lblSubstitution;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.TextBox txtTester;
    }
}
