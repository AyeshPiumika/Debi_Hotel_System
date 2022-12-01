namespace HotelManagementSystemProject
{
    partial class ManageHotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageHotels));
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tblRegister1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_Cardiff_Test1DataSet5 = new HotelManagementSystemProject.db_Cardiff_Test1DataSet5();
            this.tbl_Register1TableAdapter = new HotelManagementSystemProject.db_Cardiff_Test1DataSet5TableAdapters.tbl_Register1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_Cardiff_Test1DataSet9 = new HotelManagementSystemProject.db_Cardiff_Test1DataSet9();
            this.tblRegister2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Register2TableAdapter = new HotelManagementSystemProject.db_Cardiff_Test1DataSet9TableAdapters.tbl_Register2TableAdapter();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Cardiff_Test1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Cardiff_Test1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Input Hotel Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 338);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(283, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Input Hotel Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input Hotel Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input Hotel Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(135, 286);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(283, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 236);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(283, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 185);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(283, 20);
            this.txtName.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(134, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFind.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(342, 380);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(135, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(342, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(515, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Welcome Admin. You can manage hotels\'s registration now";
            // 
            // tblRegister1BindingSource
            // 
            this.tblRegister1BindingSource.DataMember = "tbl_Register1";
            this.tblRegister1BindingSource.DataSource = this.db_Cardiff_Test1DataSet5;
            // 
            // db_Cardiff_Test1DataSet5
            // 
            this.db_Cardiff_Test1DataSet5.DataSetName = "db_Cardiff_Test1DataSet5";
            this.db_Cardiff_Test1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Register1TableAdapter
            // 
            this.tbl_Register1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1164, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "GO To HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Input Hotel ID";
            // 
            // txtHotelID
            // 
            this.txtHotelID.Location = new System.Drawing.Point(135, 135);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(283, 20);
            this.txtHotelID.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelIDDataGridViewTextBoxColumn,
            this.hotelNameDataGridViewTextBoxColumn,
            this.hotelAddressDataGridViewTextBoxColumn,
            this.hotelUsernameDataGridViewTextBoxColumn,
            this.hotelPasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblRegister2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(573, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 329);
            this.dataGridView1.TabIndex = 26;
            // 
            // db_Cardiff_Test1DataSet9
            // 
            this.db_Cardiff_Test1DataSet9.DataSetName = "db_Cardiff_Test1DataSet9";
            this.db_Cardiff_Test1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRegister2BindingSource
            // 
            this.tblRegister2BindingSource.DataMember = "tbl_Register2";
            this.tblRegister2BindingSource.DataSource = this.db_Cardiff_Test1DataSet9;
            // 
            // tbl_Register2TableAdapter
            // 
            this.tbl_Register2TableAdapter.ClearBeforeFill = true;
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_ID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "Hotel_ID";
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelNameDataGridViewTextBoxColumn
            // 
            this.hotelNameDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Name";
            this.hotelNameDataGridViewTextBoxColumn.HeaderText = "Hotel_Name";
            this.hotelNameDataGridViewTextBoxColumn.Name = "hotelNameDataGridViewTextBoxColumn";
            // 
            // hotelAddressDataGridViewTextBoxColumn
            // 
            this.hotelAddressDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Address";
            this.hotelAddressDataGridViewTextBoxColumn.HeaderText = "Hotel_Address";
            this.hotelAddressDataGridViewTextBoxColumn.Name = "hotelAddressDataGridViewTextBoxColumn";
            // 
            // hotelUsernameDataGridViewTextBoxColumn
            // 
            this.hotelUsernameDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Username";
            this.hotelUsernameDataGridViewTextBoxColumn.HeaderText = "Hotel_Username";
            this.hotelUsernameDataGridViewTextBoxColumn.Name = "hotelUsernameDataGridViewTextBoxColumn";
            // 
            // hotelPasswordDataGridViewTextBoxColumn
            // 
            this.hotelPasswordDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Password";
            this.hotelPasswordDataGridViewTextBoxColumn.HeaderText = "Hotel_Password";
            this.hotelPasswordDataGridViewTextBoxColumn.Name = "hotelPasswordDataGridViewTextBoxColumn";
            // 
            // ManageHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHotelID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "ManageHotels";
            this.Text = "Manage Hotels";
            this.Load += new System.EventHandler(this.ManageHotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Cardiff_Test1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Cardiff_Test1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private db_Cardiff_Test1DataSet5 db_Cardiff_Test1DataSet5;
        private System.Windows.Forms.BindingSource tblRegister1BindingSource;
        private db_Cardiff_Test1DataSet5TableAdapters.tbl_Register1TableAdapter tbl_Register1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_Cardiff_Test1DataSet9 db_Cardiff_Test1DataSet9;
        private System.Windows.Forms.BindingSource tblRegister2BindingSource;
        private db_Cardiff_Test1DataSet9TableAdapters.tbl_Register2TableAdapter tbl_Register2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelPasswordDataGridViewTextBoxColumn;
    }
}