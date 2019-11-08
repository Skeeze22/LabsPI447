using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox70.Text = "2,4";
                    textBox71.Text = "1,05";
                    textBox72.Text = "2,5";
                    textBox73.Text = "0,38";
                    textBox2.Clear();
                    textBox3.Clear();
                    break;
                case 1:
                    textBox70.Text = "3,0";
                    textBox71.Text = "1,12";
                    textBox72.Text = "2,5";
                    textBox73.Text = "0,35";
                    textBox2.Clear();
                    textBox3.Clear();
                    break;
                case 2:
                    textBox70.Text = "3,6";
                    textBox71.Text = "1,20";
                    textBox72.Text = "2,5";
                    textBox73.Text = "0,32";
                    textBox2.Clear();
                    textBox3.Clear();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox35.Visible = false;
            textBox30.Visible = false;
            textBox29.Visible = false;
            textBox28.Visible = false;
            textBox27.Visible = false;
            textBox26.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;
            textBox40.Visible = false;
            textBox41.Visible = false;
            textBox42.Visible = false;
            textBox43.Visible = false;
            textBox44.Visible = false;
            textBox45.Visible = false;
            textBox46.Visible = false;
            textBox47.Visible = false;
            textBox48.Visible = false;
            textBox49.Visible = false;
            textBox50.Visible = false;
            textBox51.Visible = false;
            textBox52.Visible = false;
            textBox53.Visible = false;
            textBox54.Visible = false;
            textBox55.Visible = false;
            textBox56.Visible = false;
            textBox57.Visible = false;
            textBox58.Visible = false;
            textBox62.Visible = false;
            textBox63.Visible = false;
            textBox65.Visible = false;
            textBox66.Visible = false;
            textBox59.Visible = false;
            textBox60.Visible = false;
            textBox61.Visible = false;
            textBox67.Visible = false;
            textBox68.Visible = false;
            textBox69.Visible = false;
            textBox64.Visible = false;
            textBox70.Visible = false;
            textBox71.Visible = false;
            textBox72.Visible = false;
            textBox73.Visible = false;

            comboBox1.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox8.SelectedIndex = 2;
            comboBox7.SelectedIndex = 1;
            comboBox6.SelectedIndex = 2;
            comboBox5.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox3.SelectedIndex = 1;
            comboBox10.SelectedIndex = 1;
            comboBox11.SelectedIndex = 2;
            comboBox12.SelectedIndex = 2;
            comboBox13.SelectedIndex = 2;
            comboBox14.SelectedIndex = 2;
            comboBox15.SelectedIndex = 2;
            comboBox16.SelectedIndex = 2;
            comboBox17.SelectedIndex = 2;
            comboBox18.SelectedIndex = 2;
            comboBox2.SelectedIndex = 2;
            comboBox19.SelectedIndex = 2;
            comboBox20.SelectedIndex = 2;
            comboBox21.SelectedIndex = 2;
            comboBox22.SelectedIndex = 2;
            comboBox23.SelectedIndex = 3;
            comboBox24.SelectedIndex = 3;
            comboBox25.SelectedIndex = 3;
            comboBox26.SelectedIndex = 1;
            comboBox27.SelectedIndex = 1;
            comboBox28.SelectedIndex = 3;
            comboBox29.SelectedIndex = 2;
            comboBox30.SelectedIndex = 2;
            comboBox31.SelectedIndex = 2;
            comboBox32.SelectedIndex = 2;
            comboBox33.SelectedIndex = 2;
            comboBox34.SelectedIndex = 2;
            comboBox35.SelectedIndex = 2;
            comboBox36.SelectedIndex = 2;
            comboBox37.SelectedIndex = 2;
            comboBox38.SelectedIndex = 2;
            comboBox39.SelectedIndex = 2;
            comboBox40.SelectedIndex = 2;
            comboBox41.SelectedIndex = 2;
            comboBox42.SelectedIndex = 1;
            comboBox43.SelectedIndex = 2;
            comboBox44.SelectedIndex = 1;
            comboBox45.SelectedIndex = 2;
            comboBox46.SelectedIndex = 0;
            comboBox47.SelectedIndex = 0;
            comboBox48.SelectedIndex = 1;
            comboBox49.SelectedIndex = 2;
            comboBox50.SelectedIndex = 2;
            comboBox51.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox70.Text) * Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox71.Text)), 3));
                textBox3.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox72.Text) * Math.Pow(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox73.Text)), 3));
                //   textBox17.Text = textBox3.Text;
            }
            else MessageBox.Show("Необходимо ввести объем кода!");
        }
        double[] arg = new double[2];

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.SelectedIndex)
            {
                case 0:
                    arg[0] = 3.2;
                    arg[1] = 1.05;
                    textBox72.Text = "2,5";
                    textBox73.Text = "0,38";
                    break;
                case 1:
                    arg[0] = 3.0;
                    arg[1] = 1.12;
                    textBox72.Text = "2,5";
                    textBox73.Text = "0,35";
                    break;
                case 2:
                    arg[0] = 2.8;
                    arg[1] = 1.20;
                    textBox72.Text = "2,5";
                    textBox73.Text = "0,32";
                    break;
                default:
                    break;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.SelectedIndex)
            {
                case 0:
                    textBox19.Text = "0,75";
                    break;
                case 1:
                    textBox19.Text = "0,88";
                    break;
                case 2:
                    textBox19.Text = "1,00";
                    break;
                case 3:
                    textBox19.Text = "1,15";
                    break;
                case 4:
                    textBox19.Text = "1,40";
                    break;
                default:
                    break;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedIndex)
            {
                case 0:
                    textBox20.Text = "0,94";
                    break;
                case 1:
                    textBox20.Text = "1,00";
                    break;
                case 2:
                    textBox20.Text = "1,08";
                    break;
                case 3:
                    textBox20.Text = "1,16";
                    break;
                default:
                    break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    textBox21.Text = "0,70";
                    break;
                case 1:
                    textBox21.Text = "0,85";
                    break;
                case 2:
                    textBox21.Text = "1,00";
                    break;
                case 3:
                    textBox21.Text = "1,15";
                    break;
                case 4:
                    textBox21.Text = "1,30";
                    break;
                case 5:
                    textBox21.Text = "1,65";
                    break;
                default:
                    break;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    textBox22.Text = "1,00";
                    break;
                case 1:
                    textBox22.Text = "1,11";
                    break;
                case 2:
                    textBox22.Text = "1,30";
                    break;
                case 3:
                    textBox22.Text = "1,66";
                    break;
                default:
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    textBox23.Text = "1,00";
                    break;
                case 1:
                    textBox23.Text = "1,06";
                    break;
                case 2:
                    textBox23.Text = "1,21";
                    break;
                case 3:
                    textBox23.Text = "1,56";
                    break;
                default:
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    textBox24.Text = "0,87";
                    break;
                case 1:
                    textBox24.Text = "1,00";
                    break;
                case 2:
                    textBox24.Text = "1,15";
                    break;
                case 3:
                    textBox24.Text = "1,30";
                    break;
                default:
                    break;
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.SelectedIndex)
            {
                case 0:
                    textBox25.Text = "0,87";
                    break;
                case 1:
                    textBox25.Text = "1,00";
                    break;
                case 2:
                    textBox25.Text = "1,07";
                    break;
                case 3:
                    textBox25.Text = "1,15";
                    break;
                default:
                    break;
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox11.SelectedIndex)
            {
                case 0:
                    textBox26.Text = "1,46";
                    break;
                case 1:
                    textBox26.Text = "1,19";
                    break;
                case 2:
                    textBox26.Text = "1,00";
                    break;
                case 3:
                    textBox26.Text = "0,86";
                    break;
                case 4:
                    textBox26.Text = "0,71";
                    break;
                default:
                    break;
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox12.SelectedIndex)
            {
                case 0:
                    textBox27.Text = "1,29";
                    break;
                case 1:
                    textBox27.Text = "1,13";
                    break;
                case 2:
                    textBox27.Text = "1,00";
                    break;
                case 3:
                    textBox27.Text = "0,91";
                    break;
                case 4:
                    textBox27.Text = "0,82";
                    break;
                default:
                    break;
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox13.SelectedIndex)
            {
                case 0:
                    textBox28.Text = "1,42";
                    break;
                case 1:
                    textBox28.Text = "1,17";
                    break;
                case 2:
                    textBox28.Text = "1,00";
                    break;
                case 3:
                    textBox28.Text = "0,86";
                    break;
                case 4:
                    textBox28.Text = "0,70";
                    break;
                default:
                    break;
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox14.SelectedIndex)
            {
                case 0:
                    textBox29.Text = "1,21";
                    break;
                case 1:
                    textBox29.Text = "1,10";
                    break;
                case 2:
                    textBox29.Text = "1,00";
                    break;
                case 3:
                    textBox29.Text = "0,90";
                    break;
                default:
                    break;
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox15.SelectedIndex)
            {
                case 0:
                    textBox30.Text = "1,14";
                    break;
                case 1:
                    textBox30.Text = "1,07";
                    break;
                case 2:
                    textBox30.Text = "1,00";
                    break;
                case 3:
                    textBox30.Text = "0,95";
                    break;
                default:
                    break;
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox16.SelectedIndex)
            {
                case 0:
                    textBox31.Text = "1,24";
                    break;
                case 1:
                    textBox31.Text = "1,10";
                    break;
                case 2:
                    textBox31.Text = "1,00";
                    break;
                case 3:
                    textBox31.Text = "0,91";
                    break;
                case 4:
                    textBox31.Text = "0,82";
                    break;
                default:
                    break;
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox17.SelectedIndex)
            {
                case 0:
                    textBox32.Text = "1,24";
                    break;
                case 1:
                    textBox32.Text = "1,10";
                    break;
                case 2:
                    textBox32.Text = "1,00";
                    break;
                case 3:
                    textBox32.Text = "0,91";
                    break;
                case 4:
                    textBox32.Text = "0,83";
                    break;
                default:
                    break;
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox18.SelectedIndex)
            {
                case 0:
                    textBox35.Text = "1,23";
                    break;
                case 1:
                    textBox35.Text = "1,08";
                    break;
                case 2:
                    textBox35.Text = "1,00";
                    break;
                case 3:
                    textBox35.Text = "1,04";
                    break;
                case 4:
                    textBox35.Text = "1,10";
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                double[] arg1 = new double[15];
                double sum = 1;
                arg1[0] = Convert.ToDouble(textBox19.Text);
                arg1[1] = Convert.ToDouble(textBox20.Text);
                arg1[2] = Convert.ToDouble(textBox21.Text);
                arg1[3] = Convert.ToDouble(textBox22.Text);
                arg1[4] = Convert.ToDouble(textBox23.Text);
                arg1[5] = Convert.ToDouble(textBox24.Text);
                arg1[6] = Convert.ToDouble(textBox25.Text);
                arg1[7] = Convert.ToDouble(textBox26.Text);
                arg1[8] = Convert.ToDouble(textBox27.Text);
                arg1[9] = Convert.ToDouble(textBox28.Text);
                arg1[10] = Convert.ToDouble(textBox29.Text);
                arg1[11] = Convert.ToDouble(textBox30.Text);
                arg1[12] = Convert.ToDouble(textBox31.Text);
                arg1[13] = Convert.ToDouble(textBox32.Text);
                arg1[14] = Convert.ToDouble(textBox35.Text);

                for (int i = 0; i < 15; i++)
                {
                    sum *= arg1[i];
                }

                textBox18.Text = Convert.ToString(Math.Round(sum, 3));
                textBox5.Text = Convert.ToString(Math.Round(sum * arg[0] * Math.Pow(Convert.ToDouble(textBox4.Text), arg[1]), 3));
                textBox6.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox72.Text) * Math.Pow(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox73.Text)), 3));

            }
            else MessageBox.Show("Необходимо ввести объем кода!");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    textBox36.Text = "6,20";
                    break;
                case 1:
                    textBox36.Text = "4,96";
                    break;
                case 2:
                    textBox36.Text = "3,72";
                    break;
                case 3:
                    textBox36.Text = "2,48";
                    break;
                case 4:
                    textBox36.Text = "1,24";
                    break;
                case 5:
                    textBox36.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox19.SelectedIndex)
            {
                case 0:
                    textBox37.Text = "5,07";
                    break;
                case 1:
                    textBox37.Text = "4,05";
                    break;
                case 2:
                    textBox37.Text = "3,04";
                    break;
                case 3:
                    textBox37.Text = "2,03";
                    break;
                case 4:
                    textBox37.Text = "1,01";
                    break;
                case 5:
                    textBox37.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox20.SelectedIndex)
            {
                case 0:
                    textBox38.Text = "7,07";
                    break;
                case 1:
                    textBox38.Text = "5,65";
                    break;
                case 2:
                    textBox38.Text = "4,24";
                    break;
                case 3:
                    textBox38.Text = "2,83";
                    break;
                case 4:
                    textBox38.Text = "1,41";
                    break;
                case 5:
                    textBox38.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox21.SelectedIndex)
            {
                case 0:
                    textBox39.Text = "5,48";
                    break;
                case 1:
                    textBox39.Text = "4,38";
                    break;
                case 2:
                    textBox39.Text = "3,29";
                    break;
                case 3:
                    textBox39.Text = "2,19";
                    break;
                case 4:
                    textBox39.Text = "1,10";
                    break;
                case 5:
                    textBox39.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox22.SelectedIndex)
            {
                case 0:
                    textBox40.Text = "7,80";
                    break;
                case 1:
                    textBox40.Text = "6,24";
                    break;
                case 2:
                    textBox40.Text = "4,68";
                    break;
                case 3:
                    textBox40.Text = "3,12";
                    break;
                case 4:
                    textBox40.Text = "1,56";
                    break;
                case 5:
                    textBox40.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox23.SelectedIndex)
            {
                case 0:
                    textBox41.Text = "2,12";
                    break;
                case 1:
                    textBox41.Text = "1,62";
                    break;
                case 2:
                    textBox41.Text = "1,26";
                    break;
                case 3:
                    textBox41.Text = "1,00";
                    break;
                case 4:
                    textBox41.Text = "0,83";
                    break;
                case 5:
                    textBox41.Text = "0,63";
                    break;
                case 6:
                    textBox41.Text = "0,50";
                    break;
                default:
                    break;
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox24.SelectedIndex)
            {
                case 0:
                    textBox42.Text = "1,59";
                    break;
                case 1:
                    textBox42.Text = "1,33";
                    break;
                case 2:
                    textBox42.Text = "1,22";
                    break;
                case 3:
                    textBox42.Text = "1,00";
                    break;
                case 4:
                    textBox42.Text = "0,87";
                    break;
                case 5:
                    textBox42.Text = "0,74";
                    break;
                case 6:
                    textBox42.Text = "0,62";
                    break;
                default:
                    break;
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox25.SelectedIndex)
            {
                case 0:
                    textBox43.Text = "0,49";
                    break;
                case 1:
                    textBox43.Text = "0,60";
                    break;
                case 2:
                    textBox43.Text = "0,83";
                    break;
                case 3:
                    textBox43.Text = "1,00";
                    break;
                case 4:
                    textBox43.Text = "1,33";
                    break;
                case 5:
                    textBox43.Text = "1,91";
                    break;
                case 6:
                    textBox43.Text = "2,72";
                    break;
                default:
                    break;
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox26.SelectedIndex)
            {
                case 0:
                    textBox44.Text = "0,95";
                    break;
                case 1:
                    textBox44.Text = "1,00";
                    break;
                case 2:
                    textBox44.Text = "1,07";
                    break;
                case 3:
                    textBox44.Text = "1,15";
                    break;
                case 4:
                    textBox44.Text = "1,24";
                    break;
                default:
                    break;
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox27.SelectedIndex)
            {
                case 0:
                    textBox45.Text = "0,87";
                    break;
                case 1:
                    textBox45.Text = "1,00";
                    break;
                case 2:
                    textBox45.Text = "1,29";
                    break;
                case 3:
                    textBox45.Text = "1,81";
                    break;
                case 4:
                    textBox45.Text = "2,61";
                    break;
                default:
                    break;
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox28.SelectedIndex)
            {
                case 0:
                    textBox46.Text = "1,43";
                    break;
                case 1:
                    textBox46.Text = "1,30";
                    break;
                case 2:
                    textBox46.Text = "1,10";
                    break;
                case 3:
                    textBox46.Text = "1,00";
                    break;
                case 4:
                    textBox46.Text = "0,87";
                    break;
                case 5:
                    textBox46.Text = "0,73";
                    break;
                case 6:
                    textBox46.Text = "0,62";
                    break;
                default:
                    break;
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox29.SelectedIndex)
            {
                case 0:
                    textBox47.Text = "1,43";
                    break;
                case 1:
                    textBox47.Text = "1,14";
                    break;
                case 2:
                    textBox47.Text = "1,00";
                    break;
                case 3:
                    textBox47.Text = "1,00";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] mn = new double[7];
            double[] fact = new double[5];
            double sum_fact = 0, p_mn = 1, size, trud, time_dev, E;

            if (textBox8.Text != "")
            {
                size = Convert.ToDouble(textBox8.Text);

                mn[0] = Convert.ToDouble(textBox41.Text);
                mn[1] = Convert.ToDouble(textBox42.Text);
                mn[2] = Convert.ToDouble(textBox43.Text);
                mn[3] = Convert.ToDouble(textBox44.Text);
                mn[4] = Convert.ToDouble(textBox45.Text);
                mn[5] = Convert.ToDouble(textBox46.Text);
                mn[6] = Convert.ToDouble(textBox47.Text);

                fact[0] = Convert.ToDouble(textBox36.Text);
                fact[1] = Convert.ToDouble(textBox37.Text);
                fact[2] = Convert.ToDouble(textBox38.Text);
                fact[3] = Convert.ToDouble(textBox39.Text);
                fact[4] = Convert.ToDouble(textBox40.Text);

                for (int i = 0; i < 5; i++)
                {
                    sum_fact += fact[i];
                }

                for (int i = 0; i < 7; i++)
                {
                    p_mn *= mn[i];
                }

                E = 0.91 + (0.01 * sum_fact);

                textBox7.Text = Convert.ToString(Math.Round(sum_fact, 3));
                textBox9.Text = Convert.ToString(Math.Round(p_mn, 3));

                trud = p_mn * 2.94 * Math.Pow(size, E);
                time_dev = Convert.ToDouble(textBox47.Text) * 3.67 * Math.Pow(trud, 0.28 + 0.2 * (E - 0.91));

                textBox10.Text = Convert.ToString(Math.Round(trud, 3));
                textBox11.Text = Convert.ToString(Math.Round(time_dev, 3));
            }
            else MessageBox.Show("Необходимо ввести объем кода!");
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox30.SelectedIndex)
            {
                case 0:
                    textBox48.Text = "6,20";
                    break;
                case 1:
                    textBox48.Text = "4,96";
                    break;
                case 2:
                    textBox48.Text = "3,72";
                    break;
                case 3:
                    textBox48.Text = "2,48";
                    break;
                case 4:
                    textBox48.Text = "1,24";
                    break;
                case 5:
                    textBox48.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox31.SelectedIndex)
            {
                case 0:
                    textBox49.Text = "5,07";
                    break;
                case 1:
                    textBox49.Text = "4,05";
                    break;
                case 2:
                    textBox49.Text = "3,04";
                    break;
                case 3:
                    textBox49.Text = "2,03";
                    break;
                case 4:
                    textBox49.Text = "1,01";
                    break;
                case 5:
                    textBox49.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox32.SelectedIndex)
            {
                case 0:
                    textBox50.Text = "7,07";
                    break;
                case 1:
                    textBox50.Text = "5,65";
                    break;
                case 2:
                    textBox50.Text = "4,24";
                    break;
                case 3:
                    textBox50.Text = "2,83";
                    break;
                case 4:
                    textBox50.Text = "1,41";
                    break;
                case 5:
                    textBox50.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox33.SelectedIndex)
            {
                case 0:
                    textBox51.Text = "5,48";
                    break;
                case 1:
                    textBox51.Text = "4,38";
                    break;
                case 2:
                    textBox51.Text = "3,29";
                    break;
                case 3:
                    textBox51.Text = "2,19";
                    break;
                case 4:
                    textBox51.Text = "1,10";
                    break;
                case 5:
                    textBox51.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox34.SelectedIndex)
            {
                case 0:
                    textBox52.Text = "7,80";
                    break;
                case 1:
                    textBox52.Text = "6,24";
                    break;
                case 2:
                    textBox52.Text = "4,68";
                    break;
                case 3:
                    textBox52.Text = "3,12";
                    break;
                case 4:
                    textBox52.Text = "1,56";
                    break;
                case 5:
                    textBox52.Text = "0,00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox35.SelectedIndex)
            {
                case 0:
                    textBox53.Text = "1,42";
                    break;
                case 1:
                    textBox53.Text = "1,29";
                    break;
                case 2:
                    textBox53.Text = "1,00";
                    break;
                case 3:
                    textBox53.Text = "0,85";
                    break;
                case 4:
                    textBox53.Text = "0,71";
                    break;
                default:
                    break;
            }
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox36.SelectedIndex)
            {
                case 0:
                    textBox54.Text = "1,22";
                    break;
                case 1:
                    textBox54.Text = "1,10";
                    break;
                case 2:
                    textBox54.Text = "1,00";
                    break;
                case 3:
                    textBox54.Text = "0,88";
                    break;
                case 4:
                    textBox54.Text = "0,81";
                    break;
                default:
                    break;
            }
        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox37.SelectedIndex)
            {
                case 0:
                    textBox55.Text = "1,34";
                    break;
                case 1:
                    textBox55.Text = "1,15";
                    break;
                case 2:
                    textBox55.Text = "1,00";
                    break;
                case 3:
                    textBox55.Text = "0,88";
                    break;
                case 4:
                    textBox55.Text = "0,76";
                    break;
                default:
                    break;
            }
        }

        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox38.SelectedIndex)
            {
                case 0:
                    textBox56.Text = "1,29";
                    break;
                case 1:
                    textBox56.Text = "1,12";
                    break;
                case 2:
                    textBox56.Text = "1,00";
                    break;
                case 3:
                    textBox56.Text = "0,90";
                    break;
                case 4:
                    textBox56.Text = "0,81";
                    break;
                default:
                    break;
            }
        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox39.SelectedIndex)
            {
                case 0:
                    textBox57.Text = "1,19";
                    break;
                case 1:
                    textBox57.Text = "1,09";
                    break;
                case 2:
                    textBox57.Text = "1,00";
                    break;
                case 3:
                    textBox57.Text = "0,91";
                    break;
                case 4:
                    textBox57.Text = "0,85";
                    break;
                default:
                    break;
            }
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox40.SelectedIndex)
            {
                case 0:
                    textBox58.Text = "1,20";
                    break;
                case 1:
                    textBox58.Text = "1,09";
                    break;
                case 2:
                    textBox58.Text = "1,00";
                    break;
                case 3:
                    textBox58.Text = "0,91";
                    break;
                case 4:
                    textBox58.Text = "0,84";
                    break;
                default:
                    break;
            }
        }

        private void comboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox41.SelectedIndex)
            {
                case 0:
                    textBox62.Text = "0,84";
                    break;
                case 1:
                    textBox62.Text = "0,92";
                    break;
                case 2:
                    textBox62.Text = "1,00";
                    break;
                case 3:
                    textBox62.Text = "1,10";
                    break;
                case 4:
                    textBox62.Text = "1,26";
                    break;
                default:
                    break;
            }
        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox42.SelectedIndex)
            {
                case 0:
                    textBox63.Text = "0,23";
                    break;
                case 1:
                    textBox63.Text = "1,00";
                    break;
                case 2:
                    textBox63.Text = "1,14";
                    break;
                case 3:
                    textBox63.Text = "1,28";
                    break;
                default:
                    break;
            }
        }

        private void comboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox43.SelectedIndex)
            {
                case 0:
                    textBox64.Text = "0,73";
                    break;
                case 1:
                    textBox64.Text = "0,87";
                    break;
                case 2:
                    textBox64.Text = "1,00";
                    break;
                case 3:
                    textBox64.Text = "1,17";
                    break;
                case 4:
                    textBox64.Text = "1,34";
                    break;
                case 5:
                    textBox64.Text = "1,74";
                    break;
                default:
                    break;
            }
        }

        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox44.SelectedIndex)
            {
                case 0:
                    textBox65.Text = "0,95";
                    break;
                case 1:
                    textBox65.Text = "1,00";
                    break;
                case 2:
                    textBox65.Text = "1,07";
                    break;
                case 3:
                    textBox65.Text = "1,15";
                    break;
                case 4:
                    textBox65.Text = "1,24";
                    break;
                default:
                    break;
            }
        }

        private void comboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox45.SelectedIndex)
            {
                case 0:
                    textBox66.Text = "0,81";
                    break;
                case 1:
                    textBox66.Text = "0,91";
                    break;
                case 2:
                    textBox66.Text = "1,00";
                    break;
                case 3:
                    textBox66.Text = "1,11";
                    break;
                case 4:
                    textBox66.Text = "1,23";
                    break;
                default:
                    break;
            }
        }

        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox46.SelectedIndex)
            {
                case 0:
                    textBox59.Text = "1,00";
                    break;
                case 1:
                    textBox59.Text = "1,11";
                    break;
                case 2:
                    textBox59.Text = "1,29";
                    break;
                case 3:
                    textBox59.Text = "1,63";
                    break;
                default:
                    break;
            }
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox47.SelectedIndex)
            {
                case 0:
                    textBox60.Text = "1,00";
                    break;
                case 1:
                    textBox60.Text = "1,05";
                    break;
                case 2:
                    textBox60.Text = "1,17";
                    break;
                case 3:
                    textBox60.Text = "1,46";
                    break;
                default:
                    break;
            }
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox48.SelectedIndex)
            {
                case 0:
                    textBox61.Text = "0,87";
                    break;
                case 1:
                    textBox61.Text = "1,00";
                    break;
                case 2:
                    textBox61.Text = "1,15";
                    break;
                case 3:
                    textBox61.Text = "1,30";
                    break;
                default:
                    break;
            }
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox49.SelectedIndex)
            {
                case 0:
                    textBox67.Text = "1,17";
                    break;
                case 1:
                    textBox67.Text = "1,09";
                    break;
                case 2:
                    textBox67.Text = "1,00";
                    break;
                case 3:
                    textBox67.Text = "0,90";
                    break;
                case 4:
                    textBox67.Text = "0,78";
                    break;
                default:
                    break;
            }
        }

        private void comboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox50.SelectedIndex)
            {
                case 0:
                    textBox68.Text = "1,22";
                    break;
                case 1:
                    textBox68.Text = "1,09";
                    break;
                case 2:
                    textBox68.Text = "1,00";
                    break;
                case 3:
                    textBox68.Text = "0,93";
                    break;
                case 4:
                    textBox68.Text = "0,86";
                    break;
                case 5:
                    textBox68.Text = "0,80";
                    break;
                default:
                    break;
            }
        }

        private void comboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox51.SelectedIndex)
            {
                case 0:
                    textBox69.Text = "1,43";
                    break;
                case 1:
                    textBox69.Text = "1,14";
                    break;
                case 2:
                    textBox69.Text = "1,00";
                    break;
                case 3:
                    textBox69.Text = "1,00";
                    break;
                case 4:
                    textBox69.Text = "1,00";
                    break;
                default:
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double[] mn = new double[17];
            double[] fact = new double[5];
            double sum_fact = 0, p_mn = 1, size, trud, time_dev, E;
            if (textBox12.Text != "")
            {
                size = Convert.ToDouble(textBox12.Text);

                mn[0] = Convert.ToDouble(textBox53.Text);
                mn[1] = Convert.ToDouble(textBox54.Text);
                mn[2] = Convert.ToDouble(textBox55.Text);
                mn[3] = Convert.ToDouble(textBox56.Text);
                mn[4] = Convert.ToDouble(textBox57.Text);
                mn[5] = Convert.ToDouble(textBox58.Text);
                mn[6] = Convert.ToDouble(textBox62.Text);
                mn[7] = Convert.ToDouble(textBox63.Text);
                mn[8] = Convert.ToDouble(textBox64.Text);
                mn[9] = Convert.ToDouble(textBox65.Text);
                mn[10] = Convert.ToDouble(textBox66.Text);
                mn[11] = Convert.ToDouble(textBox59.Text);
                mn[12] = Convert.ToDouble(textBox60.Text);
                mn[13] = Convert.ToDouble(textBox61.Text);
                mn[14] = Convert.ToDouble(textBox67.Text);
                mn[15] = Convert.ToDouble(textBox68.Text);
                mn[16] = Convert.ToDouble(textBox69.Text);

                fact[0] = Convert.ToDouble(textBox48.Text);
                fact[1] = Convert.ToDouble(textBox49.Text);
                fact[2] = Convert.ToDouble(textBox50.Text);
                fact[3] = Convert.ToDouble(textBox51.Text);
                fact[4] = Convert.ToDouble(textBox52.Text);

                for (int i = 0; i < 5; i++)
                {
                    sum_fact += fact[i];
                }

                for (int i = 0; i < 7; i++)
                {
                    p_mn *= mn[i];
                }

                E = 0.91 + (0.01 * sum_fact);

                textBox17.Text = Convert.ToString(Math.Round(sum_fact, 3));
                textBox16.Text = Convert.ToString(Math.Round(p_mn, 3));

                trud = p_mn * 2.45 * Math.Pow(size, E);
                time_dev = Convert.ToDouble(textBox69.Text) * 3.67 * Math.Pow(trud, 0.28 + 0.2 * (E - 0.91));

                textBox14.Text = Convert.ToString(Math.Round(trud, 3));
                textBox15.Text = Convert.ToString(Math.Round(time_dev, 3));
            }
            else MessageBox.Show("Необходимо ввести объем кода!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("COCOMO.pdf");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label83_Click(object sender, EventArgs e)
        {

        }
    }





     


















        }


























       