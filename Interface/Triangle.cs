using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public struct Triangle<T>
    {
        private T basetri;
        private T width;

        public T Width
        {
            get { return width; }
            set { Width = value; }
        }
        public T Base
        {
            get { return basetri; }
            set { Base = value; }
        }
        public Triangle(T w, T b)
        {
            width = w;
            basetri = b;
        }
        public string GetArea()
        {
            double dblWidth = Convert.ToDouble(Width);
            double dblBase = Convert.ToDouble(Base);
            return string.Format($"{Width} * {Base} * 1/2 = {.5 * dblBase * dblWidth} ");
        }
    }
    
}
