using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_ShakeShake2
{
    public partial class Form_Report : Form
    {
        public Form_Report()
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

        private void Form_Report_Load(object sender, EventArgs e)
        {
            RefreshJamTanggal();

            panel_report.Controls.Clear();
            Form_ReportButton form_reportbutton = new Form_ReportButton();
            form_reportbutton.Dock = DockStyle.Fill;
            form_reportbutton.TopLevel = false;
            form_reportbutton.ControlBox = false;
            form_reportbutton.FormBorderStyle = FormBorderStyle.None;
            this.panel_report.Controls.Clear();
            this.panel_report.Controls.Add(form_reportbutton);
            form_reportbutton.Show();
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