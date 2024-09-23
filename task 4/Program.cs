using System;
using task_4;

class Task
{
    static void Main()
    {
        Console.Write("Enter amount of persons = ");
        int size = int.Parse(Console.ReadLine());
        Line();

        List<Person> nameComparor = new List<Person>();
        List<Person> ageComparor = new List<Person>();

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter {i + 1} person = ");
            string[] enteredInformation = Console.ReadLine().Split();

            string name = enteredInformation[0];
            int age = int.Parse(enteredInformation[1]);
            Person person = new Person(name, age);

            nameComparor.Add(person);
            ageComparor.Add(person);
            Line();
        }

        nameComparor.Sort(new NameComparor());
        ageComparor.Sort(new AgeComparor());

        for (int i = 0; i < nameComparor.Count; i++)
        {
            Console.WriteLine(nameComparor[i]);
        }

        Line();
        for (int i = 0; i < ageComparor.Count; i++)
        {
            Console.WriteLine(ageComparor[i]);
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}