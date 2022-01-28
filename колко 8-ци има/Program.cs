using System;

namespace колко_8_ци_има
{
    class Program
    {
        static void Main()
        {
            gr: Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, d;
            do
            {
                d = n % 10;
                if (d == 8)
                    i++;
                n = n / 10;
            }
            while (n != 0);
            if (i > 0)
                Console.WriteLine("цифрата 8 се среща {0} пъти", i);
            else
                Console.WriteLine("Цифрата 8 не се среща нито веднъж");
            goto gr;
        }
    }
}
