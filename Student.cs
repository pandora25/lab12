using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { set; get; }
        public double Fee { set; get; }

        public Student(){}
        //string name,string address
        public Student(string programs, int years,
            double fees, string n, string a):base(n,a)
        {
            Program = programs;
            Year = years;
            Fee = fees;
        }

        public override string ToString()
        {
            return base.ToString() + Program + " "+ Year+ " "+ Fee;
        }



    }
}
