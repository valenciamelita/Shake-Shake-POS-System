using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAD_ShakeShake2
{
    public partial class Form_AddStock : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtproduk;
        private int clickedButtonIndex;
        string productCode;
        public Form_AddStock(int index)
        {
            InitializeComponent();
            clickedButtonIndex = index;
        }

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

        private void Form_AddStock_Load(object sender, EventArgs e)
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

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_hrgmodal.Text) || string.IsNullOrEmpty(tb_jmlproduksi.Text))
            {
                label_isisemua.Visible = true;
            }
            else
            {
                string harga = tb_hrgmodal.Text;
                string jumlahprod = tb_jmlproduksi.Text;
                DateTime dateTimeValue = datetimepick_tglbuat.Value;

                DateTime dateOnly = dateTimeValue.Date;
                string formattedTanggal = dateOnly.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime tanggalKdlws = dateOnly.AddDays(30);
                string formattedTanggalKdlws = tanggalKdlws.ToString("yyyy-MM-dd HH:mm:ss");

               // MessageBox.Show(formattedTanggal);


                query = $"insert into produksi (id_produk, tgl_buat, tgl_kadaluwarsa, harga_modal, jumlah_produksi) values\r\n('{productCode}','{formattedTanggal}', '{formattedTanggalKdlws}', '{harga}', '{jumlahprod}');";
                executeSQL(query);

                Form_ChangeSaved form_changesaved = new Form_ChangeSaved();
                form_changesaved.StartPosition = FormStartPosition.Manual;
                form_changesaved.Left = 500;
                form_changesaved.Top = 250;

                form_changesaved.FormClosed += Form_changesaved_FormClosed; 
                form_changesaved.Show();
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

        private void tb_hrgmodal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_jmlproduksi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void panel_invent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
