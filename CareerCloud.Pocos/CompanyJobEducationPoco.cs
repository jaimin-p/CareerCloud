using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyJobEducationPoco
    {
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        public string Major { get; set; }
        public short Importance { get; set; }
        public byte[] TimeStamp { get; set; }

    }

}
