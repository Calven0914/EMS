namespace RoomBookingSystem
{
    partial class Form3
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
            System.Windows.Forms.Label employeeidLabel;
            System.Windows.Forms.Label employeenameLabel;
            System.Windows.Forms.Label employeeemailLabel;
            System.Windows.Forms.Label employeeaddressLabel;
            System.Windows.Forms.Label employeedepartmentLabel;
            System.Windows.Forms.Label employeedobLabel;
            System.Windows.Forms.Label employeephoneLabel;
            System.Windows.Forms.Label employeegenderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bookingDatabaseDataSet = new RoomBookingSystem.BookingDatabaseDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new RoomBookingSystem.BookingDatabaseDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new RoomBookingSystem.BookingDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidTextBox = new System.Windows.Forms.TextBox();
            this.employeenameTextBox = new System.Windows.Forms.TextBox();
            this.employeeemailTextBox = new System.Windows.Forms.TextBox();
            this.employeeaddressTextBox = new System.Windows.Forms.TextBox();
            this.employeedobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeephoneTextBox = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.employeegenderTextBox = new System.Windows.Forms.TextBox();
            this.employeedepartmentTextBox = new System.Windows.Forms.TextBox();
            employeeidLabel = new System.Windows.Forms.Label();
            employeenameLabel = new System.Windows.Forms.Label();
            employeeemailLabel = new System.Windows.Forms.Label();
            employeeaddressLabel = new System.Windows.Forms.Label();
            employeedepartmentLabel = new System.Windows.Forms.Label();
            employeedobLabel = new System.Windows.Forms.Label();
            employeephoneLabel = new System.Windows.Forms.Label();
            employeegenderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeidLabel
            // 
            employeeidLabel.AutoSize = true;
            employeeidLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeidLabel.Location = new System.Drawing.Point(39, 420);
            employeeidLabel.Name = "employeeidLabel";
            employeeidLabel.Size = new System.Drawing.Size(112, 21);
            employeeidLabel.TabIndex = 2;
            employeeidLabel.Text = "Employee ID:";
            // 
            // employeenameLabel
            // 
            employeenameLabel.AutoSize = true;
            employeenameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeenameLabel.Location = new System.Drawing.Point(39, 470);
            employeenameLabel.Name = "employeenameLabel";
            employeenameLabel.Size = new System.Drawing.Size(136, 21);
            employeenameLabel.TabIndex = 4;
            employeenameLabel.Text = "Employee Name:";
            // 
            // employeeemailLabel
            // 
            employeeemailLabel.AutoSize = true;
            employeeemailLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeemailLabel.Location = new System.Drawing.Point(39, 561);
            employeeemailLabel.Name = "employeeemailLabel";
            employeeemailLabel.Size = new System.Drawing.Size(134, 21);
            employeeemailLabel.TabIndex = 6;
            employeeemailLabel.Text = "Employee Email:";
            // 
            // employeeaddressLabel
            // 
            employeeaddressLabel.AutoSize = true;
            employeeaddressLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeaddressLabel.Location = new System.Drawing.Point(39, 515);
            employeeaddressLabel.Name = "employeeaddressLabel";
            employeeaddressLabel.Size = new System.Drawing.Size(155, 21);
            employeeaddressLabel.TabIndex = 8;
            employeeaddressLabel.Text = "Employee Address:";
            // 
            // employeedepartmentLabel
            // 
            employeedepartmentLabel.AutoSize = true;
            employeedepartmentLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeedepartmentLabel.Location = new System.Drawing.Point(502, 420);
            employeedepartmentLabel.Name = "employeedepartmentLabel";
            employeedepartmentLabel.Size = new System.Drawing.Size(179, 21);
            employeedepartmentLabel.TabIndex = 10;
            employeedepartmentLabel.Text = "Employee Department:";
            // 
            // employeedobLabel
            // 
            employeedobLabel.AutoSize = true;
            employeedobLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeedobLabel.Location = new System.Drawing.Point(502, 470);
            employeedobLabel.Name = "employeedobLabel";
            employeedobLabel.Size = new System.Drawing.Size(189, 21);
            employeedobLabel.TabIndex = 12;
            employeedobLabel.Text = "Employee Date of Birth:";
            // 
            // employeephoneLabel
            // 
            employeephoneLabel.AutoSize = true;
            employeephoneLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeephoneLabel.Location = new System.Drawing.Point(502, 515);
            employeephoneLabel.Name = "employeephoneLabel";
            employeephoneLabel.Size = new System.Drawing.Size(140, 21);
            employeephoneLabel.TabIndex = 14;
            employeephoneLabel.Text = "Employee Phone:";
            // 
            // employeegenderLabel
            // 
            employeegenderLabel.AutoSize = true;
            employeegenderLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeegenderLabel.Location = new System.Drawing.Point(502, 561);
            employeegenderLabel.Name = "employeegenderLabel";
            employeegenderLabel.Size = new System.Drawing.Size(148, 21);
            employeegenderLabel.TabIndex = 16;
            employeegenderLabel.Text = "Employee Gender:";
            // 
            // bookingDatabaseDataSet
            // 
            this.bookingDatabaseDataSet.DataSetName = "BookingDatabaseDataSet";
            this.bookingDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bookingDatabaseDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = RoomBookingSystem.BookingDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.AllowUserToResizeColumns = false;
            this.employeeDataGridView.AllowUserToResizeRows = false;
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeDataGridView.Location = new System.Drawing.Point(12, 111);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(892, 269);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "employeeid";
            this.dataGridViewTextBoxColumn1.HeaderText = "employeeid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "employeename";
            this.dataGridViewTextBoxColumn2.HeaderText = "employeename";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 103;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "employeeemail";
            this.dataGridViewTextBoxColumn3.HeaderText = "employeeemail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "employeeaddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "employeeaddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 114;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "employeedepartment";
            this.dataGridViewTextBoxColumn5.HeaderText = "employeedepartment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "employeedob";
            this.dataGridViewTextBoxColumn6.HeaderText = "employeedob";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "employeephone";
            this.dataGridViewTextBoxColumn7.HeaderText = "employeephone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 107;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "employeegender";
            this.dataGridViewTextBoxColumn8.HeaderText = "employeegender";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // employeeidTextBox
            // 
            this.employeeidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeeid", true));
            this.employeeidTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeidTextBox.Location = new System.Drawing.Point(200, 417);
            this.employeeidTextBox.Name = "employeeidTextBox";
            this.employeeidTextBox.ReadOnly = true;
            this.employeeidTextBox.Size = new System.Drawing.Size(134, 29);
            this.employeeidTextBox.TabIndex = 3;
            // 
            // employeenameTextBox
            // 
            this.employeenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeename", true));
            this.employeenameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeenameTextBox.Location = new System.Drawing.Point(200, 462);
            this.employeenameTextBox.Name = "employeenameTextBox";
            this.employeenameTextBox.Size = new System.Drawing.Size(267, 29);
            this.employeenameTextBox.TabIndex = 5;
            // 
            // employeeemailTextBox
            // 
            this.employeeemailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeeemail", true));
            this.employeeemailTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeemailTextBox.Location = new System.Drawing.Point(200, 558);
            this.employeeemailTextBox.Name = "employeeemailTextBox";
            this.employeeemailTextBox.Size = new System.Drawing.Size(267, 29);
            this.employeeemailTextBox.TabIndex = 7;
            // 
            // employeeaddressTextBox
            // 
            this.employeeaddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeeaddress", true));
            this.employeeaddressTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeaddressTextBox.Location = new System.Drawing.Point(200, 510);
            this.employeeaddressTextBox.Name = "employeeaddressTextBox";
            this.employeeaddressTextBox.Size = new System.Drawing.Size(267, 29);
            this.employeeaddressTextBox.TabIndex = 9;
            // 
            // employeedobDateTimePicker
            // 
            this.employeedobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "employeedob", true));
            this.employeedobDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeedobDateTimePicker.Location = new System.Drawing.Point(698, 462);
            this.employeedobDateTimePicker.Name = "employeedobDateTimePicker";
            this.employeedobDateTimePicker.Size = new System.Drawing.Size(206, 29);
            this.employeedobDateTimePicker.TabIndex = 13;
            this.employeedobDateTimePicker.Value = new System.DateTime(2023, 4, 9, 0, 0, 0, 0);
            // 
            // employeephoneTextBox
            // 
            this.employeephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeephone", true));
            this.employeephoneTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeephoneTextBox.Location = new System.Drawing.Point(698, 507);
            this.employeephoneTextBox.Name = "employeephoneTextBox";
            this.employeephoneTextBox.Size = new System.Drawing.Size(206, 29);
            this.employeephoneTextBox.TabIndex = 15;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(981, 459);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 43);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(981, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnclose2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 105);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnclose2
            // 
            this.btnclose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclose2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose2.FlatAppearance.BorderSize = 0;
            this.btnclose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose2.ForeColor = System.Drawing.Color.Black;
            this.btnclose2.Location = new System.Drawing.Point(1108, 0);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(41, 42);
            this.btnclose2.TabIndex = 1;
            this.btnclose2.Text = "X";
            this.btnclose2.UseVisualStyleBackColor = true;
            this.btnclose2.Click += new System.EventHandler(this.btnclose2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Employee Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 38);
            this.panel2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(916, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "©2023 Calven | All Rights Reserved";
            // 
            // employeegenderTextBox
            // 
            this.employeegenderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeegender", true));
            this.employeegenderTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeegenderTextBox.Location = new System.Drawing.Point(698, 553);
            this.employeegenderTextBox.Name = "employeegenderTextBox";
            this.employeegenderTextBox.Size = new System.Drawing.Size(206, 29);
            this.employeegenderTextBox.TabIndex = 17;
            // 
            // employeedepartmentTextBox
            // 
            this.employeedepartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeedepartment", true));
            this.employeedepartmentTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeedepartmentTextBox.Location = new System.Drawing.Point(698, 412);
            this.employeedepartmentTextBox.Name = "employeedepartmentTextBox";
            this.employeedepartmentTextBox.Size = new System.Drawing.Size(206, 29);
            this.employeedepartmentTextBox.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1150, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(employeegenderLabel);
            this.Controls.Add(this.employeegenderTextBox);
            this.Controls.Add(employeephoneLabel);
            this.Controls.Add(this.employeephoneTextBox);
            this.Controls.Add(employeedobLabel);
            this.Controls.Add(this.employeedobDateTimePicker);
            this.Controls.Add(employeedepartmentLabel);
            this.Controls.Add(this.employeedepartmentTextBox);
            this.Controls.Add(employeeaddressLabel);
            this.Controls.Add(this.employeeaddressTextBox);
            this.Controls.Add(employeeemailLabel);
            this.Controls.Add(this.employeeemailTextBox);
            this.Controls.Add(employeenameLabel);
            this.Controls.Add(this.employeenameTextBox);
            this.Controls.Add(employeeidLabel);
            this.Controls.Add(this.employeeidTextBox);
            this.Controls.Add(this.employeeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookingDatabaseDataSet bookingDatabaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BookingDatabaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private BookingDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox employeeidTextBox;
        private System.Windows.Forms.TextBox employeenameTextBox;
        private System.Windows.Forms.TextBox employeeemailTextBox;
        private System.Windows.Forms.TextBox employeeaddressTextBox;
        private System.Windows.Forms.DateTimePicker employeedobDateTimePicker;
        private System.Windows.Forms.TextBox employeephoneTextBox;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox employeegenderTextBox;
        private System.Windows.Forms.TextBox employeedepartmentTextBox;
    }
}