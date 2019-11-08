using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            Hide();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент Грива Е.В. \nТомского государственного университета системы управления и радиоэлектроники (ТУСУР), кафедры АСУ, факультета системы управления (ФСУ), группы 447-1", "Об авторе");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e) //Методичка
        {
            try
            {               
                System.Diagnostics.Process.Start("ТЭО.pdf");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }
    }
}
