using System;

namespace GoTo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Напишете x = ");
            int x = int.Parse(Console.ReadLine());
            if (x >= 0)
                goto positiv;
            x = -x * 2;
        positiv: Console.WriteLine("x= {0}", x);
        }
    }
}
