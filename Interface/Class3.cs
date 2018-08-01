using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Animal
    {
        private string name;
        private string sound;

        public const string SHELTER = "Derek's Home for Animals";
        //set at run-time inside consructors, can't be changed
        public readonly int idNum;
        
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        public Animal()
            : this("No Name", "No Sound") { } // :this calls the main constructor
        public Animal(string name)
            : this(name, "No Sound") { }
        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random rnd = new Random();
            idNum = rnd.Next(1, 123123450);
        }
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }
        //Getter without using properties
        public string GetName()
        {
            return name;
        }
        //Getter by using properties
        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;

                }
            }
        }

        public string Owner { get; set; } = "No Owner"; //default field

        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
           
        
    }
}
