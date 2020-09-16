using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp
{
    class Door
    {
        private string color;
        
        public Door(string color)
        {
            this.color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}.");
        }
    }
}
