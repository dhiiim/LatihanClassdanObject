using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasPraktikumClass_Object;

namespace praktek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek Taxi
            Taxi taxi = new Taxi();

            // Pengesetan Nilai Properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Pemanggilan Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}