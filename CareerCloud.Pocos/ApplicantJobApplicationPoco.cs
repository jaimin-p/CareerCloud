using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantJobApplicationPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public Guid Job { get; set; }
        public DateTime Application_Date { get; set; }
        public byte[] Time_Stamp { get; set; }

    }

}
