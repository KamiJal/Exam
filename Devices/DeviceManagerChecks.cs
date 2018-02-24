using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Devices
{
    public partial class DeviceManager
    {
        private bool CheckByID(string ID)
        {
            if (!Devices.Exists(device => device.ID.Equals(ID)))
            {
                Console.Clear();
                Console.WriteLine("Sorry, no device with such ID was found!");
                Thread.Sleep(3000);
                return false;
            }

            return true;
        }


        private bool CheckByName(string name)
        {
            if (!Devices.Exists(device => device.name.Equals(name)))
            {
                Console.Clear();
                Console.WriteLine("Sorry, no device with such name was found!");
                Thread.Sleep(3000);
                return false;
            }

            return true;
        }

        private bool CheckByType(TYPE type)
        {
            if (!Devices.Exists(device => device.type == type))
            {
                Console.Clear();
                Console.WriteLine("Sorry, no device with such type was found!");
                Thread.Sleep(3000);
                return false;
            }

            return true;
        }

        private bool CheckByWarranty(DateTime warranty)
        {
            if (!Devices.Exists(device => device.warranty == warranty))
            {
                Console.Clear();
                Console.WriteLine("Sorry, no device with such warranty was found!");
                Thread.Sleep(3000);
                return false;
            }

            return true;
        }

        private bool CheckByPrice(double price)
        {
            if (!Devices.Exists(device => device.price == price))
            {
                Console.Clear();
                Console.WriteLine("Sorry, no device with such price was found!");
                Thread.Sleep(3000);
                return false;
            }

            return true;
        }
    }
}
