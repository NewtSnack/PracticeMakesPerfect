using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Shoe
    {
        public string Name { get; set; }
        public Shoe(string name = "No Name")
        {
            Name = name;
        }
    }
    class ShoeFarm : IEnumerable
    {
        private List<Shoe> shoeList = new List<Shoe>();
        public ShoeFarm(List<Shoe> shoeList)
        {
            this.shoeList = shoeList;
        }

        public ShoeFarm()
        {

        }

        public Shoe this[int index] //indexer
        {
            get{return (Shoe)shoeList[index]; }
            set { shoeList.Insert(index, value); }
        }
        public int Count
        {
            get { return shoeList.Count; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return shoeList.GetEnumerator();
        }
    }
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box() //if nothing is passed
            : this(1, 1, 1) { }
        public Box(double l, double w, double b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return newBox;
        }
        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return newBox;
        }
        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length)&& (box1.Width == box2.Width)&&(box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) || (box1.Width != box2.Width) || (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("Box with Height : {0} Width : {1} Breadth : {2}", Length, Width, Breadth);
        }

        public override bool Equals(object obj)
        {
            var box = obj as Box;
            return box != null &&
                   Length == box.Length &&
                   Width == box.Width &&
                   Breadth == box.Breadth;
        }

        public override int GetHashCode()
        {
            var hashCode = -1310040851;
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Breadth.GetHashCode();
            return hashCode;
        }

        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }
        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}
