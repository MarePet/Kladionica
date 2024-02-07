using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Exceptioni
{
    public class SistemskaOperacijaException : Exception
    {
        public SistemskaOperacijaException():base("Server ne moze da izvrsi zahtev!")
        {
        }

        public SistemskaOperacijaException(string message) : base(message)
        {
        }
    }
}
