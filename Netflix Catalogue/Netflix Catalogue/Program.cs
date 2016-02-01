using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie KillBill = new Movie("Kill Bill", 3, 111);
            Movie Hangover = new Movie("The Hangover", 4, 100);
            Movie Titanic = new Movie("Titanic", 3, 194);
            Movie BruceAlmighty = new Movie("Bruce Almighty", 4, 101);
            Movie ZombieLand = new Movie("Zombie Land", 4, 88);

            TVshow Friends = new TVshow("Friends");
            Episode One = new Episode(6);
            Episode Two = new Episode(7);
            Episode Three = new Episode(5);
            Episode Four = new Episode(8);
            Episode Five = new Episode(7);
            Friends.ep.Add(One);
            Friends.ep.Add(Two);
            Friends.ep.Add(Three);
            Friends.ep.Add(Four);
            Friends.ep.Add(Five);

            Console.WriteLine(Friends);


            All all = new All();
            all.titles.Add(Hangover);

            Action action = new Action();
            action.titles.Add(KillBill);
            action.titles.Add(Hangover);
            action.titles.Add(ZombieLand);
            action.titles.Add(Titanic);

            Comedy comedy = new Comedy();
            comedy.titles.Add(Hangover);
            comedy.titles.Add(BruceAlmighty);
            comedy.titles.Add(ZombieLand);

            Romance romance = new Romance();
            romance.titles.Add(Hangover);
            romance.titles.Add(Titanic);
            romance.titles.Add(BruceAlmighty);

            Console.WriteLine("---------------");
            View.Print(romance);

            Console.WriteLine("---------------");
            Console.WriteLine(Hangover);
            Console.WriteLine(Titanic);
            Console.WriteLine(BruceAlmighty);
            Console.ReadKey();
        }
    }
}
