using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAD_ShakeShake2
{
    public partial class Form_OrderHistory : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dttrans;
        string query;
        PictureBox pb_ordhist;

        public Panel PublicPanelOrdhist
        {
            get { return panel_ordhist; }
        }

        public Form_OrderHistory()
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

        private void Form_OrderHistory_Load(object sender, EventArgs e)
        {
            RefreshJamTanggal();

            dttrans = new DataTable();
            query = $"select * from transaksi order by tgl_transaksi desc;";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dttrans);

            DateTime tanggalSebelumnya = DateTime.MinValue; 
            int indexTanggal = -1; 
            for (int i = 0; i < dttrans.Rows.Count; i++)
            {
                DateTime tglTransaksi = Convert.ToDateTime(dttrans.Rows[i]["tgl_transaksi"]);
                string idtrans = Convert.ToString(dttrans.Rows[i]["ID_TRANSAKSI"]);
                string totalitem = Convert.ToString(dttrans.Rows[i]["JML_ITEM"]);
                int hargatotal = Convert.ToInt32(dttrans.Rows[i]["TOTAL"]);

                if (tglTransaksi.Date != tanggalSebelumnya.Date)
                {
                    indexTanggal++;
                    CreateTanggalLabel(tglTransaksi, i);
                    tanggalSebelumnya = tglTransaksi.Date;

                }
                CreatePictureBox(indexTanggal, i, idtrans, totalitem, hargatotal);

            }
        }

        private void CreateTanggalLabel(DateTime tanggal, int index)
        {
            Label label_date = new Label();
            label_date.Text = tanggal.ToString("dddd, dd MMM yyyy");

            int offsetY = 4;
            int yPosition = (index * 112) + (index * offsetY) + offsetY;
            label_date.Location = new Point(390, yPosition);
            label_date.Parent = panel_ordhist;
            label_date.Size = new Size(200, 20);
            label_date.Font = new Font("Montserrat", 10, FontStyle.Bold);
            label_date.TextAlign = ContentAlignment.MiddleCenter;
            label_date.ForeColor = Color.FromArgb(173, 173, 173);
        }

        private void CreatePictureBox(int indexTanggal, int indexTransaksi, string idtrans, string totalitem, int hargatotal)
        {
            pb_ordhist = new PictureBox();
            pb_ordhist.Image = Image.FromFile(@"assets\rectangleordhist.png");
            pb_ordhist.Size = new Size(900, 80);
            pb_ordhist.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_ordhist.Tag = indexTransaksi;
            pb_ordhist.Click += Pb_ordhist_Click;

            int offsetY = 30; 
            int yPosition = (indexTransaksi) * 100 + indexTanggal * 25 + offsetY; // Sesuaikan posisi berdasarkan indeks tanggal
            pb_ordhist.Location = new Point(30, yPosition);
            pb_ordhist.Parent = panel_ordhist;
            pb_ordhist.Tag = idtrans;

            PictureBox pb_bookmark = new PictureBox();
            pb_bookmark.Image=Image.FromFile(@"assets\bookmark.png");
            pb_bookmark.Size = new Size (10, 10);
            pb_bookmark.SizeMode= PictureBoxSizeMode.AutoSize;
            pb_bookmark.Location = new Point(20, 20);
            pb_bookmark.Parent = pb_ordhist;
            pb_bookmark.Click += Pb_ordhist_Click;
            pb_bookmark.Tag = idtrans;

            string tampilidtrans = "#"+idtrans;
            Label label_idtrans = new Label();
            label_idtrans.Text = tampilidtrans;
            label_idtrans.Font = new Font("Montserrat", 15, FontStyle.Bold);
            label_idtrans.ForeColor = Color.Black;
            label_idtrans.Location = new Point(60, 10);
            label_idtrans.Size = new Size(250, 25);
            label_idtrans.BackColor = Color.Transparent;
            label_idtrans.Parent = pb_ordhist;
            label_idtrans.Click += Pb_ordhist_Click;
            label_idtrans.Tag = idtrans;

            string tampiltotalitem = totalitem+" Item";
            Label label_totalitem = new Label();
            label_totalitem.Text = tampiltotalitem;
            label_totalitem.Font = new Font("Montserrat", 15, FontStyle.Regular);
            label_totalitem.ForeColor = Color.FromArgb(25, 100, 69) ;
            label_totalitem.Location = new Point(60, 33);
            label_totalitem.Size = new Size(250, 25);
            label_totalitem.BackColor = Color.Transparent;
            label_totalitem.Parent = pb_ordhist;
            label_totalitem.Click += Pb_ordhist_Click;
            label_totalitem.Tag = idtrans;

            string tampilhargatotal = hargatotal.ToString("C0", new CultureInfo("id-ID")); ;
            Label label_hargatotal = new Label();
            label_hargatotal.Text = tampilhargatotal;
            label_hargatotal.Font = new Font("Montserrat", 15, FontStyle.Regular);
            label_hargatotal.ForeColor = Color.FromArgb(25, 100, 69);
            label_hargatotal.Location = new Point(750, 25);
            label_hargatotal.Size = new Size(250, 35);
            label_hargatotal.BackColor = Color.Transparent;
            label_hargatotal.Parent = pb_ordhist;
            label_hargatotal.Click += Pb_ordhist_Click;
            label_hargatotal.Tag = idtrans;
        }


        private void Pb_ordhist_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            Label clickedLabel = sender as Label;

            if (clickedPictureBox != null && clickedPictureBox.Tag != null)
            {
                string idtrans = (string)clickedPictureBox.Tag;
               // MessageBox.Show($"Anda Mengklik transaksi nomer: {idtrans}");
                Form_DetailTransaksi formdettrans = new Form_DetailTransaksi();
                formdettrans.Dock = DockStyle.Fill;
                formdettrans.TopLevel = false;
                formdettrans.ControlBox = false;
                formdettrans.FormBorderStyle = FormBorderStyle.None;
                formdettrans.TransactionId = idtrans;
                this.panel_ordhist.Controls.Clear();
                this.panel_ordhist.Controls.Add(formdettrans);
                formdettrans.Show();

            }
            if (clickedLabel != null && clickedLabel.Tag != null)
            {
                string idtrans = (string)clickedLabel.Tag;
              //  MessageBox.Show($"Anda Mengklik transaksi nomer: {idtrans}");
                Form_DetailTransaksi formdettrans = new Form_DetailTransaksi();
                formdettrans.Dock = DockStyle.Fill;
                formdettrans.TopLevel = false;
                formdettrans.ControlBox = false;
                formdettrans.FormBorderStyle = FormBorderStyle.None;
                formdettrans.TransactionId = idtrans;
                this.panel_ordhist.Controls.Clear();
                this.panel_ordhist.Controls.Add(formdettrans);
                formdettrans.Show();
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
