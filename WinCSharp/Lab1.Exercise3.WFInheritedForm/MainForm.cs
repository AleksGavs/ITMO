using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2023.WinCSharp.Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       

        protected void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(Width / 2, 0),
             new Point(Width / 2 - 60, 140),
             new Point(0, 160),
             new Point(120, Height / 2 + 40),
             new Point(80, Height),
             new Point(Width / 2, Height - 80), //middle
             new Point(Width - 80, Height),
             new Point(Width - 120, Height / 2 + 40),
             new Point(Width, 160),
             new Point(Width /2 + 60, 140),});
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
