using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Animal {
        public readonly string Species = "canis";
        public string Name;
        private double weight = 3.0;


        public Animal(int weight) {
            
            this.weight = weight;
        }

        public void PrintWeight() {
            Console.WriteLine(weight);
        }

        public void Feed(double foodWeight) {

            if (weight > 0)
            {
                weight += foodWeight;
                Console.WriteLine("thx for food, bro");
                Console.WriteLine("my weight is now " + weight);

            }
            else {
                Console.WriteLine("The animal is dead");

            }
            
        }

        public String returnSpeciesAndName() {
            return Species + " " + Name;
        }

        public String returnNameAndOwner(string owner) {
            return Name + " " + owner;
        }


        public void TakeForAWalk(double hours) {
            double reduceWeight = weight - hours;

            if ((reduceWeight) <= 0)
            {
                Console.WriteLine("The animal is dead");
                weight = reduceWeight;

            }
            else {
                this.weight -= hours;
                Console.WriteLine("The weight is " + weight);


            }


        }

    }
}
