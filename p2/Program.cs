using System;
using System.Runtime.CompilerServices;

namespace p1
{
    internal class Program
    {
        class math
        {
            
            public float l, w, h;
            public math(float l, float w, float h)
            {
                this.l = l;
                this.w = w;
                this.h = h;
            }
           
            private bool Check()
            {
                if (this.l>0 && this.w>0 && this.h>0)
                {
                     return true;
                }
                else
                {
                     return false;

                }
            }
            public void res()
            {

                bool check = Check();
                if (check==true)
                {
                    Console.WriteLine((2 * this.l * this.w) + (2 * this.l * this.h) + (2 * this.h * this.w));
                    Console.WriteLine((2 * this.l * this.h) + (2 * this.w * this.h));
                    Console.WriteLine(this.l * this.w * this.h);
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
        }
        static void Main()
        {
            float l, w, h;
            l = Convert.ToSingle(Console.ReadLine());
            w = Convert.ToSingle(Console.ReadLine());
            h = Convert.ToSingle(Console.ReadLine());
            math a= new math(l,w,h);
            a.res();
        }
    }
}
