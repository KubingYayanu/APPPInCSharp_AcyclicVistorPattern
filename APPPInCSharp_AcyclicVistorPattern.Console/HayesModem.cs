namespace APPPInCSharp_AcyclicVistorPattern
{
    public class HayesModem : Modem
    {
        public string ConfigurationString { get; set; }

        public void Accept(ModemVisitor v)
        {
            if (v is HayesModemVisitor)
            {
                (v as HayesModemVisitor).Visit(this);
            }
        }

        public void Dial(string pno)
        {
        }

        public void Hangup()
        {
        }

        public char Receive() => (char)0;

        public void Send(char c)
        {
        }
    }
}