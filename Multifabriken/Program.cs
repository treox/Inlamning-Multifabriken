using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class produkter
    {

    }

    class bilar : produkter
    {
        public string regNr;
        public string farg;
        public string bilmarke;
    }

    class godis : produkter
    {
        public string smak;
        public string antal;
    }

    class ror : produkter
    {
        public string diameter;
        public string langd;
    }

    class havremjolk : produkter
    {
        public string fetthalt;
        public string litermangd;
    }

    class Program
    {
        static void Main(string[] args)
        {

            var lsBilar = new List<string>();
            var lsGodis = new List<string>();
            var lsRor = new List<string>();
            var lsHavre = new List<string>();

            for ( ; ; )
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Välkommen till Multifabriken AB! ");
                Console.WriteLine("[1] Bilar ");
                Console.WriteLine("[2] Godis ");
                Console.WriteLine("[3] Rör ");
                Console.WriteLine("[4] Havremjölk ");
                Console.WriteLine();
                Console.WriteLine("[5] Kundvagn ");
                Console.WriteLine("[6] Avsluta ");
                Console.WriteLine("Beställ produkt: val [1]-[4], se kundvagn: val [5] eller avsluta val [6]. ");
                Console.WriteLine();

                string val = Console.ReadLine();

                switch(val)
                {
                    case "1":
                        bilar Bilar = new bilar();

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Mata in data för önskad bil: ");
                        Console.Write("Skriv in registreringsnummer: ");
                        Bilar.regNr = Console.ReadLine();
                        Console.Write("Skriv in färg: ");
                        Bilar.farg = Console.ReadLine();
                        Console.Write("Skriv in bilmärke: ");
                        Bilar.bilmarke = Console.ReadLine();

                        string strBilar = $"Reg.Nr: {Bilar.regNr}, Färg: {Bilar.farg}, Bilmärke: {Bilar.bilmarke}";
                        
                        lsBilar.Add(strBilar);
                        break;
                    case "2":
                        godis Godis = new godis();

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Mata in data för önskad godis: ");
                        Console.Write("Skriv in smak: ");
                        Godis.smak = Console.ReadLine();
                        Console.Write("Skriv in antal: ");
                        Godis.antal = Console.ReadLine();
                        
                        string strGodis = $"Smak: {Godis.smak}, Antal: {Godis.antal}";

                        lsGodis.Add(strGodis);
                        break;
                    case "3":
                        ror Ror = new ror();

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Mata in data för önskat rör: ");
                        Console.Write("Skriv in diameter: ");
                        Ror.diameter = Console.ReadLine();
                        Console.Write("Skriv in längd: ");
                        Ror.langd = Console.ReadLine();

                        string strRor = $"Diameter: {Ror.diameter}, Längd: {Ror.langd}";

                        lsRor.Add(strRor);
                        break;
                    case "4":
                        havremjolk Havremjolk = new havremjolk();

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Mata in data för önskad havremjölk: ");
                        Console.Write("Skriv in fetthalt: ");
                        Havremjolk.fetthalt = Console.ReadLine();
                        Console.Write("Skriv in litermängd: ");
                        Havremjolk.litermangd = Console.ReadLine();

                        string strHavre = $"Fetthalt: {Havremjolk.fetthalt}, Längd: {Havremjolk.litermangd}";

                        lsHavre.Add(strHavre);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Kundvagnen innehåller ({0} Bilar, {1} Godisar, {2} Rör, {3} Havremjölk): ", lsBilar.Count, lsGodis.Count, lsRor.Count, lsHavre.Count);
                        Console.WriteLine();

                        int countBil = 0;
                        foreach (string bil in lsBilar)
                        {
                            countBil++;
                            Console.WriteLine("-Bil {0}: {1}", countBil, bil);
                        }
                        int countGodis = 0;
                        foreach (string godis in lsGodis)
                        {
                            countGodis++;
                            Console.WriteLine("-Godis {0}: {1}", countGodis, godis);
                        }
                        int countRor = 0;
                        foreach (string ror in lsRor)
                        {
                            countRor++;
                            Console.WriteLine("-Rör {0}: {1}", countRor, ror);
                        }
                        int countHavre = 0;
                        foreach (string havre in lsHavre)
                        {
                            countHavre++;
                            Console.WriteLine("-Havremjölk {0}: {1}", countHavre, havre);
                        }
                        rtMeny:
                        Console.WriteLine();
                        Console.Write("Tryck på [m] för att gå tillbaka till menyn. ");
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
                        Console.WriteLine("Programmet avslutas... ");
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
