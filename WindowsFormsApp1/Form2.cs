using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
			//Создание объекта для генерации чисел
			Random rnd = new Random();

			//Получить случайное число (в диапазоне от 0 до 10)
			int count = rnd.Next(1, 3);
			 //тут я увеличиваю значения счетчика на 1
			if (count == 1)
			{
				//если счетчик равен 1 то медведь
				pictureBox1.Image = Properties.Resources.i3;

			}
			if (count == 2)
			{
				//если счетчик равен 2 то конь
				pictureBox1.Image = Properties.Resources.i2;
			}
			if (count == 3)
			{
				//если счетчик равен 3 то щенок и котенок
				pictureBox1.Image = Properties.Resources.i1;
			}
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Environment.Exit(0);
		}
    }
}
