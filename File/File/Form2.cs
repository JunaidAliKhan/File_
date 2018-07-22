using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "File Pat";
            label2.Text = "File Name";
            label3.Text = "Destination";
            button1.Text = "Copy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            string d = textBox3.Text + textBox2.Text;
            if (File.Exists(s))
            {
                DialogResult dr = MessageBox.Show("File is Already Exists, Do you wanna Replace It?", "Warning",
 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
               if (dr == DialogResult.Yes)
               {
                   File.Copy(s, d);
               }
            }
            else
            {
                File.Copy(s , d);
            }
          
        }
    }
}
