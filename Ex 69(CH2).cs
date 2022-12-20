using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i;
            double a, b;



            double [] Tab  = { 8.2, 5.1, 12.9, -77.9, 6.4, -3.2, 19.8 };

            for (i=0; i<3; i++)
            {
                a = Tab[i];
                b = Tab[6 - i];
                Tab[6 - i] = a;
                Tab[i] = b;
            
            }

            for (i=0; i<7; i++)
            {
                Console.WriteLine(Tab[i]);

            }
        }
    }
}
