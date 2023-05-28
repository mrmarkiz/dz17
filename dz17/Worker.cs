using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz17
{
    internal class Worker
    {
        public static string[] PIBs =
        {
            "Lionel Johnson",
            "Emma Watson",
            "Lionel Harison",
            "John Brown",
            "Antony Brewson",
            "Lionel Peterson",
            "Mikel Dillan",
            "Sam White",
            "Josh Andrewson",
            "Lionel Vasovski",
        };

        public static string[] Positions =
        {
            "Subdirector",
            "Assistant",
            "Writer",
            "Programer",
            "Manager",
            "Hard worker",
            "Cleaner",
            "Manager"
        };

        public static string[] Phones =
        {
            "23-2345-345-345",
            "23-687-6867-678",
            "23-990-4564-123",
            "32-456-3565-877",
            "23-734-3456-875",
            "54-546-1236-546",
            "87-324-7563-892",
            "98-023-2423-657",
            "65-346-2349-001"
        };

        public static string[] Emails =
        {
            "disals_123@gmail.com",
            "digdjgldfj444@gmail.com",
            "ASfldkjw@gmail.com",
            "difractor@gmail.com",
            "kilser@gmail.com",
            "lionelessi@gmail.com",
            "distructor@gmail.com",
            "topManager333@gmail.com"
        };

        public string Pib { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Worker(Random rnd)
        {
            Pib = PIBs[rnd.Next(PIBs.Length)];
            Position = Positions[rnd.Next(Positions.Length)];
            Phone = Phones[rnd.Next(Phones.Length)];
            Email = Emails[rnd.Next(Emails.Length)];
            Salary = rnd.Next(5000, 20000);
        }

        public Worker(string pib, string position, string phone, string email, double salary)
        {
            Pib = pib;
            Position = position;
            Phone = phone;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"PIB: {Pib}, Position: {Position}, Phone: {Phone}, Email: {Email}, Salary: {Salary}";
        }
    }
}
