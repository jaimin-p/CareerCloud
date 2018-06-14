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
    public class SystemLanguageCodeRepository : BaseADO , IDataRepository<SystemLanguageCodePoco>
    {
        public void Add(params SystemLanguageCodePoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(SystemLanguageCodePoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[System_Language_Codes]
                                                        (
                                                           [LanguageID]
                                                          ,[Name]
                                                          ,[Native_Name]
                                                        )
                                                        VALUES
                                                        (
                                                           @LanguageID
                                                          ,@Name
                                                          ,@Native_Name
                                                        )";

                    cmd.Parameters.AddWithValue("@LanguageID", poco.LanguageID);
                    cmd.Parameters.AddWithValue("@Name", poco.Name);
                    cmd.Parameters.AddWithValue("@Native_Name", poco.NativeName);

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

        public IList<SystemLanguageCodePoco> GetAll(params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            SystemLanguageCodePoco[] result = new SystemLanguageCodePoco[1000];
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * from System_Language_Codes";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int p = 0;
                while (reader.Read())
                {
                    SystemLanguageCodePoco poco = new SystemLanguageCodePoco();
                    poco.LanguageID = reader.GetString(0);
                    poco.Name = reader.GetString(1);
                    poco.NativeName = reader.GetString(2);
                    result[p] = poco;
                    p++;
                }
                _connection.Close();
            }
            return result.Where(t => t != null).ToList();
        }

        public IList<SystemLanguageCodePoco> GetList(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemLanguageCodePoco GetSingle(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            IQueryable<SystemLanguageCodePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SystemLanguageCodePoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach (SystemLanguageCodePoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[System_Language_Codes]
                                                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params SystemLanguageCodePoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(SystemLanguageCodePoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[System_Language_Codes]
                                                 SET [Name] = @Name
                                                    ,[Native_Name] = @Native_Name
                                               WHERE [LanguageID] = @LanguageID";

                    cmd.Parameters.AddWithValue("@LanguageID", poco.LanguageID);
                    cmd.Parameters.AddWithValue("@Name", poco.Name);
                    cmd.Parameters.AddWithValue("@Native_Name", poco.NativeName);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }
}
