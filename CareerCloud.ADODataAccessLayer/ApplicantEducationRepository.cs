using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using CareerCloud.Pocos;
using CareerCloud.DataAccessLayer;
using System.Data.SqlClient;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantEducationRepository : BaseADO , IDataRepository<ApplicantEducationPoco>
    {
        public void Add(params ApplicantEducationPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(ApplicantEducationPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Applicant_Educations]
                                                ([Id]
                                                   ,[Applicant]
                                                   ,[Major]
                                                   ,[Certificate_Diploma]
                                                   ,[Start_Date]
                                                   ,[Completion_Date]
                                                   ,[Completion_Percent])
                                             VALUES
                                                   (@Id
                                                   ,@Applicant
                                                   ,@Major
                                                   ,@Certificate_Diploma
                                                   ,@Start_Date
                                                   ,@Completion_Date
                                                   ,@Completion_Percent)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Major", poco.Major);
                    cmd.Parameters.AddWithValue("@Certificate_Diploma", poco.CertificateDiploma);
                    cmd.Parameters.AddWithValue("@Start_Date", poco.StartDate);
                    cmd.Parameters.AddWithValue("@Completion_Date", poco.CompletionDate);
                    cmd.Parameters.AddWithValue("@Completion_Percent", poco.CompletionPercent);

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

        public IList<ApplicantEducationPoco> GetAll(params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            ApplicantEducationPoco[] result_ApplicantEducation = new ApplicantEducationPoco[1000];

            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "select * from Applicant_Educations";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int p = 0;
                while(reader.Read())
                {
                    ApplicantEducationPoco poco = new ApplicantEducationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Major = reader.GetString(2);
                    poco.CertificateDiploma = reader.GetString(3);
                    poco.StartDate =reader.IsDBNull(4)?null :(DateTime?)reader.GetDateTime(4);
                    poco.CompletionDate =reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5);
                    poco.CompletionPercent = reader.IsDBNull(6) ? null : (byte?)reader.GetByte(6);
                    poco.TimeStamp = (byte[])reader["Time_Stamp"];

                    result_ApplicantEducation[p] = poco;
                    p++;
                }

                _connection.Close();
            }

            return result_ApplicantEducation.Where(t => t != null).ToList();
        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantEducationPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(ApplicantEducationPoco poco in items)
                {
                    cmd.CommandText = @"DELETE from Applicant_Educations WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params ApplicantEducationPoco[] items)
        {
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach(ApplicantEducationPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE Applicant_Educations 
                                      SET Applicant = @Applicant,
                                          Major = @Major,
                                          Certificate_Diploma = @Certificate_Diploma,
                                          Start_Date = @Start_Date,
                                          Completion_Date = @Completion_Date,
                                          Completion_Percent = @Completion_Percent
                                            WHERE Id = @Id";

                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Major", poco.Major);
                    cmd.Parameters.AddWithValue("@Certificate_Diploma", poco.CertificateDiploma);
                    cmd.Parameters.AddWithValue("@Start_Date", poco.StartDate);
                    cmd.Parameters.AddWithValue("@Completion_Date", poco.CompletionDate);
                    cmd.Parameters.AddWithValue("@Completion_Percent", poco.CompletionPercent);
                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
    }


}
