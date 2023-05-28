using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz17
{
    internal class Firm
    {
        public static string[] Names =
        {
            "White Food",
            "McDac",
            "Shiny White",
            "Gus",
            "Home Food",
            "LG",
            "Food Riders",
            "Truncy White"
        };

        public static string[] Profiles =
        {
            "Marketing",
            "Electronics",
            "Marketing",
            "Food",
            "Marketing",
            "CEO",
            "Restaurant"
        };

        public static string[] PIBs =
        {
            "Walter White",
            "Emma Black",
            "Lionel White",
            "John Brown",
            "Antony Black",
            "Lionel Black",
            "Mikel Dillan",
            "Sam White",
            "Josh Black",
            "Peter White",
        };

        public static string[] Adresses =
        {
            "London",
            "New Jercy",
            "New York",
            "London"
        };

        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Profile { get; set; }
        public string DirectorPib { get; set; }
        public List<Worker> workers { get; set; }
        public string Adress { get; set; }

        public Firm(string name, DateTime foundationDate, string profile, string directorPib, List<Worker> workers, string adress)
        {
            Name = name;
            FoundationDate = foundationDate;
            Profile = profile;
            DirectorPib = directorPib;
            this.workers = workers;
            Adress = adress;
        }

        public Firm(Random rnd, int workCount)
        {
            Name = Names[rnd.Next(Names.Length)];
            FoundationDate = new DateTime(rnd.Next(2021, 2024), rnd.Next(1, 6), rnd.Next(1, 28));
            Profile = Profiles[rnd.Next(Profiles.Length)];
            DirectorPib = PIBs[rnd.Next(PIBs.Length)];
            workers = new List<Worker>(workCount);
            for (int i = 0; i < workers.Capacity; i++)
            {
                workers.Add(new Worker(rnd));
            }
            Adress = Adresses[rnd.Next(Adresses.Length)];
        }

        public override string ToString()
        {
            return $"Name: {Name}, Foundation date: {FoundationDate.ToShortDateString()}, Profile: {Profile}, Director PIB: {DirectorPib}, Workers count: {workers.Count}, Adress: {Adress}";
        }
    }
}
