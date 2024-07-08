using System;

namespace KayttajanIka
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kerro ikäsi: ");
            int ika = int.Parse(Console.ReadLine());

            Console.WriteLine("Olet " + ika + "-vuotias, näytät ikäistäsi nuoremmalta!");
        }
    }
}
