using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //This algorithm sums two numbers and puts it in a table
            Console.WriteLine("Enter the dimension of the table: ");

            int n = int.Parse(Console.ReadLine());
            int[] T1 = new int[n];
            int[] T2 = new int[n];
            int[] T = new int[n + 1];
            int i,a;

            //The number must be entered from left to right by digit
            Console.WriteLine("Enter the number by digit: ");

            for (i=0; i<T1.Length; i++)
            {
                T1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number by digit: ");

            for (i = 0; i < T2.Length; i++)
            {
                T2[i] = int.Parse(Console.ReadLine());
            }

            // if the sum is greater than 10 the computer adds one the next operation
            for (i = 0; i < n; i++)
            {
                a = T1[n - (i + 1)] + T2[n - (i + 1)];
                T[n - i] += a % 10;

                if(a >= 10 )
                    T[n - (i + 1)] += 1;

                if (T[n - i] == 10)
                {
                    T[n - i] = 0;
                    T[n - (i + 1)] += 1;

                }




            }

            Console.WriteLine("The sum is: ");
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(T[i]);
            }
        }
    }
}
