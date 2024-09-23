using System;
using task_2;
using System.Collections.Generic;

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

            if (enteredInformation[0].ToLower() == "print") listyIterator.Print();
            if (enteredInformation[0].ToLower() == "printall") listyIterator.PrintAll();

            Line();
        }
    }

    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}