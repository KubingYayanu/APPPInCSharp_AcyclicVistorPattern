namespace APPPInCSharp_AcyclicVistorPattern
{
    public interface Modem
    {
        void Dial(string pno);

        void Hangup();

        void Send(char c);

        char Receive();

        void Accept(ModemVisitor v);
    }
}