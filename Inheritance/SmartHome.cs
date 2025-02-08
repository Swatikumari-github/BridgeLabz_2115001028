//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inheritance
//{



//    class Program
//    {
//        static void Main()
//        {
//            Thermostat thermostat = new Thermostat("TH123", "Online", 22);
//            thermostat.DisplayStatus();
//        }
//    }

//    class Device
//    {
//        protected string DeviceId;
//        protected string Status;

//        public Device(string deviceId, string status)
//        {
//            DeviceId = deviceId;
//            Status = status;
//        }

//        public virtual void DisplayStatus()
//        {
//            Console.WriteLine($"Device ID: {DeviceId}");
//            Console.WriteLine($"Status: {Status}");
//        }
//    }

//    class Thermostat : Device
//    {
//        private int TemperatureSetting;

//        public Thermostat(string deviceId, string status, int temperatureSetting) : base(deviceId, status)
//        {
//            TemperatureSetting = temperatureSetting;
//        }

//        public override void DisplayStatus()
//        {
//            base.DisplayStatus();
//            Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
//        }
//    }



//}
