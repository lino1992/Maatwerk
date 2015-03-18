using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    class Job
    {
        private int jobid;
        private int traindid;
        private DateTime begindate;
        private DateTime enddate;

        public int JobID { get { return jobid; } }
        public int TrainID { get { return traindid; } }
        public DateTime Begindate {get{return begindate;}}
        public DateTime Enddate { get { return enddate; } }

        public Job(int jobid, int trainid, DateTime begindate, DateTime enddate)
        {
            this.jobid = jobid;
            this.traindid = traindid;
            this.begindate = begindate;
            this.enddate = enddate;
        }
    }
}
