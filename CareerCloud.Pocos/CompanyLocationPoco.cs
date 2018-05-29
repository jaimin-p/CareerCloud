using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Locations")]
    class CompanyLocationPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public string CountryCode { get; set; }
        public string StateProvinceCode { get; set; }
        public string StreetAddress { get; set; }
        public string CityTown { get; set; }
        public string ZipPostalCode { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
