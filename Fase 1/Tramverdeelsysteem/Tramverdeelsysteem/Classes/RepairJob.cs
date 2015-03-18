using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    class RepairJob:Job
    {
        private int repairjobid;
        private string note;
        private string servicetype;

        public int RepairJobID { get { return repairjobid; } }
        public string Note { get { return note; } }
        public string ServiceType { get { return servicetype} }

        public RepairJob(int jobid, int trainid, DateTime begindate, DateTime enddate, int repairjobid, string note, string servicetype)
            : base(jobid, trainid, begindate, enddate)
        {
            this.repairjobid = repairjobid;
            this.note = note;
            this.servicetype = servicetype;
        }
    }
}
