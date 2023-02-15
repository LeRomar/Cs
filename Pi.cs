using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var rd = new Random();

            int inside_pts, total_pts, i;
            double x, y;
            inside_pts = 0;
            total_pts = 0;

            for (i=0; i <= 10000000; i++)
            {
                double rd_num1 = rd.NextDouble();
                double rd_num2 = rd.NextDouble();
                x = rd_num1;
                y = rd_num2;

                if (Math.Sqrt(x * x + y * y) < 1)
                    inside_pts++;

                total_pts++;

            }
            Console.Write("Pi = {0}", (double)4 * inside_pts / total_pts);
        }    
    }
}