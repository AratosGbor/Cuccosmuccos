using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajanlat
{
    public abstract class Ital : IFogyaszthato
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
    }
}
