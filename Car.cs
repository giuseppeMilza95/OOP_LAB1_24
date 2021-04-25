using System;
namespace OOPlab1
{
    public class Car
    {
        public String Make;
        public String Model;
        public decimal Value;
        public String Engine;

        public override string ToString()
        {
            return "Make: " + Make + " Model: " + Model + " Value: " + " Engine: " + Engine;
        }

        public override bool Equals(object obj)
        {
            return Make.Equals(obj);
        }



    }
}
