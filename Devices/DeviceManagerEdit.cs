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
        private void EditByID()
        {

            string ID = AskID();
            if (!CheckByID(ID))
                return;

            Devices.Where(device => device.ID.Equals(ID)).ElementAt(0).ID = ID;

            Console.WriteLine("Device with ID {0} was modified!", ID);
            Thread.Sleep(3000);
        }

        private void EditByName()
        {
            string name = AskName();
            if (!CheckByName(name))
                return;

            Devices.Where(device => device.ID.Equals(name)).ElementAt(0).name = name;
            Console.WriteLine("Device with name {0} was modified!", name);
            Thread.Sleep(3000);
        }

        private void EditByWarranty()
        {
            DateTime warranty = AskDateTime();
            if (!CheckByWarranty(warranty))
                return;

            Devices.Where(device => device.warranty == warranty).ElementAt(0).warranty = warranty;

            Console.WriteLine("Device with warranty {0} was modified!", warranty.ToString("dd.MM.yyyy"));
            Thread.Sleep(3000);
        }

        private void EditByPrice()
        {
            double price = AskPrice();
            if (!CheckByPrice(price))
                return;

            Devices.Where(device => device.price == price).ElementAt(0).price = price;

            Console.WriteLine("Device with price {0:N2} was modified!", price);
            Thread.Sleep(3000);
        }
    }
}
