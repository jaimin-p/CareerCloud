﻿using System;
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
    public class CompanyLocationRepository :BaseADO, IDataRepository<CompanyLocationPoco>
    {
        public void Add(params CompanyLocationPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                
                foreach(CompanyLocationPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Company_Locations]
                                                        (
                                                           [Id]
                                                          ,[Company]
                                                          ,[Country_Code]
                                                          ,[State_Province_Code]
                                                          ,[Street_Address]
                                                          ,[City_Town]
                                                          ,[Zip_Postal_Code]
                                                        )
                                                        VALUES
                                                        (
                                                           @Id
                                                          ,@Company
                                                          ,@Country_Code
                                                          ,@State_Province_Code
                                                          ,@Street_Address
                                                          ,@City_Town
                                                          ,@Zip_Postal_Code
                                                        )";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Company", poco.Company);
                    cmd.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    cmd.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", poco.Street);
                    cmd.Parameters.AddWithValue("@City_Town", poco.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);

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

        public IList<CompanyLocationPoco> GetAll(params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            CompanyLocationPoco[] result = new CompanyLocationPoco[1000];
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = "SELECT * from Company_Locations";

                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int p = 0;
                while (reader.Read())
                {
                    CompanyLocationPoco poco = new CompanyLocationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Company = reader.GetGuid(1);
                    poco.CountryCode = reader.GetString(2);
                    poco.Province = reader.IsDBNull(3) ? null : reader.GetString(3);
                    poco.Street = reader.IsDBNull(4) ? null : reader.GetString(4);
                    poco.City = reader.IsDBNull(5) ? null : reader.GetString(5);
                    poco.PostalCode = reader.IsDBNull(6) ? null : reader.GetString(6);
                    poco.TimeStamp = (byte[])reader["Time_Stamp"];

                    result[p] = poco;
                    p++;
                }
                _connection.Close();
            }
            return result.Where(t => t != null).ToList();
        }

        public IList<CompanyLocationPoco> GetList(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyLocationPoco GetSingle(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyLocationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyLocationPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;

                foreach (CompanyLocationPoco poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Company_Locations]
                                                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }

        public void Update(params CompanyLocationPoco[] items)
        {
            SqlConnection _connection = new SqlConnection(_connString);
            using (_connection)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _connection;
                
                foreach(CompanyLocationPoco poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Locations]
                                                 SET [Company] = @Company
                                                    ,[Country_Code] = @Country_Code
                                                    ,[State_Province_Code] = @State_Province_Code
                                                    ,[Street_Address] = @Street_Address
                                                    ,[City_Town] = @City_Town
                                                    ,[Zip_Postal_Code] = @Zip_Postal_Code
                                               WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Company", poco.Company);
                    cmd.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    cmd.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", poco.Street);
                    cmd.Parameters.AddWithValue("@City_Town", poco.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                    _connection.Close();

                }
            }
        }
    }
}
