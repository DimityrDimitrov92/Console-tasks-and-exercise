using System;

namespace WhileDoProdyljiIliIzlez
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Искате ли да продължи програмата : ");
            char a;
            do
            {
                Console.Write("Въведете Y или N и след това (enter) ");
                a = char.Parse(Console.ReadLine());
            }
            while ((a != 'Y') && (a != 'y') && (a != 'n') && (a != 'N'));
            switch (a)
            {
                case 'y': case 'Y':
                    Console.WriteLine("Програмата продължава изпълнението си");
                    break;
                case 'N': case 'n':
                    Console.WriteLine("Програмата спира");
                    break;
            }
        }
    }
}
