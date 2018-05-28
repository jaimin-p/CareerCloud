using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyDescriptionPoco
    {
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public string LanguageID { get; set; }
        public string Company_Name { get; set; }
        public string Company_Description { get; set; }
        public byte[] Time_Stamp { get; set; }

    }

}
