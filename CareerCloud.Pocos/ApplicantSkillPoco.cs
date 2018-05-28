using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantSkillPoco
    {
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Skill { get; set; }
        public string Skill_Level { get; set; }
        public byte Start_Month { get; set; }
        public int Start_Year { get; set; }
        public byte End_Month { get; set; }
        public int End_Year { get; set; }
        public byte[] Time_Stamp { get; set; }

    }

}
