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
    public partial class Form_DetailTransaksi : Form
    {
        string connectionstring = "server=localhost;uid=user;pwd=user;database=dbi_sad_baru";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dttrans;
        DataTable dtdettrans;
        string query;
        public string TransactionId { get; set; }
        public Form_DetailTransaksi()
        {
            InitializeComponent();
        }

        private void Form_DetailTransaksi_Load(object sender, EventArgs e)
        {
            dttrans = new DataTable();
            query = $"select * from transaksi where id_transaksi = '{TransactionId}';";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dttrans);

            DateTime tglTransaksi = Convert.ToDateTime(dttrans.Rows[0]["tgl_transaksi"]);
            string namapel = dttrans.Rows[0]["nama_pelanggan"] is DBNull ? "" : Convert.ToString(dttrans.Rows[0]["nama_pelanggan"]);
            string ordernum = "Order #"+TransactionId.ToString();
            int subtotal = Convert.ToInt32(dttrans.Rows[0]["total"]);
            string rpsubtot = subtotal.ToString("C0", new CultureInfo("id-ID")) ;
            label_ordercreated.Text = tglTransaksi.ToString("dddd, dd MMMM yyyy  HH:mm");
            label_namapelanggan.Text = namapel;
            label_ordernum.Text = ordernum;
            label_subtotal.Text = rpsubtot;

            dtdettrans = new DataTable();
            query = $"SELECT dt.id_detail_trans, dt.id_transaksi, dt.id_produk, p.nama_produk, dt.jml_beli, dt.hrg_satuan\r\nfrom detail_transaksi  dt, produk p\r\nwhere p.id_produk = dt.id_produk and id_transaksi = '{TransactionId}';";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtdettrans);

            for (int i = 0; i < dtdettrans.Rows.Count; i++)
            {
                string kodeitem = Convert.ToString(dtdettrans.Rows[i]["ID_PRODUK"]);
                PictureBox pb_gambaritem = new PictureBox();
                pb_gambaritem.Image = Image.FromFile($@"assets\circle2\{kodeitem}.png");
                pb_gambaritem.Size = new Size(50, 50);
                pb_gambaritem.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_gambaritem.Location = new Point(10, 10 + (i* 70));
                pb_gambaritem.Parent = panel_order;

                string namaitem = Convert.ToString(dtdettrans.Rows[i]["nama_produk"]);
                Label label_namaitem = new Label();
                label_namaitem.Text = namaitem;
                label_namaitem.Font = new Font("Montserrat", 15, FontStyle.Bold);
                label_namaitem.ForeColor = Color.Black;
                label_namaitem.Location = new Point(65, 25 + (i * 70));
                label_namaitem.Size = new Size(200, 27);
                label_namaitem.BackColor = Color.Transparent;
                label_namaitem.Parent = panel_order;

                string qitiyi = Convert.ToString(dtdettrans.Rows[i]["jml_beli"]);
                int qty = Convert.ToInt32(qitiyi);
                Label label_jumlahbeli = new Label();
                label_jumlahbeli.Text = qitiyi+"x";
                label_jumlahbeli.Font = new Font("Montserrat", 15, FontStyle.Bold);
                label_jumlahbeli.ForeColor = Color.Black;
                label_jumlahbeli.Location = new Point(415, 25 + (i * 70));
                label_jumlahbeli.Size = new Size(60, 27);
                label_jumlahbeli.BackColor = Color.Transparent;
                label_jumlahbeli.Parent = panel_order;

                int hargasat = Convert.ToInt32(dtdettrans.Rows[i]["hrg_satuan"]);
                string rphargasat = hargasat.ToString("C0", new CultureInfo("id-ID"));
                Label label_hargasatuan =new Label();
                label_hargasatuan.Text = rphargasat ;
                label_hargasatuan.Font = new Font("Montserrat", 15, FontStyle.Bold);
                label_hargasatuan.ForeColor = Color.Black;
                label_hargasatuan.Location = new Point(575, 25 + (i * 70));
                label_hargasatuan.Size = new Size(140, 27);
                label_hargasatuan.BackColor = Color.Transparent;
                label_hargasatuan.Parent = panel_order;

                int hargatotal = hargasat * qty;
                string rphargatotal = hargatotal.ToString("C0", new CultureInfo("id-ID"));
                Label label_hargatotal =new Label();
                label_hargatotal.Text = rphargatotal;
                label_hargatotal.Font = new Font("Montserrat", 15, FontStyle.Bold);
                label_hargatotal.ForeColor = Color.Black;
                label_hargatotal.Location = new Point(750, 25 + (i * 70));
                label_hargatotal.Size = new Size(130, 27);
                label_hargatotal.BackColor = Color.Transparent;
                label_hargatotal.Parent = panel_order;

                if (i < dtdettrans.Rows.Count - 1)
                {
                    PictureBox pb_line = new PictureBox();
                    pb_line.Image = Image.FromFile($@"assets\linedettrans.png");
                    pb_line.Size = new Size(880, 2);
                    pb_line.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb_line.Location = new Point(0,   ((i + 1) * 70));
                    pb_line.Parent = panel_order;
                }
            }

            

        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            Form_OrderHistory formorderhist = new Form_OrderHistory();
            formorderhist.Dock = DockStyle.Fill;
            formorderhist.TopLevel = false;
            formorderhist.ControlBox = false;
            formorderhist.FormBorderStyle = FormBorderStyle.None;
            Panel oldPanelOrdhist = formorderhist.PublicPanelOrdhist;
            oldPanelOrdhist.Location = new Point(0, 0);
            this.panel_ordhist.Size = oldPanelOrdhist.Size;
            this.panel_ordhist.Controls.Clear();
            this.panel_ordhist.Controls.Add(oldPanelOrdhist);
            formorderhist.Show();
        }
    }
}
