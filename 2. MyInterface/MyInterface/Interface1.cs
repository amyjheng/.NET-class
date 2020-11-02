using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyInterface
{
    interface IToy
    {
        void makingnoise();
    }

    class clsdog : IToy
    {
        public void makingnoise()
        {
            Debug.WriteLine("bark");
        }
    }
    class clscat : IToy
    {
        public void makingnoise()
        {
            Debug.WriteLine("meow");
        }
    }
    interface I1
    {
        void Test1();
    }
    interface I2
    {
        void Tset2();
    }
    class Class1 : Object, I1, I2,IDisposable
    {
        public void Dispose()
        {
            FinalImportantCode();
        }
        public void FinalImportantCode()
        {

        }
        public void Test1()
        {
        }
        public void Test2()
        {
        }

        public void Tset2()
        {
            throw new NotImplementedException();
        }
    }
}

