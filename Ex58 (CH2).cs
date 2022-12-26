using System;
namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int bin , a, i;
            double dec;
            dec = 0;
            i = 0;
            bin = int.Parse(Console.ReadLine());
            while (bin > 0)
            {
                a = bin % 10;
                bin = bin / 10;
                dec = dec + a*(Math.Pow(2, i));
                i=i+1;
            }
            Console.WriteLine(dec);
        }
    }
}
