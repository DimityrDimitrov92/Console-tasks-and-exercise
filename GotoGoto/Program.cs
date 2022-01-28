using System;

namespace GotoGoto
{
    class Program
    {
        static void Main()
        {
            Console.Write("Напишете x = ");
            int x = int.Parse(Console.ReadLine());
            if (x >= 0)
                goto positiv;
            x = -x * 2+20;
        positiv: Console.WriteLine("x= {0}", x);
        }
    }
}
