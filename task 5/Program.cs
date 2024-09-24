using System;
using task_5;

class Task
{
    static void Main()
    {
        List<Clinic> clinics = new List<Clinic>();
        List<Pet> pets = new List<Pet>();
        Console.Write("Enter amount of commands = ");
        int commandAmount = int.Parse(Console.ReadLine());
        Line();

        for (int i = 0; i < commandAmount; i++)
        {
            Console.Write("Enter command = ");
            string[] enteredInformation = Console.ReadLine().Split();

            //function create Pet
            if (enteredInformation[0].ToLower() == "create" && enteredInformation[1].ToLower() == "pet")
            {
                Pet pet = new Pet(enteredInformation[2], int.Parse(enteredInformation[3]), enteredInformation[4]);
                pets.Add(pet);
                Console.WriteLine("True");
            }

            //function create Clinic
            if (enteredInformation[0].ToLower() == "create" && enteredInformation[1].ToLower() == "clinic")
            {
                try
                {
                    Clinic clinic = new Clinic(enteredInformation[2], int.Parse(enteredInformation[3]));
                    clinics.Add(clinic);
                    Console.WriteLine("True");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //function addPet
            if (enteredInformation[0].ToLower() == "add")
            {
                Pet pet = new Pet();
                Clinic clinic = new Clinic();
                for (int j = 0; j < pets.Count; j++)
                {
                    if (enteredInformation[1] == pets[j].Name) pet = pets[j];
                }

                for (int j = 0; j < clinics.Count; j++)
                {
                    if (enteredInformation[2] == clinics[j].ClinicName)
                    {
                        bool result = clinics[j].AddPet(pet);
                        if (result) Console.WriteLine("True");
                        else Console.WriteLine("False");
                        break;
                    }
                }
            }

            //function Release
            if (enteredInformation[0].ToLower() == "release")
            {
                for (int j = 0; j < clinics.Count; j++)
                {
                    if (enteredInformation[1] == clinics[j].ClinicName)
                    {
                        bool result = clinics[j].ReleasePet();
                        if (result) Console.WriteLine("True");
                        else Console.WriteLine("False");
                        break;
                    }
                }
            }

            //function HasEmptyRooms
            if (enteredInformation[0].ToLower() == "hasemptyrooms")
            {
                for (int j = 0; j < clinics.Count; j++)
                {
                    if (enteredInformation[1] == clinics[j].ClinicName)
                    {
                        bool result = clinics[j].HasEmptyRooms();
                        if (result) Console.WriteLine("True");
                        else Console.WriteLine("False");
                        break;
                    }
                }
            }

            //function Print
            if (enteredInformation[0].ToLower() == "print" && enteredInformation.Length == 2)
            {
                for (int j = 0; j < clinics.Count; j++)
                {
                    if (enteredInformation[1] == clinics[j].ClinicName)
                    {
                        clinics[j].Print();
                        break;
                    }
                }
            }

            //function PrintRoom
            if (enteredInformation[0].ToLower() == "print" && enteredInformation.Length == 3)
            {
                for (int j = 0; j < clinics.Count; j++)
                {
                    if (enteredInformation[1] == clinics[j].ClinicName)
                    {
                        clinics[j].PrintRoom(int.Parse(enteredInformation[2]));
                        break;
                    }
                }
            }

            Line();
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}