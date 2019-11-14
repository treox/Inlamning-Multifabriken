using System;

namespace Multifabriken
{

    class Program
    {
        static void Main(string[] args)
        {
            
            meny Meny = new meny();
            avslut Avslut = new avslut();

            bilar Bilar = new bilar();
            godis Godis = new godis();
            ror Ror = new ror();
            havremjolk Havremjolk = new havremjolk();
    
            start1:
            Meny.presentMeny();
            start2:            
            Meny.val = Console.ReadLine();

            switch(Meny.val)
            {
                case "1":
                    Bilar.angeData();
                    Bilar.addToList();
                    goto start1;
                case "2":
                    Godis.angeData();
                    Godis.addToList();
                    goto start1;
                case "3":
                    Ror.angeData();
                    Ror.addToList();
                    goto start1;
                case "4":
                    Havremjolk.angeData();
                    Havremjolk.addToList();
                    goto start1;
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
                    Console.WriteLine("Välj [m] för att gå tillbaka till menyn. ");
                    Console.WriteLine();
                    rtMeny:
                    string retToMeny = Console.ReadLine();
                    if (retToMeny == "m")
                    {
                        goto start1;
                    }
                    else
                    {
                        goto rtMeny;
                    }
                case "6":
                    Avslut.avslutaProg();
                    return;
                default:
                    goto start2;
            }            
        }
    }
}
