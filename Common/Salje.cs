using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Salje
    {
        private readonly Socket soket;
        private NetworkStream tok;
        private BinaryFormatter formater;

        public Salje(Socket soket)
        {
            this.soket = soket;
            this.tok = new NetworkStream(soket);
            this.formater = new BinaryFormatter();

        }

        public void Posalji(object poruka)
        {
            formater.Serialize(tok, poruka);
        }
    }
}
