namespace SAD_ShakeShake2
{
    partial class Form_DetailTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DetailTransaksi));
            this.panel_ordhist = new System.Windows.Forms.Panel();
            this.label_item = new System.Windows.Forms.Label();
            this.line = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label_namapelanggan = new System.Windows.Forms.Label();
            this.label_ordernum = new System.Windows.Forms.Label();
            this.pb_back = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label_qty = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_totalprice = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_order = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ordercreated = new System.Windows.Forms.Label();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.panel_ordhist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ordhist
            // 
            this.panel_ordhist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_ordhist.Controls.Add(this.label_subtotal);
            this.panel_ordhist.Controls.Add(this.label_ordercreated);
            this.panel_ordhist.Controls.Add(this.label2);
            this.panel_ordhist.Controls.Add(this.label1);
            this.panel_ordhist.Controls.Add(this.panel_order);
            this.panel_ordhist.Controls.Add(this.guna2PictureBox1);
            this.panel_ordhist.Controls.Add(this.label_totalprice);
            this.panel_ordhist.Controls.Add(this.label_price);
            this.panel_ordhist.Controls.Add(this.label_qty);
            this.panel_ordhist.Controls.Add(this.label_item);
            this.panel_ordhist.Controls.Add(this.line);
            this.panel_ordhist.Controls.Add(this.label_namapelanggan);
            this.panel_ordhist.Controls.Add(this.label_ordernum);
            this.panel_ordhist.Controls.Add(this.pb_back);
            this.panel_ordhist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ordhist.Location = new System.Drawing.Point(0, 0);
            this.panel_ordhist.Name = "panel_ordhist";
            this.panel_ordhist.Size = new System.Drawing.Size(1433, 713);
            this.panel_ordhist.TabIndex = 0;
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.Location = new System.Drawing.Point(33, 108);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(85, 39);
            this.label_item.TabIndex = 4;
            this.label_item.Text = "Item";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.Image = global::SAD_ShakeShake2.Properties.Resources.linedettrans;
            this.line.ImageRotate = 0F;
            this.line.Location = new System.Drawing.Point(30, 92);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1325, 2);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.line.TabIndex = 3;
            this.line.TabStop = false;
            this.line.UseTransparentBackground = true;
            // 
            // label_namapelanggan
            // 
            this.label_namapelanggan.AutoSize = true;
            this.label_namapelanggan.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namapelanggan.Location = new System.Drawing.Point(1188, 35);
            this.label_namapelanggan.Name = "label_namapelanggan";
            this.label_namapelanggan.Size = new System.Drawing.Size(167, 44);
            this.label_namapelanggan.TabIndex = 2;
            this.label_namapelanggan.Text = "namapel";
            // 
            // label_ordernum
            // 
            this.label_ordernum.AutoSize = true;
            this.label_ordernum.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ordernum.Location = new System.Drawing.Point(121, 13);
            this.label_ordernum.Name = "label_ordernum";
            this.label_ordernum.Size = new System.Drawing.Size(253, 66);
            this.label_ordernum.TabIndex = 1;
            this.label_ordernum.Text = "Order #T";
            // 
            // pb_back
            // 
            this.pb_back.BackColor = System.Drawing.Color.Transparent;
            this.pb_back.Image = ((System.Drawing.Image)(resources.GetObject("pb_back.Image")));
            this.pb_back.ImageRotate = 0F;
            this.pb_back.Location = new System.Drawing.Point(30, 26);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(68, 42);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 0;
            this.pb_back.TabStop = false;
            this.pb_back.UseTransparentBackground = true;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qty.Location = new System.Drawing.Point(642, 108);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(70, 39);
            this.label_qty.TabIndex = 5;
            this.label_qty.Text = "Qty";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(917, 108);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(92, 39);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "Price";
            // 
            // label_totalprice
            // 
            this.label_totalprice.AutoSize = true;
            this.label_totalprice.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalprice.Location = new System.Drawing.Point(1158, 108);
            this.label_totalprice.Name = "label_totalprice";
            this.label_totalprice.Size = new System.Drawing.Size(170, 39);
            this.label_totalprice.TabIndex = 7;
            this.label_totalprice.Text = "Total Price";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::SAD_ShakeShake2.Properties.Resources.linedettrans;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, 171);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1325, 2);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // panel_order
            // 
            this.panel_order.AutoScroll = true;
            this.panel_order.Location = new System.Drawing.Point(30, 181);
            this.panel_order.Name = "panel_order";
            this.panel_order.Size = new System.Drawing.Size(1325, 354);
            this.panel_order.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Order Created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1035, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subtotal";
            // 
            // label_ordercreated
            // 
            this.label_ordercreated.AutoSize = true;
            this.label_ordercreated.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ordercreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label_ordercreated.Location = new System.Drawing.Point(32, 602);
            this.label_ordercreated.Name = "label_ordercreated";
            this.label_ordercreated.Size = new System.Drawing.Size(655, 55);
            this.label_ordercreated.TabIndex = 12;
            this.label_ordercreated.Text = "Wednesday, 23 Nov 2023  14:20";
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtotal.ForeColor = System.Drawing.Color.Black;
            this.label_subtotal.Location = new System.Drawing.Point(1033, 602);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(118, 55);
            this.label_subtotal.TabIndex = 13;
            this.label_subtotal.Text = "Rp 0";
            // 
            // Form_DetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 713);
            this.Controls.Add(this.panel_ordhist);
            this.Name = "Form_DetailTransaksi";
            this.Text = "Form_DetailTransaksi";
            this.Load += new System.EventHandler(this.Form_DetailTransaksi_Load);
            this.panel_ordhist.ResumeLayout(false);
            this.panel_ordhist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ordhist;
        private System.Windows.Forms.Label label_ordernum;
        private Guna.UI2.WinForms.Guna2PictureBox pb_back;
        private Guna.UI2.WinForms.Guna2PictureBox line;
        private System.Windows.Forms.Label label_namapelanggan;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label label_totalprice;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_qty;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label_ordercreated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_order;
        private System.Windows.Forms.Label label_subtotal;
    }
}