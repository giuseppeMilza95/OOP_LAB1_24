using System;

namespace OOPlab1 {
    class Program {
        static void Main(string[] args) {
            // Animal dog = new Animal();

            //dog.Name = "Szarik";

            //dog.Feed(2.0);

            // string text = dog.returnSpeciesAndName();
            //Console.WriteLine(text);
            // text += " afawefawfawe";
            // Console.WriteLine(text);

            //String nameAndOwner = dog.returnNameAndOwner("Kacper");
            // Console.WriteLine(nameAndOwner);

            // Human me = new Human();
            // me.FirstName = "Kacper";
            // me.LastName = "Warda";
            // me.Pet = dog;

            // dog.Feed(1.0);
            // dog.PrintWeight();

            // me.Phone = new Phone("onePlus",
            // "8Pro",
            //   2.3,
            // "Android");
            // Console.WriteLine(me.Phone.Model);

            // me.Phone = new Phone("apple", "6s", 5.0, "iOs");

            // Console.WriteLine(me.Phone.Model);

            Animal dog = new Animal(5);
            dog.TakeForAWalk(4);
            dog.Feed(1);

            Human giuseppe = new Human();
            giuseppe.Salary = 50000.0m;

            Car bmw = new Car();

            bmw.Engine = "Petrol";
            bmw.Make = "BMW";
            bmw.Model = " serie 1";
            bmw.Value = 2500;

            Console.WriteLine(bmw.ToString());

            
        }
    }
}
