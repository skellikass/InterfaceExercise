using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
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

        public int TrunkSize { get; set; }
        public int NumberOfDoors { get; set; }

        public void PrintCarDetails()
        {
            Console.WriteLine($"{Slogan}: The {Name} has {NumberOfWindows} windows and {NumberOfDoors} doors, as well as a {TypeOfRearEnd} that is {TrunkSize} cubic feet, \n" +
                $"and it can carry {PassengerCapacity} passengers.  {Has4WheelDriveMethod()}");
        }
    }
}
