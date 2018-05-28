using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginsLogPoco
    {
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public string Source_IP { get; set; }
        public DateTime Logon_Date { get; set; }
        public bool Is_Succesful { get; set; }

    }
}
