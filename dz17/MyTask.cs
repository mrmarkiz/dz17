using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz17
{
    internal class MyTask
    {
        public static void Run()
        {
            Random rnd = new Random();
            List<Firm> firms = new List<Firm>();
            for (int i = 0; i < 9; i++)
            {
                firms.Add(new Firm(rnd, rnd.Next(10, 250)));
            }
            firms.Add(new Firm(rnd, 10));
            Console.WriteLine("All firms:");
            MyExtensions.Show<Firm>(firms);

            Console.WriteLine("\n\nFirms with 'Food' in name:");
            MyExtensions.Show<Firm>(MyExtensions.FindFoodInName(firms));

            Console.WriteLine("\n\nFirms with Marketing profile:");
            MyExtensions.Show<Firm>(MyExtensions.MarketingProfile(firms));

            Console.WriteLine("\n\nFirms with 100+ workers:");
            MyExtensions.Show<Firm>(MyExtensions.WorkersCountMore(firms, 100));

            Console.WriteLine("\n\nFirms with 100-300 workers:");
            MyExtensions.Show<Firm>(MyExtensions.WorkersCountDiap(firms, 100, 300));

            Console.WriteLine("\n\nFirms situated in London:");
            MyExtensions.Show<Firm>(MyExtensions.LondonFirms(firms));

            Console.WriteLine("\n\nFirms with director 'White' last name:");
            MyExtensions.Show<Firm>(MyExtensions.DirectorMrWhite(firms));

            Console.WriteLine("\n\nFirms founded more than 2 years ago:");
            MyExtensions.Show<Firm>(MyExtensions.FirmOlderTwoYears(firms));

            Console.WriteLine("\n\nFirms founded more than 123 days ego:");
            MyExtensions.Show<Firm>(MyExtensions.FirmOlder123Days(firms));

            Console.WriteLine("\n\nFirms with director 'White' last name and 'White' in name:");
            MyExtensions.Show<Firm>(MyExtensions.DirectorMrBlackFirmNameHasWhite(firms));

            Console.WriteLine("\n\n///////////////////////////////////////////////\nLast firm all workers:");
            MyExtensions.Show<Worker>(firms.Last().workers);

            Console.WriteLine("\n\nWorkers with salary bigger than 10 000:");
            MyExtensions.Show<Worker>(MyExtensions.WorkerWithBiggerSal(firms.Last().workers, 10_000));

            Console.WriteLine("\n\nWorkers with position Manager:");
            MyExtensions.Show<Worker>(MyExtensions.WorkerManager(firms.Last().workers));

            Console.WriteLine("\n\nWorkers with phone staring on 23:");
            MyExtensions.Show<Worker>(MyExtensions.WorkerPhoneStartWith23(firms.Last().workers));

            Console.WriteLine("\n\nWorkers with email starting with di:");
            MyExtensions.Show<Worker>(MyExtensions.WorkerEmailStartWithdi(firms.Last().workers));

            Console.WriteLine("\n\nWorkers with name Lionel:");
            MyExtensions.Show<Worker>(MyExtensions.WorkerWithNameLionel(firms.Last().workers));
        }
    }
}
