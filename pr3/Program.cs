using System;
using System.Net;

namespace p1
{
    internal class Program
    {
        class Chiken
        {

            private int age;
            private string name;
            public Chiken(int age,string name)
            {
                this.age = age;
                this.name = name;
            }
            private bool Check1()
            {
                if (this.age <= 0 || this.age>15)
                {
                    return false;
                }
                else
                {
                    return true;
                }   
            }
            private bool Check2()
            {
                if (this.name == " " || this.name == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public int cw()
            {
                bool check1 = Check1(),check2=Check2();
                if (check1 == false)
                {
                    Console.WriteLine("Age should be between 0 and 15.");
                }
                if (check2 == false)
                {
                    Console.WriteLine("Name cannot be empty.");
                }
                if (check1 == true && check2 == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Chiken a=new Chiken(age,name);
            int res = a.cw();
            if (res == 1)
            {
                Console.WriteLine($"Chiken {name} (age {age}) can produce {res} eggs per day.");
            }
        }
    }
}
