using ADO_Catalog_WPF.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ADO_Catalog_WPF.DB
{
    public class ConectionBlockButton
    {
        public static string connectionString = @"Data Source=DESKTOP-440KLQF\SQLEXPRESS;Initial Catalog=ADOnet_Catalog;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<ProductBlockButton> GetTopCatalog()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<ProductBlockButton>($"SELECT * FROM ProductBlockButton").ToList();
            }
        }
    }
}
