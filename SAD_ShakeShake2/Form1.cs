using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAD_ShakeShake2
{
    public partial class Form_SplashScreen : Form
    {
        int currHeight;
        public Form_SplashScreen()
        {
            InitializeComponent();
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

        private void Form_SplashScreen_Load(object sender, EventArgs e)
        {

            timer1.Start();
            currHeight = 1080;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            currHeight -= 5;
            if (currHeight <= -50)
            {
                timer1.Stop();
                Form_Menu formmenu = new Form_Menu();
                formmenu.Dock = DockStyle.Fill;
                formmenu.TopLevel = false;
                formmenu.ControlBox = false;
                formmenu.FormBorderStyle = FormBorderStyle.None;
                this.panel_show.Controls.Clear();
                this.panel_show.Controls.Add(formmenu);
                formmenu.Show();
            }
            pictureBox2.Size = new Size(1284, currHeight);


        }
    }
}
