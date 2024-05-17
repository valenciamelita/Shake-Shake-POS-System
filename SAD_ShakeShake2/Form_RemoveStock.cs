using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using static Guna.UI2.Native.WinApi;

namespace SAD_ShakeShake2
{
    public partial class Form_RemoveStock : Form
    {
        string connectionstring = "server=localhost;uid=root;pwd=junior123;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        string productCode;
        DataTable dtproduk;
        DataTable dtbatch;
        int clickedButtonIndex;
        int stoknya;

        private void executeSQL(string query)
        {
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.Close();

            }
        }

            public Form_RemoveStock(int index)
        {
            InitializeComponent();
            clickedButtonIndex = index;
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            Form_Inventory forminventory = new Form_Inventory();
            forminventory.Dock = DockStyle.Fill;
            forminventory.TopLevel = false;
            forminventory.ControlBox = false;
            forminventory.FormBorderStyle = FormBorderStyle.None;
            Panel oldPanelInventory = forminventory.PublicPanelInventory;
            oldPanelInventory.Location = new Point(0, 0);
            this.panel_invent.Size = oldPanelInventory.Size;
            this.panel_invent.Controls.Clear();
            this.panel_invent.Controls.Add(oldPanelInventory);
            forminventory.Show();
        }

        private void Form_RemoveStock_Load(object sender, EventArgs e)
        {
            productCode = $"P{clickedButtonIndex + 1:D4}";
            pb_gambarproduk.Image = Image.FromFile($@"assets\circle\{clickedButtonIndex + 1}.png");
            dtproduk = new DataTable();
            query = $"select nama_produk,stok_total from produk where id_produk='{productCode}' and is_delete = 'F';";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtproduk);

            label_namaproduk.Text = Convert.ToString(dtproduk.Rows[0]["nama_produk"]);
            label_stok.Text = Convert.ToString(dtproduk.Rows[0]["STOK_TOTAL"]);

            dtbatch = new DataTable();
            query = $"select id_produksi, tgl_buat, jumlah_sisa from produksi where jumlah_sisa<> 0 and ID_PRODUK = '{productCode}' and is_delete = 'F';";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtbatch);


            cb_batch.Items.Clear(); // Clear existing items

            for (int i = 0; i < dtbatch.Rows.Count; i++)
            {
                int idProduksi = Convert.ToInt32(dtbatch.Rows[i]["id_produksi"]);
                DateTime tglBuat = Convert.ToDateTime(dtbatch.Rows[i]["tgl_buat"]);

                string formattedString = $"{idProduksi} / {tglBuat.ToString("dd MMM yyyy")}";

                cb_batch.Items.Add(formattedString);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(tb_jmlbuang.Text) || string.IsNullOrEmpty(tb_keterangan.Text))
            {
                label_isisemua.Visible = true;
            }
            else
            {

                string[] batchtanggal = cb_batch.Text.Split('/');
                string batch = batchtanggal[0];
                string tanggalbuat = batchtanggal[1];

                // Retrieve jumlah_sisa from the selected batch
                DataRow[] selectedBatchRows = dtbatch.Select($"id_produksi = '{batch}'");
                if (selectedBatchRows.Length > 0)
                {
                    int jumlahSisa = Convert.ToInt32(selectedBatchRows[0]["jumlah_sisa"]);

                    // Retrieve other input values
                    DateTime dateTimeValue = datetimepick_tglbuang.Value;
                    DateTime dateOnly = dateTimeValue.Date;
                    string formattedTanggal = dateOnly.ToString("yyyy-MM-dd HH:mm:ss");
                    string keterangan = tb_keterangan.Text;
                    int jmlbuang = Convert.ToInt32(tb_jmlbuang.Text);

                    // Check if jmlbuang exceeds jumlah_sisa
                    if (jmlbuang > jumlahSisa)
                    {
                        MessageBox.Show("Jumlah buang tidak boleh melebihi jumlah sisa.");
                        return;
                    }
                    else
                    {
                        query = $"insert into barang_expired (tgl_buang, id_produksi, keterangan, jumlah_buang) values\r\n('{formattedTanggal}','{batch}', '{keterangan}', '{jmlbuang}');";
                        executeSQL(query);

                        Form_ChangeSaved form_changesaved = new Form_ChangeSaved();
                        form_changesaved.StartPosition = FormStartPosition.Manual;
                        form_changesaved.Left = 500;
                        form_changesaved.Top = 250;

                        form_changesaved.FormClosed += Form_changesaved_FormClosed; ;
                        form_changesaved.Show();
                    }



                }
            }
        }

        private void Form_changesaved_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form_changesaved = (Form_ChangeSaved)sender;
            if (form_changesaved.OKButtonPressed)
            {
                Form_Inventory forminventory = new Form_Inventory();
                forminventory.Dock = DockStyle.Fill;
                forminventory.TopLevel = false;
                forminventory.ControlBox = false;
                forminventory.FormBorderStyle = FormBorderStyle.None;
                Panel oldPanelInventory = forminventory.PublicPanelInventory;
                oldPanelInventory.Location = new Point(0, 0);
                this.panel_invent.Size = oldPanelInventory.Size;
                this.panel_invent.Controls.Clear();
                this.panel_invent.Controls.Add(oldPanelInventory);
                forminventory.Show();
            }
        }

        private void tb_jmlbuang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label_cancel_Click(object sender, EventArgs e)
        {
            Form_Inventory forminventory = new Form_Inventory();
            forminventory.Dock = DockStyle.Fill;
            forminventory.TopLevel = false;
            forminventory.ControlBox = false;
            forminventory.FormBorderStyle = FormBorderStyle.None;
            Panel oldPanelInventory = forminventory.PublicPanelInventory;
            oldPanelInventory.Location = new Point(0, 0);
            this.panel_invent.Size = oldPanelInventory.Size;
            this.panel_invent.Controls.Clear();
            this.panel_invent.Controls.Add(oldPanelInventory);
            forminventory.Show();
        
        }
    }
}
