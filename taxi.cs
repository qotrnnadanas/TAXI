using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class taxi
    {

        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }

        private string ondutyesorno()
        {
            return onduty ? "yes" : "no";
        }

        public void taxiinfo()
        {
            Console.WriteLine("Driver Name\t\t: {0}", drivername);
            Console.WriteLine("On Duty\t\t\t: {0}", ondutyesorno());
            Console.WriteLine("Number of Passenger\t: {0}", numpassenger);
            Console.WriteLine("\n");
        }
        public void pickuppassenger()
        {
            if (onduty)
            {
                Console.WriteLine("{0} sedang menjemput penumpang", drivername);
            }
            else
            {
                Console.WriteLine("{0} sedang tidak menjemput penumpang", drivername);
            }
        }
        public void dropoffpassenger()
        {
            if (onduty)
            {
                Console.WriteLine("{0} selesai mengantar penumpang", drivername);
            }
            else
            {
                Console.WriteLine("{0} sedang menunggu penumpang", drivername);
            }
        }

    }
}