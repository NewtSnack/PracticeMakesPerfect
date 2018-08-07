using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }
        
        public Vehicle(string brand = "No Brand", int wheels = 0, int speed = 0)
        {
            Brand = brand;
            Speed = speed;
            Wheels = wheels;
        }
        public void Move()
        {
            Console.WriteLine($"The {Brand} moves foward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops");
        }
    }
}
