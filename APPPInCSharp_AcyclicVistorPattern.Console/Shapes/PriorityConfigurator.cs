namespace APPPInCSharp_AcyclicVistorPattern
{
    public class PriorityConfigurator : CircleVisitor, SquareVisitor
    {
        public void Visit(Circle c)
        {
            c.Priotity = 1;
        }

        public void Visit(Square s)
        {
            s.Priotity = 2;
        }
    }
}