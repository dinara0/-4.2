using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!(numericUpDown1.Value > numericUpDown2.Value))
            {
                numericUpDown2.Value = numericUpDown1.Value - 1;
                progressBar2.Value = Decimal.ToInt32(numericUpDown2.Value);
                textBox2.Text = numericUpDown2.Value.ToString();
            }
            progressBar1.Value = Decimal.ToInt32(numericUpDown1.Value);
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }


        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            if (!(progressBar1.Value > progressBar2.Value))
            {
                progressBar2.Value = Decimal.ToInt32(progressBar1.Value-1);
                numericUpDown2.Value = progressBar2.Value;
                textBox2.Text = progressBar2.Value.ToString();
            }
            numericUpDown1.Value = progressBar1.Value;
            textBox1.Text = numericUpDown1.Value.ToString();

        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(Int32.Parse(textBox1.Text) > Int32.Parse(textBox2.Text)))
            {
                textBox2.Text = (Int32.Parse(textBox1.Text) - 1).ToString();
                progressBar2.Value = Int32.Parse(textBox2.Text);
                numericUpDown2.Value = Int32.Parse(textBox2.Text);
                
            }
            progressBar1.Value = Int32.Parse(textBox1.Text);
            numericUpDown1.Value = Int32.Parse(textBox1.Text);
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (!(numericUpDown1.Value > numericUpDown2.Value))
            {
                numericUpDown1.Value = numericUpDown2.Value + 1;
                progressBar1.Value = Decimal.ToInt32(numericUpDown1.Value);
                textBox1.Text = numericUpDown1.Value.ToString();
            }
            progressBar2.Value = Decimal.ToInt32(numericUpDown2.Value);
            textBox2.Text = numericUpDown2.Value.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar2_Click(object sender, EventArgs e)
        {
            if (!(progressBar1.Value > progressBar2.Value))
            {
                progressBar1.Value = Decimal.ToInt32(progressBar2.Value + 1);
                numericUpDown1.Value = progressBar1.Value;
                textBox1.Text = progressBar1.Value.ToString();
            }
            numericUpDown2.Value = progressBar2.Value;
            textBox2.Text = numericUpDown2.Value.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(Int32.Parse(textBox1.Text) > Int32.Parse(textBox2.Text)))
            {
                textBox1.Text = (Int32.Parse(textBox2.Text) + 1).ToString();
                progressBar1.Value = Int32.Parse(textBox1.Text);
                numericUpDown1.Value = Int32.Parse(textBox1.Text);

            }
            progressBar2.Value = Int32.Parse(textBox2.Text);
            numericUpDown2.Value = Int32.Parse(textBox2.Text);
        }

        /* public class numer
         {
             private int value1, value2;
             public void Set_value(int value, int fl)
             {
                 if (fl == 0)
                 {
                     if
                 }
             }
         }*/
    }

}
