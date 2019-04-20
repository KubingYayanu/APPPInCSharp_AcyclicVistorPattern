namespace APPPInCSharp_AcyclicVistorPattern
{
    public interface CircleVisitor : ShapeVisitor
    {
        void Visit(Circle c);
    }
}