using System;

namespace Yli10LukuToisto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anna kymmentä suurempi luku: ");
            int luku = int.Parse(Console.ReadLine());

            for (int i = 0; i < luku; i++)
            {
                Console.Write(luku + " "); // Luku välilyönnillä

            }
            Console.WriteLine(); // Rivinvaihto

            for (int i = 0; i < luku; i++)
            {
                Console.Write(luku); // Luku ilman välilyöntiä

            }
        } // En ymmärrä täysin tehtävänantoa, mutta tulostus on annetun tehtävänannon esimerkin mukainen (oman tulkintani mukaan...)
    }
}