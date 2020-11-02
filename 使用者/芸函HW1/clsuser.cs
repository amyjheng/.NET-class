using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 芸函HW1
{
    public class clsMember
    {
        public int MemberID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public static int counter = 4;
    }
   

    public enum MembershipStatus
    {
        repeat,
        newuser
    }

    public class clsMemberShip:clsMember
    {
        private static List<clsMember> MemberList = new List<clsMember>
        {
            new clsMember{MemberID=1,UserName="John",PassWord="123456"},
            new clsMember{MemberID=2,UserName="Jack",PassWord="785642"},
            new clsMember{MemberID=3,UserName="Mary",PassWord="abc123"}
        };

        public static MembershipStatus CreateUser(string username, string password)
        {
            foreach (clsMember items in MemberList)
            {
                if (username == items.UserName)
                {
                    return MembershipStatus.repeat;
                }
            }
            return MembershipStatus.newuser;
        }

        public void Create(string username, string password)
        {
            switch (CreateUser(username, password))
            {
                case MembershipStatus.newuser:
                    MemberList.Add(new clsMember
                    {
                        MemberID = clsMember.counter,
                        UserName = username,
                        PassWord = password
                    });
                    clsMember.counter++;
                    MessageBox.Show("建立帳號成功!");
                    break;
                case MembershipStatus.repeat:
                    MessageBox.Show("此名稱已被註冊!");
                    break;
            }
        }
        public static void deleteAllMember()
        {
            MemberList.RemoveRange(0, MemberList.Count);
        }
        public static bool ValidateUser(string username, string password)
        {
            foreach (clsMember items in MemberList)
            {
                if (username == items.UserName && password == items.PassWord)
                {
                    return true;
                }
            }
            return false;
        }

        public void Validate(string username, string password)
        {
            if (ValidateUser(username, password))
            {
                MessageBox.Show("成功!");
            }
            else
            {
                MessageBox.Show("輸入名稱或密碼有誤!");
            }
        }

        public static List<clsMember> GetUserList()
        {
            return MemberList;
        }

        public static void Delete(string account, string password)
        {
            foreach (clsMember m in clsMemberShip.GetUserList())
            {
                if (m.UserName == account && m.PassWord == password)
                {
                    MemberList.RemoveAt(GetUserList().IndexOf(m));
                    return;
                }
            };
        }
    }
}