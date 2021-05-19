using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {      
            InitializeComponent();
            numericUpDown1.Text = "1";
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            
            if (rdoWoman.Checked || rdoMan.Checked && checkBox1.Checked)
            {
                double value = (double)numericUpDown1.Value - 100;
                label3.Text = Convert.ToString(value);
            }

            if (rdoMan.Checked && checkBox2.Checked)
            {
                double value = ((double)numericUpDown1.Value - 100) * 0.9;
                label3.Text = Convert.ToString(value);
            }

            if (rdoWoman.Checked && checkBox2.Checked)
            {
                double value = ((double)numericUpDown1.Value - 100) * 0.85;
                label3.Text = Convert.ToString(value);
            }
        }
    }
}
