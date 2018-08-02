using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //public private, protected Constants, Read-Only, Constructors, Setters, Getters, Properties and Static Fields
            Console.WriteLine("Class 6");
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Derek";

            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner); 
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals); //static var belong to class

            Animal fox = new Animal("Oscar", "Whatthefoxsaaaaay");
            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);



            Console.ReadKey(true);

            Console.WriteLine("Class 10");
            ElectronicsAndDrive.Vehicle buick = new ElectronicsAndDrive.Vehicle("Buick", 4, 160);

            if (buick is ElectronicsAndDrive.IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();

            Console.ReadLine();

            //Protected, Inheritance, Delegates, Super Classes, Polymorphism, Virtual, Override, Inner Classes 
            Console.WriteLine("Class 7");
            AnimalSealed whiskers = new AnimalSealed()
            {
                Name = "Whiskers",
                Sound = "Meow"

            };
            Dog grover = new Dog()
            {
                Name = "Groover",
                Sound = "Woof",
                Sound2 = "Bark"

            };

            grover.Sound = "WOOOOOOOOOOOOOF";

            whiskers.MakeSound();
            grover.MakeSound();



            Console.ReadLine();
        }

        
    }
}
