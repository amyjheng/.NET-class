using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyEvents
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            foreach (Control x in this.Controls)
            {
                x.Click += X_Click;
            }
        }
        bool Flag = true;
        private void X_Click(object sender,EventArgs e)
        {
            if (Flag == true)
            {
                ((Button)sender).Text = "X";

            }
            else
            {
                ((Button)sender).Text = "O";
            }
            Flag = !Flag;
        }
    }
}
