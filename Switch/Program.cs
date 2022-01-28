using System;

namespace Switch
{
    class Program
    {
        static void Main()
        {
            char a;
            Console.Write("Въведете буква ");
            a = Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("въведете година \"{0}\".", a);
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("въведете година \"{0}\" ", a);
                    break;
                default:
                    Console.WriteLine("въведеният израз е грешен");
                    break;
            }

        }

    }
}
