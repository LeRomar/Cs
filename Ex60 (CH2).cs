using System;
namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double pi, i, epsilon, sign;
            epsilon = double.Parse(Console.ReadLine());
            i = 1;
            sign = 0;
            pi = 0;
            while (4 / (i + 2) > epsilon)
            {
                pi += Math.Pow(-1, sign)*(4 / i);
                i += 2;
                sign++;

            }
            Console.WriteLine("pi= {0}", pi);

        }
    }
}
