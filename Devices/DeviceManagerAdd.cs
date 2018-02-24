using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

namespace Devices
{
    public partial class DeviceManager
    {
        public void AddDevice()
        {
            TYPE type = UserTypeSelector();
            string ID = AskID();
            string name = AskName();
            DateTime warranty = AskDateTime();
            double price = AskPrice();

            CreateDevice createGivenDevice = CreateCustomDeviceDelegate(type);
            Devices.Add(createGivenDevice(type, ID, name, warranty, price));

            Console.Clear();
            Console.WriteLine("New {0} was successfully added!", type.ToString().ToLower());
            Thread.Sleep(2000);
        }
    }
}
