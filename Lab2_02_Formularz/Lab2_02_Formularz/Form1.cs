using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_02_Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            float size;
            if (rduSmall.Checked == true)
            {
                size = textBox1.Font.Size;
                size = 10;
                textBox1.Font = new Font(textBox1.Font.Name, size);
            }
            if (rduBig.Checked == true)
            {
                size = textBox1.Font.Size;
                size = 13;
                textBox1.Font = new Font(textBox1.Font.Name, size);
            }
            if (rduVeryBig.Checked == true)
            {
                size = textBox1.Font.Size;
                size = 17;
                textBox1.Font = new Font(textBox1.Font.Name, size);
            }
            if(checkBox1pogrubienie.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (pochylenie.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (checkBox3podkreślenie.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);           
            }
            if (rduRed.Checked==true)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (rduBlue.Checked == true)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if (rduOrange.Checked == true)
            {
                textBox1.ForeColor = Color.Orange;
            }

        }
    }
}
