using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class prenotazione
    {
        public DateTime DataPrenotazione { get; set; }
        public int NumeroProgressivo { get; set; }
        public int Anno { get; set; }
        public DateTime PeriodoDal { get; set; }
        public DateTime PeriodoAl { get; set; }
        public decimal CaparraConfirmatoria { get; set; }
        public decimal TariffaApplicata { get; set; }
        public  string Cliente { get; set; }
        public string  Camera { get; set; }
    }
}
