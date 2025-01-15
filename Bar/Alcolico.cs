using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Alcolico
    {
        private int livello = 100;
        private string nome;
        private bool occupato = false;
        private double prezzoPubblico;
        private double prezzo;

        public Alcolico(string nome, double prezzo, double prezzoPubblico)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.prezzoPubblico = prezzoPubblico;
        }

        public string Nome { get{ return nome; } set { nome = value; } }
        public bool Occupato { get { return occupato; } set { occupato = value; } }
        public int Livello { get { return livello; } set { livello = value; } }
        public double Prezzo { get { return prezzo; } set { prezzo = value; } }
        public double PrezzoPubblico { get { return prezzoPubblico; } set { prezzoPubblico = value; } }

        public void Occupa()
        {
            Occupato = true;
        }

        public void Libera()
        {
            Occupato = false;
        }

        


    }
}
