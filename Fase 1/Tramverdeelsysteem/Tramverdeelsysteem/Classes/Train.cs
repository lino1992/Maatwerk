using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    public class Train
    {
        private int trainid;
        private string status;
        private DateTime servicedate;

        public int TrainID { get { return trainid; } }
        public string Status { get { return status; } }
        public DateTime ServiceDate { get { return servicedate; } }

        public Train(int trainid, string status, DateTime servicedate)
        {
            this.trainid = trainid;
            this.status = status;
            this.servicedate = servicedate;
        }
    }
}
