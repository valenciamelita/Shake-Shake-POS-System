using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SAD_ShakeShake2
{
    public partial class Form_AddMenu : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtproduk;
        string selectedFileName;

        string kodekat = "";
        public int clickedButtonIndex;
        string productCode;

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

        public Form_AddMenu()
        {
            InitializeComponent();
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

            if (namaprod != "" && hargaprod != "" && deskprod != "")
            {
                query = $"INSERT INTO produk (NAMA_PRODUK, HARGA_JUAL, DESKRIPSI, ID_KATEGORI) VALUES ('{namaprod}', '{hargaprod}', '{deskprod}', '{kodekat}');\r\n";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                executeSQL(query);

                string lastProductId = string.Empty;
                query = $"select max(id_produk) as idproduk from dbi_sad_baru.produk where IS_DELETE='F';";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                dtproduk = new DataTable();
                sqlAdapter.Fill(dtproduk);

                if (dtproduk.Rows.Count > 0)
                {
                    lastProductId = dtproduk.Rows[0]["idproduk"].ToString();
                }

                string indexnya = int.Parse(lastProductId.Substring(1)).ToString();

                string targetDir1 = @"assets\circle";
                string targetDir2 = @"assets\circle2";
                string targetDir3 = @"assets\fotoproduk";

                string newFileName = lastProductId + Path.GetExtension(selectedFileName);
                string newFileNameIndex = indexnya + Path.GetExtension(selectedFileName);
                string destFilePath1 = Path.Combine(targetDir1, newFileNameIndex);

                string destFilePath2 = Path.Combine(targetDir2, newFileName);
                string destFilePath3 = Path.Combine(targetDir3, newFileName);

                if (pb_gambarmenu.Image != null)
                {
                    pb_gambarmenu.Image.Dispose();
                    pb_gambarmenu.Image = null;
                }

                try
                {
                    File.Copy(selectedFileName, destFilePath1, true);
                    File.Copy (selectedFileName, destFilePath2, true);
                    File.Copy(selectedFileName, destFilePath3, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while copying the file: " + ex.Message);
                }

                Form_ChangeSaved form_changesaved = new Form_ChangeSaved();
                form_changesaved.StartPosition = FormStartPosition.Manual;
                form_changesaved.Left = 500;
                form_changesaved.Top = 250;
                form_changesaved.FormClosed += Form_changesaved_FormClosed;
                form_changesaved.Show();
            }

                else { MessageBox.Show("You need to fill all field!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
             
        }

        private void Form_changesaved_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form_changesaved = (Form_ChangeSaved)sender;
            if (form_changesaved.OKButtonPressed)
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
        }


        private void label_editgmbr_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files ( *.png) | *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = dialog.FileName;

                pb_gambarmenu.Image = Image.FromFile(selectedFileName);
            }
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
