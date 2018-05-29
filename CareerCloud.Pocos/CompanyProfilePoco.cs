using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    class CompanyProfilePoco
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string CompanyWebsite { get; set; }
        public string ContactPhone { get; set; }
        public string ContactName { get; set; }
        public byte[] CompanyLogo { get; set; }
        public byte[] TimeStamp { get; set; }

    }
}
