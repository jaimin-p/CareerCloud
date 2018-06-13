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
    public class ApplicantResumeRepository : BaseADO , IDataRepository<ApplicantResumePoco>
    {
        public void Add(params ApplicantResumePoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach (ApplicantResumePoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Applicant_Resumes]
                                                        (
                                                           [Id]
                                                          ,[Applicant]
                                                          ,[Resume]
                                                          ,[Last_Updated]
                                                        )
                                                        VALUES
                                                        (
                                                           @Id
                                                          ,@Applicant
                                                          ,@Resume
                                                          ,@Last_Updated
                                                        )";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Resume", poco.Resume);
                    cmd.Parameters.AddWithValue("@Last_Updated", poco.LastUpdated);

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

        public IList<ApplicantResumePoco> GetAll(params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            ApplicantResumePoco[] result = new ApplicantResumePoco[1000];
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * from Applicant_Resumes";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int p = 0;
                while (reader.Read())
                {
                    ApplicantResumePoco poco = new ApplicantResumePoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Resume = reader.GetString(2);
                    poco.LastUpdated = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3);

                    result[p] = poco;
                    p++;
                }
                _connection.Close();
            }

            return result.Where(t => t != null).ToList();
        }

        public IList<ApplicantResumePoco> GetList(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantResumePoco GetSingle(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantResumePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantResumePoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(ApplicantResumePoco poco in items)
                {
                    cmd.CommandText = @"DELETE from Applicant_Resumes WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }

            }
        }

        public void Update(params ApplicantResumePoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(ApplicantResumePoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Resumes]
                                                 SET [Applicant] = @Applicant
                                                    ,[Resume] = @Resume
                                                    ,[Last_Updated] = @Last_Updated
                                               WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Resume", poco.Resume);
                    cmd.Parameters.AddWithValue("@Last_Updated", poco.LastUpdated);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }
}
