using System;
namespace ВисокоснаГодина
{
    class program
    {
        static void Main()
        {
            int a, b;
            Console.Write("Напишете годината моля , педали : ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a % 100 == 0)
            {
                if (a % 400 == 0)
                {
                    b = 1;
                }
                else
                {
                    b = 0;
                }

            }
            else if (a % 4 == 0)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }
            if (b == 1)
            {
                Console.WriteLine("{0} високосна", a);
            }
            else
            {
                Console.WriteLine("{0} Не е високосна", a);
            }
            if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
            {
                b = 1;
            }
            else
            {
                b = 0;
            }
            if (b == 1)
            {
                Console.WriteLine("{0} Високосна", a);
            }
            else
            {
                Console.WriteLine("{0} Не е високосна", a);
            }
        }
    }
}