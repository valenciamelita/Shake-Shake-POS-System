namespace SAD_ShakeShake2
{
    partial class Form_AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddStock));
            this.panel_invent = new System.Windows.Forms.Panel();
            this.label_isisemua = new System.Windows.Forms.Label();
            this.button_save = new Guna.UI2.WinForms.Guna2Button();
            this.label_cancel = new System.Windows.Forms.Label();
            this.tb_jmlproduksi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_jmlproduksi = new System.Windows.Forms.Label();
            this.tb_hrgmodal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_hargamodal = new System.Windows.Forms.Label();
            this.datetimepick_tglbuat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label_tgl = new System.Windows.Forms.Label();
            this.label_stok = new System.Windows.Forms.Label();
            this.label_stoksaatini = new System.Windows.Forms.Label();
            this.label_namaproduk = new System.Windows.Forms.Label();
            this.label_addstock = new System.Windows.Forms.Label();
            this.pb_gambarproduk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb_back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_invent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambarproduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_invent
            // 
            this.panel_invent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_invent.Controls.Add(this.label_isisemua);
            this.panel_invent.Controls.Add(this.button_save);
            this.panel_invent.Controls.Add(this.label_cancel);
            this.panel_invent.Controls.Add(this.tb_jmlproduksi);
            this.panel_invent.Controls.Add(this.label_jmlproduksi);
            this.panel_invent.Controls.Add(this.tb_hrgmodal);
            this.panel_invent.Controls.Add(this.label_hargamodal);
            this.panel_invent.Controls.Add(this.datetimepick_tglbuat);
            this.panel_invent.Controls.Add(this.label_tgl);
            this.panel_invent.Controls.Add(this.label_stok);
            this.panel_invent.Controls.Add(this.label_stoksaatini);
            this.panel_invent.Controls.Add(this.label_namaproduk);
            this.panel_invent.Controls.Add(this.pb_gambarproduk);
            this.panel_invent.Controls.Add(this.label_addstock);
            this.panel_invent.Controls.Add(this.pb_back);
            this.panel_invent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_invent.Location = new System.Drawing.Point(0, 0);
            this.panel_invent.Name = "panel_invent";
            this.panel_invent.Size = new System.Drawing.Size(1433, 713);
            this.panel_invent.TabIndex = 0;
            this.panel_invent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_invent_Paint);
            // 
            // label_isisemua
            // 
            this.label_isisemua.AutoSize = true;
            this.label_isisemua.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isisemua.ForeColor = System.Drawing.Color.Red;
            this.label_isisemua.Location = new System.Drawing.Point(1022, 584);
            this.label_isisemua.Name = "label_isisemua";
            this.label_isisemua.Size = new System.Drawing.Size(376, 28);
            this.label_isisemua.TabIndex = 19;
            this.label_isisemua.Text = "*Please fill out all fields to proceed\r\n";
            this.label_isisemua.Visible = false;
            // 
            // button_save
            // 
            this.button_save.BorderRadius = 11;
            this.button_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(151)))), ((int)(((byte)(110)))));
            this.button_save.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(1185, 645);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(180, 45);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "Save";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_cancel
            // 
            this.label_cancel.AutoSize = true;
            this.label_cancel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(151)))), ((int)(((byte)(110)))));
            this.label_cancel.Location = new System.Drawing.Point(1070, 650);
            this.label_cancel.Name = "label_cancel";
            this.label_cancel.Size = new System.Drawing.Size(99, 33);
            this.label_cancel.TabIndex = 14;
            this.label_cancel.Text = "Cancel";
            this.label_cancel.Click += new System.EventHandler(this.label_cancel_Click);
            // 
            // tb_jmlproduksi
            // 
            this.tb_jmlproduksi.AutoRoundedCorners = true;
            this.tb_jmlproduksi.BorderRadius = 29;
            this.tb_jmlproduksi.BorderThickness = 0;
            this.tb_jmlproduksi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_jmlproduksi.DefaultText = "";
            this.tb_jmlproduksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_jmlproduksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_jmlproduksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_jmlproduksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_jmlproduksi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_jmlproduksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_jmlproduksi.Font = new System.Drawing.Font("Montserrat", 11F);
            this.tb_jmlproduksi.ForeColor = System.Drawing.Color.Black;
            this.tb_jmlproduksi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_jmlproduksi.Location = new System.Drawing.Point(504, 538);
            this.tb_jmlproduksi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_jmlproduksi.Name = "tb_jmlproduksi";
            this.tb_jmlproduksi.PasswordChar = '\0';
            this.tb_jmlproduksi.PlaceholderText = "";
            this.tb_jmlproduksi.SelectedText = "";
            this.tb_jmlproduksi.Size = new System.Drawing.Size(439, 61);
            this.tb_jmlproduksi.TabIndex = 13;
            this.tb_jmlproduksi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_jmlproduksi_KeyPress);
            // 
            // label_jmlproduksi
            // 
            this.label_jmlproduksi.AutoSize = true;
            this.label_jmlproduksi.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jmlproduksi.Location = new System.Drawing.Point(497, 491);
            this.label_jmlproduksi.Name = "label_jmlproduksi";
            this.label_jmlproduksi.Size = new System.Drawing.Size(279, 41);
            this.label_jmlproduksi.TabIndex = 12;
            this.label_jmlproduksi.Text = "Jumlah Produksi";
            // 
            // tb_hrgmodal
            // 
            this.tb_hrgmodal.AutoRoundedCorners = true;
            this.tb_hrgmodal.BorderRadius = 29;
            this.tb_hrgmodal.BorderThickness = 0;
            this.tb_hrgmodal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hrgmodal.DefaultText = "";
            this.tb_hrgmodal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_hrgmodal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_hrgmodal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_hrgmodal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_hrgmodal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_hrgmodal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_hrgmodal.Font = new System.Drawing.Font("Montserrat", 11F);
            this.tb_hrgmodal.ForeColor = System.Drawing.Color.Black;
            this.tb_hrgmodal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_hrgmodal.Location = new System.Drawing.Point(504, 424);
            this.tb_hrgmodal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_hrgmodal.Name = "tb_hrgmodal";
            this.tb_hrgmodal.PasswordChar = '\0';
            this.tb_hrgmodal.PlaceholderText = "";
            this.tb_hrgmodal.SelectedText = "";
            this.tb_hrgmodal.Size = new System.Drawing.Size(439, 61);
            this.tb_hrgmodal.TabIndex = 11;
            this.tb_hrgmodal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_hrgmodal_KeyPress);
            // 
            // label_hargamodal
            // 
            this.label_hargamodal.AutoSize = true;
            this.label_hargamodal.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hargamodal.Location = new System.Drawing.Point(497, 379);
            this.label_hargamodal.Name = "label_hargamodal";
            this.label_hargamodal.Size = new System.Drawing.Size(216, 41);
            this.label_hargamodal.TabIndex = 10;
            this.label_hargamodal.Text = "Harga Modal";
            // 
            // datetimepick_tglbuat
            // 
            this.datetimepick_tglbuat.Animated = true;
            this.datetimepick_tglbuat.AutoRoundedCorners = true;
            this.datetimepick_tglbuat.BackColor = System.Drawing.Color.Transparent;
            this.datetimepick_tglbuat.BorderRadius = 25;
            this.datetimepick_tglbuat.Checked = true;
            this.datetimepick_tglbuat.FillColor = System.Drawing.Color.WhiteSmoke;
            this.datetimepick_tglbuat.Font = new System.Drawing.Font("Montserrat", 10F);
            this.datetimepick_tglbuat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepick_tglbuat.Location = new System.Drawing.Point(504, 311);
            this.datetimepick_tglbuat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepick_tglbuat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepick_tglbuat.Name = "datetimepick_tglbuat";
            this.datetimepick_tglbuat.Size = new System.Drawing.Size(439, 52);
            this.datetimepick_tglbuat.TabIndex = 9;
            this.datetimepick_tglbuat.Value = new System.DateTime(2023, 12, 3, 23, 34, 3, 583);
            // 
            // label_tgl
            // 
            this.label_tgl.AutoSize = true;
            this.label_tgl.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tgl.Location = new System.Drawing.Point(497, 257);
            this.label_tgl.Name = "label_tgl";
            this.label_tgl.Size = new System.Drawing.Size(225, 41);
            this.label_tgl.TabIndex = 8;
            this.label_tgl.Text = "Tanggal Buat";
            // 
            // label_stok
            // 
            this.label_stok.AutoSize = true;
            this.label_stok.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stok.Location = new System.Drawing.Point(751, 172);
            this.label_stok.Name = "label_stok";
            this.label_stok.Size = new System.Drawing.Size(38, 41);
            this.label_stok.TabIndex = 7;
            this.label_stok.Text = "0";
            // 
            // label_stoksaatini
            // 
            this.label_stoksaatini.AutoSize = true;
            this.label_stoksaatini.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stoksaatini.Location = new System.Drawing.Point(522, 172);
            this.label_stoksaatini.Name = "label_stoksaatini";
            this.label_stoksaatini.Size = new System.Drawing.Size(218, 41);
            this.label_stoksaatini.TabIndex = 6;
            this.label_stoksaatini.Text = "Stok Saat Ini:";
            // 
            // label_namaproduk
            // 
            this.label_namaproduk.AutoSize = true;
            this.label_namaproduk.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namaproduk.Location = new System.Drawing.Point(519, 117);
            this.label_namaproduk.Name = "label_namaproduk";
            this.label_namaproduk.Size = new System.Drawing.Size(301, 55);
            this.label_namaproduk.TabIndex = 5;
            this.label_namaproduk.Text = "NamaProduk";
            // 
            // label_addstock
            // 
            this.label_addstock.AutoSize = true;
            this.label_addstock.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addstock.Location = new System.Drawing.Point(163, 23);
            this.label_addstock.Name = "label_addstock";
            this.label_addstock.Size = new System.Drawing.Size(240, 55);
            this.label_addstock.TabIndex = 3;
            this.label_addstock.Text = "Add Stock";
            // 
            // pb_gambarproduk
            // 
            this.pb_gambarproduk.BackColor = System.Drawing.Color.Transparent;
            this.pb_gambarproduk.FillColor = System.Drawing.Color.Transparent;
            this.pb_gambarproduk.ImageRotate = 0F;
            this.pb_gambarproduk.Location = new System.Drawing.Point(200, 117);
            this.pb_gambarproduk.Name = "pb_gambarproduk";
            this.pb_gambarproduk.Size = new System.Drawing.Size(250, 250);
            this.pb_gambarproduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gambarproduk.TabIndex = 4;
            this.pb_gambarproduk.TabStop = false;
            this.pb_gambarproduk.UseTransparentBackground = true;
            // 
            // pb_back
            // 
            this.pb_back.BackColor = System.Drawing.Color.Transparent;
            this.pb_back.Image = ((System.Drawing.Image)(resources.GetObject("pb_back.Image")));
            this.pb_back.ImageRotate = 0F;
            this.pb_back.Location = new System.Drawing.Point(40, 23);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(80, 57);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 2;
            this.pb_back.TabStop = false;
            this.pb_back.UseTransparentBackground = true;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // Form_AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.panel_invent);
            this.Name = "Form_AddStock";
            this.Text = "Form_AddStock";
            this.Load += new System.EventHandler(this.Form_AddStock_Load);
            this.panel_invent.ResumeLayout(false);
            this.panel_invent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambarproduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_invent;
        private Guna.UI2.WinForms.Guna2PictureBox pb_back;
        private System.Windows.Forms.Label label_stoksaatini;
        private System.Windows.Forms.Label label_namaproduk;
        private Guna.UI2.WinForms.Guna2PictureBox pb_gambarproduk;
        private System.Windows.Forms.Label label_addstock;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepick_tglbuat;
        private System.Windows.Forms.Label label_tgl;
        private System.Windows.Forms.Label label_stok;
        private Guna.UI2.WinForms.Guna2TextBox tb_hrgmodal;
        private System.Windows.Forms.Label label_hargamodal;
        private Guna.UI2.WinForms.Guna2TextBox tb_jmlproduksi;
        private System.Windows.Forms.Label label_jmlproduksi;
        private System.Windows.Forms.Label label_cancel;
        private Guna.UI2.WinForms.Guna2Button button_save;
        private System.Windows.Forms.Label label_isisemua;
    }
}