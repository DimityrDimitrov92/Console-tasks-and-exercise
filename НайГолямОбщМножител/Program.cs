using System;

namespace НайГолямОбщМножител
{
    class Program
    {
        static void Main()
        {
           eto: Console.Write("A = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            var b = int.Parse(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("Най големият общ делител е {0}", b);
            goto eto;
        }
    }
}
