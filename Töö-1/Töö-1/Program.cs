using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Loome näidisandmestiku
        var nimekiri = new[] {
      new { Nimi = "Denis", Vanus = 23 },
      new { Nimi = "Mark", Vanus = 35 },
      new { Nimi = "Treiman", Vanus = 29 },
      new { Nimi = "Väli", Vanus = 30 },
      new { Nimi = "Semmel", Vanus = 21 }
    };

        // Kasutame Skip meetodit, et vahele jätta esimesed kaks elementi
        var uusNimekiri = nimekiri.Skip(2);

        // Kasutame ThenByDescending meetodit, et sorteerida vanuse järgi alates suurimast
        var sorteeritudNimekiri = uusNimekiri.OrderByDescending(x => x.Vanus);

        // Väljastame tulemused
        Console.WriteLine("Uus nimekiri:");
        foreach (var nimi in uusNimekiri)
        {
            Console.WriteLine($"{nimi.Nimi}, {nimi.Vanus}");
        }

        Console.WriteLine("\nSorteeritud nimekiri:");
        foreach (var nimi in sorteeritudNimekiri)
        {
            Console.WriteLine($"{nimi.Nimi}, {nimi.Vanus}");
            //Skip: Meetod võtab parameetriks arvu n ja tagastab uue järjendi, kus on algse järjendi elemendid, kuid esimesed n elementi on vahele jäetud.

            //ThenByDescending: Meetod võtab parameetriks võrdlusefunktsiooni ja tagastab uue järjendi, kus elemendid on esialgu sorteeritud esimese võrdlemise järgi ja seejärel võrdlemise järgi, mida antakse meetodi parameetriks
        }
    }
}