namespace SAD_ShakeShake2
{
    partial class Form_ReportButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_report = new System.Windows.Forms.Panel();
            this.btn_grafik = new Guna.UI2.WinForms.Guna2Button();
            this.btn_labarugi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_penjualan = new Guna.UI2.WinForms.Guna2Button();
            this.label_pilih = new System.Windows.Forms.Label();
            this.panel_report.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_report
            // 
            this.panel_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_report.Controls.Add(this.btn_grafik);
            this.panel_report.Controls.Add(this.btn_labarugi);
            this.panel_report.Controls.Add(this.btn_penjualan);
            this.panel_report.Controls.Add(this.label_pilih);
            this.panel_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_report.Location = new System.Drawing.Point(0, 0);
            this.panel_report.Name = "panel_report";
            this.panel_report.Size = new System.Drawing.Size(1433, 713);
            this.panel_report.TabIndex = 0;
            // 
            // btn_grafik
            // 
            this.btn_grafik.AutoRoundedCorners = true;
            this.btn_grafik.BorderRadius = 30;
            this.btn_grafik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_grafik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_grafik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_grafik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_grafik.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(223)))), ((int)(((byte)(176)))));
            this.btn_grafik.Font = new System.Drawing.Font("Montserrat Thin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grafik.ForeColor = System.Drawing.Color.White;
            this.btn_grafik.Location = new System.Drawing.Point(958, 157);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(261, 62);
            this.btn_grafik.TabIndex = 3;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // btn_labarugi
            // 
            this.btn_labarugi.AutoRoundedCorners = true;
            this.btn_labarugi.BorderRadius = 30;
            this.btn_labarugi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_labarugi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_labarugi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_labarugi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_labarugi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(223)))), ((int)(((byte)(176)))));
            this.btn_labarugi.Font = new System.Drawing.Font("Montserrat Thin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_labarugi.ForeColor = System.Drawing.Color.White;
            this.btn_labarugi.Location = new System.Drawing.Point(599, 157);
            this.btn_labarugi.Name = "btn_labarugi";
            this.btn_labarugi.Size = new System.Drawing.Size(261, 62);
            this.btn_labarugi.TabIndex = 2;
            this.btn_labarugi.Text = "Laba Rugi";
            this.btn_labarugi.Click += new System.EventHandler(this.btn_labarugi_Click);
            // 
            // btn_penjualan
            // 
            this.btn_penjualan.AutoRoundedCorners = true;
            this.btn_penjualan.BorderRadius = 30;
            this.btn_penjualan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_penjualan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_penjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_penjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_penjualan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(223)))), ((int)(((byte)(176)))));
            this.btn_penjualan.Font = new System.Drawing.Font("Montserrat Thin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_penjualan.ForeColor = System.Drawing.Color.White;
            this.btn_penjualan.Location = new System.Drawing.Point(223, 157);
            this.btn_penjualan.Name = "btn_penjualan";
            this.btn_penjualan.Size = new System.Drawing.Size(261, 62);
            this.btn_penjualan.TabIndex = 1;
            this.btn_penjualan.Text = "Penjualan";
            this.btn_penjualan.Click += new System.EventHandler(this.btn_penjualan_Click);
            // 
            // label_pilih
            // 
            this.label_pilih.AutoSize = true;
            this.label_pilih.Font = new System.Drawing.Font("Montserrat Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pilih.Location = new System.Drawing.Point(444, 61);
            this.label_pilih.Name = "label_pilih";
            this.label_pilih.Size = new System.Drawing.Size(535, 61);
            this.label_pilih.TabIndex = 0;
            this.label_pilih.Text = "Pilih Salah Satu Report!";
            // 
            // Form_ReportButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.panel_report);
            this.Name = "Form_ReportButton";
            this.Text = "Form_ReportButton";
            this.panel_report.ResumeLayout(false);
            this.panel_report.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_report;
        private System.Windows.Forms.Label label_pilih;
        private Guna.UI2.WinForms.Guna2Button btn_labarugi;
        private Guna.UI2.WinForms.Guna2Button btn_penjualan;
        private Guna.UI2.WinForms.Guna2Button btn_grafik;
    }
}