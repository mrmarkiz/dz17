using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz17
{
    internal static class MyExtensions
    {
        public static void Show<T>(List<T> items)
        {
            Console.WriteLine(string.Join("\n", items));
        }

        public static List<Firm> FindFoodInName(List<Firm> firms)
        {
            return firms.Where(firm => firm.Name.Contains("Food") == true).ToList();
        }

        public static List<Firm> MarketingProfile(List<Firm> firms)
        {
            return firms.Where(firm => firm.Profile == "Marketing").ToList();
        }

        public static List<Firm> MarketingOrITProfile(List<Firm> firms)
        {
            return firms.Where(firm => firm.Profile == "Marketing" || firm.Profile == "IT").ToList();
        }

        public static List<Firm> WorkersCountMore(List<Firm> firms, int num)
        {
            return firms.Where(firm => firm.workers.Count > num).ToList();
        }

        public static List<Firm> WorkersCountDiap(List<Firm> firms, int bound1, int bound2)
        {
            return firms.Where(firm => firm.workers.Count > bound1 && firm.workers.Count < bound2).ToList();
        }

        public static List<Firm> LondonFirms(List<Firm> firms)
        {
            return firms.Where(firm => firm.Adress == "London").ToList();
        }

        public static List<Firm> DirectorMrWhite(List<Firm> firms)
        {
            return firms.Where(firm => (firm.DirectorPib.Split(' '))[1] == "White").ToList();
        }

        public static List<Firm> FirmOlderTwoYears(List<Firm> firms)
        {
            return firms.Where(firm => (DateTime.Now - firm.FoundationDate).TotalDays >= 730).ToList();
        }

        public static List<Firm> FirmOlder123Days(List<Firm> firms)
        {
            return firms.Where(firm => (DateTime.Now - firm.FoundationDate).TotalDays > 123).ToList();
        }

        public static List<Firm> DirectorMrBlackFirmNameHasWhite(List<Firm> firms)
        {
            return firms.Where(firm => (firm.DirectorPib.Split(' '))[1] == "Black" && firm.Name.Contains("White") == true).ToList();
        }

        public static List<Worker> WorkerWithBiggerSal(List<Worker> workers, double num)
        {
            return workers.Where(worker => worker.Salary > num).ToList();
        }

        public static List<Worker> WorkerManager(List<Worker> workers)
        {
            return workers.Where(worker => worker.Position == "Manager").ToList();
        }

        public static List<Worker> WorkerPhoneStartWith23(List<Worker> workers)
        {
            return workers.Where(worker => worker.Phone.StartsWith("23")).ToList();
        }

        public static List<Worker> WorkerEmailStartWithdi(List<Worker> workers)
        {
            return workers.Where(worker => worker.Email.StartsWith("di")).ToList();
        }

        public static List<Worker> WorkerWithNameLionel(List<Worker> workers)
        {
            return workers.Where(worker => (worker.Pib.Split(' '))[0] == "Lionel").ToList();
        }
    }
}