using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyInterface
{
    public partial class FrmTestInterface : Form
    {
        public FrmTestInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsdog d = new clsdog();
            d.makingnoise();

            IToy I;
            I = d;
            I.makingnoise();

            clscat c = new clscat();
            c.makingnoise();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1 x = new Class1();
            x.Test1();
            x.Test2();
            x.Dispose();
            x = null;
        }
    }
}
