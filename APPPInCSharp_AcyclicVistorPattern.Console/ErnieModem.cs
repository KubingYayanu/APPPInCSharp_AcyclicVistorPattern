namespace APPPInCSharp_AcyclicVistorPattern
{
    public class ErnieModem : Modem
    {
        public string InternalPattern { get; set; }

        public void Accept(ModemVisitor v)
        {
            if (v is ErnieModemVisitor)
            {
                (v as ErnieModemVisitor).Visit(this);
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