using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace SynsPunkt
{
    public class Vare
    {
        public int vnr;
        public String Varegruppe;
        public String Mærke;
        public String Glastype;
        public int Lagerstatus;
        public int Pris;
        public String Køn;
        public String Størrelse;
        public String Farve;
        

        public Vare() { }
        public Vare(int Vnr, string varegruppe, string mærke, string glastype, int lagerstatus, int pris, string køn, string størrelse, string farve)
        {
            vnr = Vnr;
            Varegruppe = varegruppe;
            Mærke = mærke;
            Glastype = glastype;
            Lagerstatus = lagerstatus;
            Pris = pris;
            Køn = køn;
            Størrelse = størrelse;
            Farve = farve;
            

        }

        public bool V { get; internal set; }
    }
}

