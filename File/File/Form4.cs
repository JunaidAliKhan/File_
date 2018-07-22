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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "File Pat";
            label2.Text = "File Name";
            button1.Text = "Exists";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            if (File.Exists(s))
            {
                MessageBox.Show("Your File Is Exists");
            }
            else
            {
                MessageBox.Show("Your File Is Not Exists");
            }
        }
    }
}
