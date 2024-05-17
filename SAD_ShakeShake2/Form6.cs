using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace SAD_ShakeShake2
{
    public partial class Form_Settings : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtproduk;
        PictureBox pb_gambarmenu;
        public Form_Settings()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            RefreshJamTanggal();
        }
        public Panel PublicPanelSettings
        {
            get { return panel_settings; }
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

        private void Form_Settings_Load(object sender, EventArgs e)
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

                PictureBox pb_settingsbg = new PictureBox();
                pb_settingsbg.Image = Image.FromFile(@"assets\bgsettings.png");
                pb_settingsbg.Size = new Size(200, 250);
                pb_settingsbg.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_settingsbg.Tag = i;

                int xPosition = (i % 3) * 250;
                int yPosition = (i / 3) * 275;
                pb_settingsbg.Location = new Point(50 + xPosition, yPosition);
                pb_settingsbg.Parent = panel_produk;

                PictureBox pb_editbutton = new PictureBox();
                pb_editbutton.Image = Image.FromFile(@"assets\btneditsettings.png");
                pb_editbutton.Size = new Size(200, 50);
                pb_editbutton.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_editbutton.Tag = i;

                pb_editbutton.Location = new Point(0, 200);
                pb_editbutton.Parent = pb_settingsbg;

                pb_editbutton.Click += Pb_editbutton_Click;

                pb_gambarmenu = new PictureBox();
                pb_gambarmenu.Image = Image.FromFile($@"assets\circle\{indexnya}.png");
                pb_gambarmenu.Size = new Size(100, 100);
                pb_gambarmenu.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_gambarmenu.Location = new Point(50, 10);
                pb_gambarmenu.BackColor = Color.Transparent;
                pb_gambarmenu.Parent = pb_settingsbg;


                Label label_namamenu = new Label();
                label_namamenu.Tag = i;
                label_namamenu.Text = namaProduk;
                label_namamenu.TextAlign = ContentAlignment.TopCenter;
                label_namamenu.Location = new Point(25, 120);
                label_namamenu.Size = new Size(150, 27);
                label_namamenu.Font = new Font("Montserrat", 12);
                label_namamenu.ForeColor = Color.Black;
                label_namamenu.BackColor = Color.Transparent;
                label_namamenu.Parent = pb_settingsbg;

                int hargaproduk = Convert.ToInt32(dtproduk.Rows[i]["harga_jual"]);
                string hargaProduk2 = hargaproduk.ToString("C0", new CultureInfo("id-ID"));
                Label label_hargaproduk = new Label();
                label_hargaproduk.Tag = i;
                label_hargaproduk.Text = hargaProduk2;
                label_hargaproduk.TextAlign = ContentAlignment.TopCenter;
                label_hargaproduk.Location = new Point(25, 150);
                label_hargaproduk.Size = new Size(150, 27);
                label_hargaproduk.Font = new Font("Montserrat", 12);
                label_hargaproduk.ForeColor = Color.Black;
                label_hargaproduk.BackColor = Color.Transparent;
                label_hargaproduk.Parent = pb_settingsbg;

            }
        }

        private void Pb_editbutton_Click(object sender, EventArgs e)
        {
            PictureBox clickedButton = sender as PictureBox;
            if (clickedButton != null)
            {
                pb_gambarmenu.Image.Dispose();
                pb_gambarmenu.Image = null;
                int index = Convert.ToInt32(clickedButton.Tag);
                Form_DishManagement form_dishmanagement = new Form_DishManagement(index);
                form_dishmanagement.Dock = DockStyle.Fill;
                form_dishmanagement.TopLevel = false;
                form_dishmanagement.ControlBox = false;
                form_dishmanagement.FormBorderStyle = FormBorderStyle.None;
                this.panel_settings.Controls.Clear();
                this.panel_settings.Controls.Add(form_dishmanagement);
                form_dishmanagement.Show();

            }


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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form_Inventory forminventory = new Form_Inventory();
            forminventory.Dock = DockStyle.Fill;
            forminventory.TopLevel = false;
            forminventory.ControlBox = false;
            forminventory.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(forminventory);
            forminventory.Show();
        }

        private void label_invent_Click(object sender, EventArgs e)
        {
            Form_Inventory forminventory = new Form_Inventory();
            forminventory.Dock = DockStyle.Fill;
            forminventory.TopLevel = false;
            forminventory.ControlBox = false;
            forminventory.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(forminventory);
            forminventory.Show();
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

        private void pb_addnew_Click(object sender, EventArgs e)
        {
            Form_AddMenu form_addmenu = new Form_AddMenu();
            form_addmenu.Dock = DockStyle.Fill;
            form_addmenu.TopLevel = false;
            form_addmenu.ControlBox = false;
            form_addmenu.FormBorderStyle = FormBorderStyle.None;
            this.panel_settings.Controls.Clear();
            this.panel_settings.Controls.Add(form_addmenu);
            form_addmenu.Show();
        }

    }
}

