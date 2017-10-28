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
    public partial class newtable : Form
    {
        String c1, c2, c3, c4, c5, c6;
        int col = 0;
        int col1 = 0, col2 = 0, col3 = 0, col4 = 0, col5 = 0, col6 = 0;
        int Col1Type = 1, Col2Type = 1, Col3Type = 1, Col4Type = 1, Col5Type = 1, Col6Type = 1;
        String Col1TypeS = "", Col2TypeS = "", Col3TypeS = "", Col4TypeS = "", Col5TypeS = "", Col6TypeS = "";
        int colr = 0;
        String coltest;
        int Error = 0;
        int Error2  = 0;
        int Error3  = 0;       
         //Column Names
        String Id,TN;
        int idtype = 0;
        Boolean increment = true;
        String IncrementS;
        // true for auto increment...
        String[] keywordlist = {"ADD","EXTERNAL","PROCEDURE","ALL","FETCH","PUBLIC","ALTER","FILE","RAISERRORAND","FILLFACTOR","READANY","FOR","READTEXT",
                   "AS","FOREIGN","RECONFIGUREASC","FREETEXT","REFERENCES","AUTHORIZATION","FREETEXTTABLE","REPLICATION","BACKUP","FROM",
                   "RESTORE","BEGIN","FULL","RESTRICTBETWEEN","FUNCTION","RETURN","BREAK","GOTO","REVERT","BROWSE","GRANT","REVOKE",
                   "BULK","GROUP","RIGHT","BY","HAVING","ROLLBACK","CASCADE","HOLDLOCK","ROWCOUNT","CASE","IDENTITY","ROWGUIDCOL",
                   "CHECK","IDENTITY","INSERT","RULE","CHECKPOINT","IDENTITYCOL","SAVE","CLOSE","IF","SCHEMA","CLUSTERED","IN","SECURITYAUDIT",
                   "COALESCE","INDEX","SELECT","COLLATE","INNER","SEMANTICKEYPHRASETABLE","COLUMN","INSERT","SEMANTICSIMILARITYDETAILSTABLE",
                   "COMMIT","INTERSECT","SEMANTICSIMILARITYTABLE","COMPUTE","INTO","SESSION_USER","CONSTRAINT","IS","SET",
                   "CONTAINS","JOIN","SETUSER","CONTAINSTABLE","KEY","SHUTDOWN","CONTINUE","KILL","SOME","CONVERT","LEFT","STATISTICS",
                   "CREATE","LIKE","SYSTEM_USER","CROSS","LINENO","TABLE","CURRENT","LOAD","TABLESAMPLE","CURRENT_DATE","MERGE","TEXTSIZE",
                   "CURRENT_TIME","NATIONAL","THEN","CURRENT_TIMESTAMP","NOCHECK","TO","CURRENT_USER","NONCLUSTERED","TOP","CURSOR","NOT","TRAN",
                   "DATABASE","NULL","TRANSACTION","DBCC","NULLIF","TRIGGER","DEALLOCATE","OF","TRUNCATE","DECLARE","OFF","TRY_CONVERT",
                   "DEFAULT","OFFSETS","TSEQUAL","DELETE","ON","UNION","DENY","OPEN","UNIQUE","DESC","OPENDATASOURCE","UNPIVOT","DISK","OPENQUERY","UPDATE",
                   "OPENROWSET","UPDATETEXT","DISTRIBUTED","OPENXML","USE","DOUBLE","OPTION","USER","DROP","OR","VALUES","DUMP","ORDER","VARYING",
                   "ELSE","OUTER","VIEW","END","OVER","WAITFOR","ERRLVL","PERCENT","WHEN","ESCAPE","PIVOT","WHERE","EXCEPT","PLAN","WHILE",
                   "EXEC","PRECISION","WITH","EXECUTE","PRIMARY","WITHIN","GROUP","EXISTS","PRINT","WRITETEXT","EXIT","PROC"};

        public newtable()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Add_mouseclick(object sender, MouseEventArgs e)   //COL Name ADD mouse click *************************************************************
        {
            String test_string = Convert.ToString(ColName.Text);
            var test_stringx = test_string.ToCharArray();
            groupBox2.Refresh();
            int error666 = 1;
            try
            {
                if (test_stringx[0] == '1' || test_stringx[0] == '2' || test_stringx[0] == '3' || test_stringx[0] == '4' || test_stringx[0] == '5' ||
                    test_stringx[0] == '6' || test_stringx[0] == '7' || test_stringx[0] == '8' || test_stringx[0] == '9' || test_stringx[0] == '0')
                {
                    error666 = 1;
                    //MessageBox.Show("Error: Column Name Cannot Be Started with a Digit!");
                    ColName.Clear();
                    //MessageBox.Show(Convert.ToString(error666));
                }
                else
                {
                    error666 = 0;
                    //MessageBox.Show(Convert.ToString(error666));
                }
            }
            catch
            {
                ColName.Clear();
                //MessageBox.Show("Error: Column Name Cannot Be Empty!");
            }

            if (sender is Button && System.Text.RegularExpressions.Regex.IsMatch(test_string, "^[a-zA-Z0-9]*$") && error666 == 0)
            {
                //coltest = Convert.ToString(ColName.Text);

                if (col1 == 1 || col2 == 1 || col3 == 1 || col4 == 1 || col5 == 1 || col6 == 1)
                {
                    if (String.IsNullOrWhiteSpace(ColName.Text) == false)
                    {
                        int verify = 1;
                        if (col1 == 1)
                        {
                            verify = 1;
                            if (ColText.Checked == true) // Looks if the Text value is selected.
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c1 = Convert.ToString(ColName.Text);
                                    Col1Type = 1;
                                    Error3 = 0;
                                }
                            }
                            else    // Then the type is numeric
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c1 = Convert.ToString(ColName.Text);
                                    Col1Type = 0;
                                    Error3 = 0;
                                }

                            }
                        }
                        else
                       if (col2 == 1)
                        {
                            verify = 1;
                            if (ColText.Checked == true)
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c2 = Convert.ToString(ColName.Text);
                                    Col2Type = 1;
                                    Error3 = 0;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c2 = Convert.ToString(ColName.Text);
                                    Col2Type = 0;
                                    Error3 = 0;
                                }
                            }

                        }

                        else
                           if (col3 == 1)
                        {
                            verify = 1;
                            if (ColText.Checked == true)
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c3 = Convert.ToString(ColName.Text);
                                    Col3Type = 1;
                                    Error3 = 0;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c3 = Convert.ToString(ColName.Text);
                                    Col3Type = 0;
                                    Error3 = 0;
                                }
                            }
                        }
                        else
                       if (col4 == 1)
                        {
                            verify = 1;
                            if (ColText.Checked == true)
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c4 = Convert.ToString(ColName.Text);
                                    Col4Type = 1;
                                    Error3 = 0;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c4 = Convert.ToString(ColName.Text);
                                    Col4Type = 0;
                                    Error3 = 0;
                                }
                            }
                        }
                        else
                       if (col5 == 1)
                        {
                            verify = 1;
                            if (ColText.Checked == true)
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c5 = Convert.ToString(ColName.Text);
                                    Col5Type = 1;
                                    Error3 = 0;
                                }
                            }

                            else
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c5 = Convert.ToString(ColName.Text);
                                    Col5Type = 0;
                                    Error3 = 0;
                                }
                            }
                        }
                        else
                       if (col6 == 1)
                        {
                            verify = 1;
                            if (ColText.Checked == true)
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c6 = Convert.ToString(ColName.Text);
                                    Col6Type = 1;
                                    Error3 = 0;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < keywordlist.Length; i++)
                                {
                                    if (keywordlist[i] == Convert.ToString(ColName.Text) || keywordlist[i].ToLower() == Convert.ToString(ColName.Text))
                                    {
                                        MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                                        Error3 = 1;
                                        ColName.Clear();
                                        verify = 0;
                                        break;
                                    }
                                }
                                if (verify == 1)
                                {
                                    c6 = Convert.ToString(ColName.Text);
                                    Col6Type = 0;
                                    Error3 = 0;
                                }
                            }
                        }
                        /* else
                         {
                               MessageBox.Show("Column Name Cannot Be Empty!");
                               Error3 = 1;
                         }*/

                        if (sender is Button)  // COLUMN TYPE************************************
                        {
                            if (Col1Type == 1)
                            {
                                Col1TypeS = "varchar(100)";
                            }
                            else
                            {
                                Col1TypeS = "bigint";
                            }
                            if (Col2Type == 1)
                            {
                                Col2TypeS = "varchar(100)";
                            }
                            else
                            {
                                Col2TypeS = "bigint";
                            }
                            if (Col3Type == 1)
                            {
                                Col3TypeS = "varchar(100)";
                            }
                            else
                            {
                                Col3TypeS = "bigint";
                            }
                            if (Col4Type == 1)
                            {
                                Col4TypeS = "varchar(100)";
                            }
                            else
                            {
                                Col4TypeS = "bigint";
                            }
                            if (Col5Type == 1)
                            {
                                Col5TypeS = "varchar(100)";
                            }
                            else
                            {
                                Col5TypeS = "bigint";
                            }
                            if (Col6Type == 1)
                            {
                                Col6TypeS = "varchar(100)";
                            }
                            else
                            {
                                Col6TypeS = "bigint";
                            }
                        }

                        if (sender is Button)
                        {
                            if (increment == true)
                            {
                                IncrementS = "int IDENTITY(1,1)";
                                idtype = 0;
                            }
                            else
                            {
                                IncrementS = "varchar(100)";
                                idtype = 1;
                            }
                        }
                        //int Col1Type=1, Col2Type=1, Col3Type=1, Col4Type=1, Col5Type=1, Col6Type=1     
                    }
                    else
                    {
                        MessageBox.Show("Error: Column Name Cannot Be Empty.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Error: Column Name Cannot Be Started with a Digit.\n       Column Name Cannot Be Empty.");
            }
        }

        private void button1_Click(object sender, EventArgs e)  //Table Name ********************************************************************************
        {
            int newProdID = 0;
            String temp1;
            int Errorxxx = 3;

            if (sender is Button)
            {

                String datasource = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + "D:\\MS VS Projects\\Contacts\\Contacts\\Contacts.mdf" + ";" + "Integrated Security = True";
                string sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[dbo].[" + Convert.ToString(TableName.Text) + "]')";
                int xx;
                for (xx = 0; xx < keywordlist.Length; xx++)
                {
                    if (Convert.ToString(TableName.Text) == keywordlist[xx])
                    {
                        Error = 1;
                        break;
                    }
                    else
                    {
                        Error = 0;
                    }
                }
                if (Error == 0)
                {
                    using (SqlConnection con = new SqlConnection(datasource))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand(sql, con);
                            con.Open();
                            newProdID = Convert.ToInt32(cmd.ExecuteScalar());   //(int)cmd.ExecuteScalar();
                                                                                //MessageBox.Show(newProdID.ToString());
                            con.Close();
                            //get the result value: 1-exist; 0-not exist;
                        }
                        catch
                        {
                            TableName.Clear();
                        }
                    }
                }
                if (String.IsNullOrWhiteSpace(TableName.Text) == true)
                {
                    Error = 1;
                    MessageBox.Show("Table name cannot be Empty!");
                    TableName.Clear();
                }
                else
                if (newProdID == 1)
                {
                    Error = 1;
                    MessageBox.Show("Table name already exist in the database.");
                    TableName.Clear();
                    TableName.Focus();
                }
                else
                if (newProdID == 0)
                {
                    String test_string = Convert.ToString(TableName.Text);
                    int i;
                    for (i = 0; i < keywordlist.Length; i++) // Keywordlist is the keywords used in sql
                    {
                        if (keywordlist[i] == Convert.ToString(TableName.Text) || keywordlist[i].ToLower() == Convert.ToString(TableName.Text))
                        {
                            MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                            TableName.Clear();
                            Error = 1;
                            break;
                        }
                    }

                    if (System.Text.RegularExpressions.Regex.IsMatch(test_string, "^[a-zA-Z]*$"))
                    {
                        Error = 0;
                        TN = Convert.ToString(TableName.Text);        // Declaring Table Name value   
                                                                      //MessageBox.Show("1");

                    }
                    else
                    {
                        MessageBox.Show("Error: Table Name can only consist of letters(a-z/A-Z)");
                        Error = 1;
                        TableName.Clear();
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
               
                this.BackColor = Color.Gainsboro;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel1.BorderStyle = BorderStyle.None;
                this.BackColor = Color.YellowGreen;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel1.BorderStyle = BorderStyle.None;
                this.BackColor = Color.Gold;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                panel1.BorderStyle = BorderStyle.None;
                this.BackColor = Color.SandyBrown;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                panel1.BorderStyle = BorderStyle.None;
                this.BackColor = Color.Turquoise;
            }           
        }

        private void ColInt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ColOk_Click(object sender, EventArgs e)
        {
            
        }

        private void ColOk_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is Button && NoOfColumns.Text != "")
            {
                NoOfColumns.Focus();
                try
                {
                    col = Convert.ToInt16(NoOfColumns.Text);
                }
                catch
                {
                    MessageBox.Show("Error: Invalid Charactor! \n\nEnter a Digit between 1-6");
                    colr = 0;
                    NoOfColumns.Clear();
                }
                if (col > 0 && col < 7)
                {
                    if (col == 1)
                    {
                        colr = 1;
                    }
                    else
                    if (col == 2)
                    {
                        colr = 2;
                    }
                    else
                    if (col == 3)
                    {
                        colr = 3;
                    }
                    else
                    if (col == 4)
                    {
                        colr = 4;
                    }
                    else
                    if (col == 5)
                    {
                        colr = 5;
                    }
                    else
                    if (col == 6)
                    {
                        colr = 6;
                    }
                }
                else
                {
                    colr = 0;                                        // Prompting to enter a value between 1-6

                    NoOfColumns.Clear();
                }

            }
            /*else
            {
                MessageBox.Show("String contains special chars");
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //COmboBox**********************************************************************
        {
            if (ColumnList.Text == "Column 1" && (colr <= 6 && colr > 0))   //Combobox selected value & compares it with the max column value
            {
                //MessageBox.Show(Convert.ToString(colr));
                col1 = 1;
                col2 = col3 = col4 = col5 = col6 = 0;
                ColName.Text = c1;
                groupBox2.Refresh();
                if (Col1Type == 1)
                {
                    ColText.Checked = true;
                }
                else
                {
                    ColInt.Checked = true;
                    ColText.Checked = false;
                }

            }
            else
                    if (ColumnList.Text == "Column 2" && colr > 1)
            {
                //MessageBox.Show(Convert.ToString(colr));
                col2 = 1;
                col1 = col3 = col4 = col5 = col6 = 0;
                ColName.Text = c2;
                groupBox2.Refresh();
                if (Col2Type == 1)
                {
                    ColText.Checked = true;
                }
                else
                {
                    ColInt.Checked = true;
                    ColText.Checked = false;
                }

            }
            else
                    if (ColumnList.Text == "Column 3" && colr > 2)
            {
                //MessageBox.Show(Convert.ToString(colr));
                col3 = 1;
                col2 = col1 = col4 = col5 = col6 = 0;
                ColName.Text = c3;
                groupBox2.Refresh();
                if (Col3Type == 1)
                {
                    ColText.Checked = true;
                }
                else
                {
                    ColInt.Checked = true;
                    ColText.Checked = false;
                }
            }
            else
                        if (ColumnList.Text == "Column 4" && colr > 3)
            {
                //MessageBox.Show(Convert.ToString(colr));
                col4 = 1;
                col2 = col3 = col1 = col5 = col6 = 0;
                ColName.Text = c4;
                groupBox2.Refresh();
                if (Col4Type == 1)
                {
                    ColText.Checked = true;
                }
                else
                {
                    ColInt.Checked = true;
                    ColText.Checked = false;
                }
            }
            else
                            if (ColumnList.Text == "Column 5" && colr > 4)
            {
                //MessageBox.Show(Convert.ToString(colr));
                col5 = 1;
                col2 = col3 = col4 = col1 = col6 = 0;
                ColName.Text = c5;
                groupBox2.Refresh();
                if (Col5Type == 1)
                {
                    ColText.Checked = true;
                }
                else
                {
                    ColInt.Checked = true;
                    ColText.Checked = false;
                }
            }
            else
                                if (ColumnList.Text == "Column 6" && colr == 6)
            {
                //MessageBox.Show(Convert.ToString(colr));
                col6 = 1;
                col2 = col3 = col4 = col5 = col1 = 0;
                ColName.Text = c6;
                groupBox2.Refresh();
                if (Col6Type == 1)
                {
                    ColText.Checked = true;
                }
                else
                {
                    ColInt.Checked = true;
                    ColText.Checked = false;
                }
            }
            else
            {
                col1 = col2 = col3 = col4 = col5 = col6 = 0;
            }
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (colr == 6)
                {
                    if (c1 == c2 || c2 == c3 || c5 == c4 || c6 == c1 || c2 == c4 || c6 == c2 || c3 == c4 || String.IsNullOrWhiteSpace(c1) ||
                       c5 == c1 || c1 == c4 || c4 == c6 || c5 == c6 || c2 == c5 || c5 == c3 || String.IsNullOrWhiteSpace(c2) ||
                       c3 == c6 || c1 == c3 || c1 == Id || c2 == Id || c3 == Id || String.IsNullOrWhiteSpace(c3) ||
                       c4 == Id || c5 == Id || c6 == Id || c1 == TN || String.IsNullOrWhiteSpace(c4) ||
                       c2 == TN || c3 == TN || c4 == TN || String.IsNullOrWhiteSpace(c5) ||
                       c5 == TN || c6 == TN || TN == Id || String.IsNullOrWhiteSpace(c6) ||
                       Error == 1 || Error2 == 1 || Error3 == 1 || TN == "" || Id == "" || TN == null || Id == null)
                    {
                        MessageBox.Show("Error: Column Names, ID & Table Name either same or missing");
                    }
                    else
                    {
                        Members mm = new Members();
                        String sql2 = "CREATE TABLE " + TN + "(" +
                                      Id + " " + IncrementS + "," +
                                      c1 + " " + Col1TypeS + "," +
                                      c2 + " " + Col2TypeS + "," +
                                      c3 + " " + Col3TypeS + "," +
                                      c4 + " " + Col4TypeS + "," +
                                      c5 + " " + Col5TypeS + "," +
                                      c6 + " " + Col6TypeS +
                                      ");";
                        db2 db = new db2();
                        String sql3 = "CREATE TABLE " + TN + "(" +
                                      "colms varchar(2)," +
                                      "id Varchar(25)," +
                                      "idtype varchar(1)," +
                                      "col1 varchar(25)," +
                                      "col1type varchar(1)," +
                                      "col2 varchar(25)," +
                                      "col2type varchar(1)," +
                                       "col3 varchar(25)," +
                                      "col3type varchar(1)," +
                                       "col4 varchar(25)," +
                                      "col4type varchar(1)," +
                                       "col5 varchar(25)," +
                                      "col5type varchar(1)," +
                                       "col6 varchar(25)," +
                                      "col6type varchar(1)" +
                                      ");";
                        String sql4 = "INSERT INTO " + TN + "(colms,id,idtype,col1,col1type,col2,col2type,col3,col3type,col4,col4type,col5,col5type,col6,col6type)" +
                                      "VALUES('6','" + Id + "','" + idtype + "','" + c1 + "','" + Col1Type + "','" + c2 + "','" + Col2Type + "','" + c3 + "','" + Col3Type + "','" + c4 + "','" + Col4Type + "','" + c5 + "','" + Col5Type + "','" + c6 + "','" + Col6Type + "');";

                        db.GetAllMembers(sql3);
                        db.GetAllMembers(sql4);
                        mm.GetAllMembers(sql2);
                        MessageBox.Show("Table Created!");
                        TableName.Clear();
                        ID.Clear();
                        NoOfColumns.Clear();
                        ColName.Clear();
                        TN = Id = c1 = c2 = c3 = c4 = c5 = c6 = "";
                    }
                }
                else
                 if (colr == 5)
                {
                    if (c1 == c2 || c2 == c3 || c5 == c4 || c2 == c4 || c3 == c4 || String.IsNullOrWhiteSpace(c1) ||   // Above 5 should be deleted
                        c5 == c1 || c1 == c4 || c2 == c5 || c5 == c3 || String.IsNullOrWhiteSpace(c2) ||
                        c1 == c3 || c1 == Id || c2 == Id || c3 == Id || String.IsNullOrWhiteSpace(c3) ||
                        c4 == Id || c5 == Id || c1 == TN || String.IsNullOrWhiteSpace(c5) ||
                        c2 == TN || c3 == TN || c4 == TN ||
                        c5 == TN || TN == Id || TN == "" || Id == "" ||
                        Error == 1 || Error2 == 1 || Error3 == 1 || TN == null || Id == null)
                    {
                        MessageBox.Show("Error: Column Names, ID & Table Name either same or missing");
                    }
                    else
                    {
                        Members mm = new Members();
                        String sql2 = "CREATE TABLE " + TN + "(" +
                                      Id + " " + IncrementS + "," +
                                      c1 + " " + Col1TypeS + "," +
                                      c2 + " " + Col2TypeS + "," +
                                      c3 + " " + Col3TypeS + "," +
                                      c4 + " " + Col4TypeS + "," +
                                      c5 + " " + Col5TypeS +
                                      ");";

                        db2 db = new db2();
                        String sql3 = "CREATE TABLE " + TN + "(" +
                                      "colms varchar(2)," +
                                      "id Varchar(25)," +
                                      "idtype varchar(1)," +
                                      "col1 varchar(25)," +
                                      "col1type varchar(1)," +
                                      "col2 varchar(25)," +
                                      "col2type varchar(1)," +
                                       "col3 varchar(25)," +
                                      "col3type varchar(1)," +
                                       "col4 varchar(25)," +
                                      "col4type varchar(1)," +
                                       "col5 varchar(25)," +
                                      "col5type varchar(1)," +
                                      ");";
                        String sql4 = "INSERT INTO " + TN + "(colms,id,idtype,col1,col1type,col2,col2type,col3,col3type,col4,col4type,col5,col5type)" +
                                      "VALUES('5','" + Id + "','" + idtype + "','" + c1 + "','" + Col1Type + "','" + c2 + "','" + Col2Type + "','" + c3 + "','" + Col3Type + "','" + c4 + "','" + Col4Type + "','" + c5 + "','" + Col5Type + "');";
                        db.GetAllMembers(sql3);
                        db.GetAllMembers(sql4);
                        mm.GetAllMembers(sql2);
                        MessageBox.Show("Table Created!");
                        TableName.Clear();
                        ID.Clear();
                        NoOfColumns.Clear();
                        ColName.Clear();
                        TN = Id = c1 = c2 = c3 = c4 = c5 = c6 = "";
                    }

                }
                else
                     if (colr == 4)
                {
                    if (c1 == c2 || c2 == c3 || c2 == c4 || c3 == c4 || String.IsNullOrWhiteSpace(c1) ||
                        c1 == c4 || String.IsNullOrWhiteSpace(c2) || String.IsNullOrWhiteSpace(c3) || String.IsNullOrWhiteSpace(c4) ||
                        c1 == c3 || c1 == Id || c2 == Id || c3 == Id ||
                        c4 == Id || c1 == TN || TN == "" || Id == "" ||
                        c2 == TN || c3 == TN || c4 == TN ||
                        TN == Id ||
                        Error == 1 || Error2 == 1 || Error3 == 1 || TN == null || Id == null)
                    {
                        MessageBox.Show("Error: Column Names, ID & Table Name either same or missing");
                    }
                    else
                    {
                        Members mm = new Members();
                        String sql2 = "CREATE TABLE " + TN + "(" +
                                      Id + " " + IncrementS + "," +
                                      c1 + " " + Col1TypeS + "," +
                                      c2 + " " + Col2TypeS + "," +
                                      c3 + " " + Col3TypeS + "," +
                                      c4 + " " + Col4TypeS +
                                      ");";

                        db2 db = new db2();
                        String sql3 = "CREATE TABLE " + TN + "(" +
                                      "colms varchar(2)," +
                                      "id Varchar(25)," +
                                      "idtype varchar(1)," +
                                      "col1 varchar(25)," +
                                      "col1type varchar(1)," +
                                      "col2 varchar(25)," +
                                      "col2type varchar(1)," +
                                       "col3 varchar(25)," +
                                      "col3type varchar(1)," +
                                       "col4 varchar(25)," +
                                      "col4type varchar(1)," +
                                      ");";
                        String sql4 = "INSERT INTO " + TN + "(colms,id,idtype,col1,col1type,col2,col2type,col3,col3type,col4,col4type)" +
                                      "VALUES('4','" + Id + "','" + idtype + "','" + c1 + "','" + Col1Type + "','" + c2 + "','" + Col2Type + "','" + c3 + "','" + Col3Type + "','" + c4 + "','" + Col4Type + "');";

                        db.GetAllMembers(sql3);
                        db.GetAllMembers(sql4);
                        mm.GetAllMembers(sql2);
                        MessageBox.Show("Table Created!");
                        TableName.Clear();
                        ID.Clear();
                        NoOfColumns.Clear();
                        ColName.Clear();
                        TN = Id = c1 = c2 = c3 = c4 = c5 = c6 = "";
                    }
                }
                else
                     if (colr == 3)
                {
                    if (c1 == c2 || c2 == c3 || String.IsNullOrWhiteSpace(c1) || String.IsNullOrWhiteSpace(c2) || String.IsNullOrWhiteSpace(c3) ||
                        c1 == c3 || c1 == Id || c2 == Id || c3 == Id ||
                        c1 == TN || TN == "" || Id == "" ||
                        c2 == TN || c3 == TN ||
                        TN == Id ||
                        Error == 1 || Error2 == 1 || Error3 == 1 || TN == null || Id == null)
                    {
                        MessageBox.Show("Error: Column Names, ID & Table Name either same or missing");
                    }
                    else
                    {
                        Members mm = new Members();
                        String sql2 = "CREATE TABLE " + TN + "(" +
                                      Id + " " + IncrementS + "," +
                                      c1 + " " + Col1TypeS + "," +
                                      c2 + " " + Col2TypeS + "," +
                                      c3 + " " + Col3TypeS +
                                      ");";

                        db2 db = new db2();
                        String sql3 = "CREATE TABLE " + TN + "(" +
                                      "colms varchar(2)," +
                                      "id Varchar(25)," +
                                      "idtype varchar(1)," +
                                      "col1 varchar(25)," +
                                      "col1type varchar(1)," +
                                      "col2 varchar(25)," +
                                      "col2type varchar(1)," +
                                       "col3 varchar(25)," +
                                      "col3type varchar(1)," +
                                      ");";
                        String sql4 = "INSERT INTO " + TN + "(colms,id,idtype,col1,col1type,col2,col2type,col3,col3type)" +
                                      "VALUES('3','" + Id + "','" + idtype + "','" + c1 + "','" + Col1Type + "','" + c2 + "','" + Col2Type + "','" + c3 + "','" + Col3Type + "');";

                        db.GetAllMembers(sql3);
                        db.GetAllMembers(sql4);
                        mm.GetAllMembers(sql2);
                        MessageBox.Show("Table Created!");
                        TableName.Clear();
                        ID.Clear();
                        NoOfColumns.Clear();
                        ColName.Clear();
                        TN = Id = c1 = c2 = c3 = c4 = c5 = c6 = "";
                    }

                }
                else
                     if (colr == 2)
                {
                    if (c1 == c2 || String.IsNullOrWhiteSpace(c1) || String.IsNullOrWhiteSpace(c2) ||
                        c1 == Id || c2 == Id ||
                        c1 == TN || TN == "" || Id == "" ||
                        c2 == TN ||
                        TN == Id ||
                        Error == 1 || Error2 == 1 || Error3 == 1 || TN == null || Id == null)
                    {
                        MessageBox.Show("Error: Column Names, ID & Table Name either same or missing");
                    }
                    else
                    {
                        Members mm = new Members();
                        String sql2 = "CREATE TABLE " + TN + "(" +
                                      Id + " " + IncrementS + "," +
                                      c1 + " " + Col1TypeS + "," +
                                      c2 + " " + Col2TypeS +
                                      ");";

                        db2 db = new db2();
                        String sql3 = "CREATE TABLE " + TN + "(" +
                                      "colms varchar(2)," +
                                      "id Varchar(25)," +
                                      "idtype varchar(1)," +
                                      "col1 varchar(25)," +
                                      "col1type varchar(1)," +
                                      "col2 varchar(25)," +
                                      "col2type varchar(1)," +
                                      ");";
                        String sql4 = "INSERT INTO " + TN + "(colms,id,idtype,col1,col1type,col2,col2type)" +
                                      "VALUES('2','" + Id + "','" + idtype + "','" + c1 + "','" + Col1Type + "','" + c2 + "','" + Col2Type + "');";

                        db.GetAllMembers(sql3);
                        db.GetAllMembers(sql4);
                        mm.GetAllMembers(sql2);
                        MessageBox.Show("Table Created!");
                        TableName.Clear();
                        ID.Clear();
                        NoOfColumns.Clear();
                        ColName.Clear();
                        TN = Id = c1 = c2 = c3 = c4 = c5 = c6 = "";
                    }

                     }
                     else
                     if (colr == 1)
                    {
                    if (c1 == Id || String.IsNullOrWhiteSpace(c1) ||
                        c1 == TN || TN == "" || Id == "" ||
                        TN == Id ||
                        Error == 1 || Error2 == 1 || Error3 == 1 || TN == null || Id == null)
                    {
                        MessageBox.Show("Error: Column Names, ID & Table Name either same or missing");
                    }
                    else
                    {
                        Members mm = new Members();
                        String sql2 = "CREATE TABLE " + TN + "(" +
                                      Id + " " + IncrementS + "," +
                                      c1 + " " + Col1TypeS +
                                      ");";

                        db2 db = new db2();
                        String sql3 = "CREATE TABLE " + TN + "(" +
                                      "colms varchar(2)," +
                                      "id Varchar(25)," +
                                      "idtype varchar(1)," +
                                      "col1 varchar(25)," +
                                      "col1type varchar(1)," +
                                      ");";

                        String sql4 = "INSERT INTO " + TN + "(colms,id,idtype,col1,col1type)" +
                                      "VALUES('1','" + Id + "','" + idtype + "','" + c1 + "','" + Col1Type + "');";

                        db.GetAllMembers(sql3);
                        db.GetAllMembers(sql4);
                        mm.GetAllMembers(sql2);
                        MessageBox.Show("Table Created!");
                        TableName.Clear();
                        ID.Clear();
                        NoOfColumns.Clear();
                        ColName.Clear();
                        TN = Id = c1 = c2 = c3 = c4 = c5 = c6 = "";



                        /*String c1, c2, c3, c4, c5, c6; //Column Names
                        String Id,TN;
                        int col1 = 0, col2 = 0, col3 = 0, col4 = 0, col5 = 0, col6 = 0;
                        Boolean increment = true; // true for auto increment
                        int Col1Type=1, Col2Type=1, Col3Type=1, Col4Type=1, Col5Type=1, Col6Type=1;
                        
                        IF OBJECT_ID('tablename') IS NULL
                        PRINT 'Table Does not Exist'
                         
                         */
                    }
                     }
                else
                {
                    MessageBox.Show("Error: Column Names, ID & Table Name either same or missing");
                }
            }
        }

        private void CreateTable_MC(object sender, MouseEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDOK_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void newtable_Load(object sender, EventArgs e)
        {
            groupBox2.Refresh();
            groupBox1.Refresh();
            panel1.BorderStyle = BorderStyle.None;
            groupBox2.BorderStyle = BorderStyle.None;
            groupBox1.BorderStyle = BorderStyle.None;
            radioButton1.Checked = true;
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        { }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TableNameOKButton(object sender, MouseEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TableName.Refresh();           
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // x = Convert.ToString(ColName.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UIDOK(object sender, MouseEventArgs e)   //UNIQUE ID OK BUtton CLICK ****************************************************************************
        {
            String test_string = Convert.ToString(ID.Text);
            if (sender is Button)
            {   if(String.IsNullOrWhiteSpace(ID.Text) == true)
                {
                    MessageBox.Show("UniqueID cannot be empty!");
                    Error2 = 1;
                }
            else
                {
                    for (int i = 0; i < keywordlist.Length; i++)
                    {
                        if (keywordlist[i] == Convert.ToString(ID.Text) || keywordlist[i].ToLower() == Convert.ToString(ID.Text))
                        {
                            MessageBox.Show("Error: " + keywordlist[i] + " cannot be used(Reserved keyword)");
                            ID.Clear();
                            Id = "";
                            Error2 = 1;                            
                            goto End;
                        }
                    }
                        
                        if (System.Text.RegularExpressions.Regex.IsMatch(test_string, "^[a-zA-Z]*$"))
                        {
                            Error2 = 0;
                            Id = Convert.ToString(ID.Text);                                             // Declaring Table ID value                              
                        }
                        else
                        {
                            MessageBox.Show("Error: Unique ID can only consist of letters(a-z/A-Z)");
                            ID.Clear();
                            ID.Focus();
                        
                        }
                                  
                }
                End:;

            }
        }
        private void Yes_CheckedChanged(object sender, EventArgs e)
        {
            if(Yes.Checked == true)
            {
                increment = true;
            }
            else
            {
                increment = false;
            }

        }
    }
}
