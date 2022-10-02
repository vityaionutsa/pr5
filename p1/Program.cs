using System;

namespace p1
{
    internal class Program
    {
        class math
        {
            public static void res(float l,float w,float h)
            {
                
                Console.WriteLine((2 * l * w)+ (2 * l * h)+ (2 * h * w));
                Console.WriteLine((2*l*h)+(2*w*h));
                Console.WriteLine(l*w*h);
            }
        }
        static void Main()
        {
            float l, w, h;
            l = Convert.ToInt64(Console.ReadLine());
            w = Convert.ToInt64(Console.ReadLine());
            h = Convert.ToInt64(Console.ReadLine());
            math.res(l,w,h);
        }
    }
}
