using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    class CleaningJob:Job
    {
        private int cleaningjobid;
        private string servicetype;

        public int CleaningJobID { get { return cleaningjobid; } }
        public string ServiceType { get { return servicetype; } }

        public CleaningJob(int jobid, int trainid, DateTime begindate, DateTime enddate, int cleaningjobid, string servicetype)
            :base(jobid, trainid, begindate, enddate)
        {
            this.cleaningjobid = cleaningjobid;
            this.servicetype = servicetype;
        }
    }
}
