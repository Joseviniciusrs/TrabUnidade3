using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class Db
    {
        private static SqlConnection conn = null;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                try
                {
                    var configuration = LoadConfiguration();
                    string connectionString = configuration.GetConnectionString("DefaultConnection");
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                }
                catch (SqlException e)
                {
                    throw new DbException(e.Message);
                }
            }
            return conn;
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                try
                {
                    conn.Close();
                }
                catch (SqlException e)
                {
                    throw new DbException(e.Message);
                }
            }
        }

        private static IConfiguration LoadConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static void CloseCommand(SqlCommand cmd)
        {
            if (cmd != null)
            {
                try
                {
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    throw new DbException(e.Message);
                }
            }
        }

        public static void CloseReader(SqlDataReader reader)
        {
            if (reader != null)
            {
                try
                {
                    reader.Close();
                }
                catch (Exception e)
                {
                    throw new DbException(e.Message);
                }
            }
        }
    }

}
