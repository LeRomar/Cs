using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n = 0;
            double e = 0;
            double fac_n = 1;
            while ((1/fac_n) >= 1e-5) 
            {
                e += 1 / fac_n;
                n = n + 1;
                fac_n *= n;
            }
            Console.WriteLine("e = {0}", e);
        }
    }
}
