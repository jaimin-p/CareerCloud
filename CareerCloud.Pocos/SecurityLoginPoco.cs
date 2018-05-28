using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginPoco
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime? Password_Update_Date { get; set; }
        public DateTime? Agreement_Accepted_Date { get; set; }
        public bool Is_Locked { get; set; }
        public bool Is_Inactive { get; set; }
        public string Email_Address { get; set; }
        public string Phone_Number { get; set; }
        public string Full_Name { get; set; }
        public bool Force_Change_Password { get; set; }
        public string Prefferred_Language { get; set; }
        public byte[] Time_Stamp { get; set; }

    }
}
