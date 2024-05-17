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
    public partial class Form_LaporanLabaRugi : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtbulan;

        public Form_LaporanLabaRugi()
        {
            InitializeComponent();
        }

        private void cb_pilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            int no = 1;
            int totalLaba = 0;
            int totalRugi = 0;

            dgv_labarugi.Rows.Clear();
            dgv_labarugi.Columns.Clear();

            string selectedMonthYear = cb_pilih.SelectedItem?.ToString();

            if (selectedMonthYear != null)
            {
                // Split the selected string to get month and year
                string[] parts = selectedMonthYear.Split(' ');
                int selectedYear = int.Parse(parts[1]);
                int selectedMonth = DateTime.ParseExact(parts[0], "MMMM", CultureInfo.CurrentCulture).Month;

                // Query to fetch data for the selected month and year
                query = $"SELECT * FROM log_laba_rugi WHERE YEAR(tgl_catat) = {selectedYear} AND MONTH(tgl_catat) = {selectedMonth}";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable selectedData = new DataTable();
                sqlAdapter.Fill(selectedData);

                dgv_labarugi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
                dgv_labarugi.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
                dgv_labarugi.AutoGenerateColumns = true;
                dgv_labarugi.Columns.Add("No", "No");
                dgv_labarugi.Columns.Add("tgl_catat", "Tanggal Catat");
                dgv_labarugi.Columns.Add("keterangan", "Keterangan");
                dgv_labarugi.Columns.Add("laba", "Laba");
                dgv_labarugi.Columns.Add("rugi", "Rugi");
                dgv_labarugi.EnableHeadersVisualStyles = false;
                dgv_labarugi.Columns["tgl_catat"].DefaultCellStyle.Format = "d MMMM yyyy";
                dgv_labarugi.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 10);
                dgv_labarugi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(133, 223, 176);
                dgv_labarugi.DefaultCellStyle.Font = new Font("Montserrat", 10);
                dgv_labarugi.DefaultCellStyle.BackColor = Color.White;

                // Populate the DataGridView with the selected data
                foreach (DataRow row in selectedData.Rows)
                {
                    DateTime tanggalCatat = Convert.ToDateTime(row["tgl_catat"]);
                    int laba = row["laba"] != DBNull.Value ? Convert.ToInt32(row["laba"]) : 0;
                    int rugi = row["rugi"] != DBNull.Value ? Convert.ToInt32(row["rugi"]) : 0;

                    dgv_labarugi.Rows.Add(no, tanggalCatat.ToString("d MMMM yyyy"), row["keterangan"], laba, rugi);
                    no++;

                    // Calculate total laba and rugi
                    totalLaba += laba;
                    totalRugi += rugi;
                }

                label_keuntunganangka.Text = totalLaba.ToString("C0", new CultureInfo("id-ID"));
                label_kerugianangka.Text = totalRugi.ToString("C0", new CultureInfo("id-ID"));
                label_totalangka.Text = (totalLaba - totalRugi).ToString("C0", new CultureInfo("id-ID"));
            }
        }
        private void Form_LaporanLabaRugi_Load(object sender, EventArgs e)
        {
            dgv_labarugi.CurrentCell = null;
            dtbulan = new DataTable();
            query = $"SELECT DISTINCT YEAR(tgl_catat) AS Tahun, MONTH(tgl_catat) AS Bulan FROM log_laba_rugi";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtbulan);
            cb_pilih.Text = "Pilih Bulan";
            for (int i = 0; i < dtbulan.Rows.Count; i++)
            {
                int year = Convert.ToInt32(dtbulan.Rows[i]["Tahun"]);
                int month = Convert.ToInt32(dtbulan.Rows[i]["Bulan"]);

                string monthYear = $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}";

                if (!cb_pilih.Items.Contains(monthYear))
                {
                    cb_pilih.Items.Add(monthYear);
                }
            }
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
