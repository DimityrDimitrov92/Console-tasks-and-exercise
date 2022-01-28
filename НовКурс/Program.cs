using System;

namespace НовКурс
{
    class Program
    {
        static void Main()
        {
            Console.Write("Напишете вашето име: ");
            string name = Console.ReadLine();
            Console.Write("На колко си години: ");
            string age = Console.ReadLine();
            Console.WriteLine(" Здравей " + name + " ти си на " + age + "години.");
        }
    }
}
