using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> everything = new List<Person>();
            everything.Add(new Person("Mike", "Google"));
            everything.Add(new Student("c# ", 1, 12, " google", "Facebook"));
            everything.Add(new Staff("GC",7250,"miky","woodwaord"));

            foreach (Person item in everything)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
