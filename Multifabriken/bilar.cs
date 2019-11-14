using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class bilar : produkter
    {
        private string regNr;
        private string farg;
        private string bilmarke;
        private string strBilar;
        public List<string> lsBilar = new List<string>();

        public override void angeData()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Mata in data för önskad bil: ");
            Console.Write("Skriv in registreringsnummer: ");
            regNr = Console.ReadLine();
            Console.Write("Skriv in färg: ");
            farg = Console.ReadLine();
            Console.Write("Skriv in bilmärke: ");
            bilmarke = Console.ReadLine();

            strBilar = $"Reg.Nr: {regNr}, Färg: {farg}, Bilmärke: {bilmarke}";
        }

        public override void addToList()
        {
            lsBilar.Add(strBilar);
        }

        public override void presentList()
        {
            int countBil = 0;
            foreach (string bil in lsBilar)
            {
                countBil++;
                Console.WriteLine("-Bil {0}: {1}", countBil, bil);
            }
        }
    }
}
