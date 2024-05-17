namespace SAD_ShakeShake2
{
    partial class Form_RemoveStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RemoveStock));
            this.panel_invent = new System.Windows.Forms.Panel();
            this.label_isisemua = new System.Windows.Forms.Label();
            this.button_save = new Guna.UI2.WinForms.Guna2Button();
            this.label_cancel = new System.Windows.Forms.Label();
            this.datetimepick_tglbuang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cb_batch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_jmlbuang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_jmlbuang = new System.Windows.Forms.Label();
            this.tb_keterangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_keterangan = new System.Windows.Forms.Label();
            this.label_tglbuang = new System.Windows.Forms.Label();
            this.label_batch = new System.Windows.Forms.Label();
            this.label_stok = new System.Windows.Forms.Label();
            this.label_stoksaatini = new System.Windows.Forms.Label();
            this.label_namaproduk = new System.Windows.Forms.Label();
            this.label_removestock = new System.Windows.Forms.Label();
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
            this.panel_invent.Controls.Add(this.datetimepick_tglbuang);
            this.panel_invent.Controls.Add(this.cb_batch);
            this.panel_invent.Controls.Add(this.tb_jmlbuang);
            this.panel_invent.Controls.Add(this.label_jmlbuang);
            this.panel_invent.Controls.Add(this.tb_keterangan);
            this.panel_invent.Controls.Add(this.label_keterangan);
            this.panel_invent.Controls.Add(this.label_tglbuang);
            this.panel_invent.Controls.Add(this.label_batch);
            this.panel_invent.Controls.Add(this.label_stok);
            this.panel_invent.Controls.Add(this.label_stoksaatini);
            this.panel_invent.Controls.Add(this.label_namaproduk);
            this.panel_invent.Controls.Add(this.pb_gambarproduk);
            this.panel_invent.Controls.Add(this.label_removestock);
            this.panel_invent.Controls.Add(this.pb_back);
            this.panel_invent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_invent.Location = new System.Drawing.Point(0, 0);
            this.panel_invent.Name = "panel_invent";
            this.panel_invent.Size = new System.Drawing.Size(1433, 713);
            this.panel_invent.TabIndex = 0;
            // 
            // label_isisemua
            // 
            this.label_isisemua.AutoSize = true;
            this.label_isisemua.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isisemua.ForeColor = System.Drawing.Color.Red;
            this.label_isisemua.Location = new System.Drawing.Point(521, 272);
            this.label_isisemua.Name = "label_isisemua";
            this.label_isisemua.Size = new System.Drawing.Size(376, 28);
            this.label_isisemua.TabIndex = 26;
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
            this.button_save.Location = new System.Drawing.Point(1223, 647);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(180, 45);
            this.button_save.TabIndex = 25;
            this.button_save.Text = "Save";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_cancel
            // 
            this.label_cancel.AutoSize = true;
            this.label_cancel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(151)))), ((int)(((byte)(110)))));
            this.label_cancel.Location = new System.Drawing.Point(1108, 652);
            this.label_cancel.Name = "label_cancel";
            this.label_cancel.Size = new System.Drawing.Size(99, 33);
            this.label_cancel.TabIndex = 24;
            this.label_cancel.Text = "Cancel";
            this.label_cancel.Click += new System.EventHandler(this.label_cancel_Click);
            // 
            // datetimepick_tglbuang
            // 
            this.datetimepick_tglbuang.Animated = true;
            this.datetimepick_tglbuang.AutoRoundedCorners = true;
            this.datetimepick_tglbuang.BackColor = System.Drawing.Color.Transparent;
            this.datetimepick_tglbuang.BorderRadius = 29;
            this.datetimepick_tglbuang.Checked = true;
            this.datetimepick_tglbuang.FillColor = System.Drawing.Color.White;
            this.datetimepick_tglbuang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.datetimepick_tglbuang.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepick_tglbuang.Location = new System.Drawing.Point(154, 549);
            this.datetimepick_tglbuang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepick_tglbuang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepick_tglbuang.Name = "datetimepick_tglbuang";
            this.datetimepick_tglbuang.Size = new System.Drawing.Size(439, 61);
            this.datetimepick_tglbuang.TabIndex = 23;
            this.datetimepick_tglbuang.Value = new System.DateTime(2023, 12, 3, 23, 34, 3, 583);
            // 
            // cb_batch
            // 
            this.cb_batch.AutoRoundedCorners = true;
            this.cb_batch.BackColor = System.Drawing.Color.Transparent;
            this.cb_batch.BorderRadius = 17;
            this.cb_batch.BorderThickness = 0;
            this.cb_batch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_batch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_batch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_batch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_batch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_batch.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cb_batch.ForeColor = System.Drawing.Color.Black;
            this.cb_batch.ItemHeight = 30;
            this.cb_batch.Location = new System.Drawing.Point(154, 446);
            this.cb_batch.Name = "cb_batch";
            this.cb_batch.Size = new System.Drawing.Size(439, 36);
            this.cb_batch.TabIndex = 22;
            // 
            // tb_jmlbuang
            // 
            this.tb_jmlbuang.AutoRoundedCorners = true;
            this.tb_jmlbuang.BorderRadius = 29;
            this.tb_jmlbuang.BorderThickness = 0;
            this.tb_jmlbuang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_jmlbuang.DefaultText = "";
            this.tb_jmlbuang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_jmlbuang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_jmlbuang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_jmlbuang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_jmlbuang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_jmlbuang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_jmlbuang.Font = new System.Drawing.Font("Montserrat", 11F);
            this.tb_jmlbuang.ForeColor = System.Drawing.Color.Black;
            this.tb_jmlbuang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_jmlbuang.Location = new System.Drawing.Point(641, 549);
            this.tb_jmlbuang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_jmlbuang.Name = "tb_jmlbuang";
            this.tb_jmlbuang.PasswordChar = '\0';
            this.tb_jmlbuang.PlaceholderText = "";
            this.tb_jmlbuang.SelectedText = "";
            this.tb_jmlbuang.Size = new System.Drawing.Size(439, 61);
            this.tb_jmlbuang.TabIndex = 21;
            this.tb_jmlbuang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_jmlbuang_KeyPress);
            // 
            // label_jmlbuang
            // 
            this.label_jmlbuang.AutoSize = true;
            this.label_jmlbuang.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jmlbuang.Location = new System.Drawing.Point(634, 502);
            this.label_jmlbuang.Name = "label_jmlbuang";
            this.label_jmlbuang.Size = new System.Drawing.Size(245, 41);
            this.label_jmlbuang.TabIndex = 20;
            this.label_jmlbuang.Text = "Jumlah Buang";
            // 
            // tb_keterangan
            // 
            this.tb_keterangan.AutoRoundedCorners = true;
            this.tb_keterangan.BorderRadius = 29;
            this.tb_keterangan.BorderThickness = 0;
            this.tb_keterangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_keterangan.DefaultText = "";
            this.tb_keterangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_keterangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_keterangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_keterangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_keterangan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_keterangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_keterangan.Font = new System.Drawing.Font("Montserrat", 11F);
            this.tb_keterangan.ForeColor = System.Drawing.Color.Black;
            this.tb_keterangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_keterangan.Location = new System.Drawing.Point(641, 435);
            this.tb_keterangan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_keterangan.Name = "tb_keterangan";
            this.tb_keterangan.PasswordChar = '\0';
            this.tb_keterangan.PlaceholderText = "";
            this.tb_keterangan.SelectedText = "";
            this.tb_keterangan.Size = new System.Drawing.Size(439, 61);
            this.tb_keterangan.TabIndex = 19;
            // 
            // label_keterangan
            // 
            this.label_keterangan.AutoSize = true;
            this.label_keterangan.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keterangan.Location = new System.Drawing.Point(634, 390);
            this.label_keterangan.Name = "label_keterangan";
            this.label_keterangan.Size = new System.Drawing.Size(201, 41);
            this.label_keterangan.TabIndex = 18;
            this.label_keterangan.Text = "Keterangan";
            // 
            // label_tglbuang
            // 
            this.label_tglbuang.AutoSize = true;
            this.label_tglbuang.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tglbuang.Location = new System.Drawing.Point(147, 502);
            this.label_tglbuang.Name = "label_tglbuang";
            this.label_tglbuang.Size = new System.Drawing.Size(254, 41);
            this.label_tglbuang.TabIndex = 16;
            this.label_tglbuang.Text = "Tanggal Buang";
            // 
            // label_batch
            // 
            this.label_batch.AutoSize = true;
            this.label_batch.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_batch.Location = new System.Drawing.Point(147, 390);
            this.label_batch.Name = "label_batch";
            this.label_batch.Size = new System.Drawing.Size(406, 41);
            this.label_batch.TabIndex = 14;
            this.label_batch.Text = "Batch / Tanggal Produksi";
            // 
            // label_stok
            // 
            this.label_stok.AutoSize = true;
            this.label_stok.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stok.Location = new System.Drawing.Point(748, 221);
            this.label_stok.Name = "label_stok";
            this.label_stok.Size = new System.Drawing.Size(38, 41);
            this.label_stok.TabIndex = 13;
            this.label_stok.Text = "0";
            // 
            // label_stoksaatini
            // 
            this.label_stoksaatini.AutoSize = true;
            this.label_stoksaatini.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stoksaatini.Location = new System.Drawing.Point(519, 221);
            this.label_stoksaatini.Name = "label_stoksaatini";
            this.label_stoksaatini.Size = new System.Drawing.Size(218, 41);
            this.label_stoksaatini.TabIndex = 12;
            this.label_stoksaatini.Text = "Stok Saat Ini:";
            // 
            // label_namaproduk
            // 
            this.label_namaproduk.AutoSize = true;
            this.label_namaproduk.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namaproduk.Location = new System.Drawing.Point(516, 166);
            this.label_namaproduk.Name = "label_namaproduk";
            this.label_namaproduk.Size = new System.Drawing.Size(301, 55);
            this.label_namaproduk.TabIndex = 11;
            this.label_namaproduk.Text = "NamaProduk";
            // 
            // label_removestock
            // 
            this.label_removestock.AutoSize = true;
            this.label_removestock.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_removestock.Location = new System.Drawing.Point(163, 23);
            this.label_removestock.Name = "label_removestock";
            this.label_removestock.Size = new System.Drawing.Size(322, 55);
            this.label_removestock.TabIndex = 9;
            this.label_removestock.Text = "Remove Stock";
            // 
            // pb_gambarproduk
            // 
            this.pb_gambarproduk.BackColor = System.Drawing.Color.Transparent;
            this.pb_gambarproduk.FillColor = System.Drawing.Color.Transparent;
            this.pb_gambarproduk.ImageRotate = 0F;
            this.pb_gambarproduk.Location = new System.Drawing.Point(235, 96);
            this.pb_gambarproduk.Name = "pb_gambarproduk";
            this.pb_gambarproduk.Size = new System.Drawing.Size(250, 250);
            this.pb_gambarproduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gambarproduk.TabIndex = 10;
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
            this.pb_back.TabIndex = 8;
            this.pb_back.TabStop = false;
            this.pb_back.UseTransparentBackground = true;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // Form_RemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.panel_invent);
            this.Name = "Form_RemoveStock";
            this.Text = "Form_RemoveStock";
            this.Load += new System.EventHandler(this.Form_RemoveStock_Load);
            this.panel_invent.ResumeLayout(false);
            this.panel_invent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambarproduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_invent;
        private System.Windows.Forms.Label label_stok;
        private System.Windows.Forms.Label label_stoksaatini;
        private System.Windows.Forms.Label label_namaproduk;
        private Guna.UI2.WinForms.Guna2PictureBox pb_gambarproduk;
        private System.Windows.Forms.Label label_removestock;
        private Guna.UI2.WinForms.Guna2PictureBox pb_back;
        private System.Windows.Forms.Label label_tglbuang;
        private System.Windows.Forms.Label label_batch;
        private Guna.UI2.WinForms.Guna2TextBox tb_jmlbuang;
        private System.Windows.Forms.Label label_jmlbuang;
        private Guna.UI2.WinForms.Guna2TextBox tb_keterangan;
        private System.Windows.Forms.Label label_keterangan;
        private Guna.UI2.WinForms.Guna2ComboBox cb_batch;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepick_tglbuang;
        private Guna.UI2.WinForms.Guna2Button button_save;
        private System.Windows.Forms.Label label_cancel;
        private System.Windows.Forms.Label label_isisemua;
    }
}