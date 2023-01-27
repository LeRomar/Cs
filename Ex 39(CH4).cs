using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //This algorithm calculates the average of the odd numbers
            int n, i, x;
            double M;
            x = 0;
            M = 0;

            Console.WriteLine("Enter the numbers: ");
            for(i=0; i<6; i++) 
            {
                n = int.Parse(Console.ReadLine());
                if ((n % 2) != 0)
                {
                    M += n;
                    x++;
                }
            }
            Console.Write("La moyenne des nombres impaires est {0}", M / x);
        }   
    }
}