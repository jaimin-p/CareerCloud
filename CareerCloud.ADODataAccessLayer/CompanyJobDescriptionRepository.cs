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
    public class CompanyJobDescriptionRepository : BaseADO, IDataRepository<CompanyJobDescriptionPoco>
    {
        public void Add(params CompanyJobDescriptionPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(CompanyJobDescriptionPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Jobs_Descriptions]
                                                        (
                                                           [Id]
                                                          ,[Job]
                                                          ,[Job_Name]
                                                          ,[Job_Descriptions]
                                                        )
                                                        VALUES
                                                        (
                                                           @Id
                                                          ,@Job
                                                          ,@Job_Name
                                                          ,@Job_Descriptions
                                                        )";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    cmd.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);

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

        public IList<CompanyJobDescriptionPoco> GetAll(params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            CompanyJobDescriptionPoco[] result = new CompanyJobDescriptionPoco[1002];
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * from Company_Jobs_Descriptions";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int p = 0;
                while (reader.Read())
                {
                    CompanyJobDescriptionPoco poco = new CompanyJobDescriptionPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    poco.JobName = reader.IsDBNull(2) ? null : reader.GetString(2);
                    poco.JobDescriptions = reader.IsDBNull(3) ? null : reader.GetString(3);
                    poco.TimeStamp = (byte[])reader["Time_Stamp"];

                    result[p] = poco;
                    p++;
                }
                _connection.Close();
            }
            return result.Where(t => t != null).ToList();
        }

        public IList<CompanyJobDescriptionPoco> GetList(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobDescriptionPoco GetSingle(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobDescriptionPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach (CompanyJobDescriptionPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Company_Jobs_Descriptions]
                                                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params CompanyJobDescriptionPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(CompanyJobDescriptionPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Jobs_Descriptions]
                                                 SET [Job] = @Job
                                                    ,[Job_Name] = @Job_Name
                                                    ,[Job_Descriptions] = @Job_Descriptions
                                               WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    cmd.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();

                }
            }
        }
    }
}
