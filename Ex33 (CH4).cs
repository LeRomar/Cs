using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //This algorithm shows the two highest numbers from the 6 numbers you enter 
            int i, n, a, b, N;

            N = 6;
            Console.WriteLine("Entres les {0} valeurs: ",N);
            a = int.Parse(Console.ReadLine());
            b = a;

            for (i=1; i<N; i++)
            {
                n = int.Parse(Console.ReadLine());

                if (n > b)
                {
                    a = b;
                    b = n;
                }
                else
                    if (n > a)
                {
                    a = n;
                }
                
            }
            Console.WriteLine("Les deux plus grandes valeurs: {0},{1} ", a, b);
        }   
    }
}