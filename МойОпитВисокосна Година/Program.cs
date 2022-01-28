using System;

namespace МойОпитВисокосна_Година
{
    class Program
    {
        static void Main()
        {
            int a, b;
        povtorenie: Console.Write("Моля така любезно да напишите година : ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
            {
                b = 1;
            }
            else
            {
                b = 0;
            }
            if (b==1)
            {
                Console.WriteLine("{0} е високосна ", a);
            }
            else
            {
                Console.WriteLine("{0} Неееееееее високосна",a);
            }
            goto povtorenie;
        }
    }
}

