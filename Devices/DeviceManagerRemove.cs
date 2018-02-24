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
        private void RemoveByID()
        {

            string ID = AskID();

            if (!CheckByID(ID))
                return;

            Devices.Remove(Devices.Where(device => device.ID.Equals(ID)).ElementAt(0));

            Console.WriteLine("Device with ID {0} was deleted!", ID);
            Thread.Sleep(3000);
        }

        private void RemoveByName()
        {
            string name = AskName();
            if (!CheckByName(name))
                return;

            Devices.Remove(Devices.Where(device => device.ID.Equals(name)).ElementAt(0));

            Console.WriteLine("Device with name {0} was deleted!", name);
            Thread.Sleep(3000);
        }
    }
}
