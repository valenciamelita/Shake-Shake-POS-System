using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAD_ShakeShake2
{
    public partial class Form_Grafik : Form
    {

        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable selectedData;
        public Form_Grafik()
        {
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable resultTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }

            return resultTable;
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

        private void cb_pilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable selectedData = new DataTable();

            if (cb_pilih.SelectedIndex == 0) // Daily
            {
                cb_pilih2.Enabled = true;
                PopulateDateComboBox("day");
            }
            else if (cb_pilih.SelectedIndex == 1) // Weekly
            {
                cb_pilih2.Enabled = true;
                PopulateDateComboBox("week");

            }
            else if (cb_pilih.SelectedIndex == 2) // Monthly
            {
                cb_pilih2.Enabled = true;
                PopulateDateComboBox("month");
            }
            else if (cb_pilih.SelectedIndex == 3) // Yearly
            {
                cb_pilih2.Enabled = true;
                PopulateDateComboBox("year"); 
            }
            else if (cb_pilih.SelectedIndex == 4) // All
            {
                query = $"call PLaporanpenjualanGraph('all', '', 0)";
                cb_pilih2.Enabled = false;
                cb_pilih2.SelectedIndex = -1;
                selectedData = ExecuteQuery(query);
            }

            chart_grafik.Series.Clear();
            chart_grafik.Series.Add("Total Penjualan");
            chart_grafik.Series["Total Penjualan"].ChartType = SeriesChartType.Column;
            Color[] dayColors = { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Orange, Color.Purple, Color.Cyan };

            int colorIndex = 0;

            foreach (DataRow row in selectedData.Rows)
            {
                string productName = row["Nama Produk"].ToString();
                int totalPenjualan = Convert.ToInt32(row["Total Penjualan"]);

                // Add data point with color from the palette
                chart_grafik.Series["Total Penjualan"].Points.AddXY(productName, totalPenjualan);
                chart_grafik.Series["Total Penjualan"].Points.Last().Color = dayColors[colorIndex % dayColors.Length]; // Assign color
                colorIndex++;
            }
            chart_grafik.Legends.Clear();
        }

        private void PopulateDateComboBox(string intervalType)
        {
            cb_pilih2.Items.Clear();

            string query = "";
            if (intervalType == "day")
            {

                query = "SELECT DISTINCT DATE_FORMAT(tgl_transaksi, '%d/%m/%Y') AS Date FROM transaksi";
            }
            else if (intervalType == "week")
            {

                query = "SELECT DISTINCT CONCAT(DATE_FORMAT(MIN(tgl_transaksi), '%d/%m/%Y'), ' - ', DATE_FORMAT(MAX(tgl_transaksi), '%d/%m/%Y')) AS Week FROM transaksi GROUP BY YEARWEEK(tgl_transaksi)";
            }
            else if (intervalType == "month")
            {
                query = "SELECT DISTINCT DATE_FORMAT(tgl_transaksi, '%M %Y') AS Month FROM transaksi";
            }
            else if (intervalType == "year")
            {
                query = "SELECT DISTINCT YEAR(tgl_transaksi) AS Year FROM transaksi";
            }

            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);

            sqlConnect.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                cb_pilih2.Items.Add(reader[0].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }


        private void cb_pilih2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pilih2.SelectedIndex != -1 && cb_pilih.SelectedIndex != -1)
            {
                string intervalType = "";
                if (cb_pilih.SelectedIndex == 0)
                    intervalType = "day";
                else if (cb_pilih.SelectedIndex == 1)
                    intervalType = "week";
                else if (cb_pilih.SelectedIndex == 2)
                    intervalType = "month";
                else if (cb_pilih.SelectedIndex == 3)
                    intervalType = "year";
                else if (cb_pilih.SelectedIndex == 4)
                    intervalType = "all";

                string selectedValue = cb_pilih2.SelectedItem.ToString();
                string formattedValue = "";

                // Format the selected value based on the interval type
                if (intervalType == "month")
                {
                    string[] parts = selectedValue.Split(' ');
                    string month = parts[0];
                    string year = parts[1];

                    // Format month as "MM/YYYY"
                    DateTime dt = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture);
                    formattedValue = dt.Month.ToString("00") + "/" + year;
                }
                else
                {
                    formattedValue = selectedValue;
                }

                // Call the stored procedure based on the selected interval type and formatted value
                string query = "";
                if (intervalType == "day")
                {
                    // Call the stored procedure with the selected day
                    query = $"call PLaporanpenjualanGraph('day', '{formattedValue}', 0)";
                }
                else if (intervalType == "week")
                {
                    // Parse the selected week range
                    string[] parts = selectedValue.Split('-');
                    string startWeek = parts[0].Trim();
                    string endWeek = parts[1].Trim();

                    // Call the stored procedure with the selected week range
                    query = $"call PLaporanpenjualanGraph('week', '{startWeek}', 0)";
                }
                else if (intervalType == "month")
                {
                    // Call the stored procedure with the selected formatted month and year
                    query = $"call PLaporanpenjualanGraph('month', '{formattedValue}', 0)";
                }
                else if (intervalType == "year")
                {
                    // Call the stored procedure with the selected year
                    query = $"call PLaporanpenjualanGraph('year', '{selectedValue}', 0)";
                }
                else if (intervalType == "all")
                {
                    // Call the stored procedure for all data
                    query = $"call PLaporanpenjualanGraph('all', '', 0)";
                }

                selectedData = ExecuteQuery(query);

                chart_grafik.Series.Clear();
                chart_grafik.Series.Add("Total Penjualan");
                chart_grafik.Series["Total Penjualan"].ChartType = SeriesChartType.Column;
                Color[] dayColors = { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Orange, Color.Purple, Color.Cyan };

                int colorIndex = 0;

                foreach (DataRow row in selectedData.Rows)
                {
                    string productName = row["Nama Produk"].ToString();
                    int totalPenjualan = Convert.ToInt32(row["Total Penjualan"]);

                    // Add data point with color from the palette
                    chart_grafik.Series["Total Penjualan"].Points.AddXY(productName, totalPenjualan);
                    chart_grafik.Series["Total Penjualan"].Points.Last().Color = dayColors[colorIndex % dayColors.Length]; // Assign color
                    colorIndex++;
                }
                chart_grafik.Legends.Clear();
            }
        }
    }
}
