using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany    --DONE

            //Create 3 classes called Car , Truck , & SUV    --DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..    --DONE
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }    --DONE
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.    --DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values;    --DONE
            //Creatively display and organize their values

            Car BMW325i = new Car()
            {
                Name = "BMW 325i",
                Slogan = "The Ultimate Driving Machine",
                NumberOfWindows = 4,
                TypeOfRearEnd = "trunk",
                PassengerCapacity = 5,
                Has4WheelDrive = false,
                TrunkSize = 12,
                NumberOfDoors = 4
            };

            BMW325i.PrintCarDetails();
            Console.WriteLine();

            SUV subaruOutback = new SUV
            {
                Name = "Subaru Outback",
                Slogan = "Confidence in Motion",
                NumberOfWindows = 4,
                TypeOfRearEnd = "cargo hold",
                PassengerCapacity = 5,
                Has4WheelDrive = false,
                CargoHoldSize = 32.6,
                HasFoldableRearSeats = true
            };

            subaruOutback.PrintSUVDetails();
            Console.WriteLine();

            Truck fordF350 = new Truck
            {
                Name = "Ford F-350",
                Slogan = "Built for the road ahead",
                NumberOfWindows = 4,
                TypeOfRearEnd = "truck bed",
                PassengerCapacity = 6,
                Has4WheelDrive = true,
                BedSize = 98.4,
                HasSecondRowOfSeats = true
            };

            fordF350.PrintTruckDetails();
            Console.WriteLine();
        }
    }
}
