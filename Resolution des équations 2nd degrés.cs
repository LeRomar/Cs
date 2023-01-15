using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;

            Console.WriteLine("Enter the coefficient of x^2");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coefficient of x");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the constant");
            c = int.Parse(Console.ReadLine());

            delta = b * b - (4 * a * c);
            if (delta > 0)
            {
                x1 = (-b + (double)Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - (double)Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = {0}" , x1);
                Console.WriteLine("x2 = {0}" , x2);
            }
            if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("x1=x2= {0}" , x1);

            }
            if (delta < 0)
            {
                Console.WriteLine("x1 = {0}" , (-b / 2 * a) + " + i*" + ((double)Math.Sqrt(Math.Abs(delta)) / 2 * a));
                Console.WriteLine("x2 = {0}" , (-b / 2 * a) + " - i*" + ((double)Math.Sqrt(Math.Abs(delta)) / 2 * a));
            }
        }   
    }
}
