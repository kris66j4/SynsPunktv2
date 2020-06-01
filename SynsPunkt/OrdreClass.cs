using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynsPunkt
{
    public class OrdreClass
    {
        public int Kundenr;
        public String Navn;
        public String Dato;
        public int Pris;

        public OrdreClass() { }

        public OrdreClass(int kundenr, string navn, string dato, int pris)
        {
            Kundenr = kundenr;
            Navn = navn;
            Dato = dato;
            Pris = pris;
        }
        public bool O { get; internal set; }
    }
}
