using System;

namespace APPPInCSharp_AcyclicVistorPattern
{
    public abstract class Shape : IComparable
    {
        public int Priotity { get; set; }

        public int CompareTo(object obj)
        {
            var shape = obj as Shape;
            return Priotity.CompareTo(shape.Priotity);
        }

        public abstract void Draw();
        public abstract void Accept(ShapeVisitor v);
    }
}