using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int  n, m, a;
            double b;
            int i = 0;
            double Moy;
            m = 0;
            b = 0;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                a = n % 10;
                n=n/10;
                m = m + (a*i);
                b += i;
                i++;
            }
            Moy = m / b;
            Console.WriteLine(m);
            Console.WriteLine(b);
            Console.WriteLine(Moy);
        }
    }
}
