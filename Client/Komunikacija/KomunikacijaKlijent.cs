using Client.Exceptioni;
using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.Komunikacija
{
    internal class KomunikacijaKlijent
    {
        private Prima prima;
        private Salje salje;

        public KomunikacijaKlijent(Socket soket)
        {
            prima = new Prima(soket);
            salje = new Salje(soket);
        }

        public void PosaljiZahtev(Zahtev zahtev)
        {
            try
            {
                salje.Posalji(zahtev);

            }
            catch (IOException ex)
            {
                throw new ServerException(ex.Message);
            }
            catch(SocketException ex)
            {
                throw new ServerException(ex.Message);
            }
        }

        public object VratiRezultatOdgovora()
        {
            Odgovor odgovor = (Odgovor)prima.Primi();
            if (odgovor.Uspesno)
            {
                return odgovor.Rezultat;
            }
            else
            {
                throw new SistemskaOperacijaException(odgovor.Greska);
            }
        }
    }
}
