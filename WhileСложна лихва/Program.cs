using System;

namespace WhileСложна_лихва
{
    class Program
    {
        static void Main()
        {
            Console.Write("Лихва % : ");
            var amount = decimal.Parse(Console.ReadLine());
            Console.Write("Първоначална сума: ");
            var rate = decimal.Parse(Console.ReadLine());
            var balance = amount;
            int month = 0;
            while (balance < amount *2 )
            {
                month++;
                balance = balance * (1 + rate / 12 / 100);
            }
            Console.WriteLine("Необходими са {0} Години и {1} Месеца" + "\nза удвояване на сумата от {2} ", month / 12, month % 12, amount);
        }
    }
}
