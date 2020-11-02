using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class ClsSpecialBanking  : ClsBanking
    {

        public void M1()
        {

        }

        public override string ToString()
        {
            return "ClsSpeical Banking ..." + this.m_Balance;
        }

        public sealed override decimal Deposit(decimal money)
        {
            // return base.Deposit(money);

            this.m_Balance += money - 100;
            return this.m_Balance;
        }

        //overloads
        public void Test(string a, string b)
        {

        }
//        嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//警告  CS0108	'ClsSpecialBanking.Test(int, int)' 會隱藏繼承的成員 'ClsBanking.Test(int, int)'。若本意即為要隱藏，請使用 new 關鍵字。	MyOOP C:\Shared\C#進階\Solution\1. MyOOP\MyOOP\ClsSpecialBanking.cs	35	使用中

        public new void Test(int i, int j)
        {

        }
    }

    class ClsSpecialSpecialBanking:ClsSpecialBanking
    {
        //public override decimal Deposit(decimal money)
        //{
        //    -200
        //    return base.Deposit(money);
        //}

        //override 
    }
}
