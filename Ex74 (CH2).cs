using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //This algorithm shows the first 50 prime numbers that the sum of their digits is not pair
            int i, n, x;
            x = 0;
            i = 1;

            while (x <= 50)
            {
                i++;
                n = 2;
                while(n*n<=i && i % n != 0)
                {
                    n+=1;
                }
                if (n * n > i)
                {
                    int b = i;
                    int a = 0;
                    while (b != 0)
                    {
                        a += (int)b % 10;
                        b = b / 10;
                    }

                    if(a%2 != 0)
                    {
                        Console.WriteLine(i);
                        x++;
                    }
                }
            }
        }
    }
}
