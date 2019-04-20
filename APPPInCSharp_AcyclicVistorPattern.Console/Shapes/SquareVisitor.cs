namespace APPPInCSharp_AcyclicVistorPattern
{
    public interface SquareVisitor : ShapeVisitor
    {
        void Visit(Square s);
    }
}