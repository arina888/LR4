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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int index = -1;
      
        private void Form4_Load(object sender, EventArgs e)
        {

            try
            {
                Base.showTarifs(dataGridView1, 0);
                {

                    double balans = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        double incom;
                        double.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom);
                        balans += incom;
                    }
                    textBox1.Text = balans.ToString();
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Тарифов нет";
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
