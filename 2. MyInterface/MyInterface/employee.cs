using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInterface
{
    enum Job
    {
        Manager,Engineer,Tester
    }
    class Clsemployee
    {
        public string Empname { get; set; }
        public DateTime Hiredate { get; set; }
        public decimal Salary { get; set; }
        public Job Jobtitle { get; set; }
        public override string ToString()
        {
            return this.Empname;
        }
        public int CompareTo(Clsemployee other)
        {
            if (this.Salary < other.Salary)
            {
                return -1;
            }
            else if (this.Salary > other.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
