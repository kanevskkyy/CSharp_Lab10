using System;
using task_3;

class Task
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        while (true)
        {
            Console.Write("Enter = ");
            string[] enteredInformation = Console.ReadLine().Split();
            if (enteredInformation[0].ToLower() == "end") break;
           
            people.Add(new Person(enteredInformation[0], int.Parse(enteredInformation[1]), enteredInformation[2]));
            Line();
        }
        Line();
        Console.Write("Now, enter index of person = ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int equal = 0, notEqual = 0;
        Person targetPerson = people[index];

        for(int i = 0; i < people.Count; i++)
        {
            if (targetPerson.CompareTo(people[i]) == 0) equal++;
            else notEqual++;
        }

        Line();
        if (equal == 1) Console.WriteLine("No matches!");
        else Console.WriteLine($"Result :\nEqual = {equal}\nNot equal = {notEqual}\nTotal people = {people.Count}");

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}