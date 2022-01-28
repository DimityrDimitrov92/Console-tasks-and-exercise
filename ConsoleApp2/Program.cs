using System;
using System.Data;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string user = "matematika";
            Console.WriteLine(user);
            Console.WriteLine($"Hallo world  " + user);
            Console.WriteLine($"i am usera : " + user.Length);
            Console.WriteLine($"hallo {user.Length} ");
            Console.WriteLine(user.ToUpper());
            Console.WriteLine(user.ToLower());
            user = user.Replace("matematika", "ivan");
            Console.WriteLine(user);
            string User1 = "Hey my love ! ";
            Console.WriteLine(User1.Contains("love"));
            Console.WriteLine(User1.StartsWith("Hey"));
            int a = 3;
            int b = 8;
            int c = a + b;
            if (a + b > 10)
            {
                Console.WriteLine("I Love\n You My love");
            }
            else
            {
                Console.WriteLine("I love You Again");
            }
            if ((a + b > 10) && (a == b))
            {
                Console.WriteLine("Obi4am te");
            }
            else
            {
                Console.WriteLine("Te amo");
            }
            if ((a + b > 10) || (b == 5))
            {
                Console.WriteLine("BAu");
            }
            else
            {
                Console.WriteLine("sat");
            }
            int omfg = 2;
            while (omfg < 10)
            {
                Console.WriteLine($" Chisla {omfg}");
                omfg++;
            }
            int omg = 1;
            do
            {
                Console.WriteLine($"Pyrvo pravi posle proverqva {omg}");
                omg++;
            }
            while (omg < 10);
            for (int baba = 0; baba < 7; baba++)
            {
                Console.WriteLine($"treti variant + { baba}");
            }
            for (char kolona = 'a'; kolona < 'd'; kolona++)
            {
                Console.WriteLine($"slojni cikli {kolona}");
            }
            for (int row = 1; row < 15; row++)
            {
                for (char column = 'a'; column < 'p'; column++)
                {
                    Console.WriteLine($"Slojnite cikli ({row},{column})");
                }
            }
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine("sbora na chislata 1-20 koito se delqt na 3 e :   " + sum);
            int x = 3;
            x = x++ + ++x;
            Console.WriteLine($"Vnimanie {x}");
            double p, o, z;
            Console.Write("p = :");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("o = :");
            o = Convert.ToDouble(Console.ReadLine());
            z = p;
            if (o > z)
            {
                z = o;
            }
            Console.WriteLine("Po golqmata stoinost  ot {0} i {1} e {2}", p ,o, z);
            int age ;
            err: Console.Write("Въведете възрастта на студента : ");
            age = Convert.ToInt16(Console.ReadLine());
            if (age < 17)
            {
                Console.WriteLine("\a\a\a");
                Console.WriteLine("*** Eror E01524 ");
                Console.WriteLine("Студентът не може да бъде по-млад от 17 години. : ");
                goto err;
            }
            Console.WriteLine("Възраст = {0} години ", age);
            if (a>b)
            {
                z = a;
            }
            else
            {
                z = b;
            }
            Console.WriteLine("между стойностите {0} и {1} по голямата е {2}",a,b,z);

        }
    }
}
