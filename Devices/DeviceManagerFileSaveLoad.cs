using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.Reflection;

namespace Devices
{
    public partial class DeviceManager
    {

        private void SaveToFile()
        {

            if (Devices.Count == 0)
            {
                Console.WriteLine("There is no devices to save!");
                Thread.Sleep(3000);
                return;
            }

            XmlSerializer formatter = new XmlSerializer(typeof(List<Device>));

            using (FileStream fs = new FileStream(String.Format("{0}\\devices.xml", Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)), FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Devices);

                Console.WriteLine("File successfully saved!");
                Thread.Sleep(3000);
            }
        }

        private void LoadFromFile()
        {

            if (!File.Exists("devices.xml"))
            {
                Console.WriteLine("Cannot load from file!");
                Thread.Sleep(3000);
                return;
            }
                

            XmlSerializer formatter = new XmlSerializer(typeof(List<Device>));

            using (FileStream fs = new FileStream("devices.xml", FileMode.Open))
            {

                List<Device> loaded = (List<Device>)formatter.Deserialize(fs);

                Devices = loaded.ToList();

                Console.WriteLine("File successfully loaded!");
                Thread.Sleep(3000);
            }
        }


    }
}
