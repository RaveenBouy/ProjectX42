using System;
using System.Data.SqlClient;

namespace Contacts
{
    internal class db2
    {
        public string GetAllMembers(String sql2)
        {
            String datasource = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + "D:\\MS VS Projects\\Contacts\\Contacts\\DBS.mdf" + ";Integrated Security=True";
            SqlConnection con = new SqlConnection(datasource);
            con.Open();
            String SQLL = sql2;
            SqlCommand cmd = new SqlCommand(SQLL, con);
            String result = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            return result;
            //testfor GIT
        }
    }
}