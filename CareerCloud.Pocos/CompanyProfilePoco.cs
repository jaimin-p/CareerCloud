using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyProfilePoco
    {
        public Guid Id { get; set; }
        public DateTime Registration_Date { get; set; }
        public string Company_Website { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_Name { get; set; }
        public byte[] Company_Logo { get; set; }
        public byte[] Time_Stamp { get; set; }

    }
}
