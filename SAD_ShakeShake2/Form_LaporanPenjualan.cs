using System;
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
    public partial class Form_LaporanPenjualan : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtbulan;
        public Form_LaporanPenjualan()
        {
            InitializeComponent();
        }

        private void cb_pilih_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgv_penjualan.EnableHeadersVisualStyles = false;
            dgv_penjualan.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
            dgv_penjualan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(133, 223, 176);
            dgv_penjualan.DefaultCellStyle.Font = new Font("Montserrat", 10);
            dgv_penjualan.DefaultCellStyle.BackColor = Color.White;
            DataTable selectedData = new DataTable();

            if (cb_pilih.SelectedIndex == 0)
            {
                query = $"call PLaporanpenjualan('day');";
            }
            else if (cb_pilih.SelectedIndex == 1)
            {
                query = $"call PLaporanpenjualan('week');";
            }
            else if (cb_pilih.SelectedIndex == 2)
            {
                query = $"call PLaporanpenjualan('month');";
            }
            else if (cb_pilih.SelectedIndex == 3)
            {
                query = $"call PLaporanpenjualan('year');";
            }
            else if (cb_pilih.SelectedIndex == 4)
            {
                query = $"call PLaporanpenjualan('all');";
            }

            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(selectedData);
            dgv_penjualan.DataSource = selectedData;
            dgv_penjualan.CurrentCell = null;

            int totalHarga = 0;
            foreach (DataRow row in selectedData.Rows)
            {
                int hargaValue = Convert.ToInt32(row["Harga"]);
                totalHarga += hargaValue;
            }
            label_totalangka.Text = totalHarga.ToString("C0", new CultureInfo("id-ID"));
        }


        private void pb_back_Click(object sender, EventArgs e)
        {
                Form_ReportButton form_reportbtn = new Form_ReportButton();
                form_reportbtn.Dock = DockStyle.Fill;
                form_reportbtn.TopLevel = false;
                form_reportbtn.ControlBox = false;
                form_reportbtn.FormBorderStyle = FormBorderStyle.None;
                Panel oldPanelReport = form_reportbtn.PublicPanelReport;
                oldPanelReport.Location = new Point(0, 0);
                this.panel_report.Size = oldPanelReport.Size;
                this.panel_report.Controls.Clear();
                this.panel_report.Controls.Add(oldPanelReport);
                form_reportbtn.Show();
            
        }
    }
}
