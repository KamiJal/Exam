using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    [Serializable]

    
    public class PC : Device
    {
        public PC() { }
        public PC(TYPE type, string ID, string name, DateTime warranty, double price) : base(type, ID, name, warranty, price)
        {

        }
    }
}
