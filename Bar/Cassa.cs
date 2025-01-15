using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Cassa
    {
        private Bar bar;
        private int ordine;
        private double pagamento;
        private double saldoCassa;

        public Cassa(double saldoCassa)
        {
            this.saldoCassa = saldoCassa;
        }

        public int Ordine { get { return ordine; } set { ordine = value; } }
        public double Pagamento { get {  return pagamento; } set {  pagamento = value; } }
        public double SaldoCassa { get { return saldoCassa; } set { saldoCassa = value; } }

        
        public void InviaOrdine()
        {
            Random rnd = new Random();
            Ordine = rnd.Next(1, bar.Alcolici.Count);

            bar.Ordini.Add(Ordine);
        }


    }
}
