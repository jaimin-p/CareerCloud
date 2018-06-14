using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.Pocos;
using CareerCloud.DataAccessLayer;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginsLogRepository :BaseADO, IDataRepository<SecurityLoginsLogPoco>
    {
        public void Add(params SecurityLoginsLogPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(SecurityLoginsLogPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins_Log]
                                                        (
                                                           [Id]
                                                          ,[Login]
                                                          ,[Source_IP]
                                                          ,[Logon_Date]
                                                          ,[Is_Succesful]
                                                        )
                                                        VALUES
                                                        (
                                                           @Id
                                                          ,@Login
                                                          ,@Source_IP
                                                          ,@Logon_Date
                                                          ,@Is_Succesful
                                                        )";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Source_IP", poco.SourceIP);
                    cmd.Parameters.AddWithValue("@Logon_Date", poco.LogonDate);
                    cmd.Parameters.AddWithValue("@Is_Succesful", poco.IsSuccesful);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsLogPoco> GetAll(params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            SecurityLoginsLogPoco[] result = new SecurityLoginsLogPoco[1000];
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * from Security_Logins_Log";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int p = 0;
                while (reader.Read())
                {
                    SecurityLoginsLogPoco poco = new SecurityLoginsLogPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Login = rdr.GetGuid(1);
                    poco.SourceIP = rdr.GetString(2);
                    poco.LogonDate = rdr.GetDateTime(3);
                    poco.IsSuccesful = rdr.GetBoolean(4);
                    poco.TimeStamp = (byte[])reader["Time_Stamp"];

                    result[p] = poco;
                    p++;
                }
                _connection.Close();
            }
            return result.Where(t => t != null).ToList();
        }

        public IList<SecurityLoginsLogPoco> GetList(Expression<Func<SecurityLoginsLogPoco, bool>> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsLogPoco GetSingle(Expression<Func<SecurityLoginsLogPoco, bool>> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginsLogPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityLoginsLogPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach (SecurityLoginsLogPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Security_Logins_Log]
                                                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params SecurityLoginsLogPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(SecurityLoginsLogPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins_Log]
                                                 SET [Login] = @Login
                                                    ,[Source_IP] = @Source_IP
                                                    ,[Logon_Date] = @Logon_Date
                                                    ,[Is_Succesful] = @Is_Succesful
                                               WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Source_IP", poco.SourceIP);
                    cmd.Parameters.AddWithValue("@Logon_Date", poco.LogonDate);
                    cmd.Parameters.AddWithValue("@Is_Succesful", poco.IsSuccesful);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();

                }
            }
        }

    }
}
