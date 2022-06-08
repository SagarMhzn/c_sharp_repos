using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    class BankAccount
    {
        private string accno;
        private string accname;
        private string address;
        private double balance;

        //creating a method to set its values

        public void setDetails(string a1, string a2, string a3, double a4)
        {
            accno = a1;
            accname = a2;
            address = a3;
            balance = a4;
        }

        public void displayDetails()
        {
            Console.WriteLine("your account number is "+ accno);
            Console.WriteLine("your account name is " + accname);
            Console.WriteLine("your address is " + address);
            Console.WriteLine("your account balance is " + balance);
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            /*BankAccount acc1 = new BankAccount();
            //acc1.accno = "122"; //cannot be accessed

            acc1.setDetails("1010", "Ram Prasad", "jamal", 120000.53);
            acc1.displayDetails();


            Calculation c = new Calculation();
            //calling calc funtion with integer values
            c.calc(1, 2);
            //calling calc funtion with double values
            c.calc(1.5, 3.69);

            Student student1 = new Student();
            
            Student student2 = new Student(13, "jake", "texas", "male", "BSc.CSIT");
            student2.displayInfo();

            TwoWheelDrive t1 = new TwoWheelDrive();
            t1.setVehicle("012", "2012", "hundai", "santro");
            t1.printVehicle();
            t1.displayTwoWheel();

            FourWheelDrive f1 = new FourWheelDrive();
            f1.setVehicle("012", "2012", "hundai", "santro");
            f1.printVehicle();
            f1.displayFourWheel();*/

            /*Demo d1 = new Demo();
            d1.getMultiplication(8, 3);
            d1.getMultiplication(5, 2);
            d1.getSum(10, 5);

            //creating reference of interface
            Calc c1;

            c1 = d1;

            c1.getMultiplication(2, 3);
            c1.getMultiplication(2, 2);
            c1.getSum(4, 5);

            PracticalDemo pd = new PracticalDemo();
            pd.findNormalDIvision(50, 5);
            pd.findModulus(25, 5);

            AbstractDemo1 ad;
            ad = pd;
            ad.findNormalDIvision(50, 5);
            ad.findModulus(25, 5);  

            practical p = new practical();
            p.findsum(2, 3);
            p.findDivision(6, 3);
            p.findModulo(7, 3);
            p.finddifference(8, 3);

            Compute1 c1;
            c1 = p;
             c1.findsum(2, 3);
            c1.finddifference(6, 3);    

            Compute2 c2;
            c2 = p;
            c2.findDivision(6, 3);
            c2.findModulo(7, 3);

            PropertyExample propertyexample = new PropertyExample();
            propertyexample.Num1 = 45;
            propertyexample.Num2 = 50;


            Console.WriteLine(propertyexample.Num1);
            Console.WriteLine(propertyexample.Num2);*/

            // creating object of snake class and accessing methods of parent classes

            Snake s1 = new Snake();
            //accessing elements of animal class
            s1.Name = "Cobra";
            s1.Type = " venomous";
            //accessing elements of reptile class
            s1.Movement = "night";
            //accessing oen class element
            s1.VenomType = "NeuroToxin";
            Console.WriteLine("Name of Snake is "+s1.Name);
            Console.WriteLine("type of snake is "+s1.Type);
            Console.WriteLine("Its movement is "+s1.Movement);
            Console.WriteLine("Its has " + s1.VenomType +  " venom");

            //creating obkect of reptile class
            Reptile rp = new Reptile();
            rp.Name = "Russel Viper";
            rp.Type = "Venomous";

            rp.Movement = "day";

            //rp.VemonType = "hemotoxin"; reptile class cannot access snake class

            Console.WriteLine("Name of Snake is " + rp.Name);
            Console.WriteLine("type of snake is " + rp.Type);
            Console.WriteLine("Its movement is " + rp.Movement);

            //Creating object of Animal class
            Animal a1 = new Animal();
            a1.Name = "zebra";
            a1.Type = "trestrial";
            Console.WriteLine("Name of Animal is " + a1.Name);
            Console.WriteLine("type of animal is " + a1.Type);

        }


    }
}
