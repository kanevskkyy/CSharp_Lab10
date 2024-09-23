using System;
using System.Collections.Generic;

class ListyIterator<T>
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

class Task
{
    static void Main()
    {
        ListyIterator<string> listyIterator = new ListyIterator<string>();
        while (true)
        {
            Console.Write("Enter information = ");
            string[] enteredInformation = Console.ReadLine().Split();

            if (enteredInformation[0].ToLower() == "end") break;

            if (enteredInformation[0].ToLower() == "create")
            {
                for (int i = 1; i < enteredInformation.Length; i++)
                {
                    listyIterator.AddElement(enteredInformation[i]);
                }
            }

            if (enteredInformation[0].ToLower() == "move")
            {
                bool result = listyIterator.Move();
                if (result) Console.WriteLine("True");
                else Console.WriteLine("False");
            }

            if (enteredInformation[0].ToLower() == "hasnext")
            {
                bool result = listyIterator.HasNext();
                if (result) Console.WriteLine("True");
                else Console.WriteLine("False");
            }

            if (enteredInformation[0].ToLower() == "print")  listyIterator.Print();

            Line();
        }
    }

    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}