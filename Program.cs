using System;

namespace HouseApp
{
    class Program
    {
//Write a Main to create a SmallApartment, a person to live in it, and to show the data of the person.

        static void Main(string[] args)
        {
            SmallApartment myApartment = new SmallApartment();
            myApartment.Door = new Door("blue");
            Person me = new Person("Angie", myApartment);
            me.ShowData();
        }
    }
}
