using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2023.WinCSharp.Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались!");
            this.Close();
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.Top -= e.Y;
            btnNo.Left += e.X;
            if (btnNo.Top < -10 || btnNo.Top > 100)
                btnNo.Top = 60;
            if (btnNo.Left < -80 || btnNo.Left > 250)
                btnNo.Left = 120;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }
    }
}
