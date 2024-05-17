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
    public partial class Form_MsgBoxAddorRemove : Form
    {
        public int clickedButtonIndex;
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
        
        public bool IsAddButtonPressed { get; private set; }
        public bool IsRemoveButtonPressed { get; private set; }

        public Form_MsgBoxAddorRemove(int index)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 90, 90));
            clickedButtonIndex = index;
        }


        private void Form_MsgBoxAddorRemove_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAddButtonPressed = true;
            IsRemoveButtonPressed = false;
            this.Close();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            IsAddButtonPressed = false;
            IsRemoveButtonPressed = true;
            this.Close();
        }
    }
}
