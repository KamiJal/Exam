using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    [Serializable]
    public class Router : Device
    {
        public Router() { }
        public Router(TYPE type, string ID, string name, DateTime warranty, double price) : base(type, ID, name, warranty, price)
        {

        }
    }
}
