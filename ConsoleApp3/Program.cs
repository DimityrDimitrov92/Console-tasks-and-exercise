using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            double a, b, c, d;
            Console.Write("a : = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b : =");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c : =");
            c = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    d = a;
                }
                else
                {
                    d = c;
                }
            }
            else
            {
                if (b > c)
                {
                    d = b;
                }
                else
                {
                    d = c;
                }
            }
            Console.WriteLine("max({0} ,{1} , {2}) = {3}", a, b, c, d);
            double q, w, e, r;
            Console.Write("q: =");
            q = Convert.ToDouble(Console.ReadLine());
            Console.Write("w: = ");
            w = Convert.ToDouble(Console.ReadLine());
            Console.Write("3: =");
            e = Convert.ToDouble(Console.ReadLine());
            if (q > w)
            {
                r = q > w ? q : e;
            }
            else
            {
                r = w > e ? w : e;
            }
            Console.WriteLine("съкратен вариант и това е {0} и {1} и {2} = {3}", q, w, e, r);
            dynamic counter = 5;
            counter = " gosho ";
            Console.WriteLine("dsad {0}das ", counter);

        }
    }
}
    

