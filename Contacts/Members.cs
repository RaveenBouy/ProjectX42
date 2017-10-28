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
            
                String datasource = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + "D:\\MS VS Projects\\Contacts\\Contacts\\Contacts.mdf" + ";" + "Integrated Security = True";
                SqlConnection con = new SqlConnection(datasource);

                String SQLL = sql2;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SQLL;
                cmd.Connection = con;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);        
                adp.Fill(dt);
                return dt;
            }
        }   
}
