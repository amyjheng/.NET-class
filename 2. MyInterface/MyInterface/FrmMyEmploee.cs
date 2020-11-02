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
    public partial class FrmMyEmploee : Form
    {
        public FrmMyEmploee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Clsemployee> emplist = new List<Clsemployee>
            {
                new Clsemployee{Empname="Alice",Hiredate=DateTime.Now,Jobtitle=Job.Engineer,Salary=45000},
                new Clsemployee{Empname="Bacon",Hiredate=DateTime.Now.AddDays(-5),Jobtitle=Job.Manager,Salary=55000},
                new Clsemployee{Empname="Cankan",Hiredate=DateTime.Now.AddDays(-10),Jobtitle=Job.Tester,Salary=50000},
                new Clsemployee{Empname="Darron",Hiredate=DateTime.Now.AddDays(-15),Jobtitle=Job.Engineer,Salary=45000},
            };
            //emplist.Sort;
            //int[] nums = { 22, 44, 1 };
            //Array.Sort(nums);
            this.dataGridView1.DataSource = emplist;
            this.listBox1.DataSource = emplist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clsemployee a = new Clsemployee { Empname = "Alice", Hiredate = DateTime.Now, Jobtitle = Job.Engineer, Salary = 45000 };
            Clsemployee b = new Clsemployee { Empname = "Bacon", Hiredate = DateTime.Now.AddDays(-5), Jobtitle = Job.Manager, Salary = 55000 };

            int result = a.CompareTo(b);

            if (result < 0)
            {
                MessageBox.Show("a薪水小於b");
            }
            else if (result > 0)
            {
                MessageBox.Show("a薪水大於b");
            }
            else
            {
                MessageBox.Show("a薪水等於b");
            }
        }
    }
}
