using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object taxi
            taxi taxi = new taxi();

            //pengestan nilai propertis
            taxi.drivername = "Jono";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            //pemanggilan method
            taxi.taxiinfo();
            taxi.pickuppassenger();
            taxi.dropoffpassenger();

            Console.ReadKey();
        }
    }
}