using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Staff : Person
    {
        public string School { set; get; }
        public double Pay { set; get; }

        public Staff(){}
        public Staff(string school,double pay, string names,string addresss) 
            : base(names, addresss)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return base.ToString() +" "+ School + " "+ Pay;
        }


    }
}
