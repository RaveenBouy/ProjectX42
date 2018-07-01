using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Contacts
{
        public class Members
        {
            public DataTable GetAllMembers(String sql2)
            {
                DataTable  dt = new DataTable();
                String datasource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TableList.mdf;Integrated Security=True";
                String datasource2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBS.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(datasource);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql2;
                cmd.Connection = con;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);        
                adp.Fill(dt);
                return dt;
            }
        }   
}
    