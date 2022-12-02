using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n, s_50, s_normal;
            s_50 = 0;
            s_normal = 0;
            double min = int.MaxValue;
            Console.WriteLine("Enter the prices");
            do
            {
                n = double.Parse(Console.ReadLine());
                if (n <= min && n != 0) 
                {
                    min = n;
                }
                if (n > 50)
                {
                    s_50 += n * 0.9;
                }
                else
                {
                    s_50 += n;
                }
                s_normal += n;

            } while (n > 0);
            if (min >= 20)
            {
                s_normal = s_normal * 0.8;
            }
            else
            {
                s_normal = s_50;
            }
            Console.WriteLine(s_normal);
        }
    }
}
