using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2023.WinCSharp.Lab5_Control
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GraphicsPath romb = new GraphicsPath();
            romb.AddPolygon(new Point[] {new Point(this.Width/2,0), new Point(this.Width, this.Height/2),
                new Point(this.Width / 2, this.Height), new Point(0,this.Height/2)});
            Region myRegion = new Region(romb);
            this.Region = myRegion;
        }
    }
}
