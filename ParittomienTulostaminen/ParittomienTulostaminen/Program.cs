using System;

namespace ParittomienTulostaminen
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int luku = 99;

            for (int i = 0; i < luku; i++) 
            {

            if (i % 2 == 1)
            
                Console.WriteLine(i);
            }
        }
    }
}
