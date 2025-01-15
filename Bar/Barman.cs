using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Barman
    {

        
        private double velocita;
        private Bar bar;

        public Barman(double velocita)
        {
            this.velocita = velocita;
        }

        public double Velocita { get { return velocita; } set { velocita = value; } }

        public void Pippa() 
        {
            Velocita = Velocita * 1.5;
        }

        public void ProcessaOrdine()
        {
            int primoOrdine = bar.Ordini[0];
            bar.Ordini.Remove(primoOrdine);

            bool clienteSoddisfatto = false;
            while (clienteSoddisfatto == false)
            {
                if (bar.Alcolici[bar.Ordini[0]].Occupato == true)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    bar.Alcolici[primoOrdine].Occupa();

                    Thread.Sleep((int)((double)7000 / velocita));

                    bar.Alcolici[primoOrdine].Libera();

                    bar.Alcolici[primoOrdine].Livello = bar.Alcolici[primoOrdine].Livello - 5;

                    if (bar.Alcolici[primoOrdine].Livello == 0 )
                    {
                        bar.Refill(bar.Alcolici[primoOrdine]);
                    }
                    clienteSoddisfatto = true;

                }
            }
        }

        public void Assumi(Bar bar)
        {
            this.bar = bar;
        }

    }
}
