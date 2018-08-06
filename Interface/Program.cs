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

            //grover.Sound = "WOOOOOOOOOOOOOF";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Su");
            grover.SetAnimalIDInfo(12346, "Jimmy James");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            AnimalSealed.AnimalHealth getHealth = new AnimalSealed.AnimalHealth();
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11,146));

            AnimalSealed monkey = new AnimalSealed()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            AnimalSealed spot = new Dog() //polymorphism
            {
                Name = "Spot",
                Sound = "Wooof",
                Sound2 = "Geeeerr"
            };

            monkey.MakeSound();
            spot.MakeSound(); // use virtual to make this call the correct MakeSound();



            Console.ReadLine();

            Console.WriteLine("Class 8");
            //OOP Fighting
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);
            Battle.StartFight(maximus, bob);
            Console.ReadLine();

            Console.WriteLine("Class 9");
            //Abstract classes, Abstract Methods, Base Classes, Is As, Casting, Polymorphism

            Console.ReadKey();
        }


    }
}
