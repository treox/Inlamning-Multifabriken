using System;
using System.Collections.Generic;

namespace Multifabriken
{
    abstract class produkter
    {
        public abstract void angeData();

        public abstract void addToList();

        public abstract void presentList();
    }

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

    class Program
    {
        static void Main(string[] args)
        {

            bilar Bilar = new bilar();
            godis Godis = new godis();
            ror Ror = new ror();
            havremjolk Havremjolk = new havremjolk();

            for ( ; ; )
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Välkommen till Multifabriken AB! ");
                Console.WriteLine("[1] Bilar ");
                Console.WriteLine("[2] Godis ");
                Console.WriteLine("[3] Rör ");
                Console.WriteLine("[4] Havremjölk ");
                Console.WriteLine("[5] Kundvagn ");
                Console.WriteLine("[6] Avsluta ");
                Console.WriteLine("Beställ produkt: val [1]-[4], se kundvagn: val [5] eller avsluta val [6]. ");
                Console.WriteLine();

                string val = Console.ReadLine();

                switch(val)
                {
                    case "1":
                        Bilar.angeData();
                        Bilar.addToList();
                        break;
                    case "2":
                        Godis.angeData();
                        Godis.addToList();
                        break;
                    case "3":
                        Ror.angeData();
                        Ror.addToList();
                        break;
                    case "4":
                        Havremjolk.angeData();
                        Havremjolk.addToList();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Kundvagnen innehåller ({0} Bilar, {1} Godisar, {2} Rör, {3} Havremjölk): ", Bilar.lsBilar.Count, Godis.lsGodis.Count, Ror.lsRor.Count, Havremjolk.lsHavre.Count);
                        Console.WriteLine();

                        Bilar.presentList();
                        Godis.presentList();
                        Ror.presentList();
                        Havremjolk.presentList();

                        Console.WriteLine();
                        Console.WriteLine("[m] Meny");
                        Console.Write("Välj [m] för att gå tillbaka till menyn. ");
                        rtMeny:
                        string retToMeny = Console.ReadLine();
                        if (retToMeny == "m")
                        {
                            Console.WriteLine("Gåt tillbaka till menyn... ");
                            break;
                        }
                        else
                        {
                            goto rtMeny;
                        }
                    case "6":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Tack för handeln! Välkommen åter! Programmet avslutas... ");
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Gör ett val [1]-[6] i menyn: ");
                        break;
                }
            }
        }
    }
}
