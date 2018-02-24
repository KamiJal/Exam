using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Devices
{
    [Serializable]
    [XmlInclude(typeof(PC))]
    [XmlInclude(typeof(Modem))]
    [XmlInclude(typeof(PC))]
    [XmlInclude(typeof(PC))]
    [XmlInclude(typeof(PC))]
    public abstract class Device
    {
        public TYPE type { get;  set; }
        public string ID { get;  set; }
        public string name { get;  set; }
        public DateTime warranty { get;  set; }
        public double price { get;  set; }

        public Device() { }

        public Device(TYPE type, string ID, string name, DateTime warranty, double price)
        {
            this.type = type;
            this.ID = ID;
            this.name = name;
            this.warranty = warranty;
            this.price = price;
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, ID: {1}\nName: {2}\nWarranty until: {3}\nPrice: {4:N2}",
                this.type.ToString().ToLower(), this.ID, this.name, this.warranty.ToString("dd.MM.yyyy"), this.price);
        }

    }
}
