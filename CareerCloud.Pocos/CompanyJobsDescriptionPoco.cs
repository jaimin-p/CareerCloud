using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyJobsDescriptionPoco
    {
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        public string Job_Name { get; set; }
        public string Job_Descriptions { get; set; }
        public byte[] Time_Stamp { get; set; }


    }
}
