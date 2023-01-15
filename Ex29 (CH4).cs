using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /// This algorithm calculates the salary based on the number of hours.
            int Tarif, nb_heures;
            double K, salaire;
            salaire = 0;

            Console.Write("Entrer le tarif: ");
            Tarif = int.Parse(Console.ReadLine());      /// How much is paid per hour
            Console.Write("Entrer le nombre d'heures: ");
            nb_heures = int.Parse(Console.ReadLine());


            if (nb_heures <= 39)  ///for the first 39 hours, he is paid normally
            {
                K = 1;
                salaire = nb_heures * K * Tarif;

            }
            if (nb_heures >= 40 && nb_heures <= 44)  /// from the 40th to the 44th hour, he is paid 1.2 the amount for the hour
            {
                K = 1.2;
                salaire = Tarif * (39 + (nb_heures - 39) * K);
               
            }
            if (nb_heures >= 45 && nb_heures <= 49)   /// from the 45th to 49th hour, 1.5
            {
                K = 1.5;
                salaire = Tarif * (39 + 1.2 * 5 + (nb_heures - 44) * K);   /// Could have put 45 instead of 39+ 1.2*5
                
            }
            if (nb_heures >= 50)
            {
                K = 1.8;
                salaire = Tarif * (39 + 1.2 * 5 + 1.5 * 5 + (nb_heures - 49) * K);   /// Same here could have put 52.5
                
            }
            Console.WriteLine("Le salaire sera {0} $",salaire);
        }   
    }
}
