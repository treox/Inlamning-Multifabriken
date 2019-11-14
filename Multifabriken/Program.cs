using System;

namespace Multifabriken
{

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
