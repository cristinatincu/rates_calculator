namespace Rates_calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericNights = new System.Windows.Forms.NumericUpDown();
            this.groupRoom = new System.Windows.Forms.GroupBox();
            this.radioTrp = new System.Windows.Forms.RadioButton();
            this.radioDbl = new System.Windows.Forms.RadioButton();
            this.radioSgl = new System.Windows.Forms.RadioButton();
            this.groupRateType = new System.Windows.Forms.GroupBox();
            this.radioNRF = new System.Windows.Forms.RadioButton();
            this.radioBar = new System.Windows.Forms.RadioButton();
            this.groupBreakfast = new System.Windows.Forms.GroupBox();
            this.radioNBB = new System.Windows.Forms.RadioButton();
            this.radioBB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listDays = new System.Windows.Forms.ListView();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDaily = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteMealPlan = new System.Windows.Forms.Button();
            this.btnDeleteRateType = new System.Windows.Forms.Button();
            this.btnDeleteRoomType = new System.Windows.Forms.Button();
            this.btnAddMealPlan = new System.Windows.Forms.Button();
            this.btnAddRateType = new System.Windows.Forms.Button();
            this.btnAddRoomType = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNights)).BeginInit();
            this.groupRoom.SuspendLayout();
            this.groupRateType.SuspendLayout();
            this.groupBreakfast.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Agency:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 29);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImage = global::Rates_calculator.Properties.Resources.button1;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCalculate.Location = new System.Drawing.Point(166, 316);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 33);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 28);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arrival date:";
            // 
            // numericNights
            // 
            this.numericNights.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNights.Location = new System.Drawing.Point(143, 131);
            this.numericNights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNights.Name = "numericNights";
            this.numericNights.Size = new System.Drawing.Size(63, 28);
            this.numericNights.TabIndex = 4;
            this.numericNights.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNights.ValueChanged += new System.EventHandler(this.numericNights_ValueChanged);
            // 
            // groupRoom
            // 
            this.groupRoom.BackColor = System.Drawing.Color.Transparent;
            this.groupRoom.Controls.Add(this.radioTrp);
            this.groupRoom.Controls.Add(this.radioDbl);
            this.groupRoom.Controls.Add(this.radioSgl);
            this.groupRoom.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRoom.Location = new System.Drawing.Point(16, 270);
            this.groupRoom.Name = "groupRoom";
            this.groupRoom.Size = new System.Drawing.Size(116, 112);
            this.groupRoom.TabIndex = 2;
            this.groupRoom.TabStop = false;
            this.groupRoom.Text = "Room";
            // 
            // radioTrp
            // 
            this.radioTrp.AutoSize = true;
            this.radioTrp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTrp.Location = new System.Drawing.Point(5, 81);
            this.radioTrp.Name = "radioTrp";
            this.radioTrp.Size = new System.Drawing.Size(61, 23);
            this.radioTrp.TabIndex = 2;
            this.radioTrp.Text = "TRP";
            this.radioTrp.UseVisualStyleBackColor = true;
            this.radioTrp.CheckedChanged += new System.EventHandler(this.clearListView);
            // 
            // radioDbl
            // 
            this.radioDbl.AutoSize = true;
            this.radioDbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDbl.Location = new System.Drawing.Point(5, 52);
            this.radioDbl.Name = "radioDbl";
            this.radioDbl.Size = new System.Drawing.Size(104, 23);
            this.radioDbl.TabIndex = 1;
            this.radioDbl.Text = "DBL/TWN";
            this.radioDbl.UseVisualStyleBackColor = true;
            this.radioDbl.CheckedChanged += new System.EventHandler(this.clearListView);
            // 
            // radioSgl
            // 
            this.radioSgl.AutoSize = true;
            this.radioSgl.Checked = true;
            this.radioSgl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSgl.Location = new System.Drawing.Point(5, 24);
            this.radioSgl.Name = "radioSgl";
            this.radioSgl.Size = new System.Drawing.Size(62, 23);
            this.radioSgl.TabIndex = 0;
            this.radioSgl.TabStop = true;
            this.radioSgl.Text = "SGL";
            this.radioSgl.UseVisualStyleBackColor = true;
            this.radioSgl.CheckedChanged += new System.EventHandler(this.clearListView);
            // 
            // groupRateType
            // 
            this.groupRateType.BackColor = System.Drawing.Color.Transparent;
            this.groupRateType.Controls.Add(this.radioNRF);
            this.groupRateType.Controls.Add(this.radioBar);
            this.groupRateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRateType.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRateType.Location = new System.Drawing.Point(143, 171);
            this.groupRateType.Name = "groupRateType";
            this.groupRateType.Size = new System.Drawing.Size(144, 93);
            this.groupRateType.TabIndex = 1;
            this.groupRateType.TabStop = false;
            this.groupRateType.Text = "Rate type";
            // 
            // radioNRF
            // 
            this.radioNRF.AutoSize = true;
            this.radioNRF.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNRF.Location = new System.Drawing.Point(5, 56);
            this.radioNRF.Name = "radioNRF";
            this.radioNRF.Size = new System.Drawing.Size(62, 23);
            this.radioNRF.TabIndex = 1;
            this.radioNRF.Text = "NRF";
            this.radioNRF.UseVisualStyleBackColor = true;
            this.radioNRF.CheckedChanged += new System.EventHandler(this.clearListView);
            // 
            // radioBar
            // 
            this.radioBar.AutoSize = true;
            this.radioBar.Checked = true;
            this.radioBar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBar.Location = new System.Drawing.Point(5, 28);
            this.radioBar.Name = "radioBar";
            this.radioBar.Size = new System.Drawing.Size(63, 23);
            this.radioBar.TabIndex = 0;
            this.radioBar.TabStop = true;
            this.radioBar.Text = "BAR";
            this.radioBar.UseVisualStyleBackColor = true;
            this.radioBar.CheckedChanged += new System.EventHandler(this.clearListView);
            // 
            // groupBreakfast
            // 
            this.groupBreakfast.BackColor = System.Drawing.Color.Transparent;
            this.groupBreakfast.Controls.Add(this.radioNBB);
            this.groupBreakfast.Controls.Add(this.radioBB);
            this.groupBreakfast.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBreakfast.Location = new System.Drawing.Point(16, 171);
            this.groupBreakfast.Name = "groupBreakfast";
            this.groupBreakfast.Size = new System.Drawing.Size(116, 93);
            this.groupBreakfast.TabIndex = 0;
            this.groupBreakfast.TabStop = false;
            this.groupBreakfast.Text = "Breakfast";
            // 
            // radioNBB
            // 
            this.radioNBB.AutoSize = true;
            this.radioNBB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNBB.Location = new System.Drawing.Point(5, 55);
            this.radioNBB.Name = "radioNBB";
            this.radioNBB.Size = new System.Drawing.Size(50, 23);
            this.radioNBB.TabIndex = 1;
            this.radioNBB.Text = "No";
            this.radioNBB.UseVisualStyleBackColor = true;
            this.radioNBB.CheckedChanged += new System.EventHandler(this.clearListView);
            // 
            // radioBB
            // 
            this.radioBB.AutoSize = true;
            this.radioBB.Checked = true;
            this.radioBB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBB.Location = new System.Drawing.Point(5, 27);
            this.radioBB.Name = "radioBB";
            this.radioBB.Size = new System.Drawing.Size(56, 23);
            this.radioBB.TabIndex = 0;
            this.radioBB.TabStop = true;
            this.radioBB.Text = "Yes";
            this.radioBB.UseVisualStyleBackColor = true;
            this.radioBB.CheckedChanged += new System.EventHandler(this.clearListView);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 29);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Rates_calculator.Properties.Resources.settings_23_24;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 29);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Rates_calculator.Properties.Resources.minimize5;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(605, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 29);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Rates_calculator.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(628, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 29);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listDays
            // 
            this.listDays.BackColor = System.Drawing.Color.White;
            this.listDays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnRate});
            this.listDays.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDays.FullRowSelect = true;
            this.listDays.GridLines = true;
            this.listDays.Location = new System.Drawing.Point(319, 35);
            this.listDays.Name = "listDays";
            this.listDays.Size = new System.Drawing.Size(309, 323);
            this.listDays.TabIndex = 16;
            this.listDays.UseCompatibleStateImageBehavior = false;
            this.listDays.View = System.Windows.Forms.View.Details;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 150;
            // 
            // columnRate
            // 
            this.columnRate.Text = "Rate";
            this.columnRate.Width = 150;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(475, 367);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(69, 27);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "Total:";
            // 
            // labelDaily
            // 
            this.labelDaily.AutoSize = true;
            this.labelDaily.BackColor = System.Drawing.Color.Transparent;
            this.labelDaily.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaily.Location = new System.Drawing.Point(324, 367);
            this.labelDaily.Name = "labelDaily";
            this.labelDaily.Size = new System.Drawing.Size(72, 27);
            this.labelDaily.TabIndex = 18;
            this.labelDaily.Text = "Daily:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteMealPlan);
            this.panel2.Controls.Add(this.btnDeleteRateType);
            this.panel2.Controls.Add(this.btnDeleteRoomType);
            this.panel2.Controls.Add(this.btnAddMealPlan);
            this.panel2.Controls.Add(this.btnAddRateType);
            this.panel2.Controls.Add(this.btnAddRoomType);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnChooseFile);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 373);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // btnDeleteMealPlan
            // 
            this.btnDeleteMealPlan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteMealPlan.BackgroundImage")));
            this.btnDeleteMealPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteMealPlan.FlatAppearance.BorderSize = 0;
            this.btnDeleteMealPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMealPlan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMealPlan.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteMealPlan.Location = new System.Drawing.Point(293, 211);
            this.btnDeleteMealPlan.Name = "btnDeleteMealPlan";
            this.btnDeleteMealPlan.Size = new System.Drawing.Size(33, 27);
            this.btnDeleteMealPlan.TabIndex = 16;
            this.btnDeleteMealPlan.Text = "-";
            this.btnDeleteMealPlan.UseVisualStyleBackColor = true;
            this.btnDeleteMealPlan.Click += new System.EventHandler(this.btnDeleteMealPlan_Click);
            // 
            // btnDeleteRateType
            // 
            this.btnDeleteRateType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRateType.BackgroundImage")));
            this.btnDeleteRateType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteRateType.FlatAppearance.BorderSize = 0;
            this.btnDeleteRateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRateType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRateType.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteRateType.Location = new System.Drawing.Point(293, 147);
            this.btnDeleteRateType.Name = "btnDeleteRateType";
            this.btnDeleteRateType.Size = new System.Drawing.Size(33, 27);
            this.btnDeleteRateType.TabIndex = 15;
            this.btnDeleteRateType.Text = "-";
            this.btnDeleteRateType.UseVisualStyleBackColor = true;
            this.btnDeleteRateType.Click += new System.EventHandler(this.btnDeleteRateType_Click);
            // 
            // btnDeleteRoomType
            // 
            this.btnDeleteRoomType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoomType.BackgroundImage")));
            this.btnDeleteRoomType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteRoomType.FlatAppearance.BorderSize = 0;
            this.btnDeleteRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoomType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoomType.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteRoomType.Location = new System.Drawing.Point(293, 81);
            this.btnDeleteRoomType.Name = "btnDeleteRoomType";
            this.btnDeleteRoomType.Size = new System.Drawing.Size(33, 27);
            this.btnDeleteRoomType.TabIndex = 14;
            this.btnDeleteRoomType.Text = "-";
            this.btnDeleteRoomType.UseVisualStyleBackColor = true;
            this.btnDeleteRoomType.Click += new System.EventHandler(this.btnDeleteRoomType_Click);
            // 
            // btnAddMealPlan
            // 
            this.btnAddMealPlan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMealPlan.BackgroundImage")));
            this.btnAddMealPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMealPlan.FlatAppearance.BorderSize = 0;
            this.btnAddMealPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMealPlan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMealPlan.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddMealPlan.Location = new System.Drawing.Point(254, 211);
            this.btnAddMealPlan.Name = "btnAddMealPlan";
            this.btnAddMealPlan.Size = new System.Drawing.Size(33, 27);
            this.btnAddMealPlan.TabIndex = 13;
            this.btnAddMealPlan.Text = "+";
            this.btnAddMealPlan.UseVisualStyleBackColor = true;
            this.btnAddMealPlan.Click += new System.EventHandler(this.btnAddMealPlan_Click);
            // 
            // btnAddRateType
            // 
            this.btnAddRateType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRateType.BackgroundImage")));
            this.btnAddRateType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRateType.FlatAppearance.BorderSize = 0;
            this.btnAddRateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRateType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRateType.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddRateType.Location = new System.Drawing.Point(254, 147);
            this.btnAddRateType.Name = "btnAddRateType";
            this.btnAddRateType.Size = new System.Drawing.Size(33, 27);
            this.btnAddRateType.TabIndex = 12;
            this.btnAddRateType.Text = "+";
            this.btnAddRateType.UseVisualStyleBackColor = true;
            this.btnAddRateType.Click += new System.EventHandler(this.btnAddRateType_Click);
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoomType.BackgroundImage")));
            this.btnAddRoomType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRoomType.FlatAppearance.BorderSize = 0;
            this.btnAddRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoomType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoomType.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddRoomType.Location = new System.Drawing.Point(254, 81);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(33, 27);
            this.btnAddRoomType.TabIndex = 11;
            this.btnAddRoomType.Text = "+";
            this.btnAddRoomType.UseVisualStyleBackColor = true;
            this.btnAddRoomType.Click += new System.EventHandler(this.btnAddRoomType_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(127, 211);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(127, 147);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(127, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Meal plans";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rate types";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room types";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(127, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Excel file: ";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseFile.BackgroundImage = global::Rates_calculator.Properties.Resources.button1;
            this.btnChooseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseFile.FlatAppearance.BorderSize = 0;
            this.btnChooseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnChooseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnChooseFile.Location = new System.Drawing.Point(466, 20);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(78, 30);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Choose";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Rates_calculator.Properties.Resources.button1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClose.Location = new System.Drawing.Point(355, 293);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Rates_calculator.Properties.Resources.button1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(209, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Rates_calculator.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listDays);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDaily);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBreakfast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupRateType);
            this.Controls.Add(this.numericNights);
            this.Controls.Add(this.groupRoom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(656, 402);
            this.MinimumSize = new System.Drawing.Size(656, 402);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rates calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericNights)).EndInit();
            this.groupRoom.ResumeLayout(false);
            this.groupRoom.PerformLayout();
            this.groupRateType.ResumeLayout(false);
            this.groupRateType.PerformLayout();
            this.groupBreakfast.ResumeLayout(false);
            this.groupBreakfast.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupRoom;
        private System.Windows.Forms.GroupBox groupRateType;
        private System.Windows.Forms.GroupBox groupBreakfast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericNights;
        private System.Windows.Forms.RadioButton radioTrp;
        private System.Windows.Forms.RadioButton radioDbl;
        private System.Windows.Forms.RadioButton radioSgl;
        private System.Windows.Forms.RadioButton radioNRF;
        private System.Windows.Forms.RadioButton radioBar;
        private System.Windows.Forms.RadioButton radioNBB;
        private System.Windows.Forms.RadioButton radioBB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listDays;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnRate;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDaily;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnAddRoomType;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteMealPlan;
        private System.Windows.Forms.Button btnDeleteRateType;
        private System.Windows.Forms.Button btnDeleteRoomType;
        private System.Windows.Forms.Button btnAddMealPlan;
        private System.Windows.Forms.Button btnAddRateType;
    }
}

