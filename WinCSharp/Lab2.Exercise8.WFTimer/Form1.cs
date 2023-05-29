using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2023.WinCSharp.Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControlTimer1.TimeEnabled)
            {
                userControlTimer1.TimeEnabled = false;
                button1.Text = "Запустить время!";
            }
            else 
            {
                userControlTimer1.TimeEnabled = true;
                button1.Text =  "Остановить время!";
            }
        }
    }
}
