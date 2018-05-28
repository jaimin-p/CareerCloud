using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginsRolePoco
    {
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public Guid Role { get; set; }
        public byte[] Time_Stamp { get; set; }
    }
}
