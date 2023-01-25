using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Inverse number with zeros on the left

            int n;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine());

            do
            {
                Console.Write(n % 10);
                n /= 10;

            } while (n != 0);
        }   
    }
}