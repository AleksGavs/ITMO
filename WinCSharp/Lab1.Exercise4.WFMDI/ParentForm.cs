﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2023.WinCSharp.Lab4
{
    public partial class ParentForm : Form
    {
        private int openDocs = 0;
        public ParentForm()
        {
            InitializeComponent();
            spDate.Text = "Date: " + Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            spWin.Text = "Windows is horizontal";
        }

        private void CascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            spWin.Text = "Windows is cascade";
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = "Child form " + ++openDocs;
            newChild.MdiParent = this;
            newChild.Show();
        }
        /*
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = "Child form " + ++openDocs;
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }*/

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocs;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    spWin.Text = "Windows is cascade";
                    break;
                    
                case "Horizontal":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    spWin.Text = "Windows is horizontal";
                    break;
            }

        }
    }
}
