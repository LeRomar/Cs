using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i;
            int[] T1 = {4, 17, 5, 15, 23, 47, 19};

            // use T1.Length to get the length of the array
            // instead of using 4. That way you can use the same code
            // for any array of any length
            for (i = 0; i < T1.Length; i++)
            {
                /* if there is only one state inside the if block
                 * then you can write without the curly braces {}
                 */
                if (T1[i] % 2 == 0)
                    T1[i] = 2;
                else
                {
                    /*
                     * if there's a divider of T1[i] between 3 and Sqrt(T1[i])
                     * then T1[i] is not a prime
                     * so for all integers n starting from 3 
                     * if n*n > T1[i] or T1[i] is divisible by n, then T1[i] is
                     * not a prime.
                     */
                    int n = 3;
                    while (n * n <= T1[i] && T1[i] % n != 0)
                        n += 1;
                    if (n * n > T1[i])
                        T1[i] = 1;
                }
            }
            /* Same with if block, with only one statement,
             * no need for the curly braces {}
             */
            for (i = 0; i < T1.Length; i++)
                Console.WriteLine(T1[i]);
        }
    }
}