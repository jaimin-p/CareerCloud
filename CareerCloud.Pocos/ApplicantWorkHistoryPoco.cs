using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string CompanyName { get; set; }
        public string CountryCode { get; set; }
        public string Location { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public short StartMonth { get; set; }
        public int StartYear { get; set; }
        public short EndMonth { get; set; }
        public int EndYear { get; set; }
        public byte[] TimeStamp { get; set; }

    }

}
