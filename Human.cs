using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Human {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        private Car car;
        private decimal salary;

        DateTime modificationDate = DateTime.Now;

        public decimal Salary {
            get {
                Console.WriteLine($"Time modification:  { modificationDate} ");
                return salary;

            }
            set {
                if (value > 0)
                {

                    salary = value;
                    Console.WriteLine(modificationDate);
                    modificationDate = DateTime.Now;
                    Console.WriteLine("The amount has been added succefully " + $"Time modification:  { modificationDate} ");

                }
            }
        }


        public Car Car {

            get { return car; }


            set { if (Salary >= car.Value)
                {
                    Console.WriteLine("You do not have enaugh money"); 

                }
                

            else if (car.Equals(car)) {

                    Console.WriteLine("You are adding the same car");
                }

                else
                {
                    car = value;
                    Console.WriteLine("You have enough money to buy the car");

                }



            }

        }

        


      

    }
}
