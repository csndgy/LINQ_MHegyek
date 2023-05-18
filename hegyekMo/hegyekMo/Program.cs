using hegyekMo;
using System;
using System.IO;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HegyCsucs> csucsok = new List<HegyCsucs>();
            string adatok = "hegyekMo.txt";
            StreamReader sr = new StreamReader(adatok);
            //sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                csucsok.Add(new HegyCsucs(adat[0], adat[1], int.Parse(adat[2])));
            }
            sr.Close();

            double osszeg = 0;

            foreach (HegyCsucs vmi in csucsok)
            {
                osszeg = osszeg + vmi.magassag ;
            }


            int megszamla = csucsok.Count;
            double atlagmagassag = osszeg / megszamla;
            Console.WriteLine($"{megszamla} hegy található az állományban.");
            Console.WriteLine($"{atlagmagassag} az átlagmagasság.");

        }
    }
}