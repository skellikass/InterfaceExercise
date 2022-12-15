using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
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

        public double CargoHoldSize { get; set; }
        public bool HasFoldableRearSeats { get; set; }
        public string HasFoldableRearSeatsMethod()
        {
            if (HasFoldableRearSeats == true)
            {
                return "has";
            }
            else
            {
                return "has no";
            }
        }

        public void PrintSUVDetails()
        {
            Console.WriteLine($"{Slogan}: The {Name} has {NumberOfWindows} windows and can carry {PassengerCapacity} passengers.  It has a {TypeOfRearEnd} \n" +
                $"that has a {CargoHoldSize} cubic feet capacity, which can be increased because it also {HasFoldableRearSeatsMethod()} foldable rear seats.  \n" +
                $"{Has4WheelDriveMethod()}");
        }
    }
}
