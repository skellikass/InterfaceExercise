using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int NumberOfWindows { get; set; }
        public string TypeOfRearEnd { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Has4WheelDrive { get; set; }
        public string Has4WheelDriveMethod()
        {
            if (Has4WheelDrive == true)
            {
                return "It has 4-wheel drive as well.";
            }
            else
            {
                return "However, it has no 4-wheel drive.";
            }
        }

        public string Name { get; set; }
        public string Slogan { get; set; }

        public double BedSize { get; set; }
        public bool HasSecondRowOfSeats { get; set; }
        public string HasSecondRowOfSeatsMethod()
        {
            if (HasSecondRowOfSeats == true)
            {
                return "It also has a second row of seats.";
            }
            else
            {
                return "However, it has no second row of seats.";
            }
        }

        public void PrintTruckDetails()
        {
            Console.WriteLine($"{Slogan}: The {Name} has {NumberOfWindows} windows and can carry {PassengerCapacity} passengers.  It has a {TypeOfRearEnd} \n" +
                $"that is {BedSize} inches.  {HasSecondRowOfSeatsMethod()}  {Has4WheelDriveMethod()}");
        }
    }
}
