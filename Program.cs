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

            Console.WriteLine("Anna joku merkkijono (esim. joku lause)");
            lause1 = Console.ReadLine();
            Console.WriteLine("Anna joku merkkijono, jota verrataan edelliseen merkkijonoon");
            lause2 = Console.ReadLine();

            //IndexOf() palauttaa (-1)tai(0),jos merkkijonoa ei löydy
            if ((lause1.IndexOf(lause2) == -1) || (lause1.IndexOf(lause2)==0))
            { Console.WriteLine("Merkkijonoa ei lötynyt"); }

            else Console.WriteLine("Merkkijono löytyi");//jos palauttaa jotain muuta merkkijono löytyi


            Console.WriteLine(lause1.IndexOf(lause2));


            //Console.WriteLine(lause2);
            Console.WriteLine();
                      
            
            Console.ReadLine();


        }
    }
}
