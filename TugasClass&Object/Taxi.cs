using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikumClass_Object
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            if (OnDuty)
            {
                Console.WriteLine("On Duty: Yes");
            }
            else
            {
                Console.WriteLine("On Duty: NO");
            }
            Console.WriteLine("Number of Pessenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
        }
    }
}
