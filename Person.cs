using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp
{
    class Person
    {
        private string name;
        private House house;

        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }

        public void ShowData()
        {
            Console.WriteLine($"My name is {name}. I have a house.");
            house.ShowData();
            Console.WriteLine("My house has a door.");
            house.GetDoor();
        }
    }
}
