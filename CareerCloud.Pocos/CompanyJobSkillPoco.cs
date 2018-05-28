using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyJobSkillPoco
    {
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        public string Skill { get; set; }
        public string SkillLevel { get; set; }
        public int Importance { get; set; }
        public byte[] TimeStamp { get; set; }


    }
}
