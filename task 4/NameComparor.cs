using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class NameComparor : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);
            
            if (result == 0) result = string.Compare(firstPerson.Name.ToLower()[0].ToString(), secondPerson.Name.ToLower()[0].ToString());

            return result;
        }
    }
}
