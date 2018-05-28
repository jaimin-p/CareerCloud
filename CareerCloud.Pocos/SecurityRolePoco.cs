using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityRolePoco
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public bool Is_Inactive { get; set; }

    }
}
