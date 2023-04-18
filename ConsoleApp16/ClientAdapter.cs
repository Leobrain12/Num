using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class ClientAdapter :  Client,Ibased
    {
        Client client;
        private Client clientdouble = new Client();
        public ClientAdapter(Client c)
        {
            client = c;
        }
        public double BasedDouble(double basedouble) => ClientDouble(basedouble);
        public int BasedInt(int basedint) => ClientInt(basedint);
        public char BasedChar(char basedchar) => ClientChar(basedchar);
    }
}
