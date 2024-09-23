using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class ListyIterator<T>
    {
        private List<T> elements;
        private int index;
        public ListyIterator()
        {
             elements = new List<T>();
             index = 0;
        }

        public void AddElement(T element)
        {
            elements.Add(element);
        }
        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
             return index < elements.Count - 1;
        }

        public void Print()
        {
            if (elements.Count == 0)
            {
                 throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(elements[index]);
        }
    }
}
