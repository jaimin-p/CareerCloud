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
        public string Skill_Level { get; set; }
        public int Importance { get; set; }
        public byte[] Time_Stamp { get; set; }


    }
}
