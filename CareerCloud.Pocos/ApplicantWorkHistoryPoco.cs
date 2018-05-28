using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantWorkHistoryPoco
    {

        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Company_Name { get; set; }
        public string Country_Code { get; set; }
        public string Location { get; set; }
        public string Job_Title { get; set; }
        public string Job_Description { get; set; }
        public short Start_Month { get; set; }
        public int Start_Year { get; set; }
        public short End_Month { get; set; }
        public int End_Year { get; set; }
        public byte[] Time_Stamp { get; set; }

    }

}
