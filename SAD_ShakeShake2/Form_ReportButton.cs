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
    public partial class Form_ReportButton : Form
    {
        public Form_ReportButton()
        {
            InitializeComponent();
        }
        public Panel PublicPanelReport
        {
            get { return panel_report; }
        }

        private void btn_penjualan_Click(object sender, EventArgs e)
        {
            panel_report.Controls.Clear();
            Form_LaporanPenjualan form_penjualan = new Form_LaporanPenjualan();
            form_penjualan.Dock = DockStyle.Fill;
            form_penjualan.TopLevel = false;
            form_penjualan.ControlBox = false;
            form_penjualan.FormBorderStyle = FormBorderStyle.None;
            this.panel_report.Controls.Clear();
            this.panel_report.Controls.Add(form_penjualan);
            form_penjualan.Show();

        }

        private void btn_labarugi_Click(object sender, EventArgs e)
        {
            panel_report.Controls.Clear();
            Form_LaporanLabaRugi form_laporanlabarugi = new Form_LaporanLabaRugi();
            form_laporanlabarugi.Dock = DockStyle.Fill;
            form_laporanlabarugi.TopLevel = false;
            form_laporanlabarugi.ControlBox = false;
            form_laporanlabarugi.FormBorderStyle = FormBorderStyle.None;
            this.panel_report.Controls.Clear();
            this.panel_report.Controls.Add(form_laporanlabarugi);
            form_laporanlabarugi.Show();
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
            panel_report.Controls.Clear();
            Form_Grafik form_grafik = new Form_Grafik();
            form_grafik.Dock = DockStyle.Fill;
            form_grafik.TopLevel = false;
            form_grafik.ControlBox = false;
            form_grafik.FormBorderStyle = FormBorderStyle.None;
            this.panel_report.Controls.Clear();
            this.panel_report.Controls.Add(form_grafik);
            form_grafik.Show();
        }
    }
}
