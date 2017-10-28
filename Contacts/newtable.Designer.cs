namespace Contacts
{
    partial class newtable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newtable));
            this.TableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoOfColumns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Yes = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.RadioButton();
            this.ColumnList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ColName = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.CreateTable = new System.Windows.Forms.Button();
            this.ColOk = new System.Windows.Forms.Button();
            this.IDOK = new System.Windows.Forms.Button();
            this.TNOk = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColInt = new System.Windows.Forms.RadioButton();
            this.ColText = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableName
            // 
            this.TableName.BackColor = System.Drawing.SystemColors.Highlight;
            this.TableName.Location = new System.Drawing.Point(96, 38);
            this.TableName.MaxLength = 25;
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(100, 20);
            this.TableName.TabIndex = 0;
            this.TableName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. Of Columns w/o ID";
            // 
            // NoOfColumns
            // 
            this.NoOfColumns.BackColor = System.Drawing.SystemColors.Highlight;
            this.NoOfColumns.Location = new System.Drawing.Point(379, 38);
            this.NoOfColumns.MaxLength = 1;
            this.NoOfColumns.Name = "NoOfColumns";
            this.NoOfColumns.Size = new System.Drawing.Size(22, 20);
            this.NoOfColumns.TabIndex = 6;
            this.NoOfColumns.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Create a new Table";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "UniqueID";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.Highlight;
            this.ID.Location = new System.Drawing.Point(96, 78);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 9;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Auto Increment?";
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Checked = true;
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(3, 1);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(46, 17);
            this.Yes.TabIndex = 11;
            this.Yes.TabStop = true;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.CheckedChanged += new System.EventHandler(this.Yes_CheckedChanged);
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(55, 2);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(41, 17);
            this.No.TabIndex = 12;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.CheckedChanged += new System.EventHandler(this.No_CheckedChanged);
            // 
            // ColumnList
            // 
            this.ColumnList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ColumnList.FormattingEnabled = true;
            this.ColumnList.Items.AddRange(new object[] {
            "Column 1",
            "Column 2",
            "Column 3",
            "Column 4",
            "Column 5",
            "Column 6"});
            this.ColumnList.Location = new System.Drawing.Point(96, 128);
            this.ColumnList.Name = "ColumnList";
            this.ColumnList.Size = new System.Drawing.Size(121, 21);
            this.ColumnList.TabIndex = 13;
            this.ColumnList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Column";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name";
            // 
            // ColName
            // 
            this.ColName.BackColor = System.Drawing.SystemColors.Highlight;
            this.ColName.Location = new System.Drawing.Point(285, 128);
            this.ColName.Name = "ColName";
            this.ColName.Size = new System.Drawing.Size(100, 20);
            this.ColName.TabIndex = 16;
            this.ColName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Chocolate;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Location = new System.Drawing.Point(391, 125);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(39, 23);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            this.Add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Add_mouseclick);
            // 
            // CreateTable
            // 
            this.CreateTable.BackColor = System.Drawing.Color.Chocolate;
            this.CreateTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTable.Location = new System.Drawing.Point(295, 173);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(85, 23);
            this.CreateTable.TabIndex = 18;
            this.CreateTable.Text = "Create Table";
            this.CreateTable.UseVisualStyleBackColor = false;
            this.CreateTable.Click += new System.EventHandler(this.CreateTable_Click);
            // 
            // ColOk
            // 
            this.ColOk.BackColor = System.Drawing.Color.Chocolate;
            this.ColOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColOk.Location = new System.Drawing.Point(407, 35);
            this.ColOk.Name = "ColOk";
            this.ColOk.Size = new System.Drawing.Size(29, 23);
            this.ColOk.TabIndex = 19;
            this.ColOk.Text = "Ok";
            this.ColOk.UseVisualStyleBackColor = false;
            this.ColOk.Click += new System.EventHandler(this.ColOk_Click);
            this.ColOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColOk_MouseClick);
            // 
            // IDOK
            // 
            this.IDOK.BackColor = System.Drawing.Color.Chocolate;
            this.IDOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IDOK.Location = new System.Drawing.Point(200, 75);
            this.IDOK.Name = "IDOK";
            this.IDOK.Size = new System.Drawing.Size(29, 23);
            this.IDOK.TabIndex = 20;
            this.IDOK.Text = "Ok";
            this.IDOK.UseVisualStyleBackColor = false;
            this.IDOK.Click += new System.EventHandler(this.IDOK_Click);
            this.IDOK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UIDOK);
            // 
            // TNOk
            // 
            this.TNOk.BackColor = System.Drawing.Color.Chocolate;
            this.TNOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TNOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNOk.Location = new System.Drawing.Point(200, 35);
            this.TNOk.Name = "TNOk";
            this.TNOk.Size = new System.Drawing.Size(29, 23);
            this.TNOk.TabIndex = 21;
            this.TNOk.Text = "Ok";
            this.TNOk.UseVisualStyleBackColor = false;
            this.TNOk.Click += new System.EventHandler(this.button1_Click);
            this.TNOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableNameOKButton);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(40, 7);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(57, 7);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Location = new System.Drawing.Point(73, 7);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(2, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 25);
            this.panel1.TabIndex = 27;
            // 
            // ColInt
            // 
            this.ColInt.AutoSize = true;
            this.ColInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColInt.Location = new System.Drawing.Point(57, 2);
            this.ColInt.Name = "ColInt";
            this.ColInt.Size = new System.Drawing.Size(71, 17);
            this.ColInt.TabIndex = 23;
            this.ColInt.Text = "Numeric";
            this.ColInt.UseVisualStyleBackColor = true;
            this.ColInt.CheckedChanged += new System.EventHandler(this.ColInt_CheckedChanged);
            // 
            // ColText
            // 
            this.ColText.AutoSize = true;
            this.ColText.Checked = true;
            this.ColText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColText.Location = new System.Drawing.Point(3, 3);
            this.ColText.Name = "ColText";
            this.ColText.Size = new System.Drawing.Size(50, 17);
            this.ColText.TabIndex = 22;
            this.ColText.TabStop = true;
            this.ColText.Text = "Text";
            this.ColText.UseVisualStyleBackColor = true;
            this.ColText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ColText);
            this.groupBox2.Controls.Add(this.ColInt);
            this.groupBox2.Location = new System.Drawing.Point(95, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 24);
            this.groupBox2.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Yes);
            this.groupBox1.Controls.Add(this.No);
            this.groupBox1.Location = new System.Drawing.Point(341, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 20);
            this.groupBox1.TabIndex = 29;
            // 
            // newtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(460, 217);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TNOk);
            this.Controls.Add(this.IDOK);
            this.Controls.Add(this.ColOk);
            this.Controls.Add(this.CreateTable);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ColName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ColumnList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NoOfColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableName);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newtable";
            this.Text = "newtable";
            this.Load += new System.EventHandler(this.newtable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoOfColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Yes;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.ComboBox ColumnList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button CreateTable;
        private System.Windows.Forms.TextBox ColName;
        private System.Windows.Forms.Button ColOk;
        private System.Windows.Forms.Button IDOK;
        private System.Windows.Forms.Button TNOk;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ColInt;
        private System.Windows.Forms.RadioButton ColText;
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Panel groupBox1;
    }
}