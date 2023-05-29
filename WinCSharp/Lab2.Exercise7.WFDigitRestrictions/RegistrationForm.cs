﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2023.WinCSharp.Lab10
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label lbl = new Label();
            TextBox txt = new TextBox();

            if (checkBox1.Checked == true)
            {
                //Label lbl = new Label();
                //TextBox txt = new TextBox();
                lbl.Location = new System.Drawing.Point(31, 96);
                lbl.Size = new System.Drawing.Size(35, 13);
                lbl.Name = "labelll";
                lbl.TabIndex = 4;
                lbl.Text = "PIN2:";
                groupBox1.Controls.Add(lbl);
                txt.Location = new System.Drawing.Point(71, 96);
                txt.Size = new System.Drawing.Size(278, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 4;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
                txt.KeyPress += new
                System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            }
            else
            {
                
                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов
                while (lcv > 5)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Поле Name не может содержать цифры");
            //}
            errorProvider1.SetError(textBox1, "Must be letter");

        }

        //private void textBox2_Validating(object sender, CancelEventArgs e)
        //{
        //    if (textBox2.Text == "")
        //    {
        //        e.Cancel = false;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            double.Parse(textBox2.Text);
        //            e.Cancel = false;
        //        }
        //        catch
        //        {
        //            e.Cancel = true;
        //            MessageBox.Show("Поле PIN не может содержать буквы");
        //        }
        //    }

        //}



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PIN не может содержать буквы");
            }

        }
        

    }
}
