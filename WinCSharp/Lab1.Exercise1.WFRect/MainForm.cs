namespace ITMO.WinCSharp.Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            else this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(500, 300);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1.0)
                this.Opacity = 0.8;
            else this.Opacity = 1.0;
        }
    }
}