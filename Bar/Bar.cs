using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Bar
    {
        private List<Alcolico> alcolici;
        private List<int> ordini;
        public List<int> Ordini { get { return ordini; } set { ordini = value; } }

        private List<Cassa> casse;
        public List<Cassa> Casse { get { return casse; } }
        private List<Barman> barmans;
        public List<Barman> Barmans;

        private double saldo;

        public Bar(double saldo)
        {
            this.saldo = saldo;
            this.alcolici = new List<Alcolico>();
            this.casse = new List<Cassa>();
        }

        public double Saldo { get { return saldo; } set { saldo = value; } }
        public List<Alcolico> Alcolici { get { return alcolici; } }

        public void Refill(Alcolico alcolico)
        {
            if (alcolico.Prezzo < saldo) 
            {
                MessageBox.Show("Saldo insufficiente a riempire la bottiglia di " + alcolico.Nome);
                return;
            }
            else
            {
                Saldo = Saldo - alcolico.Prezzo;
                alcolico.Livello = 100;
            }
        }
    }

}
