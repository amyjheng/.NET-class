using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 里程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            txtgaloon.Text = "50";
            txtfuel.Text = "20";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Car c1 = new Car(txtfuel.Text, txtgaloon.Text);
                labcount.Text = "您的交通航程為: " + " \n" + c1.Cal();
            }
            else
            {
                if (checkBox1.Checked)
                {
                    sailboat s1 = new sailboat(txtfuel.Text, txtgaloon.Text);
                    labcount.Text = "您的交通航程為: " +" \n" + s1.Cal();
                }
                else
                {
                    Boat b1 = new Boat(txtfuel.Text, txtgaloon.Text);
                    labcount.Text = "您的交通航程為: "+"\n"+ b1.Cal();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
