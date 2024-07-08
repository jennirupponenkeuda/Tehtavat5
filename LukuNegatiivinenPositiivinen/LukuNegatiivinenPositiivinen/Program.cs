using System;

namespace LukuNegatiivinenPositiivinen
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen luku: ");
            int ekaluku = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            int tokaluku = int.Parse(Console.ReadLine());

            if (ekaluku < 0 && tokaluku < 0)
            {
                Console.WriteLine("Molemmat ovat negatiivisia");
            }
            else if(ekaluku > 0 && tokaluku > 0)
            {
                Console.WriteLine("Molemmat ovat positiivisia");
            }
            else
            {
                Console.WriteLine("Toinen luvuista on negatiivinen ja toinen positiivinen");
            }


        }

    }
}
