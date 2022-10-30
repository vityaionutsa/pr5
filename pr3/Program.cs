using System;
using System.Net;

namespace p1
{
    internal class Program
    {
        class Chiken
        {

            private int age, egg;
            private string name;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0 || value <= 15)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Age should be between 0 and 15");
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (value == "" || value == " ")
                    {
                        name = value;
                    }
                    else
                    {
                        Console.WriteLine("Name cannot be empty");
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }

            public int Egg
            {
                get { return egg; }
                set { egg = value; }
            }

        }
        static void Main()
        {
            Chiken chiken = new Chiken();
            Console.Write("Name: ");
            chiken.Name = Console.ReadLine();
            Console.Write("Age: ");
            chiken.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Chiken {chiken.Name} (age {chiken.Age}) can produce 1 eggs per day.");
        }
    }
}
