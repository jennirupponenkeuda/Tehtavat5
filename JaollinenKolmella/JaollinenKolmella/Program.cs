using System;

namespace JaollinenKolmella
{
    class Program
    {
        public static void Main(string[] args)
        {
            int luku = 99;

            for (int i = 1; i < luku; i++)
                if (i % 3 == 0) // Jaollinen kolmella eli ei jää jakojäännöstä eli jakojäännös on 0!
                {
                    Console.WriteLine(i);

                }
        }
    }
}