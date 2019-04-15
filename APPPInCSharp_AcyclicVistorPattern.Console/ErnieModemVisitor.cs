namespace APPPInCSharp_AcyclicVistorPattern
{
    public interface ErnieModemVisitor : ModemVisitor
    {
        void Visit(ErnieModem m);
    }
}