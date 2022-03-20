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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalRadioButton.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }
    }
}
