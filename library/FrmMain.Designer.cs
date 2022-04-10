using System.Windows.Forms;

namespace 简单图书馆系统
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbCategory3 = new System.Windows.Forms.ComboBox();
            this.cbCategory2 = new System.Windows.Forms.ComboBox();
            this.cbCategory1 = new System.Windows.Forms.ComboBox();
            this.lbCategory2 = new System.Windows.Forms.Label();
            this.lbCategory3 = new System.Windows.Forms.Label();
            this.lbCategory1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataGridViewDel = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.dataGridViewChange = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnQueryAll = new System.Windows.Forms.Button();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cbQCategory3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbQID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbQCategory2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbQCategory1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbQName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lbTotal1 = new System.Windows.Forms.Label();
            this.lbTotal2 = new System.Windows.Forms.Label();
            this.cbCountC3 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbCountC2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbCountC1 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbCountB2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbCountB1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lbTotal3 = new System.Windows.Forms.Label();
            this.cbCountA1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDel)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChange)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.Location = new System.Drawing.Point(14, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(536, 75);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "简单图书馆管理系统";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackgroundImage = global::简单图书馆系统.Properties.Resources.tuichu;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExit.Location = new System.Drawing.Point(1210, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.BackgroundImage = global::简单图书馆系统.Properties.Resources.minx;
            this.pictureBoxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMin.Location = new System.Drawing.Point(1144, 12);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxMin.TabIndex = 3;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 691);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.tbCount);
            this.tabPage1.Controls.Add(this.lbCount);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.lbName);
            this.tabPage1.Controls.Add(this.cbCategory3);
            this.tabPage1.Controls.Add(this.cbCategory2);
            this.tabPage1.Controls.Add(this.cbCategory1);
            this.tabPage1.Controls.Add(this.lbCategory2);
            this.tabPage1.Controls.Add(this.lbCategory3);
            this.tabPage1.Controls.Add(this.lbCategory1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "增加";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::简单图书馆系统.Properties.Resources._960;
            this.pictureBox1.Location = new System.Drawing.Point(6, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1118, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 44);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(1194, 5);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(43, 41);
            this.tbCount.TabIndex = 11;
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCount_KeyPress);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(1113, 12);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(71, 29);
            this.lbCount.TabIndex = 10;
            this.lbCount.Text = "数量";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(917, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(190, 41);
            this.tbName.TabIndex = 9;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(840, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 29);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "名称";
            // 
            // cbCategory3
            // 
            this.cbCategory3.FormattingEnabled = true;
            this.cbCategory3.Location = new System.Drawing.Point(697, 9);
            this.cbCategory3.Name = "cbCategory3";
            this.cbCategory3.Size = new System.Drawing.Size(137, 37);
            this.cbCategory3.TabIndex = 7;
            // 
            // cbCategory2
            // 
            this.cbCategory2.FormattingEnabled = true;
            this.cbCategory2.Location = new System.Drawing.Point(403, 9);
            this.cbCategory2.Name = "cbCategory2";
            this.cbCategory2.Size = new System.Drawing.Size(153, 37);
            this.cbCategory2.TabIndex = 6;
            this.cbCategory2.SelectedIndexChanged += new System.EventHandler(this.cbCategory2_SelectedIndexChanged);
            // 
            // cbCategory1
            // 
            this.cbCategory1.FormattingEnabled = true;
            this.cbCategory1.Location = new System.Drawing.Point(141, 9);
            this.cbCategory1.Name = "cbCategory1";
            this.cbCategory1.Size = new System.Drawing.Size(121, 37);
            this.cbCategory1.TabIndex = 5;
            this.cbCategory1.SelectedIndexChanged += new System.EventHandler(this.cbCategory1_SelectedIndexChanged);
            // 
            // lbCategory2
            // 
            this.lbCategory2.AutoSize = true;
            this.lbCategory2.Location = new System.Drawing.Point(268, 12);
            this.lbCategory2.Name = "lbCategory2";
            this.lbCategory2.Size = new System.Drawing.Size(129, 29);
            this.lbCategory2.TabIndex = 4;
            this.lbCategory2.Text = "第二类别";
            // 
            // lbCategory3
            // 
            this.lbCategory3.AutoSize = true;
            this.lbCategory3.Location = new System.Drawing.Point(562, 12);
            this.lbCategory3.Name = "lbCategory3";
            this.lbCategory3.Size = new System.Drawing.Size(129, 29);
            this.lbCategory3.TabIndex = 2;
            this.lbCategory3.Text = "第三类别";
            // 
            // lbCategory1
            // 
            this.lbCategory1.AutoSize = true;
            this.lbCategory1.Location = new System.Drawing.Point(6, 12);
            this.lbCategory1.Name = "lbCategory1";
            this.lbCategory1.Size = new System.Drawing.Size(129, 29);
            this.lbCategory1.TabIndex = 0;
            this.lbCategory1.Text = "第一类别";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDel);
            this.tabPage2.Controls.Add(this.dataGridViewDel);
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1097, 586);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(147, 50);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataGridViewDel
            // 
            this.dataGridViewDel.ColumnHeadersHeight = 50;
            this.dataGridViewDel.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDel.Name = "dataGridViewDel";
            this.dataGridViewDel.ReadOnly = true;
            this.dataGridViewDel.RowTemplate.Height = 50;
            this.dataGridViewDel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDel.Size = new System.Drawing.Size(1238, 574);
            this.dataGridViewDel.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbChange);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnChange);
            this.tabPage3.Controls.Add(this.dataGridViewChange);
            this.tabPage3.Location = new System.Drawing.Point(4, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1250, 642);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "修改";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(139, 11);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(458, 47);
            this.tbChange.TabIndex = 3;
            this.tbChange.TextChanged += new System.EventHandler(this.tbChange_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 35);
            this.label7.TabIndex = 2;
            this.label7.Text = "值名称";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(1112, 8);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 50);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // dataGridViewChange
            // 
            this.dataGridViewChange.ColumnHeadersHeight = 50;
            this.dataGridViewChange.Location = new System.Drawing.Point(3, 64);
            this.dataGridViewChange.Name = "dataGridViewChange";
            this.dataGridViewChange.RowTemplate.Height = 50;
            this.dataGridViewChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewChange.Size = new System.Drawing.Size(1244, 575);
            this.dataGridViewChange.TabIndex = 0;
            this.dataGridViewChange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChange_CellClick);
            this.dataGridViewChange.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChange_CellEndEdit);
            this.dataGridViewChange.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChange_CellLeave);
            this.dataGridViewChange.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewChange_CellMouseDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnQueryAll);
            this.tabPage4.Controls.Add(this.dataGridViewQuery);
            this.tabPage4.Controls.Add(this.btnQuery);
            this.tabPage4.Controls.Add(this.cbQCategory3);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.tbQID);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.cbQCategory2);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.cbQCategory1);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.tbQName);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 45);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1250, 642);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "查询";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnQueryAll
            // 
            this.btnQueryAll.Location = new System.Drawing.Point(1071, 589);
            this.btnQueryAll.Name = "btnQueryAll";
            this.btnQueryAll.Size = new System.Drawing.Size(176, 50);
            this.btnQueryAll.TabIndex = 14;
            this.btnQueryAll.Text = "全部查询";
            this.btnQueryAll.UseVisualStyleBackColor = true;
            this.btnQueryAll.Click += new System.EventHandler(this.btnQueryAll_Click);
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.ColumnHeadersHeight = 50;
            this.dataGridViewQuery.Location = new System.Drawing.Point(3, 108);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.ReadOnly = true;
            this.dataGridViewQuery.RowTemplate.Height = 50;
            this.dataGridViewQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuery.Size = new System.Drawing.Size(1244, 475);
            this.dataGridViewQuery.TabIndex = 11;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1044, 59);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(203, 46);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "条件查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cbQCategory3
            // 
            this.cbQCategory3.FormattingEnabled = true;
            this.cbQCategory3.Location = new System.Drawing.Point(1044, 8);
            this.cbQCategory3.Name = "cbQCategory3";
            this.cbQCategory3.Size = new System.Drawing.Size(203, 43);
            this.cbQCategory3.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(918, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 35);
            this.label12.TabIndex = 8;
            this.label12.Text = "类别三";
            // 
            // tbQID
            // 
            this.tbQID.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbQID.Location = new System.Drawing.Point(94, 58);
            this.tbQID.Name = "tbQID";
            this.tbQID.Size = new System.Drawing.Size(181, 44);
            this.tbQID.TabIndex = 7;
            this.tbQID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQID_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 35);
            this.label11.TabIndex = 6;
            this.label11.Text = "编号";
            // 
            // cbQCategory2
            // 
            this.cbQCategory2.FormattingEnabled = true;
            this.cbQCategory2.Location = new System.Drawing.Point(725, 8);
            this.cbQCategory2.Name = "cbQCategory2";
            this.cbQCategory2.Size = new System.Drawing.Size(187, 43);
            this.cbQCategory2.TabIndex = 5;
            this.cbQCategory2.SelectedIndexChanged += new System.EventHandler(this.cbQCategory2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 35);
            this.label10.TabIndex = 4;
            this.label10.Text = "类别二";
            // 
            // cbQCategory1
            // 
            this.cbQCategory1.FormattingEnabled = true;
            this.cbQCategory1.Location = new System.Drawing.Point(401, 8);
            this.cbQCategory1.Name = "cbQCategory1";
            this.cbQCategory1.Size = new System.Drawing.Size(192, 43);
            this.cbQCategory1.TabIndex = 3;
            this.cbQCategory1.SelectedIndexChanged += new System.EventHandler(this.cbQCategory1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 35);
            this.label9.TabIndex = 2;
            this.label9.Text = "类别一";
            // 
            // tbQName
            // 
            this.tbQName.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbQName.Location = new System.Drawing.Point(94, 8);
            this.tbQName.Name = "tbQName";
            this.tbQName.Size = new System.Drawing.Size(181, 44);
            this.tbQName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "名称";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnTotal);
            this.tabPage5.Controls.Add(this.lbTotal1);
            this.tabPage5.Controls.Add(this.lbTotal2);
            this.tabPage5.Controls.Add(this.cbCountC3);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.cbCountC2);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.cbCountC1);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.cbCountB2);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.cbCountB1);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.lbTotal3);
            this.tabPage5.Controls.Add(this.cbCountA1);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Location = new System.Drawing.Point(4, 45);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1250, 642);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "统计";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(1069, 179);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(119, 49);
            this.btnTotal.TabIndex = 31;
            this.btnTotal.Text = "统计";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lbTotal1
            // 
            this.lbTotal1.AutoSize = true;
            this.lbTotal1.Location = new System.Drawing.Point(1012, 20);
            this.lbTotal1.Name = "lbTotal1";
            this.lbTotal1.Size = new System.Drawing.Size(225, 35);
            this.lbTotal1.TabIndex = 30;
            this.lbTotal1.Text = "总数：未统计";
            // 
            // lbTotal2
            // 
            this.lbTotal2.AutoSize = true;
            this.lbTotal2.Location = new System.Drawing.Point(1012, 69);
            this.lbTotal2.Name = "lbTotal2";
            this.lbTotal2.Size = new System.Drawing.Size(225, 35);
            this.lbTotal2.TabIndex = 29;
            this.lbTotal2.Text = "总数：未统计";
            // 
            // cbCountC3
            // 
            this.cbCountC3.FormattingEnabled = true;
            this.cbCountC3.Location = new System.Drawing.Point(772, 119);
            this.cbCountC3.Name = "cbCountC3";
            this.cbCountC3.Size = new System.Drawing.Size(222, 43);
            this.cbCountC3.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(641, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 35);
            this.label20.TabIndex = 27;
            this.label20.Text = "类别三";
            // 
            // cbCountC2
            // 
            this.cbCountC2.FormattingEnabled = true;
            this.cbCountC2.Location = new System.Drawing.Point(425, 119);
            this.cbCountC2.Name = "cbCountC2";
            this.cbCountC2.Size = new System.Drawing.Size(198, 43);
            this.cbCountC2.TabIndex = 26;
            this.cbCountC2.SelectedIndexChanged += new System.EventHandler(this.cbCountC2_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(299, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 35);
            this.label21.TabIndex = 25;
            this.label21.Text = "类别二";
            // 
            // cbCountC1
            // 
            this.cbCountC1.FormattingEnabled = true;
            this.cbCountC1.Location = new System.Drawing.Point(141, 119);
            this.cbCountC1.Name = "cbCountC1";
            this.cbCountC1.Size = new System.Drawing.Size(152, 43);
            this.cbCountC1.TabIndex = 24;
            this.cbCountC1.SelectedIndexChanged += new System.EventHandler(this.cbCountC1_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 35);
            this.label22.TabIndex = 23;
            this.label22.Text = "类别一";
            // 
            // cbCountB2
            // 
            this.cbCountB2.FormattingEnabled = true;
            this.cbCountB2.Location = new System.Drawing.Point(425, 70);
            this.cbCountB2.Name = "cbCountB2";
            this.cbCountB2.Size = new System.Drawing.Size(198, 43);
            this.cbCountB2.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(299, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 35);
            this.label18.TabIndex = 19;
            this.label18.Text = "类别二";
            // 
            // cbCountB1
            // 
            this.cbCountB1.FormattingEnabled = true;
            this.cbCountB1.Location = new System.Drawing.Point(141, 70);
            this.cbCountB1.Name = "cbCountB1";
            this.cbCountB1.Size = new System.Drawing.Size(152, 43);
            this.cbCountB1.TabIndex = 18;
            this.cbCountB1.SelectedIndexChanged += new System.EventHandler(this.cbCountB1_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 35);
            this.label19.TabIndex = 17;
            this.label19.Text = "类别一";
            // 
            // lbTotal3
            // 
            this.lbTotal3.AutoSize = true;
            this.lbTotal3.Location = new System.Drawing.Point(1012, 122);
            this.lbTotal3.Name = "lbTotal3";
            this.lbTotal3.Size = new System.Drawing.Size(225, 35);
            this.lbTotal3.TabIndex = 16;
            this.lbTotal3.Text = "总数：未统计";
            // 
            // cbCountA1
            // 
            this.cbCountA1.FormattingEnabled = true;
            this.cbCountA1.Location = new System.Drawing.Point(141, 21);
            this.cbCountA1.Name = "cbCountA1";
            this.cbCountA1.Size = new System.Drawing.Size(152, 43);
            this.cbCountA1.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 35);
            this.label15.TabIndex = 10;
            this.label15.Text = "类别一";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::简单图书馆系统.Properties.Resources.工1111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.pictureBoxMin);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简单图书馆系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChange)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbCategory3;
        private System.Windows.Forms.ComboBox cbCategory2;
        private System.Windows.Forms.ComboBox cbCategory1;
        private System.Windows.Forms.Label lbCategory2;
        private System.Windows.Forms.Label lbCategory3;
        private System.Windows.Forms.Label lbCategory1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dataGridViewDel;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridView dataGridViewChange;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cbQCategory3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbQID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbQCategory2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbQCategory1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbQName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lbTotal1;
        private System.Windows.Forms.Label lbTotal2;
        private System.Windows.Forms.ComboBox cbCountC3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbCountC2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbCountC1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbCountB2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbCountB1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbTotal3;
        private System.Windows.Forms.ComboBox cbCountA1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnQueryAll;
        private PictureBox pictureBoxMin;
        private TabControl tabControl1;
    }
}