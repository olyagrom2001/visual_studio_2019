using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    abstract class Figure : IComparable
    {
        public string Type { get; protected set; }
        public abstract string FigureName { get; }
        public abstract double Area();
        public int CompareTo(object obj)
        {
            Figure f = (Figure)obj;
            if (this.Area() < f.Area()) return -1;
            else if (this.Area() == f.Area()) return 0;
            else return 1;
        }

    }
}
