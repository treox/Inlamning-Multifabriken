using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class havremjolk : produkter
    {
        private string fetthalt;
        private string litermangd;
        private string strHavre;
        public List<string> lsHavre = new List<string>();

        public override void angeData()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Mata in data för önskad havremjölk: ");
            Console.Write("Skriv in fetthalt: ");
            fetthalt = Console.ReadLine();
            Console.Write("Skriv in litermängd: ");
            litermangd = Console.ReadLine();

            strHavre = $"Fetthalt: {fetthalt}, Längd: {litermangd}";
        }

        public override void addToList()
        {
            lsHavre.Add(strHavre);
        }

        public override void presentList()
        {
            int countHavre = 0;
            foreach (string havre in lsHavre)
            {
                countHavre++;
                Console.WriteLine("-Havremjölk {0}: {1}", countHavre, havre);
            }
        }
    }
}
