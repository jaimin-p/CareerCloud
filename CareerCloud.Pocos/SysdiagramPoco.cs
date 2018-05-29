using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("sysdiagrams")]
    class SysdiagramPoco
    {
        
        public string name { get; set; }

        [Column("principal_id")]
        public int principalid { get; set; }

        [Column("diagram_id")]
        public int diagramid { get; set; }
        public int? version { get; set; }
        public byte[] definition { get; set; }

    }
}
