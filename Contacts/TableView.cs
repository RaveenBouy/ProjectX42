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
using System.Drawing.Drawing2D;
using System.Resources;

namespace Contacts
{
    public partial class TableView : Form
    {
        public string tablenamex;
        String datasource = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + "D:\\MS VS Projects\\Contacts\\Contacts\\Contacts.mdf" + ";" + "Integrated Security = True";
        String colms, id;
        String text1;
        int formx = 792, formy = 352, gridx = 649, gridy = 230;
        int upx = 701, upy = 75, rightx = 737, righty = 108, downx = 701, downy = 140, leftx = 665, lefty = 108;
        int tempx = 792;
        int tempy = 352;
        int l1y = 265, l2y = 265, tb1y = 287, tb2y = 287, tb3y = 287, b1y = 284, b2y = 284, refreshby = 265;
        int b1 = 1, b2 = 0, b3 = 0, b4 = 0;
        int autox = -1;
        String pluss = "+", minuss = "-", muls = "*", divs = "/";
        int idt;
        int incrementx = 0;
        Double calcsum,sumt,sumd;
        int calcclick = 0;
        int colmsno, col1, col2, col3, col4, col5, col6;
        int taxa, disa;
        String[] tooltip = { "Adds selected operator automatically after each cell value.", "Check this if you want to perform manual calculations.", "Return to Form Adjust interface.","Calculate Both Tax and Discount."};

        
        private void button2_Click_1(object sender, EventArgs e) // search
        {
            if (text1 == "" || text1 == null)
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

       

        public TableView()
        {
            TableList tl = new TableList();                      
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(datasource))
            try
            {   
                Members mm = new Members();
                tablenamex = TableList.listx;
                string sql = "SELECT * FROM " +tablenamex+";";
                tablegrid.DataSource = mm.GetAllMembers(sql);
                TableName.Text = tablenamex;
            }
            catch
            {
                MessageBox.Show("Failed to connect");                                
            }

            db2 db = new db2();
            String colm = "SELECT colms FROM " + tablenamex + ";";
            colms = db.GetAllMembers(colm);
            if (colms == "1")
            {
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col11)));
                String col1type = "SELECT col1type FROM " + tablenamex + ";";
                col1 = Convert.ToInt32(db.GetAllMembers(col1type));
            }
            else
            if (colms == "2")
            {
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col11)));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col22)));
                String col1type = "SELECT col1type FROM " + tablenamex + ";";
                col1 = Convert.ToInt32(db.GetAllMembers(col1type));
                String col2type = "SELECT col2type FROM " + tablenamex + ";";
                col2 = Convert.ToInt32(db.GetAllMembers(col2type));
            }
            else
            if (colms == "3")
            {
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col11)));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col22)));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col33)));
                String col1type = "SELECT col1type FROM " + tablenamex + ";";
                col1 = Convert.ToInt32(db.GetAllMembers(col1type));
                String col2type = "SELECT col2type FROM " + tablenamex + ";";
                col2 = Convert.ToInt32(db.GetAllMembers(col2type));
                String col3type = "SELECT col3type FROM " + tablenamex + ";";
                col3 = Convert.ToInt32(db.GetAllMembers(col3type));               
            }
            else
            if (colms == "4")
            {
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col11)));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col22)));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col33)));
                String col44 = "SELECT col4 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col44)));
                String col1type = "SELECT col1type FROM " + tablenamex + ";";
                col1 = Convert.ToInt32(db.GetAllMembers(col1type));
                String col2type = "SELECT col2type FROM " + tablenamex + ";";
                col2 = Convert.ToInt32(db.GetAllMembers(col2type));
                String col3type = "SELECT col3type FROM " + tablenamex + ";";
                col3 = Convert.ToInt32(db.GetAllMembers(col3type));
                String col4type = "SELECT col4type FROM " + tablenamex + ";";
                col4 = Convert.ToInt32(db.GetAllMembers(col4type));
            }
            else
            if (colms == "5")
            {
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col11)));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col22)));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col33)));
                String col44 = "SELECT col4 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col44)));
                String col55 = "SELECT col5 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col55)));
                String col1type = "SELECT col1type FROM " + tablenamex + ";";
                col1 = Convert.ToInt32(db.GetAllMembers(col1type));
                String col2type = "SELECT col2type FROM " + tablenamex + ";";
                col2 = Convert.ToInt32(db.GetAllMembers(col2type));
                String col3type = "SELECT col3type FROM " + tablenamex + ";";
                col3 = Convert.ToInt32(db.GetAllMembers(col3type));
                String col4type = "SELECT col4type FROM " + tablenamex + ";";
                col4 = Convert.ToInt32(db.GetAllMembers(col4type));
                String col5type = "SELECT col5type FROM " + tablenamex + ";";
                col5 = Convert.ToInt32(db.GetAllMembers(col5type));
            }
            else
            if (colms == "6")
            {
                String col11 = "SELECT col1 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col11)));
                String col22 = "SELECT col2 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col22)));
                String col33 = "SELECT col3 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col33)));
                String col44 = "SELECT col4 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col44)));
                String col55 = "SELECT col5 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col55)));
                String col66 = "SELECT col6 FROM " + tablenamex + ";";
                randomlist.Items.Add(Convert.ToString(db.GetAllMembers(col66)));
                String col1type = "SELECT col1type FROM " + tablenamex + ";";
                col1 = Convert.ToInt32(db.GetAllMembers(col1type));
                String col2type = "SELECT col2type FROM " + tablenamex + ";";
                col2 = Convert.ToInt32(db.GetAllMembers(col2type));
                String col3type = "SELECT col3type FROM " + tablenamex + ";";
                col3 = Convert.ToInt32(db.GetAllMembers(col3type));
                String col4type = "SELECT col4type FROM " + tablenamex + ";";
                col4 = Convert.ToInt32(db.GetAllMembers(col4type));
                String col5type = "SELECT col5type FROM " + tablenamex + ";";
                col5 = Convert.ToInt32(db.GetAllMembers(col5type));
                String col6type = "SELECT col6type FROM " + tablenamex + ";";
                col6 = Convert.ToInt32(db.GetAllMembers(col6type));
            }
        }

        private void tablegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TableView_Load(object sender, EventArgs e)
        {
            calcbox.Hide();
            plusb.Hide();
            minusb.Hide();
            mulb.Hide();
            divb.Hide();
            calcout.Hide();
            ansl1.Hide();
            ansl2.Hide();
            ans1.Hide();
            ans2.Hide();
            discountans.Hide();
            discountb.Hide();
            discountt.Hide();
            disl.Hide();
            auto.Hide();
            autodis.Hide();
            taxb.Hide();
            taxl.Hide();
            taxok.Hide();
            anscopy.Hide();
            taxtb.Hide();
            combine1.Hide();
            Adjust.Hide();
            infoboxx.Hide();
            MaximizeBox = false;
            MinimizeBox = true;
            HelpButton = false;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members id = new Members();
           // String sql = "Select * from "+TableName.Text+"WHERE" + Convert.ToString(searchidtext.Text);";";

        }

        private void TableName_Click(object sender, EventArgs e)
        {

        }

        private void randomlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            text1 = randomlist.Text;
        }

        private void button3_Click(object sender, EventArgs e)
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
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //Discount Ok Button
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(discountt.Text, "^[0-9]*$") && discountt.Text != "")
            {
            if(combine1.Checked == true && taxa == 1)
            {
            double discountx, sum;
            discountx = Convert.ToDouble(discountt.Text);
            sum = (sumt / 100) * (discountx);
            sumd = sumt - sum;
            ans2.Text = Convert.ToString(sumd);
            //taxa = 0;
            }
            else
            if(combine1.Checked == true && taxa == 0)
            {
            double discountx, sum;
            discountx = Convert.ToDouble(discountt.Text);
            sum = (calcsum / 100) * (discountx);
            sumd = calcsum - sum;
            ans2.Text = Convert.ToString(sumd);
            disa = 1;
            }
            else
            if(combine1.Checked == false) // Independant - When the checkbox is unchecked. |When the user wants to find the Discount only.|
            {
            double discountx, sum;
            discountx = Convert.ToDouble(discountt.Text);
            sum = (calcsum / 100) * (discountx);
            sumd = calcsum - sum;
            ans2.Text = Convert.ToString(sumd);
            disa = 0;
            }
            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            calcclick = 1;
            if(calcbutt.Text == "Calculator")
            {
            calcbox.Show();
            plusb.Show();
            minusb.Show();
            mulb.Show();
            divb.Show();
            calcout.Show();
            ansl1.Show();          
            ans1.Show();         
            discountb.Show();           
            auto.Show();
            autodis.Show();
            leftbutton.Hide();
            rightbutton.Hide();
            upbutton.Hide();
            downbutton.Hide();      
            taxb.Show();
            combine1.Show();
            anscopy.Show();
            Adjust.Show();
            infoboxx.Show();
            this.Size = new Size(formx + 98, formy);

            auto.Select();
            plusb.ForeColor = Color.DodgerBlue;
            calcbutt.Text = "Clear";               
            }
            if(incrementx == 1)
            {
                calcbox.Clear();
                plusb.ForeColor = Color.Black;
                minusb.ForeColor = Color.Black;
                divb.ForeColor = Color.Black;
                mulb.ForeColor = Color.Black;
                b1 = b2 = b3 = b4 = 0;
            }
            incrementx = 1;
        }

        private void tablegrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void cellmouse(object sender, DataGridViewCellMouseEventArgs e)
        {
           if(calcclick == 1)
            {
            try
            {
                String x = tablegrid[e.ColumnIndex, e.RowIndex].ValueType.ToString();
                if(x == "System.Int64")
                {
                    try
                    {
                        idt = Convert.ToInt32(tablegrid[e.ColumnIndex, e.RowIndex].Value);
                        calcbox.AppendText(Convert.ToString(idt));
                        if (autox == 1 && b1 == 1)
                        {
                            calcbox.AppendText(pluss);
                        }
                        else
                        if (autox == 1 && b2 == 1)
                        {
                            calcbox.AppendText(minuss);
                        }
                        else
                        if (autox == 1 && b3 == 1)
                        {
                            calcbox.AppendText(divs);
                        }
                        else
                        if (autox == 1 && b4 == 1)
                        {
                            calcbox.AppendText(muls);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Selection.");
                    }
                }
                else
                {
                    MessageBox.Show("Selected Cell is not an Integer.");
                }
            }
            catch
            {

            }                         
           }   
        }

        private void calcbox_TextChanged(object sender, EventArgs e)
        {
            calcbox.Refresh();
        }

        private void Adjust_Click(object sender, EventArgs e)
        {
            calcbox.Hide();
            plusb.Hide();
            minusb.Hide();
            mulb.Hide();
            divb.Hide();
            calcout.Hide();
            ansl1.Hide();
            ansl2.Hide();
            ans1.Hide();
            ans2.Hide();
            discountans.Hide();
            discountb.Hide();
            discountt.Hide();
            disl.Hide();
            auto.Hide();
            autodis.Hide();
            taxb.Hide();
            taxl.Hide();
            taxok.Hide();
            anscopy.Hide();
            taxtb.Hide();
            combine1.Hide();
            Adjust.Hide();
            infoboxx.Hide();
            leftbutton.Show();
            rightbutton.Show();
            upbutton.Show();
            downbutton.Show();
            calcbutt.Text = "Calculator";
            this.Size = new Size(this.Size.Width - 98, formy);
        }

        private void combine1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void auto_MouseHover(object sender, EventArgs e) // auto hover ******************************************************************************
        {
            infoboxx.Text = tooltip[0];
        }

        private void auto_MouseLeave(object sender, EventArgs e) // auto leave
        {
            infoboxx.Text = "Hover over a control to get more information about it.";
        }

        private void autodis_MouseHover(object sender, EventArgs e) // autodis Hover
        {
            infoboxx.Text = tooltip[1];
        }

        private void autodis_MouseLeave(object sender, EventArgs e) // autodis leave
        {
            infoboxx.Text = "Hover over a control to get more information about it.";
        }

        private void Adjust_MouseHover(object sender, EventArgs e) // Adjust Hover
        {
            infoboxx.Text = tooltip[2];
        }

        private void Adjust_MouseLeave(object sender, EventArgs e) // Adjust Leave
        {
            infoboxx.Text = "Hover over a control to get more information about it.";
        }

        private void ans2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBhover(object sender, EventArgs e)
        {
            infoboxx.Text = tooltip[3];
        }

        private void checkBleave(object sender, EventArgs e)
        {
            infoboxx.Text = "Hover over a control to get more information about it.";
        }

        private void calcout_Click(object sender, EventArgs e) // Calculate Button *****************************************************************************
        {                                                       //                 *****************************************************************************
            if(auto.Checked == true &&  calcbox.Text != "" )
            {
                String x;
                x = calcbox.Text;
                List<Char> stringtoarray = x.ToList(); 
                List<Char> Outputstring = new List<char>();
                if(auto.Checked == true && (plusb.ForeColor == Color.DodgerBlue || minusb.ForeColor == Color.DodgerBlue ||
                   divb.ForeColor == Color.DodgerBlue || mulb.ForeColor == Color.DodgerBlue))
                {
                for (int i = 0; i <x.Length-1; i++)
                {
                    Outputstring.Insert(i,stringtoarray[i]);
                    //MessageBox.Show(Convert.ToString(stringtoarray[i]));
                }
                }
                String outexpression = String.Join("",Outputstring);

                calcbox.Clear();
                calcbox.Text = outexpression;
                calcbox.Refresh();                
            }

           if(System.Text.RegularExpressions.Regex.IsMatch(calcbox.Text, "^[0-9-./+*()]*$"))
           {
            DataTable dt = new DataTable();
            try
            {
              Object v = dt.Compute(calcbox.Text, null);
                    calcsum = Convert.ToDouble(v);
            }
            catch(Exception)
            {
                    MessageBox.Show("Illegal Math Expression.");
            }
            
            ans1.Text = Convert.ToString(calcsum);
           }

            if (autox == 1 && b1 == 1)
            {
                calcbox.AppendText(pluss);
            }
            else
            if (autox == 1 && b2 == 1)
            {
                calcbox.AppendText(minuss);
            }
            else
            if (autox == 1 && b3 == 1)
            {
                calcbox.AppendText(divs);
            }
            else
            if (autox == 1 && b4 == 1)
            {
                calcbox.AppendText(muls);
            }

            if(autodis.Checked == true)
            {
                calcbox.Focus();
            }   
        }

        private void discountb_Click(object sender, EventArgs e)
        {
            discountans.Show();
            discountt.Show();
            disl.Show();
            ansl2.Show();
            ans2.Show();
        }

        private void button2_Click_4(object sender, EventArgs e)
        {
            calcbox.Clear();
            calcbox.AppendText(ans1.Text);         
            if (autox == 1 && b1 == 1)
            {
                calcbox.AppendText(pluss);
            }
            else
            if (autox == 1 && b2 == 1)
            {
                calcbox.AppendText(minuss);
            }
            else
            if (autox == 1 && b3 == 1)
            {
                calcbox.AppendText(divs);
            }
            else
            if (autox == 1 && b4 == 1)
            {
                calcbox.AppendText(muls);
            }
            calcbox.Focus();
        }

        private void taxok_Click(object sender, EventArgs e) // Tax Ok Button
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(taxtb.Text, "^[0-9]*$") && taxtb.Text != "")
            {
                if (combine1.Checked == true && disa == 1)
                {
                    double tax, sum;
                    tax = Convert.ToDouble(taxtb.Text);
                    sum = (sumd / 100) * (tax);
                    sumt = sumd + sum;
                    ans2.Text = Convert.ToString(sumt);
                    //disa = 0;
                }
                else
             if (combine1.Checked == true && disa == 0)
                {
                    double tax, sum;
                    tax = Convert.ToDouble(taxtb.Text);
                    sum = (calcsum / 100) * (tax);
                    sumt = sum + calcsum;
                    ans2.Text = Convert.ToString(sumt);
                    taxa = 1;
                }
                else
             if (combine1.Checked == false)
                {
                    double tax, sum;
                    tax = Convert.ToDouble(taxtb.Text);
                    sum = (calcsum / 100) * (tax);
                    sumt = calcsum + sum;
                    ans2.Text = Convert.ToString(sumt);
                    taxa = 0;
                }
            }
        }

        private void taxtb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void siwtchradiobut(object sender, MouseEventArgs e)
        {
            if(auto.Checked == true)
            {
                auto.Checked = false;
                autodis.Checked = true;
            }
        }

        private void calcbox_Enter(object sender, EventArgs e)
        {
            if (auto.Checked == true)
            {
                auto.Checked = false;
                autodis.Checked = true;
            }
        }

        private void taxb_Click(object sender, EventArgs e)
        {
            taxtb.Show();
            taxl.Show();
            taxok.Show();
            ansl2.Show();
            ans2.Show();
        }
        int autoxxxxx = 0;
        private void auto_CheckedChanged(object sender, EventArgs e)
        {
            autoxxxxx++;
            autox = 1;
            if(autoxxxxx >=2)
            {
                b1 = b2 = b3 = b4 = 0;
            }
        }

        private void autodis_CheckedChanged_1(object sender, EventArgs e)
        {
            autox = 0;
            minusb.ForeColor = Color.Black;
            divb.ForeColor = Color.Black;
            mulb.ForeColor = Color.Black;
            plusb.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e) //plus button
        {           
            if(autox == 1)
            {
            if (plusb.ForeColor == Color.DodgerBlue)
            {
                plusb.ForeColor = Color.Black;
                b1 = 0;
            }
            else
            if (plusb.ForeColor == Color.Black)
            {
                plusb.ForeColor = Color.DodgerBlue;
                b1 = 1;
                b2 = 0;
                b3 = 0;
                b4 = 0;
                minusb.ForeColor = Color.Black;
                divb.ForeColor = Color.Black;
                mulb.ForeColor = Color.Black;
            }
            }
            else 
                if(autox == 0)
                {
                calcbox.Focus();
                calcbox.AppendText(pluss);
                b1 = 1;
                }
        }
      
        private void minusb_Click(object sender, EventArgs e)
        {
            if(autox == 1)
            {
            if (minusb.ForeColor == Color.DodgerBlue)
            {
                minusb.ForeColor = Color.Black;
                b2 = 0;
            }
            else
           if (minusb.ForeColor == Color.Black)
           {
                minusb.ForeColor = Color.DodgerBlue;
                b2 = 1;
                b1 = 0;
                b3 = 0;
                b4 = 0;
                plusb.ForeColor = Color.Black;
                divb.ForeColor = Color.Black;
                mulb.ForeColor = Color.Black;
           }
            }
            else 
                if(autox == 0)
                {
                calcbox.Focus();
                calcbox.AppendText(minuss);
                b2 = 1;
            }
        }

        private void divb_Click(object sender, EventArgs e)
        {
            if(autox == 1)
            {
            if (divb.ForeColor == Color.DodgerBlue)
            {
                divb.ForeColor = Color.Black;
                b3 = 0;
            }
            else
           if (divb.ForeColor == Color.Black)
           {
                divb.ForeColor = Color.DodgerBlue;
                b3 = 1;
                b1 = 0;
                b2 = 0;
                b4 = 0;
                mulb.ForeColor = Color.Black;
                plusb.ForeColor = Color.Black;
                minusb.ForeColor = Color.Black;
           }
            }
            else 
                if(autox == 0)
                {
                calcbox.Focus();
                calcbox.AppendText(divs);
                b3 = 1;
            }
        }

        private void mulb_Click(object sender, EventArgs e)
        {
            if(autox == 1)
            {
            if (mulb.ForeColor == Color.DodgerBlue)
            {
                mulb.ForeColor = Color.Black;
                b4 = 0;
            }
            else
           if (mulb.ForeColor == Color.Black)
           {
                mulb.ForeColor = Color.DodgerBlue;
                b4 = 1;
                b1 = 0;
                b2 = 0;
                b3 = 0;
                plusb.ForeColor = Color.Black;
                minusb.ForeColor = Color.Black;
                divb.ForeColor = Color.Black;
           }
            }
            else 
                if(autox == 0)
                {
                calcbox.Focus();
                calcbox.AppendText(muls);
                b4 = 1;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Members mm = new Members();
            String sql = "SELECT * FROM " + tablenamex + ";";
            tablegrid.DataSource = mm.GetAllMembers(sql);
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
          
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void up(object sender, EventArgs e)
        {
        }
        private void upd(object sender, EventArgs e)
        {
        }      
        private void leftbutton_Click(object sender, EventArgs e)
        {
            if(formx > tempx)
            {
            formx -= 20;
            gridx -= 20;
            upx -= 20;
            rightx -= 20;
            downx -= 20;
            leftx -= 20;
            this.Size = new Size(formx, formy);
            tablegrid.Size = new Size(gridx, gridy);
            upbutton.Location = new Point(upx, upy);
            rightbutton.Location = new Point(rightx, righty);
            downbutton.Location = new Point(downx, downy);
            leftbutton.Location = new Point(leftx, lefty);

                calcbox.Location = new Point(calcbox.Location.X - 20, calcbox.Location.Y);
                plusb.Location = new Point(plusb.Location.X - 20, plusb.Location.Y);
                minusb.Location = new Point(minusb.Location.X - 20, minusb.Location.Y);
                mulb.Location = new Point(mulb.Location.X - 20, minusb.Location.Y);
                divb.Location = new Point(divb.Location.X - 20, divb.Location.Y);
                calcout.Location = new Point(calcout.Location.X - 20, calcout.Location.Y);
                ansl1.Location = new Point(ansl1.Location.X - 20, ansl1.Location.Y);
                ansl2.Location = new Point(ansl2.Location.X - 20, ansl2.Location.Y);
                ans1.Location = new Point(ans1.Location.X - 20, ans1.Location.Y);
                ans2.Location = new Point(ans2.Location.X - 20, ans2.Location.Y);
                discountans.Location = new Point(discountans.Location.X - 20, discountans.Location.Y);
                discountb.Location = new Point(discountb.Location.X - 20, discountb.Location.Y);
                discountt.Location = new Point(discountt.Location.X - 20, discountt.Location.Y);
                disl.Location = new Point(disl.Location.X - 20, disl.Location.Y);
                auto.Location = new Point(auto.Location.X - 20, auto.Location.Y);
                autodis.Location = new Point(autodis.Location.X - 20, autodis.Location.Y);
                taxb.Location = new Point(taxb.Location.X - 20, taxb.Location.Y);
                taxl.Location = new Point(taxl.Location.X - 20, taxl.Location.Y);
                taxok.Location = new Point(taxok.Location.X - 20, taxok.Location.Y);
                anscopy.Location = new Point(anscopy.Location.X - 20, anscopy.Location.Y);
                taxtb.Location = new Point(taxtb.Location.X - 20, taxtb.Location.Y);
                combine1.Location = new Point(combine1.Location.X - 20, combine1.Location.Y);
                calcbutt.Location = new Point(calcbutt.Location.X - 20, calcbutt.Location.Y);
                Adjust.Location = new Point(Adjust.Location.X - 20, Adjust.Location.Y);
                infoboxx.Location = new Point(infoboxx.Location.X - 20, infoboxx.Location.Y);
            }
        }
        private void upbutton_Click(object sender, EventArgs e)
        {
            if(formy > tempy)
            {
            formy -= 20;
            gridy -= 20;
            this.Size = new Size(formx, formy);
            tablegrid.Size = new Size(gridx, gridy);
                l1y -= 20;
                l2y -= 20;
                tb1y -= 20;
                tb2y -= 20;
                tb3y -= 20;
                b1y -= 20;
                b2y -= 20;
                refreshby -= 20;
                label1.Location = new Point(20, l1y);
                label3.Location = new Point(230, l2y);
                searchidtext.Location = new Point(27, tb1y);
                randomlist.Location = new Point(229, tb2y);
                searchrandomtext.Location = new Point(344, tb3y);
                button3.Location = new Point(133, b1y);
                randomsearchb.Location = new Point(450, b2y);
                button1.Location = new Point(564, refreshby);
            }
        }
        private void downbutton_Click(object sender, EventArgs e)
        {
            formy += 20;
            gridy += 20;
            this.Size = new Size(formx, formy);
            tablegrid.Size = new Size(gridx, gridy);
            l1y += 20;
            l2y += 20;
            tb1y += 20;
            tb2y += 20;
            tb3y += 20;
            b1y += 20;
            b2y += 20;
            refreshby += 20;
            label1.Location = new Point(20, l1y);
            label3.Location = new Point(230, l2y);
            searchidtext.Location = new Point(27, tb1y);
            randomlist.Location = new Point(229, tb2y);
            searchrandomtext.Location = new Point(344, tb3y);
            button3.Location = new Point(133, b1y);
            randomsearchb.Location = new Point(450, b2y);
            button1.Location = new Point(564, refreshby);
        }
        // int l1y = 265, l2y = 265, tb1y = 287, tb2y = 287, tb3y = 287, b1y = 284, b2y = 284, refreshby = 265;
        private void righthover(object sender, EventArgs e)
        {
            rightbutton.Image = Database.Properties.Resources.righta1;
        }

        private void rightleave(object sender, EventArgs e)
        {
            rightbutton.Image = Database.Properties.Resources.rightd;
        }

        private void uphover(object sender, EventArgs e)
        {
            upbutton.Image = Database.Properties.Resources.upa1;
        }

        private void upleave(object sender, EventArgs e)
        {
            upbutton.Image = Database.Properties.Resources.upd;
        }

        private void lefthover(object sender, EventArgs e)
        {
            leftbutton.Image = Database.Properties.Resources.lefta1;
        }

        private void leftleave(object sender, EventArgs e)
        {
            leftbutton.Image = Database.Properties.Resources.leftd;
        }

        private void downhover(object sender, EventArgs e)
        {
            downbutton.Image = Database.Properties.Resources.downa1;
        }

        private void downleave(object sender, EventArgs e)
        {
            downbutton.Image = Database.Properties.Resources.downd;
        }

        private void rightbutton_Click(object sender, EventArgs e)
        {
            formx += 20;
            gridx += 20;
            upx += 20;
            rightx += 20;
            downx += 20;
            leftx += 20;
            this.Size = new Size(formx, formy);
            tablegrid.Size = new Size(gridx, gridy);
            upbutton.Location = new Point(upx, upy);
            rightbutton.Location = new Point(rightx, righty);
            downbutton.Location = new Point(downx, downy);
            leftbutton.Location = new Point(leftx, lefty);

            /* The Method above is a bit too complicated. The solution down below is more efficient */


            calcbox.Location = new Point(calcbox.Location.X + 20, calcbox.Location.Y);
            plusb.Location   = new Point(plusb.Location.X + 20, plusb.Location.Y);
            minusb.Location  = new Point(minusb.Location.X + 20, minusb.Location.Y);
            mulb.Location = new Point(mulb.Location.X + 20, minusb.Location.Y);
            divb.Location = new Point(divb.Location.X + 20, divb.Location.Y);
            calcout.Location = new Point(calcout.Location.X + 20, calcout.Location.Y);
            ansl1.Location = new Point(ansl1.Location.X + 20, ansl1.Location.Y);
            ansl2.Location = new Point(ansl2.Location.X + 20, ansl2.Location.Y);
            ans1.Location = new Point(ans1.Location.X + 20, ans1.Location.Y);
            ans2.Location = new Point(ans2.Location.X + 20, ans2.Location.Y);
            discountans.Location = new Point(discountans.Location.X + 20, discountans.Location.Y);
            discountb.Location = new Point(discountb.Location.X + 20, discountb.Location.Y);
            discountt.Location = new Point(discountt.Location.X + 20, discountt.Location.Y);
            disl.Location = new Point(disl.Location.X + 20, disl.Location.Y);
            auto.Location = new Point(auto.Location.X + 20, auto.Location.Y);
            autodis.Location = new Point(autodis.Location.X + 20, autodis.Location.Y);
            taxb.Location = new Point(taxb.Location.X + 20, taxb.Location.Y);
            taxl.Location = new Point(taxl.Location.X + 20, taxl.Location.Y);
            taxok.Location = new Point(taxok.Location.X + 20, taxok.Location.Y);
            anscopy.Location = new Point(anscopy.Location.X + 20, anscopy.Location.Y);
            taxtb.Location = new Point(taxtb.Location.X + 20, taxtb.Location.Y);
            combine1.Location = new Point(combine1.Location.X + 20, combine1.Location.Y);
            calcbutt.Location = new Point(calcbutt.Location.X + 20, calcbutt.Location.Y);
            Adjust.Location = new Point(Adjust.Location.X + 20, Adjust.Location.Y);
            infoboxx.Location = new Point(infoboxx.Location.X + 20, infoboxx.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
