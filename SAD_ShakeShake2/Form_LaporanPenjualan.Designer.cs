namespace SAD_ShakeShake2
{
    partial class Form_LaporanPenjualan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LaporanPenjualan));
            this.panel_report = new System.Windows.Forms.Panel();
            this.dgv_penjualan = new System.Windows.Forms.DataGridView();
            this.label_totalangka = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.cb_pilih = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_laporanlbrg = new System.Windows.Forms.Label();
            this.pb_back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_report
            // 
            this.panel_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_report.Controls.Add(this.dgv_penjualan);
            this.panel_report.Controls.Add(this.label_totalangka);
            this.panel_report.Controls.Add(this.label_total);
            this.panel_report.Controls.Add(this.cb_pilih);
            this.panel_report.Controls.Add(this.label_laporanlbrg);
            this.panel_report.Controls.Add(this.pb_back);
            this.panel_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_report.Location = new System.Drawing.Point(0, 0);
            this.panel_report.Name = "panel_report";
            this.panel_report.Size = new System.Drawing.Size(1433, 713);
            this.panel_report.TabIndex = 1;
            // 
            // dgv_penjualan
            // 
            this.dgv_penjualan.AllowUserToAddRows = false;
            this.dgv_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(223)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_penjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_penjualan.GridColor = System.Drawing.Color.White;
            this.dgv_penjualan.Location = new System.Drawing.Point(196, 192);
            this.dgv_penjualan.Name = "dgv_penjualan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_penjualan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_penjualan.RowHeadersVisible = false;
            this.dgv_penjualan.RowHeadersWidth = 62;
            this.dgv_penjualan.RowTemplate.Height = 28;
            this.dgv_penjualan.Size = new System.Drawing.Size(1046, 315);
            this.dgv_penjualan.TabIndex = 22;
            // 
            // label_totalangka
            // 
            this.label_totalangka.AutoSize = true;
            this.label_totalangka.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalangka.Location = new System.Drawing.Point(1120, 648);
            this.label_totalangka.Name = "label_totalangka";
            this.label_totalangka.Size = new System.Drawing.Size(24, 33);
            this.label_totalangka.TabIndex = 19;
            this.label_totalangka.Text = "-";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(714, 648);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(286, 33);
            this.label_total.TabIndex = 16;
            this.label_total.Text = "TOTAL PENGHASILAN";
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
            this.label_laporanlbrg.Size = new System.Drawing.Size(419, 55);
            this.label_laporanlbrg.TabIndex = 13;
            this.label_laporanlbrg.Text = "Laporan Penjualan";
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
            // Form_LaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.panel_report);
            this.Name = "Form_LaporanPenjualan";
            this.Text = "Form_LaporanPenjualan";
            this.panel_report.ResumeLayout(false);
            this.panel_report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_report;
        private System.Windows.Forms.DataGridView dgv_penjualan;
        private System.Windows.Forms.Label label_totalangka;
        private System.Windows.Forms.Label label_total;
        private Guna.UI2.WinForms.Guna2ComboBox cb_pilih;
        private System.Windows.Forms.Label label_laporanlbrg;
        private Guna.UI2.WinForms.Guna2PictureBox pb_back;
    }
}