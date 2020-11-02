using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyEvents_CSharp;

namespace MyEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         this.buttonX.Click+=new EventHandler(aaa);
            this.buttonX.Click += delegate
             {
                 MessageBox.Show("匿名方法");
             };
        }
        

        private void buttonX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button X");
        }
        private void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("AAAAAAA");
        }
    }
}
