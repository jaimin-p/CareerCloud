using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantProfilePoco
    {
     
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public decimal? Current_Salary { get; set; }
        public decimal? Current_Rate { get; set; }
        public string Currency { get; set; }
        public string Country_Code { get; set; }
        public string State_Province_Code { get; set; }
        public string Street_Address { get; set; }
        public string City_Town { get; set; }
        public string Zip_Postal_Code { get; set; }
        public byte[] Time_Stamp { get; set; }
    }

}
