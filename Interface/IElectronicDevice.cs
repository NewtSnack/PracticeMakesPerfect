using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
    interface ICommand
    {
        void Execute();
        void Undo();
    }
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("TV has been turned off");
        }

        public void On()
        {
            Console.WriteLine("TV has been turned on");
        }

        public void VolumeDown()
        {
            if (Volume !=0)
            {
                Volume--;
                Console.WriteLine($"The TV Volume is at {Volume}");
            }
        }

        public void VolumeUp()
        {
            if (Volume < 100)
            {
                Volume++;
                Console.WriteLine($"The TV Volume is at {Volume}");

            }
        }
    }
    class DVDPlayer : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("DVD Player has been turned Off");
        }

        public void On()
        {
            Console.WriteLine("DVD Player has been turned On");

        }

        public void VolumeDown()
        {
            if (Volume != 0)
            {
                Volume--;
                Console.WriteLine($"The TV Volume is at {Volume}");
            }
        }

        public void VolumeUp()
        {
            if (Volume < 10)
            {
                Volume++;
                Console.WriteLine($"The TV Volume is at {Volume}");
            }
        }
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
    class DVDPlayerRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new DVDPlayer();
        }
    }
}
