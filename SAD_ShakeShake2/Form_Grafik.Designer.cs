namespace SAD_ShakeShake2
{
    partial class Form_Grafik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Grafik));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_report = new System.Windows.Forms.Panel();
            this.cb_pilih = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_laporanlbrg = new System.Windows.Forms.Label();
            this.pb_back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cb_pilih2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chart_grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_report
            // 
            this.panel_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_report.Controls.Add(this.chart_grafik);
            this.panel_report.Controls.Add(this.cb_pilih2);
            this.panel_report.Controls.Add(this.cb_pilih);
            this.panel_report.Controls.Add(this.label_laporanlbrg);
            this.panel_report.Controls.Add(this.pb_back);
            this.panel_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_report.Location = new System.Drawing.Point(0, 0);
            this.panel_report.Name = "panel_report";
            this.panel_report.Size = new System.Drawing.Size(1433, 713);
            this.panel_report.TabIndex = 2;
            // 
            // cb_pilih
            // 
            this.cb_pilih.BackColor = System.Drawing.Color.Transparent;
            this.cb_pilih.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_pilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pilih.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_pilih.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_pilih.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_pilih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_pilih.ItemHeight = 30;
            this.cb_pilih.Items.AddRange(new object[] {
            "Harian",
            "Mingguan",
            "Bulanan",
            "Tahunan",
            "Semua"});
            this.cb_pilih.Location = new System.Drawing.Point(186, 115);
            this.cb_pilih.Name = "cb_pilih";
            this.cb_pilih.Size = new System.Drawing.Size(378, 36);
            this.cb_pilih.TabIndex = 14;
            this.cb_pilih.SelectedIndexChanged += new System.EventHandler(this.cb_pilih_SelectedIndexChanged);
            // 
            // label_laporanlbrg
            // 
            this.label_laporanlbrg.AutoSize = true;
            this.label_laporanlbrg.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_laporanlbrg.Location = new System.Drawing.Point(153, 22);
            this.label_laporanlbrg.Name = "label_laporanlbrg";
            this.label_laporanlbrg.Size = new System.Drawing.Size(338, 55);
            this.label_laporanlbrg.TabIndex = 13;
            this.label_laporanlbrg.Text = "Laporan Grafik";
            // 
            // pb_back
            // 
            this.pb_back.BackColor = System.Drawing.Color.Transparent;
            this.pb_back.Image = ((System.Drawing.Image)(resources.GetObject("pb_back.Image")));
            this.pb_back.ImageRotate = 0F;
            this.pb_back.Location = new System.Drawing.Point(41, 22);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(80, 57);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 12;
            this.pb_back.TabStop = false;
            this.pb_back.UseTransparentBackground = true;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // cb_pilih2
            // 
            this.cb_pilih2.BackColor = System.Drawing.Color.Transparent;
            this.cb_pilih2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_pilih2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pilih2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_pilih2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_pilih2.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.cb_pilih2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_pilih2.ItemHeight = 30;
            this.cb_pilih2.Location = new System.Drawing.Point(752, 115);
            this.cb_pilih2.Name = "cb_pilih2";
            this.cb_pilih2.Size = new System.Drawing.Size(378, 36);
            this.cb_pilih2.TabIndex = 23;
            this.cb_pilih2.SelectedIndexChanged += new System.EventHandler(this.cb_pilih2_SelectedIndexChanged);
            // 
            // chart_grafik
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_grafik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_grafik.Legends.Add(legend1);
            this.chart_grafik.Location = new System.Drawing.Point(186, 185);
            this.chart_grafik.Name = "chart_grafik";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_grafik.Series.Add(series1);
            this.chart_grafik.Size = new System.Drawing.Size(961, 502);
            this.chart_grafik.TabIndex = 24;
            this.chart_grafik.Text = "chart1";
            // 
            // Form_Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.panel_report);
            this.Name = "Form_Grafik";
            this.Text = "Form_Grafik";
            this.panel_report.ResumeLayout(false);
            this.panel_report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_report;
        private Guna.UI2.WinForms.Guna2ComboBox cb_pilih;
        private System.Windows.Forms.Label label_laporanlbrg;
        private Guna.UI2.WinForms.Guna2PictureBox pb_back;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafik;
        private Guna.UI2.WinForms.Guna2ComboBox cb_pilih2;
    }
}