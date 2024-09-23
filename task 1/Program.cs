using System;

class ListyIterator<T>
{
    private List<T> elements = new List<T>();
    private int index = -1;

    public bool Move()
    {
        if (this.HasNext())
        {
            index++;
            return true;
        }
        else return false;
    }

    public bool HasNext() 
    {
        return index < elements.Count;
    }

    public void Print()
    {
        if (elements.Count == 0) throw new InvalidOperationException("Invalid Operation!");
        if (index < 0 || index >= elements.Count)  throw new InvalidOperationException("Invalid Operation!");

        Console.WriteLine(elements[index]);
    }
}


class Task
{
    static void Main()
    {

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}