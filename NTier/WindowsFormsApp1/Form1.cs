using Banking;
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
    public partial class Form1  : MyOOP.FrmLogo
    {
        public Form1()
        {
            InitializeComponent();

            this.Title = " ~xxx";
            this.Color2 = Color.Red;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banking.ClsBanking a = new Banking.ClsBanking();
            MessageBox.Show("a " + a.Deposit(1000));

            ClsSpecialBanking b = new ClsSpecialBanking();
            MessageBox.Show("b " + b.Deposit(1000));


        }
    }
}
