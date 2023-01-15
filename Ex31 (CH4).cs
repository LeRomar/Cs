using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ///Cet algorithme calcule la résistance équivalente des trois résistances en fonction du type du montage
            double R1, R2, R3, Req;
            string type;
            Req = 0;

            Console.WriteLine("Entrer la valeur des résistances :");
            R1 = double.Parse(Console.ReadLine());
            R2 = double.Parse(Console.ReadLine());
            R3 = double.Parse(Console.ReadLine());

            Console.Write("Entrer le type du montage :");
            type = Console.ReadLine();   /// Enter serie or derivation

            if(type == "serie")
            {
                Req = R1 + R2 + R3;
            }
            else
            {
                Req = R1 * R2 * R3 / (R1 * R3 + R1 * R2 + R2 * R3);
                if(R1 == 0 || R2 == 0 || R3 == 0)
                {
                    Req = 0;
                }
            }
            Console.WriteLine("La résistance équivalente est : {0}", Req);
        }   
    }
}
