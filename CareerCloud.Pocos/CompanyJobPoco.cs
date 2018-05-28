using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyJobPoco
    {
        pu public Guid Id { get; set; }
        public Guid Company { get; set; }
        public DateTime ProfileCreated { get; set; }
        public bool IsInactive { get; set; }
        public bool IsCompanyHidden { get; set; }
        public byte[] TimeStamp { get; set; }



    }
}
