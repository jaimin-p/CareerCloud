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
        public DateTime Profile_Created { get; set; }
        public bool Is_Inactive { get; set; }
        public bool Is_Company_Hidden { get; set; }
        public byte[] Time_Stamp { get; set; }



    }
}
