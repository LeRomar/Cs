using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Calculates the sum of the digits
            int n, S;

            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            S = 0;

            while (n != 0)
            {
                S += n % 10;
                n /= 10;
            }
            Console.WriteLine("La somme est {0} ", S);
        }
    }
}