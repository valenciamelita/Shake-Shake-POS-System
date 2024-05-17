using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_ShakeShake2
{
    public partial class Form_MsgBoxCorrect : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public bool IsYesButtonPressed { get; private set; }
        public bool IsNoButtonPressed { get; private set; }
        public Form_MsgBoxCorrect()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 90, 90));
        }

        private void Form_MsgBoxCorrect_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            IsYesButtonPressed = true;
            IsNoButtonPressed = false;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            IsYesButtonPressed = false;
            IsNoButtonPressed = true;
            this.Close();
        }
    }
}
