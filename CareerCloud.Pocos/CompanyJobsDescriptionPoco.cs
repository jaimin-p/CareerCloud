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
        public string JobName { get; set; }
        public string JobDescriptions { get; set; }
        public byte[] TimeStamp { get; set; }


    }
}
