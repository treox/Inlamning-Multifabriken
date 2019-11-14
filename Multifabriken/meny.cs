using System;

namespace Multifabriken
{
    class meny
    {
        public string val; 

        public void presentMeny()
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
        }
    }
}