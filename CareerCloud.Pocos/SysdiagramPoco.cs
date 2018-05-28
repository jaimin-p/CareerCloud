using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SysdiagramPoco
    {
        public string name { get; set; }
        public int principalid { get; set; }
        public int diagramid { get; set; }
        public int? version { get; set; }
        public byte[] definition { get; set; }

    }
}
