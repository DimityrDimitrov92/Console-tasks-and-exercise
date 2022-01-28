using System;

namespace Break
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i <10 )
            {
                i++;
                Console.WriteLine("Номер на цикъла {0}.", i);
                if (i == 7) break;
                Console.WriteLine("изпълни следваща стъпка .");
            }
        }
    }
}
