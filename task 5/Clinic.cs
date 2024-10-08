﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Clinic
    {
        public string ClinicName { get; set; }
        private List<Pet> Rooms;
        private int centerRoom;

        public Clinic() { }

        public Clinic(string clinicName, int roomAmount)
        {
            ClinicName = clinicName;
            if (roomAmount % 2 == 0) throw new ArgumentException("Rooms amount, cannot be even");
            else 
            {
                centerRoom = roomAmount / 2;
                Rooms = new List<Pet>(new Pet[roomAmount]);
            }
        }

        public bool AddPet(Pet pet)
        {
            int isFree = 0;
            for(int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i] == null) isFree++;
            }

            if (isFree > 0)
            {
                if (Rooms[centerRoom] == null)
                {
                    Rooms[centerRoom] = pet;
                    return true;
                }
                if (Rooms[centerRoom - 1] == null)
                {
                    Rooms[centerRoom - 1] = pet;
                    return true;
                }
                if (Rooms[centerRoom + 1] == null)
                {
                    Rooms[centerRoom + 1] = pet;
                    return true;
                }

                for (int i = 0; i < centerRoom - 1; i++)
                {
                    if (Rooms[i] == null)
                    {
                        Rooms[i] = pet;
                        return true;
                    }
                }

                for (int i = centerRoom + 1; i < Rooms.Count; i++)
                {
                    if (Rooms[i] == null)
                    {
                        Rooms[i] = pet;
                        return true;
                    }
                }
            }
            return false; 
        }

        public bool ReleasePet()
        {
            for(int i = centerRoom; i < Rooms.Count; i++)
            {
                if (Rooms[i] != null)
                {
                    Rooms[i] = null;
                    return true;
                }
            }

            for(int i = 0; i < centerRoom; i++)
            {
                if (Rooms[i] != null)
                {
                    Rooms[i] = null;
                    return true;
                }
            }


            return false;
        }

        public bool HasEmptyRooms()
        {
            for(int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i] == null) return true;
            }
            return false;
        }

        public void Print()
        {
            int counter = 0;
            foreach (Pet pet in Rooms) 
            {
                counter++;
                Console.WriteLine(pet);
            }
            if (counter == 0) Console.WriteLine("All rooms are empty!!!");
        }

        public void PrintRoom(int index)
        {
            if (Rooms[index] != null) Console.WriteLine(Rooms[index]);
            else Console.WriteLine("Room empty!");
        }
    }
}