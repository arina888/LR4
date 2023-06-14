using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string city1;
        double cost;
        tarif room;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox3.Text != "")
                {

                    try
                    {
                        city1 = textBox1.Text;
                   
                        cost = double.Parse(textBox3.Text);
                        if (cost >= 0)
                        {
                            room = new tarif(city1, cost);
                            if (Base.addTariff(room))
                            {
                                label4.Text = "Тариф добавлен";
                            }
                            else label4.Text = "Тариф уже добавлен";
                        }
                        else label4.Text = "Стоимость должна быть положительным числом";

                    }
                    catch (Exception ex)
                    {
                        label4.Text = "Ошибка";
                    }

                }
                else
                {
                    MessageBox.Show("Укажите стоимость тарифа");
                }
            }
            else
            {
                MessageBox.Show("Укажите название населенных пунктов");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ',') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == 32 )
            {
                e.Handled = true;
            }
        }

     

     
    }
}
