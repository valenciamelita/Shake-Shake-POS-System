using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.DataFormats;

namespace SAD_ShakeShake2
{
    public partial class Form_Inventory : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtproduk;
        public Panel PublicPanelInventory
        {
            get { return panel_invent; }
        }
        public Form_Inventory()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            RefreshJamTanggal();
        }

        private void RefreshJamTanggal()
        {

            DateTime waktuSekarang = DateTime.Now;

            label_haritgl.Text = waktuSekarang.ToString("dddd, dd MMM yyyy");
            label_jam.Text = waktuSekarang.ToString("HH:mm");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            RefreshJamTanggal();
        }

        private void x_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form_Inventory_Load(object sender, EventArgs e)
        {
            RefreshJamTanggal();

            dtproduk = new DataTable();
            query = $"select * from produk where is_delete = 'F'";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtproduk);
 

            for (int i = 0; i < dtproduk.Rows.Count; i++)
            {
                string namaProduk = dtproduk.Rows[i]["NAMA_PRODUK"].ToString();
                string idprod = dtproduk.Rows[i]["ID_PRODUK"].ToString();
                string fileName = $"{idprod}.png";
                int indexnya = int.Parse(idprod.Substring(1));

                PictureBox pb_inventbg = new PictureBox();
                pb_inventbg.Image = Image.FromFile(@"assets\inventbg.png");
                pb_inventbg.Size = new Size(250, 270);
                pb_inventbg.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_inventbg.Tag = i;

                int xPosition = (i % 3) * 300;
                int yPosition = (i / 3) * 300; 
                pb_inventbg.Location = new Point(50 + xPosition, yPosition);
                pb_inventbg.Parent = panel_invent;

                PictureBox pb_editbutton = new PictureBox();
                pb_editbutton.Image = Image.FromFile(@"assets\inventedit.png");
                pb_editbutton.Size = new Size(250, 50);
                pb_editbutton.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_editbutton.Tag = i;

                pb_editbutton.Location = new Point(0, 220);
                pb_editbutton.Parent = pb_inventbg;

                pb_editbutton.Click += Pb_editbutton_Click;

                PictureBox pb_gambarmenu = new PictureBox();
                pb_gambarmenu.Image = Image.FromFile($@"assets\circle\{indexnya}.png");
                pb_gambarmenu.Size = new Size(100, 100);
                pb_gambarmenu.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_gambarmenu.Location = new Point(75, 10);
                pb_gambarmenu.BackColor = Color.Transparent;
                pb_gambarmenu.Parent = pb_inventbg;

                Label label_namamenu = new Label();
                label_namamenu.Tag = i;
                label_namamenu.Text = namaProduk;
                label_namamenu.TextAlign = ContentAlignment.TopCenter;
                label_namamenu.Location = new Point(50, 120);
                label_namamenu.Size = new Size(150, 27);
                label_namamenu.Font = new Font("Montserrat", 12);
                label_namamenu.ForeColor = Color.Black;
                label_namamenu.BackColor = Color.Transparent;
                label_namamenu.Parent = pb_inventbg;

                PictureBox pb_kotakstok = new PictureBox();
                pb_kotakstok.Image = Image.FromFile($@"assets\rectangleqtyinvent.png");
                pb_kotakstok.Size = new Size(80, 45);
                pb_kotakstok.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_kotakstok.Location = new Point(85, 155);
                pb_kotakstok.BackColor = Color.Transparent;
                pb_kotakstok.Parent = pb_inventbg;

                string stokProduk = dtproduk.Rows[i]["STOK_TOTAL"].ToString();

                Label label_stoktotal = new Label();
                label_stoktotal.Tag = i;
                label_stoktotal.Text = stokProduk;
                label_stoktotal.TextAlign = ContentAlignment.TopCenter;
                label_stoktotal.Location = new Point(-7,10);
                label_stoktotal.Size = new Size(100, 20);
                label_stoktotal.Font = new Font("Montserrat", 12, FontStyle.Bold);
                label_stoktotal.ForeColor = Color.Black;
                label_stoktotal.BackColor = Color.Transparent;
                label_stoktotal.Parent = pb_kotakstok;

            }

        }

        private void Pb_editbutton_Click(object sender, EventArgs e)
        {
            PictureBox clickedButton = sender as PictureBox;
            if (clickedButton != null)
            {
                int index = Convert.ToInt32(clickedButton.Tag);

                Form_MsgBoxAddorRemove form_msgboxaddorremove = new Form_MsgBoxAddorRemove(index);
                form_msgboxaddorremove.StartPosition = FormStartPosition.Manual;
                form_msgboxaddorremove.Left = 500;
                form_msgboxaddorremove.Top = 250;

                form_msgboxaddorremove.FormClosed += Form_MsgBoxAddorRemove_Closed;
                form_msgboxaddorremove.Show();
            }

        }

        private void Form_MsgBoxAddorRemove_Closed(object sender, FormClosedEventArgs e)
        {
            var form_msgboxaddorremove = (Form_MsgBoxAddorRemove)sender;

            int clickedButtonIndex = form_msgboxaddorremove.clickedButtonIndex;

            if (form_msgboxaddorremove.IsAddButtonPressed)
            {
                Form_AddStock form_addstock = new Form_AddStock(clickedButtonIndex);
                form_addstock.Dock = DockStyle.Fill;
                form_addstock.TopLevel = false;
                form_addstock.ControlBox = false;
                form_addstock.FormBorderStyle = FormBorderStyle.None;
                this.panel_invent.Controls.Clear();
                this.panel_invent.Controls.Add(form_addstock);
                form_addstock.Show();
            }
            else if (form_msgboxaddorremove.IsRemoveButtonPressed)
            {
                panel_invent.Controls.Clear();
                Form_RemoveStock form_removestock = new Form_RemoveStock(clickedButtonIndex);
                form_removestock.Dock = DockStyle.Fill;
                form_removestock.TopLevel = false;
                form_removestock.ControlBox = false;
                form_removestock.FormBorderStyle = FormBorderStyle.None;
                this.panel_invent.Controls.Clear();
                this.panel_invent.Controls.Add(form_removestock);
                form_removestock.Show();
            }
        }

        private void x_button_MouseEnter(object sender, EventArgs e)
        {
            x_button.ForeColor = Color.White;
            x_button.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void x_button_MouseLeave(object sender, EventArgs e)
        {
            x_button.ForeColor = Color.DimGray;
            x_button.BackColor = Color.White;
        }

        private void label_sidemenu_Click(object sender, EventArgs e)
        {
            Form_Menu formmenu = new Form_Menu();
            formmenu.Dock = DockStyle.Fill;
            formmenu.TopLevel = false;
            formmenu.ControlBox = false;
            formmenu.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formmenu);
            formmenu.Show();
        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            Form_Menu formmenu = new Form_Menu();
            formmenu.Dock = DockStyle.Fill;
            formmenu.TopLevel = false;
            formmenu.ControlBox = false;
            formmenu.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formmenu);
            formmenu.Show();
        }

        private void label_ordhist_Click(object sender, EventArgs e)
        {
            Form_OrderHistory formorderhist = new Form_OrderHistory();
            formorderhist.Dock = DockStyle.Fill;
            formorderhist.TopLevel = false;
            formorderhist.ControlBox = false;
            formorderhist.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formorderhist);
            formorderhist.Show();
        }

        private void pb_orderhist_Click(object sender, EventArgs e)
        {
            Form_OrderHistory formorderhist = new Form_OrderHistory();
            formorderhist.Dock = DockStyle.Fill;
            formorderhist.TopLevel = false;
            formorderhist.ControlBox = false;
            formorderhist.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formorderhist);
            formorderhist.Show();
        }

        private void label_report_Click(object sender, EventArgs e)
        {
            Form_Report formreport = new Form_Report();
            formreport.Dock = DockStyle.Fill;
            formreport.TopLevel = false;
            formreport.ControlBox = false;
            formreport.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formreport);
            formreport.Show();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

            Form_Report formreport = new Form_Report();
            formreport.Dock = DockStyle.Fill;
            formreport.TopLevel = false;
            formreport.ControlBox = false;
            formreport.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formreport);
            formreport.Show();

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            Form_Settings formsettings = new Form_Settings();
            formsettings.Dock = DockStyle.Fill;
            formsettings.TopLevel = false;
            formsettings.ControlBox = false;
            formsettings.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formsettings);
            formsettings.Show();
        }

        private void label_settings_Click(object sender, EventArgs e)
        {
            Form_Settings formsettings = new Form_Settings();
            formsettings.Dock = DockStyle.Fill;
            formsettings.TopLevel = false;
            formsettings.ControlBox = false;
            formsettings.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formsettings);
            formsettings.Show();
        }
    }
}
