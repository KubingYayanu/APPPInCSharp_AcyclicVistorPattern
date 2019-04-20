namespace APPPInCSharp_AcyclicVistorPattern
{
    public class Circle : Shape
    {
        public override void Accept(ShapeVisitor v)
        {
            if (v is CircleVisitor)
            {
                (v as CircleVisitor).Visit(this);
            }
        }

        public override void Draw()
        {
        }
    }
}