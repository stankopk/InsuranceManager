using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManager
{
    public class Connect
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ligaa\Source\Repos\stankopk\InsuranceManager\Database.mdf;Integrated Security=True";
    }
}
