using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void getInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
    }
}
