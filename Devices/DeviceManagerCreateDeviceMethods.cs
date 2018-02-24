using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    public partial class DeviceManager
    {

        private CreateDevice CreateCustomDeviceDelegate(TYPE key)
        {
            if (key == TYPE.PC)
                return delegate (TYPE type, string ID, string name, DateTime warranty, double price) { return new PC(type, ID, name, warranty, price); };

            if (key == TYPE.PRINTER)
                return delegate (TYPE type, string ID, string name, DateTime warranty, double price) { return new Printer(type, ID, name, warranty, price); };

            if (key == TYPE.COPIER)
                return delegate (TYPE type, string ID, string name, DateTime warranty, double price) { return new Copier(type, ID, name, warranty, price); };

            if (key == TYPE.SCANER)
                return delegate (TYPE type, string ID, string name, DateTime warranty, double price) { return new Scaner(type, ID, name, warranty, price); };

            if (key == TYPE.MODEM)
                return delegate (TYPE type, string ID, string name, DateTime warranty, double price) { return new Modem(type, ID, name, warranty, price); };


            return delegate (TYPE type, string ID, string name, DateTime warranty, double price) { return new Router(type, ID, name, warranty, price); };
        }


    }
}
