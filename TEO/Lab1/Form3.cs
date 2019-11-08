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
    public partial class Form3 : Form
    {

        static public TextBox m_textBox;

        public Form3(Form2 form)
        {
           
            m_textBox = textBoxCP;
            InitializeComponent();
        }
    }
}
