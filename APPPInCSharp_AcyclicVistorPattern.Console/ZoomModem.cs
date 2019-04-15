namespace APPPInCSharp_AcyclicVistorPattern
{
    public class ZoomModem : Modem
    {
        public int ConfigurationValue { get; set; }

        public void Accept(ModemVisitor v)
        {
            if (v is ZoomModemVisitor)
            {
                (v as ZoomModemVisitor).Visit(this);
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