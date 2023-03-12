using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Alphabet = "abcdefghijklmmnopqrstuvwxyz";
            char[] chArray = Alphabet.ToCharArray();
            string Phrase;
            int i, j;

            Phrase = Console.ReadLine();
            Phrase.ToLower();
            char[] phArray = Phrase.ToCharArray();
            for (i = 0; i < Phrase.Length; i++)
            {
                for (j=0; j < Alphabet.Length; j++)
                {
                    if (phArray[i] == chArray[j] )
                    {
                        if (j <= 12) 
                        {
                            phArray[i] = chArray[j + 13];
                        }
                        if(j>12) 
                        {
                            phArray[i] = chArray[(j + 13) / 25];
                        }

                    }
                }

                Console.Write(phArray[i]);           
            }





        }
    }
} 