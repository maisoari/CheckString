using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lause1, lause2;

            Console.WriteLine("Verrataan sisältyykö toinen merkkijono ensimmäiseen merkkijonoon");
            Console.WriteLine("Anna joku merkkijono (esim. joku lause)");
            lause1 = Console.ReadLine();        //talletetaan annettu mrkjono muutujaan (lause1)
            Console.WriteLine("Anna joku toinen merkkijono, jota verrataan edelliseen merkkijonoon");
            lause2 = Console.ReadLine();       //talletetaan annettu mrkjono muutujaan (lause2)

            if (lause2 == "")    //Tarkistetaan onko merkkijono tyhjä (lause2 == string.Empty)
            { 
              Console.WriteLine("Toinen merkkijono puuttuu!");
            }

                 
            if (lause1.IndexOf(lause2) == -1)   //IndexOf() palauttaa (-1),jos merkkijonoa ei löydy
            Console.WriteLine("Merkkijonoa ei lötynyt");

               
             else if (lause2 != "")           //jos palauttaa jotain muuta ja mrkjono ei ole tyhjä, merkkijono löytyi
             Console.WriteLine("Merkkijono löytyi");   
                       
            Console.WriteLine("Yes!");
                                 
            Console.ReadLine();


        }
    }
}
