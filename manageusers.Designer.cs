namespace grandee_project
{
    partial class manageusers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.idcusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcusDataGridViewTextBoxColumn,
            this.cusnameDataGridViewTextBoxColumn,
            this.cusphoneDataGridViewTextBoxColumn,
            this.cusaccountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addcustomerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Search Cutomer ID";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(12, 82);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(581, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(498, 171);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(73, 36);
            this.materialRaisedButton2.TabIndex = 5;
            this.materialRaisedButton2.Text = "Update";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(599, 111);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(69, 36);
            this.materialRaisedButton3.TabIndex = 6;
            this.materialRaisedButton3.Text = "Delete";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Customer Name";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(21, 179);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(134, 23);
            this.materialSingleLineTextField3.TabIndex = 10;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "Customer Phone";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(161, 179);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(134, 23);
            this.materialSingleLineTextField4.TabIndex = 11;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "Customer Account";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(301, 179);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(126, 23);
            this.materialSingleLineTextField5.TabIndex = 12;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.AutoSize = true;
            this.materialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Icon = null;
            this.materialRaisedButton7.Location = new System.Drawing.Point(599, 69);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(73, 36);
            this.materialRaisedButton7.TabIndex = 16;
            this.materialRaisedButton7.Text = "Search";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(599, 171);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton1.TabIndex = 17;
            this.materialRaisedButton1.Text = "REFRESH";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // idcusDataGridViewTextBoxColumn
            // 
            this.idcusDataGridViewTextBoxColumn.DataPropertyName = "id_cus";
            this.idcusDataGridViewTextBoxColumn.HeaderText = "id_cus";
            this.idcusDataGridViewTextBoxColumn.Name = "idcusDataGridViewTextBoxColumn";
            // 
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            // 
            // cusphoneDataGridViewTextBoxColumn
            // 
            this.cusphoneDataGridViewTextBoxColumn.DataPropertyName = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.HeaderText = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.Name = "cusphoneDataGridViewTextBoxColumn";
            // 
            // cusaccountDataGridViewTextBoxColumn
            // 
            this.cusaccountDataGridViewTextBoxColumn.DataPropertyName = "cus_account";
            this.cusaccountDataGridViewTextBoxColumn.HeaderText = "cus_account";
            this.cusaccountDataGridViewTextBoxColumn.Name = "cusaccountDataGridViewTextBoxColumn";
            // 
            // addcustomerBindingSource
            // 
            this.addcustomerBindingSource.DataSource = typeof(grandee_project.addcustomer);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Delete Customer ID";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(12, 124);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(581, 23);
            this.materialSingleLineTextField2.TabIndex = 18;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // manageusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 508);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialRaisedButton7);
            this.Controls.Add(this.materialSingleLineTextField5);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(680, 508);
            this.MinimumSize = new System.Drawing.Size(680, 508);
            this.Name = "manageusers";
            this.Text = "manageusers";
            this.Load += new System.EventHandler(this.manageusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addcustomerBindingSource;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
    }
}