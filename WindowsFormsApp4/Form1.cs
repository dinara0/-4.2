using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Model model1; //Ссылки на
        Model model2; //модель
        public Form1()
        {
            InitializeComponent();
            model1 = new Model(); //Создаем модель 1-й группы
            //Обновление компонент 1
            model1.observers += new System.EventHandler(this.UpdateFromModel1);
            model2 = new Model(); //Создаем модель 2-ой группы
            //Обновление компонент 2
            model2.observers += new System.EventHandler(this.UpdateFromModel2);
           
        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //При изменении значения компонента, передаем его в модель
            model1.setValue(Decimal.ToInt32(numericUpDown1.Value));          
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // При изменении значения компонента, передаем его в модель
            model2.setValue(Decimal.ToInt32(numericUpDown2.Value));         
        }

     
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model1.setValue(Int32.Parse(textBox1.Text));             
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)            
                model2.setValue(Int32.Parse(textBox2.Text));                 
        }

        //Обновление значений компонент 1-ой группы на форме
        private void UpdateFromModel1(object sender, EventArgs e)
        {
            if (CompareValue(model1, model2))
                model2.setValue(model1.getValue() - 1);
            
            textBox1.Text = model1.getValue().ToString();
            numericUpDown1.Value = model1.getValue();
            progressBar1.Value = model1.getValue();
        }

        //Обновление значений компонент 2-ой группы на форме
        private void UpdateFromModel2(object sender, EventArgs e)
        {
            if (CompareValue(model1, model2))
                model1.setValue(model2.getValue() + 1);
            textBox2.Text = model2.getValue().ToString();
            numericUpDown2.Value = model2.getValue();
            progressBar2.Value = model2.getValue();
        }

        public bool CompareValue(Model model1, Model model2)
        {
            if (model1.getValue() <= model2.getValue())
                return true;
            else return false;
        }
        public class Model
        {
            private int value; //Значения компонента
            public System.EventHandler observers; //Событие

            
            //Функция для изменения значения компонента 2-ой группы(любые)
            public void setValue(int value)
            {
                this.value = value;
                observers.Invoke(this, null);
            }

            //Функция для возвращения значения компонента при обновлении
            public int getValue()
            {
                return value;
            }
        }
    }

}
