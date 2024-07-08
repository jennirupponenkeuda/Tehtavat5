using System;
namespace EkanjaVikanKirjaimenVaihto
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Anna sana: ");
            string sana = (Console.ReadLine()); // Palauttaa oletuksena merkkijonon, joten ei tarvi muunnosta

            char EkaKirjain = sana[0]; // Uusi muuttuja, jossa viitataan sanan ensimmäiseen indeksiin, eli nollaan
            char VikaKirjain = sana[sana.Length -1]; //Uusi muuttuja, jossa sanan ns. pituudesta otetaan viimeinen kirjain

            sana = sana.Remove(0,1).Insert(0, VikaKirjain.ToString()); // Tässä poistetaan käyttäjän antaman sanan eka kirjain ja vaihdetaan se sanan viimeiseen kirjaimeem huom! Remove -metodissa eka argumentti kertoo mistä poisto aloitetaan ja toinen, kuinka monta merkkiä poistetaan
            sana = sana.Remove(sana.Length - 1,1).Insert(sana.Length - 1, EkaKirjain.ToString()); // Tässä sama, mutta toisinpäin; viimeinen kirjain poistetaan ja vaihdetaan ensimmäiseen kirjaimeen

            Console.WriteLine(sana);

        }
    }
}