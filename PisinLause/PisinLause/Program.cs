using System;
namespace PisinLause
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anna lause: ");
            string lause = Console.ReadLine();

            string[] sanat = lause.Split(' '); // taulukko, johon on pilkottu lause sanoiksi erotettuina välilyönneillä
            string pisinsana = ""; // alustetaan tyhjä merkkijono pisimpää sanaa varten

            foreach (string sana in sanat) // tässä silmukassa käydään läpi sanat -taulukon sanat ja tallennetaan kukin väliaikaisesti pisinsana merkkijonoon
            {
                if (sana.Length > pisinsana.Length)
                {
                    pisinsana = sana; // päivitetään pisin sanoista tähän, jos ylläoleva ehto toteutuu
                }
            }
            Console.WriteLine("Pisin sana lauseessasi on " + pisinsana);
            
        }
    }
}
