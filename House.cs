using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp
{
    class House
    {
        private double area;
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                this.area = value;
            }
        }

        private Door door;
        public Door Door
        {
            get
            {
                return door;
            }
            set
            {
                this.door = value;
            }
        }

        public House(double area)
        {
            this.area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2.");
        }

        public void GetDoor()
        {
            door.ShowData();
        }
    }
}
