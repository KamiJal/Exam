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
        private void Print()
        {
            foreach (var device in Devices)
                Console.WriteLine(device);

            Console.ReadKey();
        }

        private void Print(TYPE type)
        {
            if (!CheckByType(type))
                return;

            foreach (var device in Devices.Where(device => device.type == type))
                Console.WriteLine(device);

            Console.ReadKey();
        }

        private void Print(string name)
        {
            if (!CheckByName(name))
                return;

            foreach (var device in Devices.Where(device => device.name.Equals(name)))
                Console.WriteLine(device);

            Console.ReadKey();
        }
    }
}
