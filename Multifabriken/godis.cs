using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class godis : produkter
    {
        private string smak;
        private string antal;
        private string strGodis;
        public List<string> lsGodis = new List<string>();

        public override void angeData()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Mata in data för önskad godis: ");
            Console.Write("Skriv in smak: ");
            smak = Console.ReadLine();
            Console.Write("Skriv in antal: ");
            antal = Console.ReadLine();
                        
            strGodis = $"Smak: {smak}, Antal: {antal}";
        }

        public override void addToList()
        {
            lsGodis.Add(strGodis);
        }

        public override void presentList()
        {
            int countGodis = 0;
            foreach (string godis in lsGodis)
            {
                countGodis++;
                Console.WriteLine("-Godis {0}: {1}", countGodis, godis);
            }
        }
    }
}
