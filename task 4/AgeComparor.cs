using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class AgeComparor : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            return firstPerson.Age.CompareTo(secondPerson.Age);
        }
    }
}
