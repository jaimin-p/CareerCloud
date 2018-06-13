using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADO
    {
        protected readonly SqlConnection _connection;

        public BaseADO()
        {
            SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        }
    }
}
