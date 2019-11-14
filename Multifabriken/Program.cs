using System;

namespace Multifabriken
{

    class Program
    {
        static void Main(string[] args)
        {
            
            meny Meny = new meny();
            avslut Avslut = new avslut();
            standard Standard = new standard();

            bilar Bilar = new bilar();
            godis Godis = new godis();
            ror Ror = new ror();
            havremjolk Havremjolk = new havremjolk();

            for ( ; ; )
            {
                
                Meny.presentMeny();

                switch(Meny.val)
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
                            break;
                        }
                        else
                        {
                            goto rtMeny;
                        }
                    case "6":
                        Avslut.avslutaProg();
                        return;
                    default:
                        Standard.standardVal();
                        break;
                }
            }
        }
    }
}
