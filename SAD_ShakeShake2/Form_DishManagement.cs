using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace SAD_ShakeShake2
{
    public partial class Form_DishManagement : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtproduk;

        string kodekat = "";
        public int clickedButtonIndex;
        string productCode;
        public Form_DishManagement(int clickedButtonIndex)
        {
            InitializeComponent();
            this.clickedButtonIndex = clickedButtonIndex;
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

        private void pb_back_Click(object sender, EventArgs e)
        {
            Form_Settings form_settings = new Form_Settings();
            form_settings.Dock = DockStyle.Fill;
            form_settings.TopLevel = false;
            form_settings.ControlBox = false;
            form_settings.FormBorderStyle = FormBorderStyle.None;
            Panel oldPanelSettings = form_settings.PublicPanelSettings;
            oldPanelSettings.Location = new Point(0, 0);
            this.panel_settings.Size = oldPanelSettings.Size;
            this.panel_settings.Controls.Clear();
            this.panel_settings.Controls.Add(oldPanelSettings);
            form_settings.Show();

        }

        private void Form_DishManagement_Load(object sender, EventArgs e)
        {
            productCode = $"P{clickedButtonIndex + 1:D4}";
            pb_gambarmenu.Image = Image.FromFile($@"assets\circle\{clickedButtonIndex + 1}.png");
            dtproduk = new DataTable();
            query = $"select nama_produk,harga_jual,id_kategori,deskripsi from produk where id_produk='{productCode}' and is_delete = 'F';";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtproduk);

            tb_namamenu.Text = Convert.ToString(dtproduk.Rows[0]["nama_produk"]);
            tb_harga.Text = Convert.ToString(dtproduk.Rows[0]["harga_jual"]);
            tb_deskripsi.Text = Convert.ToString(dtproduk.Rows[0]["deskripsi"]);
            kodekat = Convert.ToString(dtproduk.Rows[0]["id_kategori"]);

            if (kodekat == "K0001")
            {
                cb_kategori.SelectedIndex = 0;
            }
            else if (kodekat == "K0002")
            {
                cb_kategori.SelectedIndex = 1;
            }
            else
            {
                cb_kategori.SelectedIndex = 2;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            Form_MsgBoxDelete form_msgboxdelete = new Form_MsgBoxDelete();
            form_msgboxdelete.StartPosition = FormStartPosition.Manual;
            form_msgboxdelete.Left = 500;
            form_msgboxdelete.Top = 250;

            form_msgboxdelete.FormClosed += Form_msgboxdelete_FormClosed; ;
            form_msgboxdelete.Show();
        }

        private void Form_msgboxdelete_FormClosed(object sender, FormClosedEventArgs e)
        {

            var form_msgboxdelete = (Form_MsgBoxDelete)sender;

            if (form_msgboxdelete.IsYesButtonPressed)
            {
                query = $"update dbi_sad_baru.produk set is_Delete = 'T' where id_produk = '{productCode}'";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                executeSQL(query);

                Form_Settings form_settings = new Form_Settings();
                form_settings.Dock = DockStyle.Fill;
                form_settings.TopLevel = false;
                form_settings.ControlBox = false;
                form_settings.FormBorderStyle = FormBorderStyle.None;
                Panel oldPanelSettings = form_settings.PublicPanelSettings;
                oldPanelSettings.Location = new Point(0, 0);
                this.panel_settings.Size = oldPanelSettings.Size;
                this.panel_settings.Controls.Clear();
                this.panel_settings.Controls.Add(oldPanelSettings);
                form_settings.Show();
            }
        }

            private void button_save_Click(object sender, EventArgs e)
        {
            string namaprod = tb_namamenu.Text;
            string hargaprod = tb_harga.Text;
            string deskprod = tb_deskripsi.Text;

            if (cb_kategori.SelectedIndex == 0)
            {
                kodekat = "K001";
            }
            else if (cb_kategori.SelectedIndex == 1)
            {
                kodekat = "K002";
            }
            else
            {
                kodekat = "K003";
            }

            if (namaprod != "" && hargaprod != "" && deskprod!="")
            {
                query = $"update produk\r\nset NAMA_PRODUK = '{namaprod}', HARGA_JUAL='{hargaprod}', DESKRIPSI='{deskprod}', ID_KATEGORI = '{kodekat}' where ID_PRODUK = '{productCode}';";
                executeSQL(query);

                Form_ChangeSaved form_changesaved = new Form_ChangeSaved();
                form_changesaved.StartPosition = FormStartPosition.Manual;
                form_changesaved.Left = 500;
                form_changesaved.Top = 250;

                form_changesaved.FormClosed += Form_changesaved_FormClosed;
                form_changesaved.Show();
            }
            else { MessageBox.Show("You need to fill all field!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Form_changesaved_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form_changesaved = (Form_ChangeSaved)sender;
            if (form_changesaved.OKButtonPressed)
            {
                Form_Settings form_settings = new Form_Settings();
                form_settings.Dock = DockStyle.Fill;
                form_settings.TopLevel = false;
                form_settings.ControlBox = false;
                form_settings.FormBorderStyle = FormBorderStyle.None;
                Panel oldPanelSettings = form_settings.PublicPanelSettings;
                oldPanelSettings.Location = new Point(0, 0);
                this.panel_settings.Size = oldPanelSettings.Size;
                this.panel_settings.Controls.Clear();
                this.panel_settings.Controls.Add(oldPanelSettings);
                form_settings.Show();
            }
        }

        private void label_cancel_Click(object sender, EventArgs e)
        {
            Form_Settings formsettings = new Form_Settings();
            formsettings.Dock = DockStyle.Fill;
            formsettings.TopLevel = false;
            formsettings.ControlBox = false;
            formsettings.FormBorderStyle = FormBorderStyle.None;
            Panel oldPanelInventory = formsettings.PublicPanelSettings;
            oldPanelInventory.Location = new Point(0, 0);
            this.panel_settings.Size = oldPanelInventory.Size;
            this.panel_settings.Controls.Clear();
            this.panel_settings.Controls.Add(oldPanelInventory);
            formsettings.Show();
        }

        private void tb_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
