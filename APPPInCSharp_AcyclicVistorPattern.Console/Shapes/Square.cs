namespace APPPInCSharp_AcyclicVistorPattern
{
    public class Square : Shape
    {
        public override void Accept(ShapeVisitor v)
        {
            if (v is SquareVisitor)
            {
                (v as SquareVisitor).Visit(this);
            }
        }

        public override void Draw()
        {
        }
    }
}