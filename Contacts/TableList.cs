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
    public partial class TableList : Form
    {
        String datasource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MS_VS_Projects\GitHubProjectX\ProjectX42\Contacts\TableList.mdf;Integrated Security=True";
        String datasource2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MS_VS_Projects\GitHubProjectX\ProjectX42\Contacts\DBS.mdf;Integrated Security=True";
        public static string listx;
        public TableList()
        {
            InitializeComponent();
        }

        private void TableList_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        EditTable et;
        private void button2_Click(object sender, EventArgs e) //Table Edit *************************************************************************************
        {
            String tablex = Convert.ToString(List.SelectedItem);
            listx = tablex;
            if(tablex!="")
            {
                try
                {
                    et.Show();
                }
                catch
                {
                    et = new EditTable();
                    et.Show();
                }
            }
            else
            {
                MessageBox.Show("Table is not selected");
            }


        }
        TableView tv;
        private void button4_Click(object sender, EventArgs e) //Table View **************************************************************************************
        {
            String tablex = Convert.ToString(List.SelectedItem);
            listx = tablex;    
            if(tablex !="")
            {
            try
            {
                tv.Show();
            }
            catch
            {
                TableView tv = new TableView();
                tv.Show();
            }
            }
            else
            {
                MessageBox.Show("Table is not selected");
            }
        }

        private void button1_Click(object sender, EventArgs e) //Generate List ***********************************************************************************
        {
            using (SqlConnection con = new SqlConnection(datasource))
              try
              {                
                    con.Open();
                    DataTable schema = con.GetSchema("Tables");                   
                    List.Items.Clear();
                    foreach (DataRow row in schema.Rows)
                    {
                        List.Items.Add(row[2].ToString());
                    }
                    con.Close();
                   
                }
                catch
                {
                    MessageBox.Show("failed to connect!");
                }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //Delete Table **************************************************************************************
        {
            String tables = Convert.ToString(List.SelectedItem);
            if(tables!="")
            {

                DialogResult DR = MessageBox.Show("Deletion Of The Table Is Not Reversible. \nAre You Sure?", "Deleting the entire Table", MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(datasource);
                    SqlConnection con2 = new SqlConnection(datasource2);
                    try
                    {
                        con.Open();
                        con2.Open();
                        String tableselected = "DROP TABLE " + tables + ";";
                        String tableselected2 = "DROP TABLE " + tables + ";";
                        SqlCommand cmd = new SqlCommand(tableselected, con);
                        SqlCommand cmd2 = new SqlCommand(tableselected2, con2);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        List.Items.Clear();
                        DataTable schema = con.GetSchema("Tables");
                        foreach (DataRow row in schema.Rows)
                        {
                            List.Items.Add(row[2].ToString());
                        }
                        con.Close();
                        con2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Unexpected error");
                    }
                }
                else
                if (DR == DialogResult.No)
                {
                }
                
            }
            else
            {
                MessageBox.Show("Table is not selected");
            }
        }
    }
}
/*
 * DataTable schema = connection.GetSchema("Tables");
    List<string> TableNames = new List<string>();
    foreach (DataRow row in schema.Rows)
    {
        TableNames.Add(row[2].ToString());
    }
    return TableNames;
*/