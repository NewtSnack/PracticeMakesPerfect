using System;
using System.Collections.Generic;
using System.Text;

namespace Electronics
{
    interface IElectricDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
    class Television : IElectricDevice
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
        IElectricDevice device;

        public PowerButton(IElectricDevice device)
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
    class TVremote
    {
        public static IElectricDevice GetDevice()
        {
            return new Television();
        }
    }
}
