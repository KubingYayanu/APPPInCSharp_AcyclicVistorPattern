namespace APPPInCSharp_AcyclicVistorPattern
{
    public interface HayesModemVisitor : ModemVisitor
    {
        void Visit(HayesModem m);
    }
}