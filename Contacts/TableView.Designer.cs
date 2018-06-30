namespace Contacts
{
    partial class TableView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableView));
            this.tablegrid = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.Label();
            this.searchidtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.randomlist = new System.Windows.Forms.ComboBox();
            this.randomsearchb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchrandomtext = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rightb = new System.Windows.Forms.Button();
            this.calcbutt = new System.Windows.Forms.Button();
            this.calcbox = new System.Windows.Forms.TextBox();
            this.downbutton = new System.Windows.Forms.Button();
            this.upbutton = new System.Windows.Forms.Button();
            this.leftbutton = new System.Windows.Forms.Button();
            this.rightbutton = new System.Windows.Forms.Button();
            this.plusb = new System.Windows.Forms.Button();
            this.mulb = new System.Windows.Forms.Button();
            this.divb = new System.Windows.Forms.Button();
            this.minusb = new System.Windows.Forms.Button();
            this.calcout = new System.Windows.Forms.Button();
            this.ansl1 = new System.Windows.Forms.Label();
            this.discountt = new System.Windows.Forms.TextBox();
            this.discountb = new System.Windows.Forms.Button();
            this.disl = new System.Windows.Forms.Label();
            this.discountans = new System.Windows.Forms.Button();
            this.ansl2 = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.RadioButton();
            this.autodis = new System.Windows.Forms.RadioButton();
            this.ans1 = new System.Windows.Forms.TextBox();
            this.anscopy = new System.Windows.Forms.Button();
            this.taxok = new System.Windows.Forms.Button();
            this.taxl = new System.Windows.Forms.Label();
            this.taxb = new System.Windows.Forms.Button();
            this.taxtb = new System.Windows.Forms.TextBox();
            this.combine1 = new System.Windows.Forms.CheckBox();
            this.Adjust = new System.Windows.Forms.Button();
            this.ans2 = new System.Windows.Forms.TextBox();
            this.infoboxx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tablegrid
            // 
            this.tablegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablegrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tablegrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablegrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablegrid.Location = new System.Drawing.Point(12, 29);
            this.tablegrid.MultiSelect = false;
            this.tablegrid.Name = "tablegrid";
            this.tablegrid.ReadOnly = true;
            this.tablegrid.ShowCellErrors = false;
            this.tablegrid.ShowCellToolTips = false;
            this.tablegrid.ShowEditingIcon = false;
            this.tablegrid.ShowRowErrors = false;
            this.tablegrid.Size = new System.Drawing.Size(649, 230);
            this.tablegrid.TabIndex = 60;
            this.tablegrid.VirtualMode = true;
            this.tablegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablegrid_CellContentClick_1);
            this.tablegrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cellmouse);
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(305, 9);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(14, 17);
            this.TableName.TabIndex = 1;
            this.TableName.Text = "*";
            this.TableName.Click += new System.EventHandler(this.TableName_Click);
            // 
            // searchidtext
            // 
            this.searchidtext.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchidtext.Location = new System.Drawing.Point(27, 287);
            this.searchidtext.Name = "searchidtext";
            this.searchidtext.Size = new System.Drawing.Size(100, 20);
            this.searchidtext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-------Search by ID --------------";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(564, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // randomlist
            // 
            this.randomlist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.randomlist.FormattingEnabled = true;
            this.randomlist.Location = new System.Drawing.Point(229, 287);
            this.randomlist.Name = "randomlist";
            this.randomlist.Size = new System.Drawing.Size(110, 21);
            this.randomlist.TabIndex = 51;
            this.randomlist.SelectedIndexChanged += new System.EventHandler(this.randomlist_SelectedIndexChanged);
            // 
            // randomsearchb
            // 
            this.randomsearchb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.randomsearchb.Location = new System.Drawing.Point(450, 284);
            this.randomsearchb.Name = "randomsearchb";
            this.randomsearchb.Size = new System.Drawing.Size(51, 23);
            this.randomsearchb.TabIndex = 50;
            this.randomsearchb.Text = "Search";
            this.randomsearchb.UseVisualStyleBackColor = false;
            this.randomsearchb.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "--------------------Random String ------------------------";
            // 
            // searchrandomtext
            // 
            this.searchrandomtext.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchrandomtext.Location = new System.Drawing.Point(344, 287);
            this.searchrandomtext.Name = "searchrandomtext";
            this.searchrandomtext.Size = new System.Drawing.Size(100, 20);
            this.searchrandomtext.TabIndex = 48;
            this.searchrandomtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(133, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Table Name :";
            // 
            // rightb
            // 
            this.rightb.BackColor = System.Drawing.Color.Transparent;
            this.rightb.FlatAppearance.BorderSize = 0;
            this.rightb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightb.Location = new System.Drawing.Point(752, 101);
            this.rightb.Name = "rightb";
            this.rightb.Size = new System.Drawing.Size(40, 35);
            this.rightb.TabIndex = 59;
            this.rightb.UseVisualStyleBackColor = false;
            this.rightb.MouseHover += new System.EventHandler(this.righthover);
            // 
            // calcbutt
            // 
            this.calcbutt.Location = new System.Drawing.Point(681, 29);
            this.calcbutt.Name = "calcbutt";
            this.calcbutt.Size = new System.Drawing.Size(75, 23);
            this.calcbutt.TabIndex = 66;
            this.calcbutt.Text = "Calculator";
            this.calcbutt.UseVisualStyleBackColor = true;
            this.calcbutt.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // calcbox
            // 
            this.calcbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calcbox.Location = new System.Drawing.Point(680, 58);
            this.calcbox.Name = "calcbox";
            this.calcbox.Size = new System.Drawing.Size(192, 20);
            this.calcbox.TabIndex = 67;
            this.calcbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.siwtchradiobut);
            this.calcbox.TextChanged += new System.EventHandler(this.calcbox_TextChanged);
            this.calcbox.Enter += new System.EventHandler(this.calcbox_Enter);
            // 
            // downbutton
            // 
            this.downbutton.BackColor = System.Drawing.Color.Transparent;
            this.downbutton.FlatAppearance.BorderSize = 0;
            this.downbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.downbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.downbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downbutton.Image = ((System.Drawing.Image)(resources.GetObject("downbutton.Image")));
            this.downbutton.Location = new System.Drawing.Point(701, 140);
            this.downbutton.Name = "downbutton";
            this.downbutton.Size = new System.Drawing.Size(35, 30);
            this.downbutton.TabIndex = 65;
            this.downbutton.UseVisualStyleBackColor = false;
            this.downbutton.Click += new System.EventHandler(this.downbutton_Click);
            this.downbutton.MouseLeave += new System.EventHandler(this.downleave);
            this.downbutton.MouseHover += new System.EventHandler(this.downhover);
            // 
            // upbutton
            // 
            this.upbutton.BackColor = System.Drawing.Color.Transparent;
            this.upbutton.FlatAppearance.BorderSize = 0;
            this.upbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.upbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.upbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upbutton.Image = ((System.Drawing.Image)(resources.GetObject("upbutton.Image")));
            this.upbutton.Location = new System.Drawing.Point(701, 75);
            this.upbutton.Name = "upbutton";
            this.upbutton.Size = new System.Drawing.Size(35, 30);
            this.upbutton.TabIndex = 64;
            this.upbutton.UseVisualStyleBackColor = false;
            this.upbutton.Click += new System.EventHandler(this.upbutton_Click);
            this.upbutton.MouseLeave += new System.EventHandler(this.upleave);
            this.upbutton.MouseHover += new System.EventHandler(this.uphover);
            // 
            // leftbutton
            // 
            this.leftbutton.BackColor = System.Drawing.Color.Transparent;
            this.leftbutton.FlatAppearance.BorderSize = 0;
            this.leftbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leftbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftbutton.Image = ((System.Drawing.Image)(resources.GetObject("leftbutton.Image")));
            this.leftbutton.Location = new System.Drawing.Point(665, 108);
            this.leftbutton.Name = "leftbutton";
            this.leftbutton.Size = new System.Drawing.Size(35, 30);
            this.leftbutton.TabIndex = 62;
            this.leftbutton.UseVisualStyleBackColor = false;
            this.leftbutton.Click += new System.EventHandler(this.leftbutton_Click);
            this.leftbutton.MouseLeave += new System.EventHandler(this.leftleave);
            this.leftbutton.MouseHover += new System.EventHandler(this.lefthover);
            // 
            // rightbutton
            // 
            this.rightbutton.BackColor = System.Drawing.Color.Transparent;
            this.rightbutton.FlatAppearance.BorderSize = 0;
            this.rightbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightbutton.Image = ((System.Drawing.Image)(resources.GetObject("rightbutton.Image")));
            this.rightbutton.Location = new System.Drawing.Point(737, 108);
            this.rightbutton.Name = "rightbutton";
            this.rightbutton.Size = new System.Drawing.Size(35, 30);
            this.rightbutton.TabIndex = 59;
            this.rightbutton.UseVisualStyleBackColor = false;
            this.rightbutton.Click += new System.EventHandler(this.rightbutton_Click);
            this.rightbutton.MouseLeave += new System.EventHandler(this.rightleave);
            this.rightbutton.MouseHover += new System.EventHandler(this.righthover);
            // 
            // plusb
            // 
            this.plusb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusb.ForeColor = System.Drawing.Color.Black;
            this.plusb.Location = new System.Drawing.Point(681, 84);
            this.plusb.Name = "plusb";
            this.plusb.Size = new System.Drawing.Size(19, 21);
            this.plusb.TabIndex = 68;
            this.plusb.Text = "+";
            this.plusb.UseVisualStyleBackColor = true;
            this.plusb.Click += new System.EventHandler(this.button4_Click);
            // 
            // mulb
            // 
            this.mulb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulb.ForeColor = System.Drawing.Color.Black;
            this.mulb.Location = new System.Drawing.Point(756, 84);
            this.mulb.Name = "mulb";
            this.mulb.Size = new System.Drawing.Size(19, 21);
            this.mulb.TabIndex = 69;
            this.mulb.Text = "*";
            this.mulb.UseVisualStyleBackColor = true;
            this.mulb.Click += new System.EventHandler(this.mulb_Click);
            // 
            // divb
            // 
            this.divb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divb.ForeColor = System.Drawing.Color.Black;
            this.divb.Location = new System.Drawing.Point(731, 84);
            this.divb.Name = "divb";
            this.divb.Size = new System.Drawing.Size(19, 21);
            this.divb.TabIndex = 70;
            this.divb.Text = "/";
            this.divb.UseVisualStyleBackColor = true;
            this.divb.Click += new System.EventHandler(this.divb_Click);
            // 
            // minusb
            // 
            this.minusb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusb.ForeColor = System.Drawing.Color.Black;
            this.minusb.Location = new System.Drawing.Point(706, 84);
            this.minusb.Name = "minusb";
            this.minusb.Size = new System.Drawing.Size(19, 21);
            this.minusb.TabIndex = 71;
            this.minusb.Text = "-";
            this.minusb.UseVisualStyleBackColor = true;
            this.minusb.Click += new System.EventHandler(this.minusb_Click);
            // 
            // calcout
            // 
            this.calcout.BackColor = System.Drawing.Color.Chocolate;
            this.calcout.Location = new System.Drawing.Point(781, 84);
            this.calcout.Name = "calcout";
            this.calcout.Size = new System.Drawing.Size(63, 21);
            this.calcout.TabIndex = 72;
            this.calcout.Text = "Calculate";
            this.calcout.UseVisualStyleBackColor = false;
            this.calcout.Click += new System.EventHandler(this.calcout_Click);
            // 
            // ansl1
            // 
            this.ansl1.AutoSize = true;
            this.ansl1.BackColor = System.Drawing.Color.Transparent;
            this.ansl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ansl1.Location = new System.Drawing.Point(682, 111);
            this.ansl1.Name = "ansl1";
            this.ansl1.Size = new System.Drawing.Size(57, 15);
            this.ansl1.TabIndex = 73;
            this.ansl1.Text = "Answer =";
            // 
            // discountt
            // 
            this.discountt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.discountt.Location = new System.Drawing.Point(745, 133);
            this.discountt.Name = "discountt";
            this.discountt.Size = new System.Drawing.Size(27, 20);
            this.discountt.TabIndex = 75;
            this.discountt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // discountb
            // 
            this.discountb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountb.Location = new System.Drawing.Point(681, 132);
            this.discountb.Name = "discountb";
            this.discountb.Size = new System.Drawing.Size(58, 21);
            this.discountb.TabIndex = 76;
            this.discountb.Text = "Discount";
            this.discountb.UseVisualStyleBackColor = true;
            this.discountb.Click += new System.EventHandler(this.discountb_Click);
            // 
            // disl
            // 
            this.disl.AutoSize = true;
            this.disl.BackColor = System.Drawing.Color.Transparent;
            this.disl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.disl.Location = new System.Drawing.Point(769, 135);
            this.disl.Name = "disl";
            this.disl.Size = new System.Drawing.Size(18, 15);
            this.disl.TabIndex = 77;
            this.disl.Text = "%";
            // 
            // discountans
            // 
            this.discountans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountans.Location = new System.Drawing.Point(785, 132);
            this.discountans.Name = "discountans";
            this.discountans.Size = new System.Drawing.Size(29, 21);
            this.discountans.TabIndex = 78;
            this.discountans.Text = "ok";
            this.discountans.UseVisualStyleBackColor = true;
            this.discountans.Click += new System.EventHandler(this.button6_Click);
            // 
            // ansl2
            // 
            this.ansl2.AutoSize = true;
            this.ansl2.BackColor = System.Drawing.Color.Transparent;
            this.ansl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ansl2.Location = new System.Drawing.Point(682, 185);
            this.ansl2.Name = "ansl2";
            this.ansl2.Size = new System.Drawing.Size(57, 15);
            this.ansl2.TabIndex = 79;
            this.ansl2.Text = "Answer =";
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Location = new System.Drawing.Point(665, 81);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(14, 13);
            this.auto.TabIndex = 81;
            this.auto.TabStop = true;
            this.auto.Tag = "check this radio button to activate automatic calculations.";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.CheckedChanged += new System.EventHandler(this.auto_CheckedChanged);
            this.auto.MouseLeave += new System.EventHandler(this.auto_MouseLeave);
            this.auto.MouseHover += new System.EventHandler(this.auto_MouseHover);
            // 
            // autodis
            // 
            this.autodis.AutoSize = true;
            this.autodis.Location = new System.Drawing.Point(665, 97);
            this.autodis.Name = "autodis";
            this.autodis.Size = new System.Drawing.Size(14, 13);
            this.autodis.TabIndex = 82;
            this.autodis.TabStop = true;
            this.autodis.UseVisualStyleBackColor = true;
            this.autodis.CheckedChanged += new System.EventHandler(this.autodis_CheckedChanged_1);
            this.autodis.MouseLeave += new System.EventHandler(this.autodis_MouseLeave);
            this.autodis.MouseHover += new System.EventHandler(this.autodis_MouseHover);
            // 
            // ans1
            // 
            this.ans1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ans1.Location = new System.Drawing.Point(739, 110);
            this.ans1.Name = "ans1";
            this.ans1.ReadOnly = true;
            this.ans1.Size = new System.Drawing.Size(133, 20);
            this.ans1.TabIndex = 83;
            this.ans1.Tag = "bitch";
            // 
            // anscopy
            // 
            this.anscopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anscopy.Location = new System.Drawing.Point(820, 132);
            this.anscopy.Name = "anscopy";
            this.anscopy.Size = new System.Drawing.Size(33, 21);
            this.anscopy.TabIndex = 84;
            this.anscopy.Text = "Ans";
            this.anscopy.UseVisualStyleBackColor = true;
            this.anscopy.Click += new System.EventHandler(this.button2_Click_4);
            // 
            // taxok
            // 
            this.taxok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxok.Location = new System.Drawing.Point(785, 159);
            this.taxok.Name = "taxok";
            this.taxok.Size = new System.Drawing.Size(29, 21);
            this.taxok.TabIndex = 88;
            this.taxok.Text = "ok";
            this.taxok.UseVisualStyleBackColor = true;
            this.taxok.Click += new System.EventHandler(this.taxok_Click);
            // 
            // taxl
            // 
            this.taxl.AutoSize = true;
            this.taxl.BackColor = System.Drawing.Color.Transparent;
            this.taxl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxl.Location = new System.Drawing.Point(769, 162);
            this.taxl.Name = "taxl";
            this.taxl.Size = new System.Drawing.Size(18, 15);
            this.taxl.TabIndex = 87;
            this.taxl.Text = "%";
            // 
            // taxb
            // 
            this.taxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxb.Location = new System.Drawing.Point(681, 159);
            this.taxb.Name = "taxb";
            this.taxb.Size = new System.Drawing.Size(58, 21);
            this.taxb.TabIndex = 86;
            this.taxb.Text = "Tax";
            this.taxb.UseVisualStyleBackColor = true;
            this.taxb.Click += new System.EventHandler(this.taxb_Click);
            // 
            // taxtb
            // 
            this.taxtb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.taxtb.Location = new System.Drawing.Point(745, 160);
            this.taxtb.Name = "taxtb";
            this.taxtb.Size = new System.Drawing.Size(27, 20);
            this.taxtb.TabIndex = 85;
            this.taxtb.TextChanged += new System.EventHandler(this.taxtb_TextChanged);
            // 
            // combine1
            // 
            this.combine1.AutoSize = true;
            this.combine1.Location = new System.Drawing.Point(824, 163);
            this.combine1.Name = "combine1";
            this.combine1.Size = new System.Drawing.Size(15, 14);
            this.combine1.TabIndex = 89;
            this.combine1.UseVisualStyleBackColor = true;
            this.combine1.CheckedChanged += new System.EventHandler(this.combine1_CheckedChanged);
            // 
            // Adjust
            // 
            this.Adjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adjust.Location = new System.Drawing.Point(772, 29);
            this.Adjust.Name = "Adjust";
            this.Adjust.Size = new System.Drawing.Size(55, 23);
            this.Adjust.TabIndex = 90;
            this.Adjust.Text = "←↑↓→";
            this.Adjust.UseVisualStyleBackColor = true;
            this.Adjust.Click += new System.EventHandler(this.Adjust_Click);
            this.Adjust.MouseLeave += new System.EventHandler(this.Adjust_MouseLeave);
            this.Adjust.MouseHover += new System.EventHandler(this.Adjust_MouseHover);
            // 
            // ans2
            // 
            this.ans2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ans2.Location = new System.Drawing.Point(739, 182);
            this.ans2.Name = "ans2";
            this.ans2.ReadOnly = true;
            this.ans2.Size = new System.Drawing.Size(133, 20);
            this.ans2.TabIndex = 91;
            this.ans2.Tag = "textboxxxxxxx";
            this.ans2.TextChanged += new System.EventHandler(this.ans2_TextChanged);
            // 
            // infoboxx
            // 
            this.infoboxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoboxx.ForeColor = System.Drawing.Color.Crimson;
            this.infoboxx.Location = new System.Drawing.Point(681, 210);
            this.infoboxx.Multiline = true;
            this.infoboxx.Name = "infoboxx";
            this.infoboxx.Size = new System.Drawing.Size(191, 49);
            this.infoboxx.TabIndex = 92;
            this.infoboxx.Text = "Hover over a control to get more information about it.";
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 314);
            this.Controls.Add(this.infoboxx);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.Adjust);
            this.Controls.Add(this.combine1);
            this.Controls.Add(this.taxok);
            this.Controls.Add(this.taxl);
            this.Controls.Add(this.taxb);
            this.Controls.Add(this.taxtb);
            this.Controls.Add(this.anscopy);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.autodis);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.ansl2);
            this.Controls.Add(this.discountans);
            this.Controls.Add(this.disl);
            this.Controls.Add(this.discountb);
            this.Controls.Add(this.discountt);
            this.Controls.Add(this.ansl1);
            this.Controls.Add(this.calcout);
            this.Controls.Add(this.minusb);
            this.Controls.Add(this.divb);
            this.Controls.Add(this.mulb);
            this.Controls.Add(this.plusb);
            this.Controls.Add(this.calcbox);
            this.Controls.Add(this.calcbutt);
            this.Controls.Add(this.downbutton);
            this.Controls.Add(this.upbutton);
            this.Controls.Add(this.leftbutton);
            this.Controls.Add(this.rightbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.randomlist);
            this.Controls.Add(this.randomsearchb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchrandomtext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchidtext);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.tablegrid);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableView";
            this.Text = "Table View";
            this.Load += new System.EventHandler(this.TableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablegrid;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.TextBox searchidtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox randomlist;
        private System.Windows.Forms.Button randomsearchb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchrandomtext;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rightbutton;
        private System.Windows.Forms.Button rightb;
        private System.Windows.Forms.Button leftbutton;
        private System.Windows.Forms.Button downbutton;
        private System.Windows.Forms.Button calcbutt;
        private System.Windows.Forms.Button upbutton;
        private System.Windows.Forms.TextBox calcbox;
        private System.Windows.Forms.Button plusb;
        private System.Windows.Forms.Button mulb;
        private System.Windows.Forms.Button divb;
        private System.Windows.Forms.Button minusb;
        private System.Windows.Forms.Button calcout;
        private System.Windows.Forms.Label ansl1;
        private System.Windows.Forms.TextBox discountt;
        private System.Windows.Forms.Button discountb;
        private System.Windows.Forms.Label disl;
        private System.Windows.Forms.Button discountans;
        private System.Windows.Forms.Label ansl2;
        private System.Windows.Forms.RadioButton auto;
        private System.Windows.Forms.RadioButton autodis;
        private System.Windows.Forms.Button anscopy;
        private System.Windows.Forms.Button taxok;
        private System.Windows.Forms.Label taxl;
        private System.Windows.Forms.Button taxb;
        private System.Windows.Forms.TextBox taxtb;
        private System.Windows.Forms.CheckBox combine1;
        private System.Windows.Forms.Button Adjust;
        private System.Windows.Forms.TextBox ans2;
        private System.Windows.Forms.TextBox infoboxx;
        private System.Windows.Forms.TextBox ans1;
    }
}