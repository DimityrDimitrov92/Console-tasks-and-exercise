using System;

namespace СредноАритмитично
{
    class Program
    {
        static void Main()
        {
            double x, s = 0.0;
            int i = 0, k = 1;
            do
            {
                Console.Write("въведете X [{0}]" , k);
                x = double.Parse(Console.ReadLine());
                k++;
                s += x; //s = s + x
                if (x != 0)
                    i++;
            }
            while (x != 0);
            if (i != 0) //не може да се дели на 0!!!
            {
                Console.WriteLine("сума: {0}\nСредноаритметично: {1}", s, s / i);
            }
            else
                Console.WriteLine("сума : {0}", s);
        }
    }
}
