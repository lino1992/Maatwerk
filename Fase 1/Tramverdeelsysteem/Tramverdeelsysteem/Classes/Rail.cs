using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    public class Rail
    {
        private int railid;
        private string type;

        public int RailID { get { return railid; } }
        public string Type { get { return type; } }

        public Rail(int railid, string type)
        {
            this.railid = railid;
            this.type = type;
        }
    }
}
