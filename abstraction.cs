using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    public class Vehicles
    {
        string registration;
        string model;
        string brand;
        string name;

        public void setVehicle(string a1,string a2, string a3, string a4)
        {
            registration = a1;
            model = a2;
            brand = a3;
            name = a4;
        }

        public void printVehicle()
        {
            Console.WriteLine("registration number is: "+registration);
            Console.WriteLine("model is "+model);
            Console.WriteLine("brand is "+brand);
            Console.WriteLine("vehicle name is" + name);
        }
    }
    public class TwoWheelDrive : Vehicles
    {
        public void displayTwoWheel()
        {
            Console.WriteLine("Only two wheels are run by engine!\n");
        }
    }

    public class FourWheelDrive : Vehicles
    {
        public void displayFourWheel()
        {
            Console.WriteLine("All four wheels are run by engine!\n");
        }
    }
}
