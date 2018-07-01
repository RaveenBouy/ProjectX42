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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }
        newtable nt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nt.Show();
            }
            catch
            {
                nt = new newtable();
                nt.Show();
            }
        }
        TableList tl;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tl.Show();
            }
            catch
            {
                tl = new TableList();
                tl.Show();
            }
        }

        private void mousehoverevent(object sender, EventArgs e)
        {
            button1.BackColor = Color.OrangeRed;
        }

        private void mouseleaveevent(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSeaGreen;
        }

        private void mousehoverevent2(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSeaGreen;
        }

        private void mouseleveevent2(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Connectionl.Hide();
            String datasource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TableList.mdf;Integrated Security=True";
            String datasource2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBS.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(datasource);
            SqlConnection con2 = new SqlConnection(datasource2);
                try
                {
                    con.Open();
                    con2.Open();
                }
                catch(Exception)
                {
                    Connectionl.Show();
                    button1.Hide();
                    button2.Hide();
                }
        }
    }
}
