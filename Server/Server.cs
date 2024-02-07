using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket osluskujuciSoket;
        private List<KlijentHandler> klijenti = new List<KlijentHandler>();
        private BindingList<Korisnik> korisnici = new BindingList<Korisnik>();
        private BindingList<Administrator> administratori = new BindingList<Administrator>();
        public BindingList<Korisnik> Korisnici
        {
            get { return korisnici; }
        }
        public BindingList<Administrator> Administratori
        {
            get { return administratori; }
        }
        public Server()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Pokreni()
        {
            osluskujuciSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
        }

        public void Osluskuj()
        {
            osluskujuciSoket.Listen(5);
            bool kraj = false;
            while (!kraj)
            {
                try
                {

                    Socket klijent = osluskujuciSoket.Accept();
                    KlijentHandler handler = new KlijentHandler(klijent, korisnici, administratori);
                    klijenti.Add(handler);
                    Thread nit = new Thread(handler.PokreniHandler);
                    nit.IsBackground = true;
                    nit.Start();

                }
                catch (SocketException)
                {
                    Console.WriteLine("Kraj rada");
                    kraj = true;
                }
            }
        }

        internal void Zaustavi()
        {
            osluskujuciSoket.Close();
            foreach (KlijentHandler k in klijenti)
            {
                k.Zaustavi();
            }
            klijenti.Clear();
        }
    }
}
