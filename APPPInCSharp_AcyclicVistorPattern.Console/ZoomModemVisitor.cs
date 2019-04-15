namespace APPPInCSharp_AcyclicVistorPattern
{
    public interface ZoomModemVisitor : ModemVisitor
    {
        void Visit(ZoomModem m);
    }
}