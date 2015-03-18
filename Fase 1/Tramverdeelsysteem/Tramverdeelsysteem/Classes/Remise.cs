using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    class Remise
    {
        private int remise;
        private string name;
        private string abbrevation;

        public int Remise { get { return remise; } }
        public string Name { get { return name; } }
        public string Abbrevation { get { return abbrevation; } }

        public Remise(int remise, string name, string abbrevation)
        {
            this.remise = remise;
            this.name = name;
            this.abbrevation = abbrevation;
        }
    }
}
