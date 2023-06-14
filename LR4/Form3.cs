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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string  lastname, city1,city2;
        double min, cost;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == 32)
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == 32)
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number == 32) 
            {
                e.Handled = true;
            }
        }

     

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number == 32)
            {
                e.Handled = true;
            }
        }
             

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
     

        private void button1_Click(object sender, EventArgs e)
          
        {
            if (textBox1.Text != "")
            {    if (textBox3.Text != "")
                 {
                        if (textBox4.Text != "")
                        {
                            if (textBox5.Text != "")
                            {
                                try
                                {
                                    lastname = textBox1.Text;
                                    city1 = textBox3.Text;
                                    min = double.Parse(textBox4.Text);
                                    cost = double.Parse(textBox5.Text);
                                if (min >= 0 && cost >= 0)
                                { 

                                    label4.Text = Base.addSubscriber(lastname, city1, min, cost);
                                }
                                    
                                    else
                                    {
                                        label4.Text = "Количество минут и цена задаются положительным числом";
                                    }
                                }

                                catch (Exception ex)
                                {
                                    label4.Text = "Ошибка. тариф некорректного формата";
                                }
                            }
                            else
                            {
                            MessageBox.Show("Укажите количество минут");
                            }
                        }
                        else
                        {
                        MessageBox.Show("Укажите тариф");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Укажите город, куда произведен звонок");
                    }
                        
                
            }
            else
            {
                MessageBox.Show("Укажите фамилию");
            }

        }
    }
}

    
