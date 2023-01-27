using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, i;
            string F, A;
            F = "-";
            A = "*";

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {
                for(i=0; i < n; i++)
                {
                    Console.Write(F);
                }
                Console.WriteLine(A);
                n--;
            }

        }
    }
}
