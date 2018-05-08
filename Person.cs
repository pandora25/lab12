using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Person
    {
        public string Name
        { set; get; }
        public string Addresss
        { set; get; }

        public Person() {  }
        public Person(string names, string addresss)
        {
            Name = names;
            Addresss = addresss;
        }

        public override string ToString()
        {
            return Name + " " + Addresss;
        }
    }
}
