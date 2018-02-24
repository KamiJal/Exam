using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Devices
{
    public partial class DeviceManager
    {

        public void Menu()
        {
            bool run = true;
            while (run)
            {
                string input = "";
                while (!Regex.IsMatch(input, @"^[1-5]{1}$"))
                {
                    Console.Clear();
                    Console.WriteLine("Device Manager Menu");
                    Console.WriteLine("1. Add device");
                    Console.WriteLine("2. Remove device");
                    Console.WriteLine("3. Edit device");
                    Console.WriteLine("4. Search device");
                    Console.WriteLine("5. Try Load From File");
                    Console.WriteLine("6. Exit menu");
                    input = Console.ReadLine();
                }

                switch (input)
                {
                    case "1": AddDevice(); break;
                    case "2": RemoveMenu(); break;
                    case "3": EditInsideMenu(); break;
                    case "4": SearchMenu(); break;
                    case "5": LoadFromFile(); break;
                    case "6": SaveToFile(); run = false; break;
                }
            }

        }

        private void RemoveMenu()
        {
            bool run = true;

            while (run)
            {
                string input = "";
            while (!Regex.IsMatch(input, @"^[1-3]{1}$"))
            {
                Console.Clear();
                Console.WriteLine("Device Delete Menu");
                Console.WriteLine("1. Delete by ID");
                Console.WriteLine("2. Delete by name");
                Console.WriteLine("3. Exit menu");
                input = Console.ReadLine();
            }
                switch (input)
                {
                    case "1": RemoveByID(); break;
                    case "2": RemoveByName(); break;
                    case "3": run = false; break;
                }
            }
        }

        private void EditMenu()
        {
            bool run = true;

            while (run)
            {
                string input = "";
                while (!Regex.IsMatch(input, @"^[1-3]{1}$"))
                {
                    Console.Clear();
                    Console.WriteLine("Device Edit Menu");
                    Console.WriteLine("1. Edit (search by ID)");
                    Console.WriteLine("2. Edit (search by name)");
                    Console.WriteLine("3. Exit menu");
                    input = Console.ReadLine();
                }
                switch (input)
                {
                    case "1": EditByID(); break;
                    case "2": EditByName(); break;
                    case "3": run = false; break;
                }
            }
        }

        private void SearchMenu()
        {
            bool run = true;

            while (run)
            {
                string input = "";
                while (!Regex.IsMatch(input, @"^[1-4]{1}$"))
                {
                    Console.Clear();
                    Console.WriteLine("Device Search Menu");
                    Console.WriteLine("1. Show all devices");
                    Console.WriteLine("2. Search by type");
                    Console.WriteLine("3. Search by name");
                    Console.WriteLine("4. Exit menu");
                    input = Console.ReadLine();
                }

                switch (input)
                {
                    case "1": Print(); break;
                    case "2": Print(UserTypeSelector()); break;
                    case "3": string name = AskName(); Print(name); break;
                    case "4": run = false; break;
                }
            }
        }



        private TYPE UserTypeSelector()
        {

            string input = "";
            while (!Regex.IsMatch(input, @"^[1-6]{1}$"))
            {
                Console.Clear();
                Console.WriteLine("Please choose device type:");
                Console.WriteLine("1. PC\n2. PRINTER\n3. SCANER\n4. COPIER\n5. MODEM\n6. ROUTER");
                input = Console.ReadLine();
            }

            return DeviceTypes[input];
        }

        private void EditInsideMenu()
        {
            bool run = true;

            while (run)
            {
                string input = "";
                while (!Regex.IsMatch(input, @"^[1-5]{1}$"))
                {
                    Console.Clear();
                    Console.WriteLine("What would you like to change");
                    Console.WriteLine("1. ID");
                    Console.WriteLine("2. Name");
                    Console.WriteLine("3. Warranty");
                    Console.WriteLine("4. Price");
                    Console.WriteLine("5. Exit menu");
                    input = Console.ReadLine();
                }

                switch (input)
                {
                    case "1": EditByName(); break;
                    case "2": EditByID(); break;
                    case "3": EditByWarranty(); break;
                    case "4": EditByPrice(); break;
                    case "5": run = false; break;
                }
            }
        }


    }
}
