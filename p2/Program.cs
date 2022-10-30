using System;
using System.Runtime.CompilerServices;

namespace p1
{
    internal class Program
    {
        class Math
        {

            private float l, w, h;

            public float L
            {
                get { return l; }
                set
                {
                    if (value > 0)
                    {
                        l = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }
            public float W
            {
                get { return w; }
                set
                {
                    if (value > 0)
                    {
                        w = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }
            public float H
            {
                get { return h; }
                set
                {
                    if (value > 0)
                    {
                        h = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("value");
                    }
                }
            }

            public Math()
            {
            }

            public void res()
            {
                Console.WriteLine((2 * this.l * this.w) + (2 * this.l * this.h) + (2 * this.h * this.w));
                Console.WriteLine((2 * this.l * this.h) + (2 * this.w * this.h));
                Console.WriteLine(this.l * this.w * this.h);
            }
        }
        static void Main()
        {
            Math a = new Math();
            a.L = Convert.ToSingle(Console.ReadLine());
            a.W = Convert.ToSingle(Console.ReadLine());
            a.H = Convert.ToSingle(Console.ReadLine());
            a.res();
        }
    }
}
