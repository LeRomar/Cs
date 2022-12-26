using System;
namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double  a, b, i, j;
            int n;
            n = int.Parse(Console.ReadLine());
            i = 0;
            j = 0;
            while (n > 0)
            {
                a = n % 10;
                n = n / 10;
                b = n % 10;
                n = n / 10;
                i++;
                if (Math.Abs(a - b) == 1)
                {
                    j++;
                }
            }
            if (j == i)
            {
                Console.WriteLine("GRAY");
            }
            else
            {
                Console.WriteLine("NOT GRAY");
            }
        }
    }
}
