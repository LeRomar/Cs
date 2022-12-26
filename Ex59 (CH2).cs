using System;
namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        
            double deg, coef ,pt, val;
            deg = 1;

            while (deg > 0)
            {
                Console.WriteLine("Enter the degree");
                deg = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the coeff");
                coef = double.Parse(Console.ReadLine());

            }
        }
    }
}
