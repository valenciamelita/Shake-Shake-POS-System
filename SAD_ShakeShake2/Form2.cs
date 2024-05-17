using System;
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
using Guna.UI2.WinForms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System.Collections.Specialized;
using static Guna.UI2.Native.WinApi;
using System.Reflection;

namespace SAD_ShakeShake2
{
    public partial class Form_Menu : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        DataTable dtproduk;
        DataTable dtproduk_search;
        PictureBox pb_cardmenu;
        PictureBox pb_gambarmenu;
        Label label_namamenu;
        Label label_harga;
        Label label_desc;
        Label label_cat;
        Label kosong;
        List<KeyValuePair<string, int>> orderset;
        Label label_qtyorder;
        int totalproduk;
        int grandTotal;
        int hargaJual2;

        public Form_Menu()
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

        private void UpdateGrandTotalLabel()
        {
            grandTotal = 0;

            foreach (var entry in orderset)
            {
                int productIndex = dtproduk.Rows.IndexOf(dtproduk.Select($"NAMA_PRODUK = '{entry.Key}'").FirstOrDefault());
                int hargaJual = Convert.ToInt32(dtproduk.Rows[productIndex]["HARGA_JUAL"]);
                grandTotal += entry.Value * hargaJual;
            }

            string formattedGrandTotal = grandTotal.ToString("C0", new CultureInfo("id-ID"));
            label_gtotalrp.Text = formattedGrandTotal;

        }
        public void LoadProduk(int i, DataTable dt)
        {
            pb_cardmenu = new PictureBox();
            pb_cardmenu.Image = Image.FromFile(@"assets\rectangle1.png");
            pb_cardmenu.Size = new Size(550, 150);
            pb_cardmenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_cardmenu.Tag = i;
            string namaProduk = dt.Rows[i]["NAMA_PRODUK"].ToString();
            string idprod = dt.Rows[i]["ID_PRODUK"].ToString();
            string fileName = $"{idprod}.png";
            int yPosition = i * 150;
            pb_cardmenu.Location = new Point(-10, yPosition);
            pb_cardmenu.Parent = panel_menu;

            pb_gambarmenu = new PictureBox();
            pb_gambarmenu.Image = Image.FromFile($@"assets\fotoproduk\{fileName}");
            pb_gambarmenu.Size = new Size(100, 100);
            pb_gambarmenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_gambarmenu.Location = new Point(30, 20);
            pb_gambarmenu.Parent = pb_cardmenu;
            pb_gambarmenu.Tag = i;

            label_namamenu = new Label();
            label_namamenu.Tag = i;
            label_namamenu.Text = namaProduk;
            label_namamenu.TextAlign = ContentAlignment.TopLeft;
            label_namamenu.Location = new Point(150, 15);
            label_namamenu.Size = new Size(250, 40);
            label_namamenu.Font = new Font("Montserrat", 15, FontStyle.Bold);
            label_namamenu.ForeColor = Color.Black;
            label_namamenu.Parent = pb_cardmenu;

            int hargaJual = Convert.ToInt32(dt.Rows[i]["HARGA_JUAL"]);
            string hargaProduk = hargaJual.ToString("C0", new CultureInfo("id-ID"));

            label_harga = new Label();
            label_harga.Text = hargaProduk;
            label_harga.Font = new Font("Montserrat", 10, FontStyle.Regular);
            label_harga.ForeColor = Color.Black;
            label_harga.Location = new Point(150, 50);
            label_harga.Size = new Size(250, 20);
            label_harga.BackColor = Color.Transparent;
            label_harga.Parent = pb_cardmenu;
            label_harga.Tag = i;

            string descProduk = dt.Rows[i]["DESKRIPSI"].ToString();

            label_desc = new Label();
            label_desc.Text = descProduk;
            label_desc.Font = new Font("Montserrat", 10, FontStyle.Regular);
            label_desc.ForeColor = Color.FromArgb(138, 138, 138);
            label_desc.Location = new Point(150, label_harga.Bottom + 5);
            label_desc.Size = new Size(300, 17);
            label_desc.Parent = pb_cardmenu;
            label_desc.Tag = i;

            string catProduk = dt.Rows[i]["ID_KATEGORI"].ToString();
            label_cat = new Label();
            label_cat.Location = new Point(150, label_desc.Bottom + 10);
            label_cat.Font = new Font("Montserrat", 10, FontStyle.Regular);
            label_cat.Size = new Size(300, 20);
            label_cat.Parent = pb_cardmenu;
            label_cat.Tag = i;

            if (catProduk == "K001")
            {
                label_cat.Text = "Seasonal";
                label_cat.ForeColor = Color.Red;
            }
            else if (catProduk == "K002")
            {
                label_cat.Text = "Premium";
                label_cat.ForeColor = Color.Green;
            }
            else if (catProduk == "K003")
            {
                label_cat.Text = "Regular";
                label_cat.ForeColor = Color.FromArgb(254, 203, 28);
            }
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

        private void SetOrderNumber()
        {
            DateTime today = DateTime.Today;
            string formattedDate = today.ToString("yyMMdd");
            string query = $"SELECT MAX(SUBSTRING(id_transaksi, 8)) FROM transaksi WHERE id_transaksi LIKE 'T{formattedDate}%';";

            try
            {
                sqlConnect.Open();

                sqlCommand = new MySqlCommand(query, sqlConnect);
                object result = sqlCommand.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    int lastNumber = Convert.ToInt32(result);
                    int nextNumber = lastNumber + 1;

                    string paddedNextNumber = nextNumber.ToString("D3");

                    label_ordernum.Text = $"Order #{paddedNextNumber}";
                }
                else
                {
                    label_ordernum.Text = $"Order #001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        public void ClickProduk(int productIndex, string productName)
        {

            foreach (var entry in orderset)
            {
                string productname = entry.Key;
                int quantity = entry.Value;

                DataRow[] foundRows = dtproduk.Select($"NAMA_PRODUK = '{productname}'");
                if (foundRows.Length > 0)
                {
                    int productindex = dtproduk.Rows.IndexOf(foundRows[0]);
                    hargaJual2 = Convert.ToInt32(dtproduk.Rows[productindex]["HARGA_JUAL"]);
                    
                }
            }

            string hargaProduk2 = hargaJual2.ToString("C0", new CultureInfo("id-ID"));
            int indexdari = orderset.FindIndex(entry => entry.Key == productName);
            int indexdariproduk = -1;
            for (int i = 0; i < dtproduk.Rows.Count; i++)
            {
                if (dtproduk.Rows[i]["NAMA_PRODUK"].ToString() == productName)
                {
                    indexdariproduk = i;
                    break;
                }
            }

            PictureBox pb_gambarmenuu = new PictureBox();
            pb_gambarmenuu.Image = Image.FromFile($@"assets\circle\{indexdariproduk + 1}.png");
            pb_gambarmenuu.Size = new Size(35, 35);
            pb_gambarmenuu.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_gambarmenuu.Location = new Point(27, 10 + indexdari * 50);
            pb_gambarmenuu.Parent = panel_order;

            Label label_namamenuorder = new Label();
            label_namamenuorder.Text = productName;
            label_namamenuorder.Font = new Font("Montserrat", 10, FontStyle.Regular);
            label_namamenuorder.ForeColor = Color.Black;
            label_namamenuorder.Location = new Point(60, 15 + indexdari * 50);
            label_namamenuorder.Size = new Size(130, 17);
            label_namamenuorder.BackColor = Color.Transparent;
            label_namamenuorder.Parent = panel_order;

            Label label_hargaorder = new Label();
            label_hargaorder.Text = hargaProduk2;
            label_hargaorder.Font = new Font("Montserrat", 8, FontStyle.Regular);
            label_hargaorder.ForeColor = Color.Black;
            label_hargaorder.Location = new Point(62, 30 + indexdari * 50);
            label_hargaorder.Size = new Size(130, 20);
            label_hargaorder.BackColor = Color.Transparent;
            label_hargaorder.Parent = panel_order;

            PictureBox pb_qty = new PictureBox();
            pb_qty.Image = Image.FromFile($@"assets\rectangleqtyorder.png");
            pb_qty.Size = new Size(35, 35);
            pb_qty.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_qty.Location = new Point(195, 10 + indexdari * 50);
            pb_qty.Parent = panel_order;
            pb_qty.BringToFront();

            label_qtyorder = new Label();
            label_qtyorder.Text = orderset.First(entry => entry.Key == productName).Value.ToString();
            label_qtyorder.Font = new Font("Montserrat", 8, FontStyle.Bold);
            label_qtyorder.ForeColor = Color.Black;
            label_qtyorder.Location = new Point(10, 10);
            label_qtyorder.Size = new Size(40, 20);
            label_qtyorder.BackColor = Color.Transparent;
            label_qtyorder.Parent = pb_qty;
            label_qtyorder.BringToFront();


            totalproduk = Convert.ToInt32(label_qtyorder.Text) * Convert.ToInt32(hargaJual2);
            string rptotalproduk = totalproduk.ToString("C0", new CultureInfo("id-ID"));

            Label label_priceorder = new Label();
            label_priceorder.Text = rptotalproduk;
            label_priceorder.Font = new Font("Montserrat", 10, FontStyle.Bold);
            label_priceorder.ForeColor = Color.Black;
            label_priceorder.Location = new Point(240, 20 + indexdari * 50);
            label_priceorder.Size = new Size(85, 20);
            label_priceorder.BackColor = Color.Transparent;
            label_priceorder.Parent = panel_order;
            label_priceorder.BringToFront();

            Guna2PictureBox pb_sampah = new Guna2PictureBox();
            pb_sampah.Image = Image.FromFile($@"assets\trashbin.png");
            pb_sampah.Tag = indexdari;
            pb_sampah.Size = new Size(35, 35);
            pb_sampah.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_sampah.Location = new Point(330, 10 + indexdari * 50);
            pb_sampah.Parent = panel_order;
            pb_sampah.Click += Pb_sampah_Click;
        }

        private void Pb_sampah_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null && clickedPictureBox.Tag != null)
            {
                int productIndex = (int)clickedPictureBox.Tag;
                string productName = orderset.ElementAt(productIndex).Key;

                if (orderset.Any(entry => entry.Key == productName))
                {
                    orderset.RemoveAll(entry => entry.Key == productName);
                    panel_order.Controls.Clear();

                    foreach (var kvp in orderset)
                    {
                        int productIndex2 = GetProductIndexByName(kvp.Key);
                        ClickProduk(productIndex2, kvp.Key);
                    }
                }
                UpdateGrandTotalLabel();
            }
        }
        private int GetProductIndexByName(string productName)
        {
            for (int i = 0; i < dtproduk.Rows.Count; i++)
            {
                if (dtproduk.Rows[i]["NAMA_PRODUK"].ToString() == productName)
                {
                    return i;
                }
            }
            return -1; // Return -1 or handle the case when the product is not found
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            RefreshJamTanggal();

            orderset = new List<KeyValuePair<string, int>>();
            dtproduk = new DataTable();
            query = $"select * from produk where is_delete = 'F'";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtproduk);

            for (int i = 0; i < dtproduk.Rows.Count; i++)
            {
                LoadProduk(i, dtproduk);
                pb_cardmenu.Click += Pb_cardmenu_Click;
                pb_gambarmenu.Click += Pb_cardmenu_Click;
                label_namamenu.Click += Pb_cardmenu_Click;
                label_harga.Click += Pb_cardmenu_Click;
                label_desc.Click += Pb_cardmenu_Click;
                label_cat.Click += Pb_cardmenu_Click;
            }

            kosong = new Label();
            kosong.Text = "Pick an Item!";
            kosong.TextAlign = ContentAlignment.TopLeft;
            kosong.Location = new Point(120, 250);
            kosong.Size = new Size(250, 40);
            kosong.Font = new Font("Montserrat", 15);
            kosong.ForeColor = Color.FromArgb(142, 141, 141);
            kosong.Parent = panel_order;

            SetOrderNumber();

        }

        private void Pb_cardmenu_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            Label clickedLabel = sender as Label;

            if (clickedPictureBox != null && clickedPictureBox.Tag != null)
            {
                int productIndex = (int)clickedPictureBox.Tag;
                string productName = dtproduk.Rows[productIndex]["NAMA_PRODUK"].ToString();
                int availableStock = Convert.ToInt32(dtproduk.Rows[productIndex]["STOK_TOTAL"]);

                if (orderset.Any(entry => entry.Key == productName))
                {
                    var foundEntry = orderset.FirstOrDefault(pair => pair.Key == productName);
                    int index = orderset.IndexOf(foundEntry);
                    int newQuantity = foundEntry.Value + 1;
                    if (newQuantity > availableStock)
                    {
                        MessageBox.Show($"Cannot add more {productName}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    orderset[index] = new KeyValuePair<string, int>(foundEntry.Key, foundEntry.Value + 1);
                    kosong.Visible = false;
                    ClickProduk(productIndex, productName);
                    button_clear.Visible = true;
                }
                else
                {
                    if (1 > availableStock)
                    {
                        MessageBox.Show($"Cannot add {productName}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    orderset.Add(new KeyValuePair<string, int>(productName, 1));
                    kosong.Visible = false;
                    ClickProduk(productIndex, productName);
                    panel_grandtotal.Visible = true;
                    button_clear.Visible = true;
                }

                UpdateGrandTotalLabel();
                panel_order.Refresh();
            }

            if (clickedLabel != null && clickedLabel.Tag != null)
            {
                int productIndex2 = (int)clickedLabel.Tag;
                string productName2 = dtproduk.Rows[productIndex2]["NAMA_PRODUK"].ToString();
                int availableStock = Convert.ToInt32(dtproduk.Rows[productIndex2]["STOK_TOTAL"]);

                if (orderset.Any(entry => entry.Key == productName2))
                {
                    var foundEntry = orderset.FirstOrDefault(pair => pair.Key == productName2);
                    int index = orderset.IndexOf(foundEntry);
                    int newQuantity = foundEntry.Value + 1;
                    if (newQuantity > availableStock)
                    {
                        MessageBox.Show($"Cannot add more {productName2}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    orderset[index] = new KeyValuePair<string, int>(foundEntry.Key, foundEntry.Value + 1);
                    kosong.Visible = false;
                    ClickProduk(productIndex2, productName2);
                    button_clear.Visible = true;
                }
                else
                {
                    if (1 > availableStock)
                    {
                        MessageBox.Show($"Cannot add {productName2}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    orderset.Add(new KeyValuePair<string, int>(productName2, 1));
                    kosong.Visible = false;
                    ClickProduk(productIndex2, productName2);
                    panel_grandtotal.Visible = true;
                    button_clear.Visible = true;
                }
            }
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

        private void icon_orderhist_Click(object sender, EventArgs e)
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
            pb_gambarmenu.Image.Dispose();
            pb_gambarmenu.Image = null;
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
            pb_gambarmenu.Image.Dispose();
            pb_gambarmenu.Image = null;
            formsettings.Dock = DockStyle.Fill;
            formsettings.TopLevel = false;
            formsettings.ControlBox = false;
            formsettings.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(formsettings);
            formsettings.Show();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            RefreshJamTanggal();
        }

        private void x_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void x_button_MouseLeave(object sender, EventArgs e)
        {
            x_button.ForeColor = Color.DimGray;
            x_button.BackColor = Color.White;
        }

        private void x_button_MouseEnter(object sender, EventArgs e)
        {
            x_button.ForeColor = Color.White;
            x_button.BackColor = Color.FromArgb(255, 0, 0);
        }


        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dtproduk_search = new DataTable();
            query = $"call psearchproduk('{tb_search.Text}');";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtproduk_search);

            panel_menu.Controls.Clear();

            for (int i = 0; i < dtproduk_search.Rows.Count; i++)
            {

                LoadProduk(i, dtproduk_search);
                pb_cardmenu.Click += Pb_cardmenu2_Click;
                pb_gambarmenu.Click += Pb_cardmenu2_Click;
                label_namamenu.Click += Pb_cardmenu2_Click;
                label_harga.Click += Pb_cardmenu2_Click;
                label_desc.Click += Pb_cardmenu2_Click;
                label_cat.Click += Pb_cardmenu2_Click;

            }
        }

        private void Pb_cardmenu2_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            Label clickedLabel = sender as Label;

            if (clickedPictureBox != null && clickedPictureBox.Tag != null)
            {
                int productIndex = (int)clickedPictureBox.Tag;
                string productName = dtproduk.Rows[productIndex]["NAMA_PRODUK"].ToString();
                int availableStock = Convert.ToInt32(dtproduk.Rows[productIndex]["STOK_TOTAL"]);

                if (orderset.Any(entry => entry.Key == productName))
                {
                    var foundEntry = orderset.FirstOrDefault(pair => pair.Key == productName);
                    int index = orderset.IndexOf(foundEntry);
                    int newQuantity = foundEntry.Value + 1;
                    if (newQuantity > availableStock)
                    {
                        MessageBox.Show($"Cannot add more {productName}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    orderset[index] = new KeyValuePair<string, int>(foundEntry.Key, foundEntry.Value + 1);
                    kosong.Visible = false;
                    ClickProduk(productIndex, productName);
                    button_clear.Visible = true;
                }
                else
                {
                    if (1 > availableStock)
                    {
                        MessageBox.Show($"Cannot add {productName}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    orderset.Add(new KeyValuePair<string, int>(productName, 1));
                    kosong.Visible = false;
                    ClickProduk(productIndex, productName);
                    panel_grandtotal.Visible = true;
                    button_clear.Visible = true;
                }

                UpdateGrandTotalLabel();
                panel_order.Refresh();
            }

            if (clickedLabel != null && clickedLabel.Tag != null)
            {
                int productIndex2 = (int)clickedLabel.Tag;
                string productName2 = dtproduk.Rows[productIndex2]["NAMA_PRODUK"].ToString();
                int availableStock = Convert.ToInt32(dtproduk.Rows[productIndex2]["STOK_TOTAL"]);

                if (orderset.Any(entry => entry.Key == productName2))
                {
                    var foundEntry = orderset.FirstOrDefault(pair => pair.Key == productName2);
                    int index = orderset.IndexOf(foundEntry);
                    int newQuantity = foundEntry.Value + 1;
                    if (newQuantity > availableStock)
                    {
                        MessageBox.Show($"Cannot add more {productName2}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    orderset[index] = new KeyValuePair<string, int>(foundEntry.Key, foundEntry.Value + 1);
                    kosong.Visible = false;
                    ClickProduk(productIndex2, productName2);
                    button_clear.Visible = true;
                }
                else
                {
                    if (1 > availableStock)
                    {
                        MessageBox.Show($"Cannot add {productName2}. Available stock: {availableStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    orderset.Add(new KeyValuePair<string, int>(productName2, 1));
                    kosong.Visible = false;
                    ClickProduk(productIndex2, productName2);
                    panel_grandtotal.Visible = true;
                    button_clear.Visible = true;
                }
            }
        }

        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_menu.Controls.Clear();
            tb_search.ResetText();
            if (cb_sort.SelectedIndex == 0)
            {
                dtproduk = new DataTable();
                query = $"select * from produk where is_delete = 'F'";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtproduk);


            }
            else if (cb_sort.SelectedIndex == 1)
            {
                dtproduk = new DataTable();
                query = $"select * from vSortCat where is_delete = 'F'";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtproduk);

            }
            else
            {
                dtproduk = new DataTable();
                query = $"select * from vSortHarga where is_delete = 'F'";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtproduk);
            }

            for (int i = 0; i < dtproduk.Rows.Count; i++)
            {
                LoadProduk(i, dtproduk);
                pb_cardmenu.Click += Pb_cardmenu_Click;
                pb_gambarmenu.Click += Pb_cardmenu_Click;
                label_namamenu.Click += Pb_cardmenu_Click;
                label_harga.Click += Pb_cardmenu_Click;
                label_desc.Click += Pb_cardmenu_Click;
                label_cat.Click += Pb_cardmenu_Click;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            orderset.Clear();
            panel_order.Controls.Clear();
            panel_grandtotal.Visible = false;
            kosong.Visible = true;
            button_clear.Visible = false;
            cb_sort.SelectedIndex = 0;
        }
        private void button_checkout_Click(object sender, EventArgs e)
        {

            Form_MsgBoxCorrect form_msgboxcorrect = new Form_MsgBoxCorrect();
            form_msgboxcorrect.StartPosition = FormStartPosition.Manual;
            form_msgboxcorrect.Left = 500;
            form_msgboxcorrect.Top = 250;

            form_msgboxcorrect.FormClosed += Form_msgboxcorrect_FormClosed; ;
            form_msgboxcorrect.Show();


        }
        private void Form_msgboxcorrect_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form_msgboxcorrect = (Form_MsgBoxCorrect)sender;

            if (form_msgboxcorrect.IsYesButtonPressed)
            {
                string namapelanggann = tb_namapelanggan.Text;
                if (string.IsNullOrEmpty(tb_namapelanggan.Text))
                {
                    namapelanggann = null;
                }

                int jumlahitem = orderset.Count;

                query = "SELECT fgenidtrans();";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable cobakDT = new DataTable();
                sqlAdapter.Fill(cobakDT);
                sqlConnect.Open();
                string hslId = Convert.ToString(sqlCommand.ExecuteScalar());
                sqlConnect.Close();

                query= $"INSERT INTO transaksi (id_transaksi, nama_pelanggan, jml_item, total) VALUES ('{hslId}', '{namapelanggann}', '{jumlahitem}', '{grandTotal}');";
                executeSQL(query);

                foreach (var orderEntry in orderset)
                {
                    string productName = orderEntry.Key;
                    int quantity = orderEntry.Value;

                    DataTable productDetails = new DataTable();
                    string getProductDetailsQuery = $"SELECT id_produk, harga_jual FROM produk WHERE NAMA_PRODUK = '{productName}';";
                    sqlConnect = new MySqlConnection(connectionstring);
                    sqlCommand = new MySqlCommand(getProductDetailsQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(productDetails);

                    string idprod = Convert.ToString(productDetails.Rows[0]["id_produk"]);
                    int hrgsat = Convert.ToInt32(productDetails.Rows[0]["harga_jual"]);

                    query = $"INSERT INTO detail_transaksi (id_transaksi, id_produk, jml_beli, hrg_satuan) VALUES ('{hslId}', '{idprod}', '{quantity}', '{hrgsat}');";
                    executeSQL(query);
                }


                Form_MsgBoxSaved form_msgboxsaved = new Form_MsgBoxSaved();
                form_msgboxsaved.StartPosition = FormStartPosition.Manual;
                form_msgboxsaved.Left = 500;
                form_msgboxsaved.Top = 250;

                form_msgboxsaved.FormClosed += Form_msgboxsaved_FormClosed;
                form_msgboxsaved.Show();

            }
        }
        private void Form_msgboxsaved_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form_msgboxsaved = (Form_MsgBoxSaved)sender;
            if (form_msgboxsaved.IsOKKButtonPressed)
            {
                orderset.Clear();
                panel_order.Controls.Clear();
                panel_grandtotal.Visible = false;
                kosong.Visible = true;
                button_clear.Visible = false;
                cb_sort.SelectedIndex = 0;
                tb_namapelanggan.Clear();
            }
            SetOrderNumber();
        } 
    }
}
