using System;

namespace HelloWorld
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            int i, j, sqrt;
            int[] T1 = { 4, 17, 5, 15 };


            for (i = 0; i < 4; i++)
            {
              
                   if (T1[i]
 % 2 == 0)
                {
                    T1[i] = 2;
                }

                          
    else
                {
                    if (T1[i] <= 3)
                    {
                        T1[i] = 1;
                    }
                    else
                    {
                        sqrt = (int)Math.Sqrt(T1[i]);
                        for (j=2; j<=sqrt; j++)
                        {
                            if (T1[i] % j != 0)
                            {
                                T1[i] = 1;
                            }
                        }
                    }

                }
            }
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine(T1[i]);
            }
        }
    }
}
