namespace APPPInCSharp_AcyclicVistorPattern
{
    public class UnixModemConfigurator : HayesModemVisitor, ZoomModemVisitor, ErnieModemVisitor
    {
        public void Visit(HayesModem m)
        {
            m.ConfigurationString = "&s1=4&D=3";
        }

        public void Visit(ZoomModem m)
        {
            m.ConfigurationValue = 42;
        }

        public void Visit(ErnieModem m)
        {
            m.InternalPattern = "C is too slow";
        }
    }
}