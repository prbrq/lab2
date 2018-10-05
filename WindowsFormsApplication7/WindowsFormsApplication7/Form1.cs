using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form   {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    double Сумма = Convert.ToDouble(textBox1.Text);
                    double Разность = Convert.ToDouble(textBox2.Text);
                    double Свет = (Сумма - Разность) / 2;
                    double Лампа = Свет + Разность;
                    textBox3.Text = String.Format("Стоимость светодиода: {0}; Стоимость энергосберегающей лампы: {1}", Свет, Лампа);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            }
    }
}
