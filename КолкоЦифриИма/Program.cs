using System;

namespace КолкоЦифриИма
{
    class Program
    {
        static void Main()
        {
            arr: Console.Write("N := ");
            var n = ulong.Parse(Console.ReadLine());
            var n1 = n;
            int i = 0;
            while (n>0)
            {
                i++;
                n = n / 10;
            }
            Console.WriteLine("Числото {0} има {1} корена", n1, i);
            goto arr;
        }
    }
}
