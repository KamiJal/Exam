using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Devices
{
    public partial class DeviceManager
    {
        private string AskID()
        {
            Console.Clear();
            Console.WriteLine("Please enter ID of device:");
            return Console.ReadLine();
        }

        private string AskName()
        {
            Console.Clear();
            Console.WriteLine("Please enter name of device:");
            return Console.ReadLine();
        }

        private DateTime AskDateTime()
        {
            DateTime warranty = DateTime.Now.AddYears(-11);
            string input = "";
            bool success = false;
            while (!success)
            {
                Console.Clear();
                Console.WriteLine("Please enter device warranty (like dd.mm.yyyy):");
                Console.WriteLine("Warranty year should be no older than {0}", DateTime.Now.AddYears(-10).Year);
                input = Console.ReadLine();

                if (!Regex.IsMatch(input, @"^\d{2}.\d{2}.\d{4}$"))
                    continue;
                if (!DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out warranty))
                    continue;

                success = warranty.Year > DateTime.Now.AddYears(-10).Year;
            }

            return warranty;
        }

        private double AskPrice()
        {
            string input = "";
            double price;
            while (!Double.TryParse(input, out price))
            {
                Console.Clear();
                Console.WriteLine("Please enter price");
                input = Console.ReadLine();
            }

            return price;
        }
    }
}
