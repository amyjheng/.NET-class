using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 芸函HW1
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            
            this.dataGridView1.DataSource = null;
            //this.dataGridView1.DataSource = 
        }
        clsMemberShip x = new clsMemberShip();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool booID = IsIDCorrect(txtname.Text);
            bool booPW = IsStrongPassword(txtpwd.Text);
            clsMemberShip createuser = new clsMemberShip();
            createuser.Create(this.txtname.Text, this.txtpwd.Text);

            
            dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = clsMemberShip.GetUserList();
        }
        bool IsStrongPassword(string pw)
        {
            bool result = Regex.IsMatch(pw, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
            return result;
        }
        bool IsIDCorrect(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }

        bool flag = true;
        private void button1_Click(object sender, EventArgs e)
        {
            clsMemberShip validateuser = new clsMemberShip();
            validateuser.Validate(this.txtname.Text, this.txtpwd.Text);
        }

        

        private void btnmemberlist_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clsMemberShip.GetUserList();
        }

        

       

        private void btnindex_Click(object sender, EventArgs e)
        {

            //clsMemberShip ms = new clsMemberShip();
            //int result;
            //try
            //{
            //    if (int.TryParse(txtselect.Text, out result))
            //    {
            //        if ((ms[int.Parse(txtselect.Text)].ToString()) != null)
            //            this.label4.Text = ms[int.Parse(txtselect.Text)].ToString();
            //    }
            //    else
            //        MessageBox.Show("ID為數字，請輸入數字格式");
            //}
            //catch (System.NullReferenceException ex) { MessageBox.Show("此ID未加入會員，或是已被刪除"); }
            //;
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = 
            //clsMemberShip mbs2 = new clsMemberShip();
            //int result;
            //bool isparse = int.TryParse(txtselect.Text, out result);
            //if (isparse)
            //{
            //    //if (result <= MemberShip.GetUserList().Count )
            //    try
            //    {
            //        MessageBox.Show("你的ID是 : " + result + "\n"
            //        + "使用者名稱 : " + mbs2{ result - 1}.UserName + "\n"
            //        + "密碼 : " + mbs2[result - 1].Password, "Tips"
            //        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Tips"
            //        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
            //else
            //{

            //    if (mbs2[txtselect.Text].MemberID < 0)
            //    {
            //        MessageBox.Show("沒有符合的資料", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        MessageBox.Show("你的ID是 : " + mbs2[txtselect.Text].MemberID + "\n"
            //        + "使用者名稱 : " + mbs2[txtselect.Text].UserName + "\n"
            //        + "密碼 : " + mbs2[txtselect.Text].Password, "Tips"
            //     , MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsMemberShip.deleteAllMember();
            this.dataGridView1.DataSource = null;
        }
    }
    }

