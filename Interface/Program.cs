using System;
using System.Collections;
using System.Collections.Generic;

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
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }
            IElectronicDevice TV = TVRemote.GetDevice();
            IElectronicDevice DVDPlayer = DVDPlayerRemote.GetDevice();


            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();

            PowerButton powBut2 = new PowerButton(DVDPlayer);
            powBut2.Execute();

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
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach(Shape s in shapes)
            {
                s.getInfo();
                Console.WriteLine("The {0} Area : {1:f2}", s.Name, s.Area());
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }
                if(s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle.");
                }
                Console.WriteLine();                
            }
            object circ1 = new Circle(4);
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
            Console.ReadKey();

            Console.WriteLine("Class 11");
            //Collections: ArrayLists, Dictionaries, Queues and Stacks
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(1, "Turkey");
            ArrayList range = aList2.GetRange(0, 2);

            foreach(object o in range)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));
            string[] myArray = (string[])aList2.ToArray(typeof(string)); //arraylist to a string array

            string[] customers = { "Bob", "Sally", "Sue" };

            ArrayList cusArrayList = new ArrayList();
            cusArrayList.AddRange(customers);

            foreach(string s in cusArrayList)
            {
                Console.WriteLine(s);
            }
            //Dictionary           
            Console.ReadLine();
            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "The Flash");
            superheroes.Remove("Barry West");
            Console.WriteLine("Count : {0}", superheroes.Count);
            Console.WriteLine("Clark Kent : {0}", superheroes.ContainsKey("Clark Kent"));

            superheroes.TryGetValue("Clark Kent", out string test);
            Console.WriteLine($"Clark Kent : {test}");

            foreach(KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            Console.ReadLine();
            //Queue
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach(object o in queue)
            {
                Console.WriteLine($)
            }
        }


    }
}
