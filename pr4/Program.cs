using System;
using System.Net.Cache;
using System.Security.Policy;
using System.Xml.Linq;

namespace pr4
{
    internal class Program
    {
        class People
        {
            private string name;
            private int money;

            public string Name
            {
                get { return name; }
                set 
                {
                    if (value != " " || value != "")
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

            public int Money
            {
                get { return money; }
                set 
                {
                    if (value >= 0)
                    {
                        money = value;
                    }
                    else
                    {
                        Console.WriteLine("Money cannot be negative");
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }
        }

        class Products
        {
            private string namep;
            private int price;

            public string Namep
            {
                get { return namep; }
                set
                {
                    if (value != " " || value != "")
                    {
                        namep = value;
                    }
                    else
                    {
                        Console.WriteLine("Name cannot be empty");
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }

            public int Price
            {
                get { return price; }
                set
                {
                    if (value > 0)
                    {
                        price = value;
                    }
                    else
                    {
                        Console.WriteLine("Money cannot be negative");
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }

        }
        static void Main()
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            People[] people = new People[n];
            Products[] products = new Products[n];
            for (int i=0;i<n;i++)
            {
                people[i] = new People();
                products[i] = new Products();
            }
            for (int i=0;i<n;i++)
            {
                Console.Write("Name: ");
                people[i].Name = Console.ReadLine();
                Console.Write($"{people[i].Name} money: ");
                people[i].Money = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("Name of product: ");
                products[i].Namep = Console.ReadLine();
                Console.Write($"{products[i].Namep} Price: ");
                products[i].Price = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
