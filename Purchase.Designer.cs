namespace grandee_project
{
    partial class Purchase
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialSingleLineTextField9 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField10 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField11 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.idpurcahseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaserepBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purchaserepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaserepBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaserepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Vendor Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.materialSingleLineTextField9);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField8);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField7);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField4);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField5);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField6);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField3);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField2);
            this.groupBox1.Controls.Add(this.materialSingleLineTextField1);
            this.groupBox1.Location = new System.Drawing.Point(247, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // materialSingleLineTextField9
            // 
            this.materialSingleLineTextField9.Depth = 0;
            this.materialSingleLineTextField9.Hint = "Paid Amount";
            this.materialSingleLineTextField9.Location = new System.Drawing.Point(335, 119);
            this.materialSingleLineTextField9.MaxLength = 32767;
            this.materialSingleLineTextField9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField9.Name = "materialSingleLineTextField9";
            this.materialSingleLineTextField9.PasswordChar = '\0';
            this.materialSingleLineTextField9.SelectedText = "";
            this.materialSingleLineTextField9.SelectionLength = 0;
            this.materialSingleLineTextField9.SelectionStart = 0;
            this.materialSingleLineTextField9.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField9.TabIndex = 8;
            this.materialSingleLineTextField9.TabStop = false;
            this.materialSingleLineTextField9.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField8
            // 
            this.materialSingleLineTextField8.Depth = 0;
            this.materialSingleLineTextField8.Hint = "Less";
            this.materialSingleLineTextField8.Location = new System.Drawing.Point(177, 119);
            this.materialSingleLineTextField8.MaxLength = 32767;
            this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
            this.materialSingleLineTextField8.PasswordChar = '\0';
            this.materialSingleLineTextField8.SelectedText = "";
            this.materialSingleLineTextField8.SelectionLength = 0;
            this.materialSingleLineTextField8.SelectionStart = 0;
            this.materialSingleLineTextField8.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField8.TabIndex = 7;
            this.materialSingleLineTextField8.TabStop = false;
            this.materialSingleLineTextField8.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField7
            // 
            this.materialSingleLineTextField7.Depth = 0;
            this.materialSingleLineTextField7.Hint = "Add";
            this.materialSingleLineTextField7.Location = new System.Drawing.Point(19, 119);
            this.materialSingleLineTextField7.MaxLength = 32767;
            this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
            this.materialSingleLineTextField7.PasswordChar = '\0';
            this.materialSingleLineTextField7.SelectedText = "";
            this.materialSingleLineTextField7.SelectionLength = 0;
            this.materialSingleLineTextField7.SelectionStart = 0;
            this.materialSingleLineTextField7.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField7.TabIndex = 6;
            this.materialSingleLineTextField7.TabStop = false;
            this.materialSingleLineTextField7.UseSystemPasswordChar = false;
            this.materialSingleLineTextField7.Click += new System.EventHandler(this.materialSingleLineTextField7_Click);
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "Weight";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(335, 73);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField4.TabIndex = 5;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            this.materialSingleLineTextField4.Click += new System.EventHandler(this.materialSingleLineTextField4_Click);
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "Weight per Bag";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(176, 73);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField5.TabIndex = 4;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "Rate per Bag";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(19, 73);
            this.materialSingleLineTextField6.MaxLength = 32767;
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField6.TabIndex = 3;
            this.materialSingleLineTextField6.TabStop = false;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            this.materialSingleLineTextField6.Click += new System.EventHandler(this.materialSingleLineTextField6_Click);
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Bags";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(335, 29);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField3.TabIndex = 2;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            this.materialSingleLineTextField3.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Vehicle No";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(177, 29);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField2.TabIndex = 1;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Item Name";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(19, 29);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpurcahseDataGridViewTextBoxColumn,
            this.idvenDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.vehiclenoDataGridViewTextBoxColumn,
            this.rpbDataGridViewTextBoxColumn,
            this.wpbDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.addamountDataGridViewTextBoxColumn,
            this.lessamountDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.balanceamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaserepBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 227);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(657, 260);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(102, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Enter Data";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(617, 543);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 36);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "Generate Report";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialSingleLineTextField10
            // 
            this.materialSingleLineTextField10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialSingleLineTextField10.Depth = 0;
            this.materialSingleLineTextField10.Hint = "id";
            this.materialSingleLineTextField10.Location = new System.Drawing.Point(315, 556);
            this.materialSingleLineTextField10.MaxLength = 32767;
            this.materialSingleLineTextField10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField10.Name = "materialSingleLineTextField10";
            this.materialSingleLineTextField10.PasswordChar = '\0';
            this.materialSingleLineTextField10.SelectedText = "";
            this.materialSingleLineTextField10.SelectionLength = 0;
            this.materialSingleLineTextField10.SelectionStart = 0;
            this.materialSingleLineTextField10.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField10.TabIndex = 25;
            this.materialSingleLineTextField10.TabStop = false;
            this.materialSingleLineTextField10.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(140, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "todate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "fromdate";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(134, 559);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker3.TabIndex = 22;
            this.dateTimePicker3.Value = new System.DateTime(2018, 9, 26, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 559);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.Value = new System.DateTime(2018, 9, 26, 0, 0, 0, 0);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(497, 260);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(69, 36);
            this.materialRaisedButton3.TabIndex = 26;
            this.materialRaisedButton3.Text = "DELETE";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(572, 260);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton4.TabIndex = 27;
            this.materialRaisedButton4.Text = "REFRESH";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialSingleLineTextField11
            // 
            this.materialSingleLineTextField11.Depth = 0;
            this.materialSingleLineTextField11.Hint = "id_purchase";
            this.materialSingleLineTextField11.Location = new System.Drawing.Point(339, 273);
            this.materialSingleLineTextField11.MaxLength = 32767;
            this.materialSingleLineTextField11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField11.Name = "materialSingleLineTextField11";
            this.materialSingleLineTextField11.PasswordChar = '\0';
            this.materialSingleLineTextField11.SelectedText = "";
            this.materialSingleLineTextField11.SelectionLength = 0;
            this.materialSingleLineTextField11.SelectionStart = 0;
            this.materialSingleLineTextField11.Size = new System.Drawing.Size(152, 23);
            this.materialSingleLineTextField11.TabIndex = 29;
            this.materialSingleLineTextField11.TabStop = false;
            this.materialSingleLineTextField11.UseSystemPasswordChar = false;
            // 
            // idpurcahseDataGridViewTextBoxColumn
            // 
            this.idpurcahseDataGridViewTextBoxColumn.DataPropertyName = "id_purcahse";
            this.idpurcahseDataGridViewTextBoxColumn.HeaderText = "id_purcahse";
            this.idpurcahseDataGridViewTextBoxColumn.Name = "idpurcahseDataGridViewTextBoxColumn";
            // 
            // idvenDataGridViewTextBoxColumn
            // 
            this.idvenDataGridViewTextBoxColumn.DataPropertyName = "id_ven";
            this.idvenDataGridViewTextBoxColumn.HeaderText = "id_ven";
            this.idvenDataGridViewTextBoxColumn.Name = "idvenDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // vehiclenoDataGridViewTextBoxColumn
            // 
            this.vehiclenoDataGridViewTextBoxColumn.DataPropertyName = "vehicle_no";
            this.vehiclenoDataGridViewTextBoxColumn.HeaderText = "vehicle_no";
            this.vehiclenoDataGridViewTextBoxColumn.Name = "vehiclenoDataGridViewTextBoxColumn";
            // 
            // rpbDataGridViewTextBoxColumn
            // 
            this.rpbDataGridViewTextBoxColumn.DataPropertyName = "rpb";
            this.rpbDataGridViewTextBoxColumn.HeaderText = "rpb";
            this.rpbDataGridViewTextBoxColumn.Name = "rpbDataGridViewTextBoxColumn";
            // 
            // wpbDataGridViewTextBoxColumn
            // 
            this.wpbDataGridViewTextBoxColumn.DataPropertyName = "wpb";
            this.wpbDataGridViewTextBoxColumn.HeaderText = "wpb";
            this.wpbDataGridViewTextBoxColumn.Name = "wpbDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            // 
            // addamountDataGridViewTextBoxColumn
            // 
            this.addamountDataGridViewTextBoxColumn.DataPropertyName = "add_amount";
            this.addamountDataGridViewTextBoxColumn.HeaderText = "add_amount";
            this.addamountDataGridViewTextBoxColumn.Name = "addamountDataGridViewTextBoxColumn";
            // 
            // lessamountDataGridViewTextBoxColumn
            // 
            this.lessamountDataGridViewTextBoxColumn.DataPropertyName = "less_amount";
            this.lessamountDataGridViewTextBoxColumn.HeaderText = "less_amount";
            this.lessamountDataGridViewTextBoxColumn.Name = "lessamountDataGridViewTextBoxColumn";
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            // 
            // balanceamountDataGridViewTextBoxColumn
            // 
            this.balanceamountDataGridViewTextBoxColumn.DataPropertyName = "balance_amount";
            this.balanceamountDataGridViewTextBoxColumn.HeaderText = "balance_amount";
            this.balanceamountDataGridViewTextBoxColumn.Name = "balanceamountDataGridViewTextBoxColumn";
            // 
            // purchaserepBindingSource1
            // 
            this.purchaserepBindingSource1.DataSource = typeof(grandee_project.Purchaserep);
            // 
            // purchaserepBindingSource
            // 
            this.purchaserepBindingSource.DataSource = typeof(grandee_project.Purchaserep);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 591);
            this.Controls.Add(this.materialSingleLineTextField11);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialSingleLineTextField10);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.MaximumSize = new System.Drawing.Size(773, 591);
            this.MinimumSize = new System.Drawing.Size(773, 591);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaserepBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaserepBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField9;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField8;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpurcahseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiclenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaserepBindingSource;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource purchaserepBindingSource1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField11;
    }
}