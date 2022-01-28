using System;

namespace XnaNta
{
    class Program
    {
        static void Main()
        {
            int fakt = 1;
            fakt = fakt * 1;
            fakt = fakt * 2;
            fakt = fakt * 3;
            fakt = fakt - 1;
            Console.WriteLine("{0}", fakt);
            Console.Write("въведете число от 1-20: ");
            ulong n = ulong.Parse(Console.ReadLine());
            ulong fack = 1U;
            for (ulong i = 1; i <= n; i++)
            {
                fack = fack * i;
            }
            Console.WriteLine("{1} числото е равно на {0}", fack, n);
        }
    }
}