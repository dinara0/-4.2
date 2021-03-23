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
            

        private void Label1_Click(object sender, EventArgs e)
        {
           
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


   

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int i1 = Convert.ToInt32(textBox1.Text);
            int i2 = Int32.Parse(textBox2.Text);

            if (e.KeyCode == Keys.Enter)
            {
                if (!(i1 > i2))
                {
                    textBox2.Text = (Int32.Parse(textBox1.Text) - 1).ToString();
                    progressBar2.Value = Int32.Parse(textBox2.Text);
                    numericUpDown2.Value = Int32.Parse(textBox2.Text);

                }
                progressBar1.Value = Int32.Parse(textBox1.Text); 
                numericUpDown1.Value = Int32.Parse(textBox1.Text);
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text)))
                {
                    textBox1.Text = (Int32.Parse(textBox2.Text) + 1).ToString();
                    progressBar1.Value = Int32.Parse(textBox1.Text);
                    numericUpDown1.Value = Int32.Parse(textBox1.Text);

                }
                progressBar2.Value = Int32.Parse(textBox2.Text);
                numericUpDown2.Value = Int32.Parse(textBox2.Text);
            }
        }

         public class model         {
             private int value1, value2;

             public void Set_value1(int value, )
             {
                value1 = value;
                 if (value1 <= value2)
                 {
                    value2 = value1 - 1;
                 }
             }
            public void Set_value2(int value, )
            {
                value2 = value;
                if (value1 <= value2)
                {
                    value1 = value2 + 1;
                }
            }
            public int Get_value1 ()
            {
                return value1;
            }
            public int Get_value2()
            {
                return value2;
            }
        }
    }

}
