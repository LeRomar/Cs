using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            String N = Console.ReadLine();
            Console.WriteLine("The height(odd number): ");
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    if (i == j || i + j == H-1)
                    {
                        Console.Write(N + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();



        }


    }
}