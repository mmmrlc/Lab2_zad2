using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        int size;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton5.Checked == true) || (radioButton6.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    size = 16;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size);
                }
                if (radioButton2.Checked == true)
                {
                    size = 20;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size);
                }
                if (radioButton3.Checked == true)
                {
                    size = 24;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size);
                }
            }
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true) || (radioButton3.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    textBox1.ForeColor = Color.Red;
                }
                if (radioButton2.Checked == true)
                {
                    textBox1.ForeColor = Color.Blue;
                }
                if (radioButton3.Checked == true)
                {
                    textBox1.ForeColor = Color.Orange;
                }
            }
            if ((checkBox1.Checked == true) || (checkBox2.Checked == true) || (checkBox3.Checked == true))
            {
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic);
                }
                else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Underline);
                }
                else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size, FontStyle.Italic | FontStyle.Underline);
                }
                else if (checkBox1.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size, FontStyle.Bold);
                }
                else if (checkBox2.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size, FontStyle.Italic);
                }
                else if (checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, size, FontStyle.Underline);
                }
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
