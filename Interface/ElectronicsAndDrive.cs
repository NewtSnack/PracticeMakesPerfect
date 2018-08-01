using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class ElectronicsAndDrive
    {
        public interface IDrivable
        {
            int Wheels { get; set; }
            double Speed { get; set; }
            void Move();
            void Stop();

        }
        public class Vehicle : IDrivable
        {
            public string Brand { get; set; }
            public int Wheels { get; set; }
            public double Speed { get; set; }

            public void Move()
            {
                Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH");
            }
            public Vehicle(string brand = "No Brand",
                int wheels = 0,
                double speed = 0)
            {
                Brand = brand;
                Wheels = wheels;
                Speed = speed;
            }

            public void Stop()
            {
                Console.WriteLine($"The {Brand} Stops.");
                Speed = 0;
            }

        }
    }
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is off");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;

            Console.WriteLine($"The TV Volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;

            Console.WriteLine($"The TV Volume is at {Volume}");
        }
    }
    interface ICommand
    {
        void Execute();
        void Undo();
    }
    class PowerButton : ICommand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
