namespace SAD_ShakeShake2
{
    partial class Form_LaporanLabaRugi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LaporanLabaRugi));
            this.panel_report = new System.Windows.Forms.Panel();
            this.dgv_labarugi = new System.Windows.Forms.DataGridView();
            this.label_totalangka = new System.Windows.Forms.Label();
            this.label_kerugianangka = new System.Windows.Forms.Label();
            this.label_keuntunganangka = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_kerugian = new System.Windows.Forms.Label();
            this.label_keuntungan = new System.Windows.Forms.Label();
            this.cb_pilih = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_laporanlbrg = new System.Windows.Forms.Label();
            this.pb_back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labarugi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_report
            // 
            this.panel_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_report.Controls.Add(this.dgv_labarugi);
            this.panel_report.Controls.Add(this.label_totalangka);
            this.panel_report.Controls.Add(this.label_kerugianangka);
            this.panel_report.Controls.Add(this.label_keuntunganangka);
            this.panel_report.Controls.Add(this.label_total);
            this.panel_report.Controls.Add(this.label_kerugian);
            this.panel_report.Controls.Add(this.label_keuntungan);
            this.panel_report.Controls.Add(this.cb_pilih);
            this.panel_report.Controls.Add(this.label_laporanlbrg);
            this.panel_report.Controls.Add(this.pb_back);
            this.panel_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_report.Location = new System.Drawing.Point(0, 0);
            this.panel_report.Name = "panel_report";
            this.panel_report.Size = new System.Drawing.Size(1433, 713);
            this.panel_report.TabIndex = 0;
            // 
            // dgv_labarugi
            // 
            this.dgv_labarugi.AllowUserToAddRows = false;
            this.dgv_labarugi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(223)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_labarugi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_labarugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_labarugi.GridColor = System.Drawing.Color.White;
            this.dgv_labarugi.Location = new System.Drawing.Point(196, 192);
            this.dgv_labarugi.Name = "dgv_labarugi";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_labarugi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_labarugi.RowHeadersVisible = false;
            this.dgv_labarugi.RowHeadersWidth = 62;
            this.dgv_labarugi.RowTemplate.Height = 28;
            this.dgv_labarugi.Size = new System.Drawing.Size(1046, 315);
            this.dgv_labarugi.TabIndex = 22;
            // 
            // label_totalangka
            // 
            this.label_totalangka.AutoSize = true;
            this.label_totalangka.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalangka.Location = new System.Drawing.Point(1171, 632);
            this.label_totalangka.Name = "label_totalangka";
            this.label_totalangka.Size = new System.Drawing.Size(24, 33);
            this.label_totalangka.TabIndex = 21;
            this.label_totalangka.Text = "-";
            // 
            // label_kerugianangka
            // 
            this.label_kerugianangka.AutoSize = true;
            this.label_kerugianangka.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kerugianangka.Location = new System.Drawing.Point(1171, 582);
            this.label_kerugianangka.Name = "label_kerugianangka";
            this.label_kerugianangka.Size = new System.Drawing.Size(24, 33);
            this.label_kerugianangka.TabIndex = 20;
            this.label_kerugianangka.Text = "-";
            // 
            // label_keuntunganangka
            // 
            this.label_keuntunganangka.AutoSize = true;
            this.label_keuntunganangka.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keuntunganangka.Location = new System.Drawing.Point(1171, 533);
            this.label_keuntunganangka.Name = "label_keuntunganangka";
            this.label_keuntunganangka.Size = new System.Drawing.Size(24, 33);
            this.label_keuntunganangka.TabIndex = 19;
            this.label_keuntunganangka.Text = "-";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(23)))));
            this.label_total.Location = new System.Drawing.Point(891, 632);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(96, 33);
            this.label_total.TabIndex = 18;
            this.label_total.Text = "TOTAL";
            // 
            // label_kerugian
            // 
            this.label_kerugian.AutoSize = true;
            this.label_kerugian.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kerugian.Location = new System.Drawing.Point(837, 582);
            this.label_kerugian.Name = "label_kerugian";
            this.label_kerugian.Size = new System.Drawing.Size(150, 33);
            this.label_kerugian.TabIndex = 17;
            this.label_kerugian.Text = "KERUGIAN";
            // 
            // label_keuntungan
            // 
            this.label_keuntungan.AutoSize = true;
            this.label_keuntungan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keuntungan.Location = new System.Drawing.Point(791, 533);
            this.label_keuntungan.Name = "label_keuntungan";
            this.label_keuntungan.Size = new System.Drawing.Size(196, 33);
            this.label_keuntungan.TabIndex = 16;
            this.label_keuntungan.Text = "KEUNTUNGAN";
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
            this.label_laporanlbrg.Size = new System.Drawing.Size(417, 55);
            this.label_laporanlbrg.TabIndex = 13;
            this.label_laporanlbrg.Text = "Laporan Laba Rugi";
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
            // Form_LaporanLabaRugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.panel_report);
            this.Name = "Form_LaporanLabaRugi";
            this.Text = "Form_LaporanLabaRugi";
            this.Load += new System.EventHandler(this.Form_LaporanLabaRugi_Load);
            this.panel_report.ResumeLayout(false);
            this.panel_report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labarugi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_report;
        private System.Windows.Forms.Label label_laporanlbrg;
        private Guna.UI2.WinForms.Guna2PictureBox pb_back;
        private Guna.UI2.WinForms.Guna2ComboBox cb_pilih;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_kerugian;
        private System.Windows.Forms.Label label_keuntungan;
        private System.Windows.Forms.Label label_totalangka;
        private System.Windows.Forms.Label label_kerugianangka;
        private System.Windows.Forms.Label label_keuntunganangka;
        private System.Windows.Forms.DataGridView dgv_labarugi;
    }
}