using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Contacts
{
    public partial class EditTable : Form
    {
        public string tablenamex;
        private int colmsno;
        int key;
        String text1;
        private String datasource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MS_VS_Projects\GitHubProjectX\ProjectX42\Contacts\TableList.mdf;Integrated Security=True";
        private String datasource2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MS_VS_Projects\GitHubProjectX\ProjectX42\Contacts\DBS.mdf;Integrated Security=True";

        public EditTable()
        {
            InitializeComponent();
        }

        private void EditTable_Load(object sender, EventArgs e)
        {
            this.Size = new Size(915, 347);
            editlabelpk.Hide();
            tablenamex = TableList.listx;
            tablenamelabel.Text = tablenamex;
            using (SqlConnection con = new SqlConnection(datasource)) // TableView
                try
                {
                    Members mm = new Members();
                    tablenamex = TableList.listx;
                    string sql = "SELECT * FROM " + tablenamex + ";";
                    tablegrid.DataSource = mm.GetAllMembers(sql);
                    tablenamelabel.Text = tablenamex;
                }
                catch
                {
                    MessageBox.Show("Failed to connect");
                }

            if (rbinsert.Checked == true)
            {
                editidl.Hide();
                editidtb.Hide();
                editidb.Hide();
                editcol1b.Hide();
                editcol2b.Hide();
                editcol3b.Hide();
                editcol4b.Hide();
                editcol5b.Hide();
                editcol6b.Hide();
            }
            db2 db = new db2();
            String sqldb2 = "SELECT colms FROM " + tablenamex + ";";
            String s1 = db.GetAllMembers(sqldb2);
            colmsno = Convert.ToInt16(s1);
            if (colmsno == 1)
            {
                String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                String tcol1 = Convert.ToString(db.GetAllMembers(ctcol1));
                if (tcol1 == "0")
                {
                    col1text.MaxLength = 19;                  
                }
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                col1.Text = Convert.ToString(db.GetAllMembers(col11));
                col2.Hide();
                col2text.Hide();
                col3.Hide();
                col3text.Hide();
                col4.Hide();
                col4text.Hide();
                col5.Hide();
                col5text.Hide();
                col6.Hide();
                col6text.Hide();
                Insert.Location = new Point(703, 155);
                randomlist.Items.Add(col1.Text);
            }
            else
            if (colmsno == 2)
            {
                String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                String tcol1 = Convert.ToString(db.GetAllMembers(ctcol1));
                if (tcol1 == "0")
                {
                    col1text.MaxLength = 19;
                }
                String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                String tcol2 = Convert.ToString(db.GetAllMembers(ctcol2));
                if (tcol2 == "0")
                {
                    col2text.MaxLength = 19;
                }
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                col1.Text = Convert.ToString(db.GetAllMembers(col11));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                col2.Text = Convert.ToString(db.GetAllMembers(col22));
                col3.Hide();
                col3text.Hide();
                col4.Hide();
                col4text.Hide();
                col5.Hide();
                col5text.Hide();
                col6.Hide();
                col6text.Hide();
                Insert.Location = new Point(703, 180);
                randomlist.Items.Add(col1.Text);
                randomlist.Items.Add(col2.Text);
            }
            else
            if (colmsno == 3)
            {
                String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                String tcol1 = Convert.ToString(db.GetAllMembers(ctcol1));
                if (tcol1 == "0")
                {
                    col1text.MaxLength = 19;
                }
                String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                String tcol2 = Convert.ToString(db.GetAllMembers(ctcol2));
                if (tcol2 == "0")
                {
                    col2text.MaxLength = 19;
                }
                String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                String tcol3 = Convert.ToString(db.GetAllMembers(ctcol3));
                if (tcol3 == "0")
                {
                    col3text.MaxLength = 19;
                }
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                col1.Text = Convert.ToString(db.GetAllMembers(col11));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                col2.Text = Convert.ToString(db.GetAllMembers(col22));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                col3.Text = Convert.ToString(db.GetAllMembers(col33));
                col4.Hide();
                col4text.Hide();
                col5.Hide();
                col5text.Hide();
                col6.Hide();
                col6text.Hide();
                Insert.Location = new Point(703, 205);
                randomlist.Items.Add(col1.Text);
                randomlist.Items.Add(col2.Text);
                randomlist.Items.Add(col3.Text);
            }
            else
            if (colmsno == 4)
            {
                String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                String tcol1 = Convert.ToString(db.GetAllMembers(ctcol1));
                if (tcol1 == "0")
                {
                    col1text.MaxLength = 19;
                }
                String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                String tcol2 = Convert.ToString(db.GetAllMembers(ctcol2));
                if (tcol2 == "0")
                {
                    col2text.MaxLength = 19;
                }
                String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                String tcol3 = Convert.ToString(db.GetAllMembers(ctcol3));
                if (tcol3 == "0")
                {
                    col3text.MaxLength = 19;
                }
                String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                String tcol4 = Convert.ToString(db.GetAllMembers(ctcol4));
                if (tcol4 == "0")
                {
                    col4text.MaxLength = 19;
                }
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                col1.Text = Convert.ToString(db.GetAllMembers(col11));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                col2.Text = Convert.ToString(db.GetAllMembers(col22));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                col3.Text = Convert.ToString(db.GetAllMembers(col33));
                String col44 = "SELECT col4 FROM " + tablenamex + ";";
                col4.Text = Convert.ToString(db.GetAllMembers(col44));
                col5.Hide();
                col5text.Hide();
                col6.Hide();
                col6text.Hide();
                Insert.Location = new Point(703, 230);
                randomlist.Items.Add(col1.Text);
                randomlist.Items.Add(col2.Text);
                randomlist.Items.Add(col3.Text);
                randomlist.Items.Add(col4.Text);
            }
            else
            if (colmsno == 5)
            {
                String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                String tcol1 = Convert.ToString(db.GetAllMembers(ctcol1));
                if (tcol1 == "0")
                {
                    col1text.MaxLength = 19;
                }
                String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                String tcol2 = Convert.ToString(db.GetAllMembers(ctcol2));
                if (tcol2 == "0")
                {
                    col2text.MaxLength = 19;
                }
                String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                String tcol3 = Convert.ToString(db.GetAllMembers(ctcol3));
                if (tcol3 == "0")
                {
                    col3text.MaxLength = 19;
                }
                String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                String tcol4 = Convert.ToString(db.GetAllMembers(ctcol4));
                if (tcol4 == "0")
                {
                    col4text.MaxLength = 19;
                }
                String ctcol5 = "SELECT col5type FROM " + tablenamex + ";";
                String tcol5 = Convert.ToString(db.GetAllMembers(ctcol5));
                if (tcol5 == "0")
                {
                    col5text.MaxLength = 19;
                }
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                col1.Text = Convert.ToString(db.GetAllMembers(col11));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                col2.Text = Convert.ToString(db.GetAllMembers(col22));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                col3.Text = Convert.ToString(db.GetAllMembers(col33));
                String col44 = "SELECT col4 FROM " + tablenamex + ";";
                col4.Text = Convert.ToString(db.GetAllMembers(col44));
                String col55 = "SELECT col5 FROM " + tablenamex + ";";
                col5.Text = Convert.ToString(db.GetAllMembers(col55));
                col6.Hide();
                col6text.Hide();
                Insert.Location = new Point(703, 255);
                randomlist.Items.Add(col1.Text);
                randomlist.Items.Add(col2.Text);
                randomlist.Items.Add(col3.Text);
                randomlist.Items.Add(col4.Text);
                randomlist.Items.Add(col5.Text);
            }
            else
            if (colmsno == 6)
            {
                String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                String tcol1 = Convert.ToString(db.GetAllMembers(ctcol1));
                if (tcol1 == "0")
                {
                    col1text.MaxLength = 19;
                }
                String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                String tcol2 = Convert.ToString(db.GetAllMembers(ctcol2));
                if (tcol2 == "0")
                {
                    col2text.MaxLength = 19;
                }
                String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                String tcol3 = Convert.ToString(db.GetAllMembers(ctcol3));
                if (tcol3 == "0")
                {
                    col3text.MaxLength = 19;
                }
                String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                String tcol4 = Convert.ToString(db.GetAllMembers(ctcol4));
                if (tcol4 == "0")
                {
                    col4text.MaxLength = 19;
                }
                String ctcol5 = "SELECT col5type FROM " + tablenamex + ";";
                String tcol5 = Convert.ToString(db.GetAllMembers(ctcol5));
                if (tcol5 == "0")
                {
                    col5text.MaxLength = 19;
                }
                String ctcol6 = "SELECT col6type FROM " + tablenamex + ";";
                String tcol6 = Convert.ToString(db.GetAllMembers(ctcol6));
                if (tcol6 == "0")
                {
                    col6text.MaxLength = 19;
                }
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                col1.Text = Convert.ToString(db.GetAllMembers(col11));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                col2.Text = Convert.ToString(db.GetAllMembers(col22));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                col3.Text = Convert.ToString(db.GetAllMembers(col33));
                String col44 = "SELECT col4 FROM " + tablenamex + ";";
                col4.Text = Convert.ToString(db.GetAllMembers(col44));
                String col55 = "SELECT col5 FROM " + tablenamex + ";";
                col5.Text = Convert.ToString(db.GetAllMembers(col55));
                String col66 = "SELECT col6 FROM " + tablenamex + ";";
                col6.Text = Convert.ToString(db.GetAllMembers(col66));
                randomlist.Items.Add(col1.Text);
                randomlist.Items.Add(col2.Text);
                randomlist.Items.Add(col3.Text);
                randomlist.Items.Add(col4.Text);
                randomlist.Items.Add(col5.Text);
                randomlist.Items.Add(col6.Text);
            }
            else
            {
                MessageBox.Show("Oops.. Something went wrong!");
            }

            String uidx = "SELECT idtype FROM " + tablenamex + ";";
            string uidxxx = "SELECT id FROM " + tablenamex + ";";
            int uidxx = Convert.ToInt16(db.GetAllMembers(uidx));
            if (uidxx == 1)
            {
                IDlabel.Text = Convert.ToString(db.GetAllMembers(uidxxx));
                pklabel.Hide();
                IDtext.Show();
                IDlabel.Show();
            }
            else
            if (uidxx == 0)
            {
                pklabel.Show();
                IDtext.Hide();
            }
        }

        private void col1text_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchrandomtext_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void searchrandom_Click(object sender, EventArgs e)
        {
            if(text1 == "" || text1 == null)
            {
                MessageBox.Show("Error : Select a column in order to search.");
            }
            else
            {
            String randomt = Convert.ToString(searchrandomtext.Text);
            Members mm = new Members();
            String sql = "SELECT * FROM " + tablenamex + " WHERE " + text1 + " LIKE '%" + randomt + "%' ;";
            tablegrid.DataSource = mm.GetAllMembers(sql);
            }
        }

        private void tablenamelabel_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
     
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Insert radio button ****
        {
            editidb.Location = new Point(840, 31);
            editcol1b.Location = new Point(840, 127);
            editcol2b.Location = new Point(840, 151);
            editcol3b.Location = new Point(840, 176);
            editcol4b.Location = new Point(840, 199);
            editcol5b.Location = new Point(840, 225);
            editcol6b.Location = new Point(840, 250);
            this.Size = new Size(915, 347);
            db2 db = new db2();
            String uidx = "SELECT idtype FROM " + tablenamex + ";";
            string uidxxx = "SELECT id FROM " + tablenamex + ";";
            int uidxx = Convert.ToInt16(db.GetAllMembers(uidx));
            if (uidxx == 1)
            {
                pklabel.Hide();
                IDlabel.Show();
                IDtext.Show();
                editlabelpk.Hide();
            }
            else
            if (uidxx == 0)
            {
                pklabel.Show();
                IDlabel.Hide();
                IDtext.Hide();
                editlabelpk.Hide();
            }

            Insert.Show();
            editidl.Hide();
            editidtb.Hide();
            editidb.Hide();
            editcol1b.Hide();
            editcol2b.Hide();
            editcol3b.Hide();
            editcol4b.Hide();
            editcol5b.Hide();
            editcol6b.Hide();
            col1text.Clear();
            col2text.Clear();
            col3text.Clear();
            col4text.Clear();
            col5text.Clear();
            col6text.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Edit Radio Button ******
        {
            this.Size = new Size(975, 347);
            db2 db = new db2();
            String uidx = "SELECT idtype FROM " + tablenamex + ";";
            string uidxxx = "SELECT id FROM " + tablenamex + ";";
            int uidxx = Convert.ToInt16(db.GetAllMembers(uidx));
            if (uidxx == 1)
            {                             
                    pklabel.Hide();
                    IDlabel.Hide();
                    IDtext.Hide();
                    editlabelpk.Show();
            }
            else
            if (uidxx == 0)
            {
                pklabel.Hide();
                IDlabel.Hide();
                IDtext.Hide();
                editlabelpk.Show();
            }

            Insert.Hide();
            editidl.Show();
            editidtb.Show();
            editidb.Show();
            editidb.Location = new Point(902, 31);
            if (colmsno == 1)
            {
                editcol1b.Show();
                col1text.Clear();
                editidb.Location = new Point(902, 31);
                editcol1b.Location = new Point(902,127);
            }
            else
            if (colmsno == 2)
            {
                editcol1b.Show();
                editcol2b.Show();
                col1text.Clear();
                col2text.Clear();
                editidb.Location = new Point(902, 31);
                editcol1b.Location = new Point(902, 127);
                editcol2b.Location = new Point(902, 151);
            }
            else
            if (colmsno == 3)
            {
                editcol1b.Show();
                editcol2b.Show();
                editcol3b.Show();
                col1text.Clear();
                col2text.Clear();
                col3text.Clear();
                editidb.Location = new Point(902, 31);
                editcol1b.Location = new Point(902, 127);
                editcol2b.Location = new Point(902, 151);
                editcol3b.Location = new Point(902, 176);
            }
            else
            if (colmsno == 4)
            {
                editcol1b.Show();
                editcol2b.Show();
                editcol3b.Show();
                editcol4b.Show();
                col1text.Clear();
                col2text.Clear();
                col3text.Clear();
                col4text.Clear();
                editidb.Location = new Point(902, 31);
                editcol1b.Location = new Point(902, 127);
                editcol2b.Location = new Point(902, 151);
                editcol3b.Location = new Point(902, 176);
                editcol4b.Location = new Point(902, 199);
            }
            else
            if (colmsno == 5)
            {
                editcol1b.Show();
                editcol2b.Show();
                editcol3b.Show();
                editcol4b.Show();
                editcol5b.Show();
                col1text.Clear();
                col2text.Clear();
                col3text.Clear();
                col4text.Clear();
                col5text.Clear();
                editidb.Location = new Point(902, 31);
                editcol1b.Location = new Point(902, 127);
                editcol2b.Location = new Point(902, 151);
                editcol3b.Location = new Point(902, 176);
                editcol4b.Location = new Point(902, 199);
                editcol5b.Location = new Point(902, 225);
            }
            else
            if (colmsno == 6)
            {
                editcol1b.Show();
                editcol2b.Show();
                editcol3b.Show();
                editcol4b.Show();
                editcol5b.Show();
                editcol6b.Show();
                col1text.Clear();
                col2text.Clear();
                col3text.Clear();
                col4text.Clear();
                col5text.Clear();
                col6text.Clear();
                editidb.Location = new Point(902, 31);
                editcol1b.Location = new Point(902, 127);
                editcol2b.Location = new Point(902, 151);
                editcol3b.Location = new Point(902, 176);
                editcol4b.Location = new Point(902, 199);
                editcol5b.Location = new Point(902, 225);
                editcol6b.Location = new Point(902, 250);
            }
        }
        String searchstr = "";
        private void editidb_Click(object sender, EventArgs e)
        {
            db2 getid = new db2();
            String idtp = "SELECT idtype FROM " + tablenamex + ";";            
            Members mm = new Members();
            String idoutput;
            String searchid = Convert.ToString(editidtb.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";            
            idoutput = getid.GetAllMembers(sqlidget);
            int iidtp = Convert.ToInt16(getid.GetAllMembers(idtp));     //ID Type. 1 = varchar 0 = int
            String key = "-1";          
                try
                {
                    SqlConnection con = new SqlConnection(datasource);
                if(iidtp == 1)
                {
                    SqlCommand cmd = new SqlCommand(" SELECT COUNT(*) FROM " + tablenamex + " WHERE " + idoutput + "= '" + editidtb.Text + "' ;", con);
                    con.Open();
                    key = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                }
                else
                if(iidtp == 0)
                {
                    if(System.Text.RegularExpressions.Regex.IsMatch(searchid, "^[0-9]*$") && editidtb.Text != "")
                    {
                    SqlCommand cmd = new SqlCommand(" SELECT COUNT(*) FROM " + tablenamex + " WHERE " + idoutput + "= " + editidtb.Text + " ;", con);
                    con.Open();
                    key = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error : Incorrect Search String. Please use an integer value");
                        editidtb.Clear();
                    }
                }

                }
                catch
                {
                    MessageBox.Show("search is not working....");
                }
            if(key == "0")
            {
                MessageBox.Show("ID not found!");
                editidtb.Clear();
            }
            else
                if(key == "1")
                {
                String sql = " SELECT * FROM " + tablenamex + " WHERE " + idoutput + " = '" + searchid + "' ;";
                tablegrid.DataSource = mm.GetAllMembers(sql);
                searchstr = searchid;
                }
        }

        private void col2text_TextChanged(object sender, EventArgs e)
        {
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            db2 insb = new db2();
            Members mm = new Members();
            String idtp = "SELECT idtype FROM " + tablenamex + ";";
            String colmsn = "SELECT colms FROM " + tablenamex + ";";
            String idnamex = "SELECT id FROM " + tablenamex + ";";
            int iidtp = Convert.ToInt16(insb.GetAllMembers(idtp));     //ID Type. 1 = varchar 0 = int
            int ccolmsn = Convert.ToInt16(insb.GetAllMembers(colmsn)); //No of columns **
            String outidnamex = Convert.ToString(insb.GetAllMembers(idnamex));
            String icol1 = "", icol2 = "", icol3 = "", icol4 = "", icol5 = "", icol6 = "";           //insert RButton
            String tcol1 = "", tcol2 = "", tcol3 = "", tcol4 = "", tcol5 = "", tcol6 = "";           //Column Type
            int colmsni = Convert.ToInt16(ccolmsn);                    //For insert....
            String idname="";
            int newID = -1;
            String returnid = "";
            int Errorid = 0, Errorcol1 = 0, Errorcol2 = 0, Errorcol3 = 0, Errorcol4 = 0, Errorcol5 = 0, Errorcol6 = 0; //Error1 = id error(exists) -----
            int col1ok, col2ok, col3ok, col4ok, col5ok, col6ok; col1ok = col2ok = col3ok = col4ok = col5ok = col6ok = -1;         

            if (rbedit.Checked == false)
            {
                if (iidtp == 1)        //id = 1 == varchar
                {
                    idname = Convert.ToString(IDtext.Text);
                    SqlConnection con = new SqlConnection(datasource);
                       try
                       {
                            con.Open();
                            String sqlout = "SELECT * FROM " + tablenamex +" WHERE " + outidnamex + " = '" + idname + "';";
                            SqlCommand cmd = new SqlCommand(sqlout, con);
                            returnid = (String)cmd.ExecuteScalar();                   
                            if(returnid == idname)
                            {
                                newID = 1;
                            }
                            else
                            {
                                newID = 0;
                            }
                            //newID = Convert.ToInt32(cmd.ExecuteScalar());   //(int)cmd.ExecuteScalar();*/
                            con.Close();
                                                      
                       }
                       catch
                       {
                            MessageBox.Show("Error: Something went wrong!");
                       }

                    if (newID == 1)
                    {                        
                        IDtext.Clear();
                        idname = "";
                        Errorid = 1;
                        //Need to complete
                    }
                    else
                    if (newID == 0)
                    {
                        Errorid = 0;
                    }

                    if (colmsni == 1)
                    {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        if (tcol1 == "0")
                        {
                            col1text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text !="")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                    }
                    else
                    if (colmsni == 2)
                    {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        if (tcol1 == "0")
                        {
                            col1text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            col2text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                    }
                    else
                    if (colmsni == 3)
                    {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        if (tcol1 == "0")
                        {
                            col1text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            col2text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            col3text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                    }
                    else
                    if (colmsni == 4)
                    {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                        tcol4 = Convert.ToString(insb.GetAllMembers(ctcol4));
                        icol4 = Convert.ToString(col4text.Text);
                        if (tcol1 == "0")
                        {
                            col1text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            col2text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            col3text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                        if (tcol4 == "0")
                        {
                            col4text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol4, "^[0-9]*$") && col4text.Text != "")
                            {
                                Errorcol4 = 0;
                            }
                            else
                            {
                                Errorcol4 = 1;
                                col4text.Clear();
                            }
                        }
                    }
                    else
                    if (colmsni == 5)
                    {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                        tcol4 = Convert.ToString(insb.GetAllMembers(ctcol4));
                        icol4 = Convert.ToString(col4text.Text);
                        String ctcol5 = "SELECT col5type FROM " + tablenamex + ";";
                        tcol5 = Convert.ToString(insb.GetAllMembers(ctcol5));
                        icol5 = Convert.ToString(col5text.Text);
                        if (tcol1 == "0")
                        {
                            col1text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            col2text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            col3text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                        if (tcol4 == "0")
                        {
                            col4text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol4, "^[0-9]*$") && col4text.Text != "")
                            {
                                Errorcol4 = 0;
                            }
                            else
                            {
                                Errorcol4 = 1;
                                col4text.Clear();
                            }
                        }
                        if (tcol5 == "0")
                        {
                            col5text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol5, "^[0-9]*$") && col5text.Text != "")
                            {
                                Errorcol5 = 0;
                            }
                            else
                            {
                                Errorcol5 = 1;
                                col5text.Clear();
                            }
                        }
                    }
                    else
                    if (colmsni == 6)
                    {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                        tcol4 = Convert.ToString(insb.GetAllMembers(ctcol4));
                        icol4 = Convert.ToString(col4text.Text);
                        String ctcol5 = "SELECT col5type FROM " + tablenamex + ";";
                        tcol5 = Convert.ToString(insb.GetAllMembers(ctcol5));
                        icol5 = Convert.ToString(col5text.Text);
                        String ctcol6 = "SELECT col6type FROM " + tablenamex + ";";
                        tcol6 = Convert.ToString(insb.GetAllMembers(ctcol6));
                        icol6 = Convert.ToString(col6text.Text);
                        if (tcol1 == "0")
                        {
                            col1text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            col2text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            col3text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                        if (tcol4 == "0")
                        {
                            col4text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol4, "^[0-9]*$") && col4text.Text != "")
                            {
                                Errorcol4 = 0;
                            }
                            else
                            {
                                Errorcol4 = 1;
                                col4text.Clear();
                            }
                        }
                        if (tcol5 == "0")
                        {
                            col5text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol5, "^[0-9]*$") && col5text.Text != "")
                            {
                                Errorcol5 = 0;
                            }
                            else
                            {
                                Errorcol5 = 1;
                                col5text.Clear();
                            }
                        }
                        if (tcol6 == "0")
                        {
                            col6text.MaxLength = 19;
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol6, "^[0-9]*$") && col6text.Text != "")
                            {
                                Errorcol6 = 0;
                            }
                            else
                            {
                                Errorcol6 = 1;
                                col6text.Clear();
                            }
                        }
                    }
                    if (colmsni == 1) //SQL QUERY- INSERTION
                    {
                        if (Errorid == 0)
                        {
                        if (IDtext.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(IDtext.Text, "^[ ]*$"))
                        {
                            if (tcol1 == "0") //type 0 - int 1-varchar  **If col1 type is = 0 means int, check for errorcol = 1, if col1type is 1, var, dw about error 
                            {
                                if (Errorcol1 == 0) //int
                                {
                                    String sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + ")" +
                                                  "VALUES('" + idname + "'," + icol1 + ");";
                                    mm.GetAllMembers(sqlx);
                                }
                                else
                                {
                                    MessageBox.Show("Error : Incorrect input for the Column : "+col1.Text+"\n  Tip: "+col1.Text+" accepts only Integers");
                                    col1text.Clear();
                                }
                            }
                            else
                            if (tcol1 == "1") //varchar
                            {
                                String sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + ")" +
                                              "VALUES('" + idname + "','" + icol1 + "');";
                                mm.GetAllMembers(sqlx);
                            }
                        }                       
                        else
                        {
                            MessageBox.Show("Error : ID Cannot be NULL");
                        }
                        }
                        else
                        {
                            MessageBox.Show("Error : ID already exists");
                        }
                    }
                    else
                    if (colmsni == 2)           // ******** 2nd colmsni
                        {
                        if (Errorid == 0)
                        {
                        if (IDtext.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(IDtext.Text, "^[ ]*$"))
                        {
                            if (tcol1 == "0") // int
                            {
                                if (Errorcol1 == 0) // entered is int
                                {
                                    col1ok = 0;                                  
                                }
                                else
                                {
                                    col1ok = 1;
                                   MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");                                    
                                }
                            }
                            else
                            if (tcol1 == "1") //varchar
                            {
                                    col1ok = 0;
                            }

                            if (tcol2 == "0")
                            {
                                if (Errorcol2 == 0) //int
                                {
                                        col2ok = 0;
                                }
                                else
                                {
                                   col2ok = 1;
                                   MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                                }
                            }
                            else
                            if (tcol2 == "1") //varchar
                            {
                                    col2ok = 0;
                            }                           
                        if(col1ok == 0 && col2ok == 0)
                        {
                            String sqlx;
                           if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                           {                                                        
                                    if (tcol2 == "0")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + ")" +
                                                          "VALUES('" + idname + "'," + icol1 +","+icol2+");";
                                        mm.GetAllMembers(sqlx);
                                    }
                                    else
                                    if (tcol2 == "1")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + ")" +
                                                    "VALUES('" + idname + "'," + icol1 +",'"+icol2+"');";
                                        mm.GetAllMembers(sqlx);
                                    }
                           }
                           else
                           if(tcol1 == "1") // varchar
                           {
                                    if (tcol2 == "0")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + ")" +
                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ");";
                                        mm.GetAllMembers(sqlx);
                                    }
                                    else
                                    if (tcol2 == "1")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + ")" +
                                                    "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "');";
                                        mm.GetAllMembers(sqlx);
                                    }
                           }
                           }
                        }
                        else
                        {
                            MessageBox.Show("Error : ID cannot be NULL");
                        }
                        }
                        else
                        {
                            MessageBox.Show("Error : ID already exists");
                        }
                    }
                    else
                    if (colmsni == 3)           // ******** 2nd colmsni
                    {
                        if (Errorid == 0)
                        {
                            if (IDtext.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(IDtext.Text, "^[ ]*$"))
                            {
                                if (tcol1 == "0") // int
                                {
                                    if (Errorcol1 == 0) // entered is int
                                    {
                                        col1ok = 0;
                                    }
                                    else
                                    {
                                        col1ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol1 == "1") //varchar
                                {
                                    col1ok = 0;
                                }
                                if (tcol2 == "0")
                                {
                                    if (Errorcol2 == 0) //int
                                    {
                                        col2ok = 0;
                                    }
                                    else
                                    {
                                        col2ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol2 == "1") //varchar
                                {
                                    col2ok = 0;
                                }

                                if (tcol3 == "0")
                                {
                                    if (Errorcol3 == 0) //int
                                    {
                                        col3ok = 0;
                                    }
                                    else
                                    {
                                        col3ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol3 == "1") //varchar
                                {
                                    col3ok = 0;
                                }
                                if (col1ok == 0 && col2ok == 0 && col3ok == 0)
                                {
                                    String sqlx;
                                    if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                                    {
                                        if (tcol2 == "0")
                                        {                                         
                                            if (tcol3 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + ","+col3.Text+")" +
                                                                  "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                            "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                            "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                    else
                                    if (tcol1 == "1") // varchar
                                    {
                                        if (tcol2 == "0")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                            "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                            "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error : ID cannot be NULL");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error : ID already exists");
                        }
                    }
                    else
                        if (colmsni == 4)           // ******** 2nd colmsni
                        {
                        if (Errorid == 0)
                        {
                            if (IDtext.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(IDtext.Text, "^[ ]*$"))
                            {
                                if (tcol1 == "0") // int
                                {
                                    if (Errorcol1 == 0) // entered is int
                                    {
                                        col1ok = 0;
                                    }
                                    else
                                    {
                                        col1ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol1 == "1") //varchar
                                {
                                    col1ok = 0;
                                }
                                if (tcol2 == "0")
                                {
                                    if (Errorcol2 == 0) //int
                                    {
                                        col2ok = 0;
                                    }
                                    else
                                    {
                                        col2ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol2 == "1") //varchar
                                {
                                    col2ok = 0;
                                }

                                if (tcol3 == "0")
                                {
                                    if (Errorcol3 == 0) //int
                                    {
                                        col3ok = 0;
                                    }
                                    else
                                    {
                                        col3ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol3 == "1") //varchar
                                {
                                    col3ok = 0;
                                }

                                if (tcol4 == "0")
                                {
                                    if (Errorcol4 == 0) //int
                                    {
                                        col4ok = 0;
                                    }
                                    else
                                    {
                                        col4ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col4.Text + "\n  Tip: " + col4.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol4 == "1") //varchar
                                {
                                    col4ok = 0;
                                }
                                if (col1ok == 0 && col2ok == 0 && col3ok == 0 && col4ok == 0)
                                {
                                    String sqlx;
                                    if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                                    {
                                        if (tcol2 == "0")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }

                                            }
                                        }
                                    }
                                    else
                                    if (tcol1 == "1") // varchar
                                    {
                                        if (tcol2 == "0")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                                  "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }

                                            }
                                        }
                                    
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error : ID cannot be NULL");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error : ID already exists");
                        }
                        }
                    else
                        if (colmsni == 5)           // ******** 2nd colmsni
                        {
                        if (Errorid == 0)
                        {
                            if (IDtext.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(IDtext.Text, "^[ ]*$"))
                            {
                                if (tcol1 == "0") // int
                                {
                                    if (Errorcol1 == 0) // entered is int
                                    {
                                        col1ok = 0;
                                    }
                                    else
                                    {
                                        col1ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol1 == "1") //varchar
                                {
                                    col1ok = 0;
                                }
                                if (tcol2 == "0")
                                {
                                    if (Errorcol2 == 0) //int
                                    {
                                        col2ok = 0;
                                    }
                                    else
                                    {
                                        col2ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol2 == "1") //varchar
                                {
                                    col2ok = 0;
                                }

                                if (tcol3 == "0")
                                {
                                    if (Errorcol3 == 0) //int
                                    {
                                        col3ok = 0;
                                    }
                                    else
                                    {
                                        col3ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol3 == "1") //varchar
                                {
                                    col3ok = 0;
                                }

                                if (tcol4 == "0")
                                {
                                    if (Errorcol4 == 0) //int
                                    {
                                        col4ok = 0;
                                    }
                                    else
                                    {
                                        col4ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col4.Text + "\n  Tip: " + col4.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol4 == "1") //varchar
                                {
                                    col4ok = 0;
                                }
                                if (tcol5 == "0")
                                {
                                    if (Errorcol5 == 0) //int
                                    {
                                        col5ok = 0;
                                    }
                                    else
                                    {
                                        col5ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col5.Text + "\n  Tip: " + col5.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol5 == "1") //varchar
                                {
                                    col5ok = 0;
                                }
                                if (col1ok == 0 && col2ok == 0 && col3ok == 0 && col4ok == 0 && col5ok == 0)
                                {
                                    String sqlx;
                                    if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                                    {
                                        if (tcol2 == "0")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 +");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "','"+ icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")//
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "0")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "0")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }

                                            }
                                        }
                                    }
                                    else
                                    if (tcol1 == "1") // varchar
                                    {
                                        if (tcol2 == "0")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")//
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "0")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "0")//
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                         if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                                      "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                        mm.GetAllMembers(sqlx);
                                                    }
                                                }

                                            }
                                         }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error : ID cannot be NULL");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error : ID already exists");
                        }
                        }
                    else
                        if (colmsni == 6)           // ******** 6th colmsni
                        {
                        if (Errorid == 0)
                        {
                            if (IDtext.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(IDtext.Text, "^[ ]*$"))
                            {
                                if (tcol1 == "0") // int
                                {
                                    if (Errorcol1 == 0) // entered is int
                                    {
                                        col1ok = 0;
                                    }
                                    else
                                    {
                                        col1ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol1 == "1") //varchar
                                {
                                    col1ok = 0;
                                }
                                if (tcol2 == "0")
                                {
                                    if (Errorcol2 == 0) //int
                                    {
                                        col2ok = 0;
                                    }
                                    else
                                    {
                                        col2ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol2 == "1") //varchar
                                {
                                    col2ok = 0;
                                }

                                if (tcol3 == "0")
                                {
                                    if (Errorcol3 == 0) //int
                                    {
                                        col3ok = 0;
                                    }
                                    else
                                    {
                                        col3ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol3 == "1") //varchar
                                {
                                    col3ok = 0;
                                }

                                if (tcol4 == "0")
                                {
                                    if (Errorcol4 == 0) //int
                                    {
                                        col4ok = 0;
                                    }
                                    else
                                    {
                                        col4ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col4.Text + "\n  Tip: " + col4.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol4 == "1") //varchar
                                {
                                    col4ok = 0;
                                }
                                if (tcol5 == "0")
                                {
                                    if (Errorcol5 == 0) //int
                                    {
                                        col5ok = 0;
                                    }
                                    else
                                    {
                                        col5ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col5.Text + "\n  Tip: " + col5.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol5 == "1") //varchar
                                {
                                    col5ok = 0;
                                }
                                if (tcol6 == "0")
                                {
                                    if (Errorcol6 == 0) //int
                                    {
                                        col6ok = 0;
                                    }
                                    else
                                    {
                                        col6ok = 1;
                                        MessageBox.Show("Error : Incorrect input for the Column : " + col6.Text + "\n  Tip: " + col6.Text + " accepts only Integers");
                                    }
                                }
                                else
                                if (tcol6 == "1") //varchar
                                {
                                    col6ok = 0;
                                }
                                if (col1ok == 0 && col2ok == 0 && col3ok == 0 && col4ok == 0 && col5ok == 0 && col6ok == 0)
                                {
                                    String sqlx;
                                    if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                                    {
                                        if (tcol2 == "0")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")//
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")// 31 41 
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "1")//31
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")//31 40
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                             if (tcol3 == "1")//
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")// 31 41 
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "1")//31
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")//31 40
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "'," + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                             }
                                        }
                                    }
                                    else
                                    if (tcol1 == "1") // varchar
                                    {
                                        if (tcol2 == "0")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            if (tcol3 == "1")//
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")// 31 41 
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "1")//31
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")//31 40
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        if (tcol2 == "1")
                                        {
                                            if (tcol3 == "0")
                                            {
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                             if (tcol3 == "1")//
                                            {
                                                if (tcol4 == "1")
                                                {
                                                    if (tcol5 == "1")//
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")// 31 41 
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                                else
                                                if (tcol4 == "0")
                                                {
                                                    if (tcol5 == "1")//31
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                    else
                                                    if (tcol5 == "0")//31 40
                                                    {
                                                        if (tcol6 == "0")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                        else
                                                        if (tcol6 == "1")
                                                        {
                                                            sqlx = "INSERT INTO " + tablenamex + "(" + outidnamex + "," + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                          "VALUES('" + idname + "','" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                            mm.GetAllMembers(sqlx);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error : ID cannot be NULL");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error : ID already exists");
                        }
                        }
                }              
                else
                if (iidtp == 0)
                {
                    if (colmsni == 1)
                    {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        if (tcol1 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                    }
                    else
                     if (colmsni == 2)
                     {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        if (tcol1 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                    }
                    else
                     if (colmsni == 3)
                     {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        if (tcol1 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                     }
                    else
                     if (colmsni == 4)
                     {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                        tcol4 = Convert.ToString(insb.GetAllMembers(ctcol4));
                        icol4 = Convert.ToString(col4text.Text);
                        if (tcol1 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                        if (tcol4 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol4, "^[0-9]*$") && col4text.Text != "")
                            {
                                Errorcol4 = 0;
                            }
                            else
                            {
                                Errorcol4 = 1;
                                col4text.Clear();
                            }
                        }
                     }
                    else
                     if (colmsni == 5)
                     {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                        tcol4 = Convert.ToString(insb.GetAllMembers(ctcol4));
                        icol4 = Convert.ToString(col4text.Text);
                        String ctcol5 = "SELECT col5type FROM " + tablenamex + ";";
                        tcol5 = Convert.ToString(insb.GetAllMembers(ctcol5));
                        icol5 = Convert.ToString(col5text.Text);
                        if (tcol1 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                        if (tcol4 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol4, "^[0-9]*$") && col4text.Text != "")
                            {
                                Errorcol4 = 0;
                            }
                            else
                            {
                                Errorcol4 = 1;
                                col4text.Clear();
                            }
                        }
                        if (tcol5 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol5, "^[0-9]*$") && col5text.Text != "")
                            {
                                Errorcol5 = 0;
                            }
                            else
                            {
                                Errorcol5 = 1;
                                col5text.Clear();
                            }
                        }
                     }
                    else
                     if (colmsni == 6)
                     {
                        String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                        tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                        icol1 = Convert.ToString(col1text.Text);
                        String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                        tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                        icol2 = Convert.ToString(col2text.Text);
                        String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                        tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                        icol3 = Convert.ToString(col3text.Text);
                        String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                        tcol4 = Convert.ToString(insb.GetAllMembers(ctcol4));
                        icol4 = Convert.ToString(col4text.Text);
                        String ctcol5 = "SELECT col5type FROM " + tablenamex + ";";
                        tcol5 = Convert.ToString(insb.GetAllMembers(ctcol5));
                        icol5 = Convert.ToString(col5text.Text);
                        String ctcol6 = "SELECT col6type FROM " + tablenamex + ";";
                        tcol6 = Convert.ToString(insb.GetAllMembers(ctcol6));
                        icol6 = Convert.ToString(col6text.Text);
                        if (tcol1 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol1, "^[0-9]*$") && col1text.Text != "")
                            {
                                Errorcol1 = 0;
                            }
                            else
                            {
                                Errorcol1 = 1;
                                col1text.Clear();
                            }
                        }
                        if (tcol2 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol2, "^[0-9]*$") && col2text.Text != "")
                            {
                                Errorcol2 = 0;
                            }
                            else
                            {
                                Errorcol2 = 1;
                                col2text.Clear();
                            }
                        }
                        if (tcol3 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol3, "^[0-9]*$") && col3text.Text != "")
                            {
                                Errorcol3 = 0;
                            }
                            else
                            {
                                Errorcol3 = 1;
                                col3text.Clear();
                            }
                        }
                        if (tcol4 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol4, "^[0-9]*$") && col4text.Text != "")
                            {
                                Errorcol4 = 0;
                            }
                            else
                            {
                                Errorcol4 = 1;
                                col4text.Clear();
                            }
                        }
                        if (tcol5 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol5, "^[0-9]*$") && col5text.Text != "")
                            {
                                Errorcol5 = 0;
                            }
                            else
                            {
                                Errorcol5 = 1;
                                col5text.Clear();
                            }
                        }
                        if (tcol6 == "0")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(icol6, "^[0-9]*$") && col6text.Text != "")
                            {
                                Errorcol6 = 0;
                            }
                            else
                            {
                                Errorcol6 = 1;
                                col6text.Clear();
                            }
                        }
                     }
                    if (colmsni == 1) //SQL QUERY- INSERTION
                    {
                        if (tcol1 == "0") //type 0 - int 1-varchar  **If col1 type is = 0 means int, check for errorcol = 1, if col1type is 1, var, dw about error 
                        {
                            if (Errorcol1 == 0) //int
                            {
                                String sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + ")" +
                                              "VALUES(" + icol1 + ");";
                                mm.GetAllMembers(sqlx);
                            }
                            else
                            {
                                MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                                col1text.Clear();
                            }
                        }
                        else
                        if (tcol1 == "1") //varchar
                        {
                            String sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + ")" +
                                          "VALUES('" + icol1 + "');";
                            mm.GetAllMembers(sqlx);
                        }
                    }               
                else
                if (colmsni == 2)           // ******** 2nd colmsni
                {
                    if (tcol1 == "0") // int
                    {
                        if (Errorcol1 == 0) // entered is int
                        {
                            col1ok = 0;
                        }
                        else
                        {
                            col1ok = 1;
                            MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                        }
                    }
                    else
                    if (tcol1 == "1") //varchar
                    {
                        col1ok = 0;
                    }

                    if (tcol2 == "0")
                    {
                        if (Errorcol2 == 0) //int
                        {
                            col2ok = 0;
                        }
                        else
                        {
                            col2ok = 1;
                            MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                        }
                    }
                    else
                    if (tcol2 == "1") //varchar
                    {
                        col2ok = 0;
                    }
                    if (col1ok == 0 && col2ok == 0)
                    {
                        String sqlx;
                        if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                        {
                            if (tcol2 == "0")
                            {
                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + ")" +
                                                  "VALUES(" + icol1 + "," + icol2 + ");";
                                mm.GetAllMembers(sqlx);
                            }
                            else
                            if (tcol2 == "1")
                            {
                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + ")" +
                                            "VALUES(" + icol1 + ",'" + icol2 + "');";
                                mm.GetAllMembers(sqlx);
                            }
                        }
                        else
                        if (tcol1 == "1") // varchar
                        {
                            if (tcol2 == "0")
                            {
                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + ")" +
                                                  "VALUES('" + icol1 + "'," + icol2 + ");";
                                mm.GetAllMembers(sqlx);
                            }
                            else
                            if (tcol2 == "1")
                            {
                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + ")" +
                                            "VALUES('" + icol1 + "','" + icol2 + "');";
                                mm.GetAllMembers(sqlx);
                            }
                        }
                    }
                }
                else
                        if (colmsni == 3)           // ******** 2nd colmsni
                        {
                        if (tcol1 == "0") // int
                        {
                            if (Errorcol1 == 0) // entered is int
                            {
                                col1ok = 0;
                            }
                            else
                            {
                                col1ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol1 == "1") //varchar
                        {
                            col1ok = 0;
                        }
                        if (tcol2 == "0")
                        {
                            if (Errorcol2 == 0) //int
                            {
                                col2ok = 0;
                            }
                            else
                            {
                                col2ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol2 == "1") //varchar
                        {
                            col2ok = 0;
                        }

                        if (tcol3 == "0")
                        {
                            if (Errorcol3 == 0) //int
                            {
                                col3ok = 0;
                            }
                            else
                            {
                                col3ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol3 == "1") //varchar
                        {
                            col3ok = 0;
                        }
                        if (col1ok == 0 && col2ok == 0 && col3ok == 0)
                        {
                            String sqlx;
                            if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                          "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ");";
                                        mm.GetAllMembers(sqlx);
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                    "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "');";
                                        mm.GetAllMembers(sqlx);
                                    }
                                }
                                else
                                if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                          "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ");";
                                        mm.GetAllMembers(sqlx);
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                    "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "');";
                                        mm.GetAllMembers(sqlx);
                                    }
                                }
                            }
                            else
                            if (tcol1 == "1") // varchar
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                          "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ");";
                                        mm.GetAllMembers(sqlx);
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                    "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "');";
                                        mm.GetAllMembers(sqlx);
                                    }
                                }
                                else
                                if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                          "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ");";
                                        mm.GetAllMembers(sqlx);
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + ")" +
                                                    "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "');";
                                        mm.GetAllMembers(sqlx);
                                    }
                                }
                            }
                        }
                        }
                    else
                    if (colmsni == 4)           // ******** 2nd colmsni
                    {
                        if (tcol1 == "0") // int
                        {
                            if (Errorcol1 == 0) // entered is int
                            {
                                col1ok = 0;
                            }
                            else
                            {
                                col1ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol1 == "1") //varchar
                        {
                            col1ok = 0;
                        }
                        if (tcol2 == "0")
                        {
                            if (Errorcol2 == 0) //int
                            {
                                col2ok = 0;
                            }
                            else
                            {
                                col2ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol2 == "1") //varchar
                        {
                            col2ok = 0;
                        }

                        if (tcol3 == "0")
                        {
                            if (Errorcol3 == 0) //int
                            {
                                col3ok = 0;
                            }
                            else
                            {
                                col3ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol3 == "1") //varchar
                        {
                            col3ok = 0;
                        }

                        if (tcol4 == "0")
                        {
                            if (Errorcol4 == 0) //int
                            {
                                col4ok = 0;
                            }
                            else
                            {
                                col4ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col4.Text + "\n  Tip: " + col4.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol4 == "1") //varchar
                        {
                            col4ok = 0;
                        }
                        if (col1ok == 0 && col2ok == 0 && col3ok == 0 && col4ok == 0)
                        {
                            String sqlx;
                            if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                    }
                                }
                                else
                                if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }

                                    }
                                }
                            }
                            else
                            if (tcol1 == "1") // varchar
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                    }
                                }
                                else
                                if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + ");";
                                            mm.GetAllMembers(sqlx);
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + ")" +
                                                          "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "');";
                                            mm.GetAllMembers(sqlx);
                                        }

                                    }
                                }

                            }
                        }
                    }
                    else
                    if (colmsni == 5)           // ******** 2nd colmsni
                    {
                        if (tcol1 == "0") // int
                        {
                            if (Errorcol1 == 0) // entered is int
                            {
                                col1ok = 0;
                            }
                            else
                            {
                                col1ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol1 == "1") //varchar
                        {
                            col1ok = 0;
                        }
                        if (tcol2 == "0")
                        {
                            if (Errorcol2 == 0) //int
                            {
                                col2ok = 0;
                            }
                            else
                            {
                                col2ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol2 == "1") //varchar
                        {
                            col2ok = 0;
                        }

                        if (tcol3 == "0")
                        {
                            if (Errorcol3 == 0) //int
                            {
                                col3ok = 0;
                            }
                            else
                            {
                                col3ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol3 == "1") //varchar
                        {
                            col3ok = 0;
                        }

                        if (tcol4 == "0")
                        {
                            if (Errorcol4 == 0) //int
                            {
                                col4ok = 0;
                            }
                            else
                            {
                                col4ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col4.Text + "\n  Tip: " + col4.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol4 == "1") //varchar
                        {
                            col4ok = 0;
                        }
                        if (tcol5 == "0")
                        {
                            if (Errorcol5 == 0) //int
                            {
                                col5ok = 0;
                            }
                            else
                            {
                                col5ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col5.Text + "\n  Tip: " + col5.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol5 == "1") //varchar
                        {
                            col5ok = 0;
                        }
                        if (col1ok == 0 && col2ok == 0 && col3ok == 0 && col4ok == 0 && col5ok == 0)
                        {
                            String sqlx;
                            if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")//
                                    {
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "0")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "0")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                }
                                else
                                if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }

                                    }
                                }
                            }
                            else
                            if (tcol1 == "1") // varchar
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")//
                                    {
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "0")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "0")//
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                }
                                else
                                 if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ");";
                                                mm.GetAllMembers(sqlx);
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + ")" +
                                                              "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "');";
                                                mm.GetAllMembers(sqlx);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                    else
                    if (colmsni == 6)           // ******** 6th colmsni
                    {
                        if (tcol1 == "0") // int
                        {
                            if (Errorcol1 == 0) // entered is int
                            {
                                col1ok = 0;
                            }
                            else
                            {
                                col1ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol1 == "1") //varchar
                        {
                            col1ok = 0;
                        }
                        if (tcol2 == "0")
                        {
                            if (Errorcol2 == 0) //int
                            {
                                col2ok = 0;
                            }
                            else
                            {
                                col2ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol2 == "1") //varchar
                        {
                            col2ok = 0;
                        }

                        if (tcol3 == "0")
                        {
                            if (Errorcol3 == 0) //int
                            {
                                col3ok = 0;
                            }
                            else
                            {
                                col3ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol3 == "1") //varchar
                        {
                            col3ok = 0;
                        }

                        if (tcol4 == "0")
                        {
                            if (Errorcol4 == 0) //int
                            {
                                col4ok = 0;
                            }
                            else
                            {
                                col4ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col4.Text + "\n  Tip: " + col4.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol4 == "1") //varchar
                        {
                            col4ok = 0;
                        }
                        if (tcol5 == "0")
                        {
                            if (Errorcol5 == 0) //int
                            {
                                col5ok = 0;
                            }
                            else
                            {
                                col5ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col5.Text + "\n  Tip: " + col5.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol5 == "1") //varchar
                        {
                            col5ok = 0;
                        }
                        if (tcol6 == "0")
                        {
                            if (Errorcol6 == 0) //int
                            {
                                col6ok = 0;
                            }
                            else
                            {
                                col6ok = 1;
                                MessageBox.Show("Error : Incorrect input for the Column : " + col6.Text + "\n  Tip: " + col6.Text + " accepts only Integers");
                            }
                        }
                        else
                        if (tcol6 == "1") //varchar
                        {
                            col6ok = 0;
                        }
                        if (col1ok == 0 && col2ok == 0 && col3ok == 0 && col4ok == 0 && col5ok == 0 && col6ok == 0)
                        {
                            String sqlx;
                            if (tcol1 == "0")//mm.GetAllMembers(sqlx);  **makea public string and keep assigning - execute at the last one* //type = tcol1 = int
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")//
                                    {
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")// 31 41 
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "1")//31
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")//31 40
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + "," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                    }
                                    else
                                     if (tcol3 == "1")//
                                    {
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")// 31 41 
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "1")//31
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")//31 40
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            if (tcol1 == "1") // varchar
                            {
                                if (tcol2 == "0")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + "," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    if (tcol3 == "1")//
                                    {
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")// 31 41 
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "1")//31
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")//31 40
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "'," + icol2 + ",'" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                if (tcol2 == "1")
                                {
                                    if (tcol3 == "0")
                                    {
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + "," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "'," + icol3 + ",'" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                    }
                                    else
                                     if (tcol3 == "1")//
                                    {
                                        if (tcol4 == "1")
                                        {
                                            if (tcol5 == "1")//
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "','" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")// 31 41 
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "','" + icol4 + "'," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                        else
                                        if (tcol4 == "0")
                                        {
                                            if (tcol5 == "1")//31
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "'," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + ",'" + icol5 + "','" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                            else
                                            if (tcol5 == "0")//31 40
                                            {
                                                if (tcol6 == "0")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES(" + icol1 + ",'" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + "," + icol6 + ");";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                                else
                                                if (tcol6 == "1")
                                                {
                                                    sqlx = "INSERT INTO " + tablenamex + "(" + col1.Text + "," + col2.Text + "," + col3.Text + "," + col4.Text + "," + col5.Text + "," + col6.Text + ")" +
                                                                  "VALUES('" + icol1 + "','" + icol2 + "','" + icol3 + "'," + icol4 + "," + icol5 + ",'" + icol6 + "');";
                                                    mm.GetAllMembers(sqlx);
                                                }
                                            }
                                        }
                                     }
                                }
                            }
                        }
                    
                    }
                }
                String reset = "SELECT * FROM " + tablenamex + ";";
                tablegrid.DataSource = mm.GetAllMembers(reset);
            }
             else
             {
                MessageBox.Show("Not the correct insert button....");
             }
        }
        private void button1_Click(object sender, EventArgs e) //reset
        {
            String reset = "SELECT * FROM " + tablenamex + ";";
            Members mm = new Members();
            tablegrid.DataSource = mm.GetAllMembers(reset);
        }

        private void editcol1b_Click(object sender, EventArgs e)
        {
            db2 insb = new db2();
            Members mm = new Members();
            String ctcol = "SELECT col1type FROM " + tablenamex + ";";
            String tcol = Convert.ToString(insb.GetAllMembers(ctcol));
            String icol = Convert.ToString(col1text.Text);
            String icollabel = Convert.ToString(col1.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";
            String id = insb.GetAllMembers(sqlidget);
            String sqlidtype = "SELECT idtype FROM " + tablenamex + ";"; 
            String idtype = insb.GetAllMembers(sqlidtype);
            String sql = "";
            
            if (tcol == "0")
            {
                String ctcol1 = "SELECT col1type FROM " + tablenamex + ";";
                String tcol1 = Convert.ToString(insb.GetAllMembers(ctcol1));
                if (tcol1 == "0")
                {
                    col1text.MaxLength = 19;
                }
               
                if (searchstr != "")
                {
                if (System.Text.RegularExpressions.Regex.IsMatch(icol, "^[0-9]*$") && col1text.Text != "")
                {
                if(idtype == "1")
                {
                    sql = "UPDATE " + tablenamex +
                          " SET " + icollabel + " = " + icol +
                          " WHERE " + id + " = '" + searchstr + "' ;";
                    tablegrid.DataSource = mm.GetAllMembers(sql);
                    String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                    tablegrid.DataSource = mm.GetAllMembers(sql2);
                }
                else
                if(idtype == "0")
                {
                    sql = "UPDATE " + tablenamex +
                          " SET " + icollabel + " = " + icol +
                          " WHERE " + id + " = " + searchstr + ";";
                    tablegrid.DataSource = mm.GetAllMembers(sql);
                    String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                    tablegrid.DataSource = mm.GetAllMembers(sql2);
                }
                }
                else
                {
                        MessageBox.Show("Error : Incorrect input for the Column : " + col1.Text + "\n  Tip: " + col1.Text + " accepts only Integers");
                        col1text.Clear();
                }
                }
                else
                {
                        MessageBox.Show("Error : You must select a valid ID");
                }

            }
            else
            if (tcol == "1")
            {
                if (searchstr != "")
                {
                    if(idtype == "1")
                {
                    sql = "UPDATE " + tablenamex +
                          " SET " + icollabel + " = '" + icol +
                          "' WHERE " + id + " = '" + searchstr + "' ;";
                    tablegrid.DataSource = mm.GetAllMembers(sql);
                    String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                    tablegrid.DataSource = mm.GetAllMembers(sql2);
                }
                else
                if(idtype == "0")
                {
                    sql = "UPDATE " + tablenamex +
                          " SET " + icollabel + " = '" + icol +
                          "' WHERE " + id + " = " + searchstr + ";";
                    tablegrid.DataSource = mm.GetAllMembers(sql);
                    String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                    tablegrid.DataSource = mm.GetAllMembers(sql2);
                }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }
            }
        }

        private void editcol2b_Click(object sender, EventArgs e)
        {
            db2 insb = new db2();
            Members mm = new Members();
            String ctcol = "SELECT col2type FROM " + tablenamex + ";";
            String tcol = Convert.ToString(insb.GetAllMembers(ctcol));
            String icol = Convert.ToString(col2text.Text);
            String icollabel = Convert.ToString(col2.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";
            String id = insb.GetAllMembers(sqlidget);
            String sql = "";
            String sqlidtype = "SELECT idtype FROM " + tablenamex + ";";
            String idtype = insb.GetAllMembers(sqlidtype);

            if (tcol == "0")
            {
                String ctcol2 = "SELECT col2type FROM " + tablenamex + ";";
                String tcol2 = Convert.ToString(insb.GetAllMembers(ctcol2));
                if (tcol2 == "0")
                {
                    col2text.MaxLength = 19;
                }
                if (searchstr != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(icol, "^[0-9]*$") && col2text.Text != "")
                    {
                        if (idtype == "1")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                        else
                        if (idtype == "0")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : Incorrect input for the Column : " + col2.Text + "\n  Tip: " + col2.Text + " accepts only Integers");
                        col2text.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }

            }
            else
            if (tcol == "1")
            {
                if (searchstr != "")
                {
                    if (idtype == "1")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                    else
                if (idtype == "0")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }
            }
        }

        private void editcol3b_Click(object sender, EventArgs e)
        {
            db2 insb = new db2();
            Members mm = new Members();
            String ctcol = "SELECT col3type FROM " + tablenamex + ";";
            String tcol = Convert.ToString(insb.GetAllMembers(ctcol));
            String icol = Convert.ToString(col3text.Text);
            String icollabel = Convert.ToString(col3.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";
            String id = insb.GetAllMembers(sqlidget);
            String sql = "";
            String sqlidtype = "SELECT idtype FROM " + tablenamex + ";";
            String idtype = insb.GetAllMembers(sqlidtype);

            if (tcol == "0")
            {
                String ctcol3 = "SELECT col3type FROM " + tablenamex + ";";
                String tcol3 = Convert.ToString(insb.GetAllMembers(ctcol3));
                if (tcol3 == "0")
                {
                    col3text.MaxLength = 19;
                }
                if (searchstr != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(icol, "^[0-9]*$") && col3text.Text != "")
                    {
                        if (idtype == "1")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                        else
                        if (idtype == "0")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : Incorrect input for the Column : " + col3.Text + "\n  Tip: " + col3.Text + " accepts only Integers");
                        col3text.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }

            }
            else
            if (tcol == "1")
            {
                if (searchstr != "")
                {
                    if (idtype == "1")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                    else
                if (idtype == "0")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }
            }
        }

        private void editcol4b_Click(object sender, EventArgs e)
        {
            db2 insb = new db2();
            Members mm = new Members();
            String ctcol = "SELECT col4type FROM " + tablenamex + ";";
            String tcol = Convert.ToString(insb.GetAllMembers(ctcol));
            String icol = Convert.ToString(col4text.Text);
            String icollabel = Convert.ToString(col4.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";
            String id = insb.GetAllMembers(sqlidget);
            String sql = "";
            String sqlidtype = "SELECT idtype FROM " + tablenamex + ";";
            String idtype = insb.GetAllMembers(sqlidtype);

            if (tcol == "0")
            {
                String ctcol4 = "SELECT col4type FROM " + tablenamex + ";";
                String tcol4 = Convert.ToString(insb.GetAllMembers(ctcol4));
                if (tcol4 == "0")
                {
                    col4text.MaxLength = 19;
                }
                if (searchstr != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(icol, "^[0-9]*$") && col4text.Text != "")
                    {
                        if (idtype == "1")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                        else
                        if (idtype == "0")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : Incorrect input for the Column : " + col4.Text + "\n  Tip: " + col4.Text + " accepts only Integers");
                        col4text.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }

            }
            else
            if (tcol == "1")
            {
                if (searchstr != "")
                {
                    if (idtype == "1")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                    else
                if (idtype == "0")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            db2 insb = new db2();
            Members mm = new Members();
            String ctcol = "SELECT col5type FROM " + tablenamex + ";";
            String tcol = Convert.ToString(insb.GetAllMembers(ctcol));
            String icol = Convert.ToString(col5text.Text);
            String icollabel = Convert.ToString(col5.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";
            String id = insb.GetAllMembers(sqlidget);
            String sql = "";
            String sqlidtype = "SELECT idtype FROM " + tablenamex + ";";
            String idtype = insb.GetAllMembers(sqlidtype);

            if (tcol == "0")
            {
                String ctcol5 = "SELECT col5type FROM " + tablenamex + ";";
                String tcol5 = Convert.ToString(insb.GetAllMembers(ctcol5));
                if (tcol5 == "0")
                {
                    col5text.MaxLength = 19;
                }
                if (searchstr != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(icol, "^[0-9]*$") && col5text.Text != "")
                    {
                        if (idtype == "1")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                        else
                        if (idtype == "0")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : Incorrect input for the Column : " + col5.Text + "\n  Tip: " + col5.Text + " accepts only Integers");
                        col5text.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }

            }
            else
            if (tcol == "1")
            {
                if (searchstr != "")
                {
                    if (idtype == "1")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                    else
                if (idtype == "0")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }
            }
        }

        private void editcol6b_Click(object sender, EventArgs e)
        {
            db2 insb = new db2();
            Members mm = new Members();
            String ctcol = "SELECT col6type FROM " + tablenamex + ";";
            String tcol = Convert.ToString(insb.GetAllMembers(ctcol));
            String icol = Convert.ToString(col6text.Text);
            String icollabel = Convert.ToString(col6.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";
            String id = insb.GetAllMembers(sqlidget);
            String sql = "";
            String sqlidtype = "SELECT idtype FROM " + tablenamex + ";";
            String idtype = insb.GetAllMembers(sqlidtype);

            if (tcol == "0")
            {
                String ctcol6 = "SELECT col6type FROM " + tablenamex + ";";
                String tcol6 = Convert.ToString(insb.GetAllMembers(ctcol6));
                if (tcol6 == "0")
                {
                    col6text.MaxLength = 19;
                }
                if (searchstr != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(icol, "^[0-9]*$") && col6text.Text != "")
                    {
                        if (idtype == "1")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                        else
                        if (idtype == "0")
                        {
                            sql = "UPDATE " + tablenamex +
                                  " SET " + icollabel + " = " + icol +
                                  " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql);
                            String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                            tablegrid.DataSource = mm.GetAllMembers(sql2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : Incorrect input for the Column : " + col6.Text + "\n  Tip: " + col6.Text + " accepts only Integers");
                        col6text.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }

            }
            else
            if (tcol == "1")
            {
                if (searchstr != "")
                {
                    if (idtype == "1")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = '" + searchstr + "' ;";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                    else
                    if (idtype == "0")
                    {
                        sql = "UPDATE " + tablenamex +
                              " SET " + icollabel + " = '" + icol +
                              "' WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql);
                        String sql2 = "SELECT * FROM " + tablenamex + " WHERE " + id + " = " + searchstr + ";";
                        tablegrid.DataSource = mm.GetAllMembers(sql2);
                    }
                }
                else
                {
                    MessageBox.Show("Error : You must select a valid ID");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          text1 = randomlist.Text;
        }
        String deleteid;
        private void searchid_Click(object sender, EventArgs e)
        {
            db2 getid = new db2();
            String idtp = "SELECT idtype FROM " + tablenamex + ";";
            Members mm = new Members();
            String idoutput;
            String searchid = Convert.ToString(searchidtext.Text);
            String sqlidget = "SELECT id FROM " + tablenamex + ";";
            idoutput = getid.GetAllMembers(sqlidget);
            int iidtp = Convert.ToInt16(getid.GetAllMembers(idtp));     //ID Type. 1 = varchar 0 = int
            String key = "-1";
            try
            {
                SqlConnection con = new SqlConnection(datasource);
                if (iidtp == 1)
                {
                    SqlCommand cmd = new SqlCommand(" SELECT COUNT(*) FROM " + tablenamex + " WHERE " + idoutput + "= '" + searchidtext.Text + "' ;", con);
                    con.Open();
                    key = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                }
                else
                if (iidtp == 0)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(searchid, "^[0-9]*$") && searchidtext.Text != "")
                    {
                        SqlCommand cmd = new SqlCommand(" SELECT COUNT(*) FROM " + tablenamex + " WHERE " + idoutput + "= " + searchidtext.Text + " ;", con);
                        con.Open();
                        key = Convert.ToString(cmd.ExecuteScalar());
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error : Incorrect Search String. Please use an integer value");
                        searchidtext.Clear();
                    }
                }

            }
            catch
            {
                MessageBox.Show("search is not working....");
            }
            if (key == "0")
            {
                MessageBox.Show("ID not found!");
                searchidtext.Clear();
            }
            else
            if (key == "1")
            {
                String sql = " SELECT * FROM " + tablenamex + " WHERE " + idoutput + " = '" + searchid + "' ;";
                tablegrid.DataSource = mm.GetAllMembers(sql);
                deleteid = searchid;
            }
        }

        private void button2_Click(object sender, EventArgs e)  // DELETE
        {
            db2 getid = new db2();
            String idtp = "SELECT id FROM " + tablenamex + ";";
            String idname = getid.GetAllMembers(idtp);
            Members mm = new Members();
            String sql = "DELETE FROM " + tablenamex + " WHERE " + idname + " = '" + deleteid + "' ;";
            String sql2 = "SELECT * FROM " + tablenamex + ";";
            mm.GetAllMembers(sql);
            tablegrid.DataSource = mm.GetAllMembers(sql2);
            col1text.Clear();
            col2text.Clear();
            col3text.Clear();
            col4text.Clear();
            col5text.Clear();
            col6text.Clear();
        }

        private void editidtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchidtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectidcell(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(rbedit.Checked == true)
            {
            try
            {
                String xxxx = tablegrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                editidtb.Text = xxxx;
            }

            catch
            {
                MessageBox.Show("Invalid selection.");
            }
            }           
        }
    }
}

/*

  { YES BBBzzzzzzzzzzz   ( ͡° ͜ʖ ͡°)
  }

    deeem 7882 Code likes total.
*/
