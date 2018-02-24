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

        private delegate Device CreateDevice(TYPE type, string ID, string name, DateTime warranty, double price);

        private static Dictionary<string, TYPE> DeviceTypes = new Dictionary<string, TYPE>() 
            { {"1", TYPE.PC }, {"2", TYPE.PRINTER }, {"3", TYPE.SCANER}, {"4", TYPE.COPIER }, {"5", TYPE.MODEM }, {"6", TYPE.ROUTER }};

        public List<Device> Devices;


        public DeviceManager()
        {
            Devices = new List<Device>();
        }






    }
}
