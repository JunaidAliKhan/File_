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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "File-Address";
            label2.Text = "File-Name";
            label3.Text = "File-Extension";
            button1.Text = "File-Stream-Reader";
            button2.Text = "File-Stream-Writer";
            button3.Text = "Stream-Reader";
            button4.Text = "Stream-Write";

            textBox3.ScrollBars = ScrollBars.Both;
            string[] s = { ".txt", ".doc", ".xls", };
            comboBox1.Items.AddRange(s);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text + textBox2.Text + comboBox1.Text;
                FileStream fs = new FileStream(s, FileMode.OpenOrCreate);
                Byte[] b = new Byte[100];
                Char[] ch = new Char[100];
                fs.Read(b, 0, 100);
                Decoder ds = Encoding.UTF8.GetDecoder();
                ds.GetChars(b, 0, b.Length, ch, 0);
                foreach (char c in ch)
                {
                    textBox3.Text += c;
                }
                fs.Close();
                MessageBox.Show("Your File Is Ready To Read Now");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text + textBox2.Text + comboBox1.Text;
                FileStream fs = new FileStream(s, FileMode.OpenOrCreate);
                Byte[] b = new Byte[100];
                Char[] ch = new Char[100];

                Encoder es = Encoding.UTF8.GetEncoder();
                es.GetBytes(ch, 0, ch.Length, b, 0, true);
                fs.Write(b, 0, 100);
                fs.Close();
                MessageBox.Show("Your File Is Create, Now Ready To Write");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text + textBox2.Text + comboBox1.Text;
                StreamReader sr = new StreamReader(s);

                textBox3.Text = sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Your File Is Ready To Read Now");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text + textBox2.Text + comboBox1.Text;
                StreamWriter sr = new StreamWriter(s);

                sr.Write(textBox3.Text);
                sr.Close();
                MessageBox.Show("Your File Is Create, Now Ready To Write");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
