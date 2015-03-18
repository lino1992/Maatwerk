using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    public class Section
    {
        private int section;
        private string blocked;

        public int Section { get { return section; } }
        public string Blocked { get { return blocked; } }

        public Section(int section, string blocked)
        {
            this.section = section;
            this.blocked = blocked;
        }

    }
}
