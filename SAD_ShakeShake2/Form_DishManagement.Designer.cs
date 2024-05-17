namespace SAD_ShakeShake2
{
    partial class Form_DishManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DishManagement));
            this.label_dishmanagement = new System.Windows.Forms.Label();
            this.label_namamenu = new System.Windows.Forms.Label();
            this.tb_namamenu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_harga = new System.Windows.Forms.Label();
            this.tb_harga = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_desc = new System.Windows.Forms.Label();
            this.tb_deskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_kategori = new System.Windows.Forms.Label();
            this.cb_kategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_save = new Guna.UI2.WinForms.Guna2Button();
            this.label_cancel = new System.Windows.Forms.Label();
            this.button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.pb_back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb_gambarmenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_settings = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambarmenu)).BeginInit();
            this.panel_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_dishmanagement
            // 
            this.label_dishmanagement.AutoSize = true;
            this.label_dishmanagement.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dishmanagement.Location = new System.Drawing.Point(348, 9);
            this.label_dishmanagement.Name = "label_dishmanagement";
            this.label_dishmanagement.Size = new System.Drawing.Size(735, 99);
            this.label_dishmanagement.TabIndex = 1;
            this.label_dishmanagement.Text = "Dish Management";
            // 
            // label_namamenu
            // 
            this.label_namamenu.AutoSize = true;
            this.label_namamenu.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namamenu.Location = new System.Drawing.Point(462, 141);
            this.label_namamenu.Name = "label_namamenu";
            this.label_namamenu.Size = new System.Drawing.Size(138, 28);
            this.label_namamenu.TabIndex = 3;
            this.label_namamenu.Text = "Nama Menu";
            // 
            // tb_namamenu
            // 
            this.tb_namamenu.AutoRoundedCorners = true;
            this.tb_namamenu.BorderRadius = 25;
            this.tb_namamenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_namamenu.DefaultText = "";
            this.tb_namamenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_namamenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_namamenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_namamenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_namamenu.FillColor = System.Drawing.Color.Gainsboro;
            this.tb_namamenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_namamenu.Font = new System.Drawing.Font("Montserrat", 10F);
            this.tb_namamenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_namamenu.Location = new System.Drawing.Point(467, 175);
            this.tb_namamenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_namamenu.Name = "tb_namamenu";
            this.tb_namamenu.PasswordChar = '\0';
            this.tb_namamenu.PlaceholderText = "";
            this.tb_namamenu.SelectedText = "";
            this.tb_namamenu.Size = new System.Drawing.Size(372, 53);
            this.tb_namamenu.TabIndex = 4;
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_harga.Location = new System.Drawing.Point(462, 234);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(74, 28);
            this.label_harga.TabIndex = 5;
            this.label_harga.Text = "Harga";
            // 
            // tb_harga
            // 
            this.tb_harga.AutoRoundedCorners = true;
            this.tb_harga.BorderRadius = 25;
            this.tb_harga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_harga.DefaultText = "";
            this.tb_harga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_harga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_harga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_harga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_harga.FillColor = System.Drawing.Color.Gainsboro;
            this.tb_harga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_harga.Font = new System.Drawing.Font("Montserrat", 10F);
            this.tb_harga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_harga.Location = new System.Drawing.Point(467, 268);
            this.tb_harga.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.PasswordChar = '\0';
            this.tb_harga.PlaceholderText = "";
            this.tb_harga.SelectedText = "";
            this.tb_harga.Size = new System.Drawing.Size(372, 53);
            this.tb_harga.TabIndex = 6;
            this.tb_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_harga_KeyPress);
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desc.Location = new System.Drawing.Point(462, 327);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(108, 28);
            this.label_desc.TabIndex = 7;
            this.label_desc.Text = "Deskripsi";
            // 
            // tb_deskripsi
            // 
            this.tb_deskripsi.AutoRoundedCorners = true;
            this.tb_deskripsi.BorderRadius = 25;
            this.tb_deskripsi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_deskripsi.DefaultText = "";
            this.tb_deskripsi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_deskripsi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_deskripsi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_deskripsi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_deskripsi.FillColor = System.Drawing.Color.Gainsboro;
            this.tb_deskripsi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_deskripsi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.tb_deskripsi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_deskripsi.Location = new System.Drawing.Point(467, 361);
            this.tb_deskripsi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_deskripsi.Name = "tb_deskripsi";
            this.tb_deskripsi.PasswordChar = '\0';
            this.tb_deskripsi.PlaceholderText = "";
            this.tb_deskripsi.SelectedText = "";
            this.tb_deskripsi.Size = new System.Drawing.Size(499, 53);
            this.tb_deskripsi.TabIndex = 8;
            // 
            // label_kategori
            // 
            this.label_kategori.AutoSize = true;
            this.label_kategori.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kategori.Location = new System.Drawing.Point(462, 420);
            this.label_kategori.Name = "label_kategori";
            this.label_kategori.Size = new System.Drawing.Size(100, 28);
            this.label_kategori.TabIndex = 9;
            this.label_kategori.Text = "Kategori";
            // 
            // cb_kategori
            // 
            this.cb_kategori.AutoRoundedCorners = true;
            this.cb_kategori.BackColor = System.Drawing.Color.Transparent;
            this.cb_kategori.BorderRadius = 17;
            this.cb_kategori.BorderThickness = 0;
            this.cb_kategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kategori.FillColor = System.Drawing.Color.Gainsboro;
            this.cb_kategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_kategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_kategori.Font = new System.Drawing.Font("Montserrat", 10F);
            this.cb_kategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_kategori.ItemHeight = 30;
            this.cb_kategori.Items.AddRange(new object[] {
            "Premium",
            "Seasonal",
            "Reguler"});
            this.cb_kategori.Location = new System.Drawing.Point(467, 451);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(222, 36);
            this.cb_kategori.TabIndex = 10;
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
            this.button_save.Location = new System.Drawing.Point(1222, 625);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(180, 45);
            this.button_save.TabIndex = 27;
            this.button_save.Text = "Save";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_cancel
            // 
            this.label_cancel.AutoSize = true;
            this.label_cancel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(151)))), ((int)(((byte)(110)))));
            this.label_cancel.Location = new System.Drawing.Point(1079, 630);
            this.label_cancel.Name = "label_cancel";
            this.label_cancel.Size = new System.Drawing.Size(99, 33);
            this.label_cancel.TabIndex = 26;
            this.label_cancel.Text = "Cancel";
            this.label_cancel.Click += new System.EventHandler(this.label_cancel_Click);
            // 
            // button_delete
            // 
            this.button_delete.BorderRadius = 11;
            this.button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button_delete.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(46, 630);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(244, 45);
            this.button_delete.TabIndex = 28;
            this.button_delete.Text = "Delete Menu";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // pb_back
            // 
            this.pb_back.BackColor = System.Drawing.Color.Transparent;
            this.pb_back.Image = ((System.Drawing.Image)(resources.GetObject("pb_back.Image")));
            this.pb_back.ImageRotate = 0F;
            this.pb_back.Location = new System.Drawing.Point(46, 26);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(80, 57);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 29;
            this.pb_back.TabStop = false;
            this.pb_back.UseTransparentBackground = true;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_gambarmenu
            // 
            this.pb_gambarmenu.BackColor = System.Drawing.Color.Transparent;
            this.pb_gambarmenu.ImageRotate = 0F;
            this.pb_gambarmenu.Location = new System.Drawing.Point(231, 141);
            this.pb_gambarmenu.Name = "pb_gambarmenu";
            this.pb_gambarmenu.Size = new System.Drawing.Size(200, 200);
            this.pb_gambarmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gambarmenu.TabIndex = 2;
            this.pb_gambarmenu.TabStop = false;
            this.pb_gambarmenu.UseTransparentBackground = true;
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.pb_gambarmenu);
            this.panel_settings.Controls.Add(this.button_delete);
            this.panel_settings.Controls.Add(this.label_dishmanagement);
            this.panel_settings.Controls.Add(this.label_cancel);
            this.panel_settings.Controls.Add(this.button_save);
            this.panel_settings.Controls.Add(this.tb_namamenu);
            this.panel_settings.Controls.Add(this.label_namamenu);
            this.panel_settings.Controls.Add(this.label_harga);
            this.panel_settings.Controls.Add(this.tb_harga);
            this.panel_settings.Controls.Add(this.cb_kategori);
            this.panel_settings.Controls.Add(this.label_desc);
            this.panel_settings.Controls.Add(this.label_kategori);
            this.panel_settings.Controls.Add(this.tb_deskripsi);
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_settings.Location = new System.Drawing.Point(0, 0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(1433, 713);
            this.panel_settings.TabIndex = 30;
            // 
            // Form_DishManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.panel_settings);
            this.Name = "Form_DishManagement";
            this.Text = "Form_DishManagement";
            this.Load += new System.EventHandler(this.Form_DishManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambarmenu)).EndInit();
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_dishmanagement;
        private Guna.UI2.WinForms.Guna2PictureBox pb_gambarmenu;
        private System.Windows.Forms.Label label_namamenu;
        private Guna.UI2.WinForms.Guna2TextBox tb_namamenu;
        private System.Windows.Forms.Label label_harga;
        private Guna.UI2.WinForms.Guna2TextBox tb_harga;
        private System.Windows.Forms.Label label_desc;
        private Guna.UI2.WinForms.Guna2TextBox tb_deskripsi;
        private System.Windows.Forms.Label label_kategori;
        private Guna.UI2.WinForms.Guna2ComboBox cb_kategori;
        private Guna.UI2.WinForms.Guna2Button button_save;
        private System.Windows.Forms.Label label_cancel;
        private Guna.UI2.WinForms.Guna2Button button_delete;
        private Guna.UI2.WinForms.Guna2PictureBox pb_back;
        private System.Windows.Forms.Panel panel_settings;
    }
}