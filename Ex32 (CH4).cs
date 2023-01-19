using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // This algorithm tells you date of tomorrow based on the date you give it

            int jour, mois;

            Console.Write("Enter the day: ");
            jour = int.Parse(Console.ReadLine());
            Console.Write("Enter the month: ");
            mois = int.Parse(Console.ReadLine());

            jour++;

            switch (mois)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                
                    if((jour<=1) || (jour > 32))
                    {
                        Console.WriteLine("Error you idiot ");
                        return;
                    }
                    if (jour == 32)
                    {
                        jour = 1;

                        if (mois < 12)
                            mois++;
                        else
                            mois = 1;
                    }
                    break;

                case 4: case 6: case 9:
                case 11:

                    if((jour<=1) || (jour > 31))
                    {
                        Console.WriteLine("Error you fucking idiot ");
                        return;
                    }
                    if (jour == 31)
                    {
                        jour = 1;
                        mois++;
                    }
                    break;

                case 2:

                    if((jour<=1) ||(jour> 29))
                    {
                        Console.WriteLine("You fucking bitch ");
                    }
                    if (jour == 29)
                    {
                        jour = 1;
                        mois++;
                    }
                    break;

                default:
                    Console.WriteLine("Error dans le mois ");
                    return;

            }
            Console.WriteLine("Date of tmrw: {0}/{1}", jour, mois);
        }   
    }
}
