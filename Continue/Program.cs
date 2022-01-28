using System;

namespace Continue
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i<5)
            {
                ++i;
                if (i == 3) continue;
                Console.WriteLine("Номер на цикъла {0}.",i);
                Console.WriteLine("Изпълни следващата стъпка");
            }
        }
    }
}
