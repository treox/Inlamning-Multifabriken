using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class ror : produkter
    {
        private string diameter;
        private string langd;
        private string strRor;
        public List<string> lsRor = new List<string>();

        public override void angeData()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Mata in data för önskat rör: ");
            Console.Write("Skriv in diameter: ");
            diameter = Console.ReadLine();
            Console.Write("Skriv in längd: ");
            langd = Console.ReadLine();

            strRor = $"Diameter: {diameter}, Längd: {langd}";
        }

        public override void addToList()
        {
            lsRor.Add(strRor);
        }

        public override void presentList()
        {
            int countRor = 0;
            foreach (string ror in lsRor)
            {
                countRor++;
                Console.WriteLine("-Rör {0}: {1}", countRor, ror);
            }
        }
    }
}
