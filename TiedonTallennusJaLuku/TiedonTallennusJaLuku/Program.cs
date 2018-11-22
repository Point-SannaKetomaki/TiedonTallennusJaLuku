using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennusJaLuku
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\Users\OWNER\Google Drive\PointCollege\Kurssi_05_Ohjelmoinnin jatkokurssi\lämpötila.txt";

            //luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine($"Aiemmin asetettu lämpötila on {aiempiArvo}°");
            }
            else
            {
                Console.WriteLine("Tervetuloa lämpötilan asettamisohjelmaan!");
            }



            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu");
            Console.ReadLine();
        }
    }
}
