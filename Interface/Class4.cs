using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice
{
    class AnimalSealed
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDinfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum,
            string owner)
        {
            animalIDinfo.IDNum = idNum;
            animalIDinfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} had the ID of {animalIDinfo.IDNum} and it owned by {animalIDinfo.Owner}");
        }
        public virtual void MakeSound() //virtual so now subclasses can override
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public AnimalSealed()
            :this("No Name","No Sound") { }
        public AnimalSealed(string name)
            :this(name, "No Sound") { }
       public AnimalSealed(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        //properties
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                else
                {
                    name = value;
                }

            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                else
                {
                    sound = value;
                }

            }
        }
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }
    }
    class Dog : AnimalSealed
    {
        public string Sound2 { get; set; } = "Grrr";

        public override void MakeSound()
        {
             Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound 2")
            :base(name, sound)
        {
            Sound2 = sound2;
        }
    }
    class AnimalIDInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No Owner";
    }

}
