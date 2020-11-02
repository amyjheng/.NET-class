using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banking
{
    public class ClsBanking : Object
    {
        //建構子方法
        public ClsBanking()
        {
            //初始化物件
            this.m_Balance = 0;
        }

        //建構子方法
        public ClsBanking(decimal money)
        { 
            //初始化物件
            this.m_Balance = money;
        }

        //建構子方法
        public ClsBanking(int p2, int p3)
        {
            //初始化物件
          
           this.P2 = p2;
           this.P3 = p3;
           
        }
        //解構子方法
        ~ClsBanking()
        {
            Debug.WriteLine("~ClsBanking");
           
        }

        private static double m_InterestRate = 3.5;
        public static double InterestRate
        {
            get
            {
                //logic........
                return m_InterestRate;
            }
           
        }

        // class var. /  Field
        //internal decimal Balance = 1;


        //property Binding

        protected decimal m_Balance;
        public decimal Balance
        {
            get
            {
                //get logic .....
                return m_Balance;
            }
            set
            {
                //set logic .....
                if (value > 0)
                {
                    m_Balance = value;
                }
            }
        }

        private int m_P1=666;

       
        //Get Only
      
        public int P1
        {
            get
            {
                //...
                return m_P1;
            }
            //set
            //{
            //    //....
            //    m_P1 = value;
            }

        //Set Only Property
        //Password
        public int P2
        {
            set
            {
                //value
            }
        }

        //C# 2.0 get set 不同存取修飾子
        public int P3
        {
            get
            {
                return 999;
            }
            private set
            {

            }
        }

        //C# 3.0
        //C# 3.0 Auto Property 自動實作屬性
        public int P4 { get; set; }

        public int Field4;

        private int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int this[int index]
        {
            get
            {
                if (index <0 || index > nums.Length-1)
                {
                    throw new Exception("Index out of range ......");
                }
                return nums[index];
            }
            //set
            //{

            //}
        }

        public int this[string name]
        {
            get
            {
                int index = int.Parse( name);

                if (index < 0 || index > nums.Length - 1)
                {
                    throw new Exception("Index out of range ......");
                }
                return nums[index];
            }
            //set
            //{

            //}
        }
        public int Field1 = 999;
        public int Field2 = 666;


        public void Test()
        {
            int a, b;
            A();
            B();
        }
        public void Test(int i, int j)
        {

        }
        public void Test(string s)
        {

        }
        public void Test(int a, int b, int c)
        {

        }
        private void A()
        {

        }
        private void B()
        {

        }
        //


        public override string ToString()
        {
            return "ClsBanking..." + this.m_Balance;
        }

        public virtual decimal Deposit(decimal money)
        {
            this.m_Balance += money;
            return this.m_Balance;
        }

        public virtual decimal Withdraw(decimal money)
        {
            if (this.m_Balance - money <0)
            {
                //Fire Event ...
                throw new Exception("餘額不足...");
            }
            this.m_Balance -= money;
            return this.m_Balance;
        }

        public int Property
        {
            get => default(int);
            set
            {
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}

