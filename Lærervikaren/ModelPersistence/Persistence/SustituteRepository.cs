using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelPersistence.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Data.SqlClient;

namespace ModelPersistence.Persistence
{

    public class SubstituteRepository
    {
        private readonly string _connectionString;

        public SubstituteRepository(IConfiguration configuration)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string? _connectionString = config.GetConnectionString("MyDBConnection");

        }

        public void CreateSubstitute(Substitute substituteToBeCreated)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Substitute (_Name, Phone, SSN, ChildCertificateExpiryDate, Active) " +
                                                 "VALUES (@Name, @Phone, @SSN, @ChildCertificateExpiryDate, @Active); " +
                                                 "SELECT CAST(scope_identity() AS int)", con);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = substituteToBeCreated.Name ?? (object)DBNull.Value;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = substituteToBeCreated.Phone ?? (object)DBNull.Value;
                cmd.Parameters.Add("@SSN", SqlDbType.NVarChar).Value = substituteToBeCreated.SSN ?? (object)DBNull.Value;
                cmd.Parameters.Add("@ChildCertificateExpiryDate", SqlDbType.Date).Value = substituteToBeCreated.ChildCertificateExpiryDate.HasValue ? (object)substituteToBeCreated.ChildCertificateExpiryDate.Value : DBNull.Value;
                cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = substituteToBeCreated.Active;

                // Udfør kommandoen og sæt SubstituteId til det nyoprettede ID
                substituteToBeCreated.SubstituteId = (int)cmd.ExecuteScalar();

                // Tilføj til in-memory liste
                _substitutes.Add(substituteToBeCreated);
            }
        }


    }

}
