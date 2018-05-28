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
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public byte[] TimeStamp { get; set; }

    }

}
