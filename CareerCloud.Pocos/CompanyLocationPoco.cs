using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyLocationPoco
    {
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public string Country_Code { get; set; }
        public string State_Province_Code { get; set; }
        public string Street_Address { get; set; }
        public string City_Town { get; set; }
        public string Zip_Postal_Code { get; set; }
        public byte[] Time_Stamp { get; set; }
    }
}
