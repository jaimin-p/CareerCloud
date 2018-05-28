using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantEducationPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Major { get; set; }
        public string Certificate_Diploma { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? Completion_Date { get; set; }
        public byte? Completion_Percent { get; set; }
        public byte[] Time_Stamp { get; set; }
    }

}
