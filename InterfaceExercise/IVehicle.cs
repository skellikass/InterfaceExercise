using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */

        public int NumberOfWindows { get; set; }
        public string TypeOfRearEnd { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Has4WheelDrive { get; set; }
    }
}
