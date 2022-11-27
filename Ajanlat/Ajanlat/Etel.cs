using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajanlat
{
    class Etel : IFogyaszthato
    {

        public int Ar()
        {
            return mennyiseg;
        }

        public int Mennyiseg()
        {
            return ar;
        }

        public int ar { get; set; }
        public int mennyiseg { get; set; }
        public string megnevezes { get; set; }
        public string tipus { get; set; }
        public string stilus { get; set; }

        Etel(int ar, int mennyiseg, string megnevezes, string tipus, string stilus)
        {
            this.ar = ar;
            this.mennyiseg = mennyiseg;
            this.megnevezes = megnevezes;
            this.tipus = tipus;
            this.stilus = stilus;
        }
    }
}
