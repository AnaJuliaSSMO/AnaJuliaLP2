using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaaaaaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\MySlave; Initial Catalog=LOGINUSER; Integrated Security=SSPI;"),
            };

            cmd.CommandText = @"INSERT INTO Login VALUES ('Maria Almira','Almira',12091962)";

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
