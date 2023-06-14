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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string lastName;
        double price;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            lastName = textBox1.Text;

            price = Base.ats(lastName);
            if (price == -1)
            { textBox2.Text = "Абонент не найден"; }
            
            else{ textBox2.Text = price.ToString(); }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == 32)
            {
                e.Handled = true;
            }
        }
    }
}
