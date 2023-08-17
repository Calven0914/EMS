namespace RoomBookingSystem
{
    partial class Form2
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
            System.Windows.Forms.Label employeenameLabel;
            System.Windows.Forms.Label employeeemailLabel;
            System.Windows.Forms.Label employeeaddressLabel;
            System.Windows.Forms.Label employeedepartmentLabel;
            System.Windows.Forms.Label employeedobLabel;
            System.Windows.Forms.Label employeephoneLabel;
            System.Windows.Forms.Label employeegenderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bookingDatabaseDataSet = new RoomBookingSystem.BookingDatabaseDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new RoomBookingSystem.BookingDatabaseDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new RoomBookingSystem.BookingDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeenameTextBox = new System.Windows.Forms.TextBox();
            this.employeeemailTextBox = new System.Windows.Forms.TextBox();
            this.employeeaddressTextBox = new System.Windows.Forms.TextBox();
            this.employeedobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeephoneTextBox = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            employeenameLabel = new System.Windows.Forms.Label();
            employeeemailLabel = new System.Windows.Forms.Label();
            employeeaddressLabel = new System.Windows.Forms.Label();
            employeedepartmentLabel = new System.Windows.Forms.Label();
            employeedobLabel = new System.Windows.Forms.Label();
            employeephoneLabel = new System.Windows.Forms.Label();
            employeegenderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeenameLabel
            // 
            employeenameLabel.AutoSize = true;
            employeenameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeenameLabel.Location = new System.Drawing.Point(64, 187);
            employeenameLabel.Name = "employeenameLabel";
            employeenameLabel.Size = new System.Drawing.Size(178, 27);
            employeenameLabel.TabIndex = 4;
            employeenameLabel.Text = "Employee Name:";
            // 
            // employeeemailLabel
            // 
            employeeemailLabel.AutoSize = true;
            employeeemailLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeemailLabel.Location = new System.Drawing.Point(64, 239);
            employeeemailLabel.Name = "employeeemailLabel";
            employeeemailLabel.Size = new System.Drawing.Size(177, 27);
            employeeemailLabel.TabIndex = 6;
            employeeemailLabel.Text = "Employee Email:";
            // 
            // employeeaddressLabel
            // 
            employeeaddressLabel.AutoSize = true;
            employeeaddressLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeaddressLabel.Location = new System.Drawing.Point(64, 288);
            employeeaddressLabel.Name = "employeeaddressLabel";
            employeeaddressLabel.Size = new System.Drawing.Size(198, 27);
            employeeaddressLabel.TabIndex = 8;
            employeeaddressLabel.Text = "Employee Address:";
            // 
            // employeedepartmentLabel
            // 
            employeedepartmentLabel.AutoSize = true;
            employeedepartmentLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeedepartmentLabel.Location = new System.Drawing.Point(539, 239);
            employeedepartmentLabel.Name = "employeedepartmentLabel";
            employeedepartmentLabel.Size = new System.Drawing.Size(235, 27);
            employeedepartmentLabel.TabIndex = 10;
            employeedepartmentLabel.Text = "Employee Department:";
            // 
            // employeedobLabel
            // 
            employeedobLabel.AutoSize = true;
            employeedobLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeedobLabel.Location = new System.Drawing.Point(539, 187);
            employeedobLabel.Name = "employeedobLabel";
            employeedobLabel.Size = new System.Drawing.Size(248, 27);
            employeedobLabel.TabIndex = 12;
            employeedobLabel.Text = "Employee Date of Birth:";
            // 
            // employeephoneLabel
            // 
            employeephoneLabel.AutoSize = true;
            employeephoneLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeephoneLabel.Location = new System.Drawing.Point(64, 341);
            employeephoneLabel.Name = "employeephoneLabel";
            employeephoneLabel.Size = new System.Drawing.Size(182, 27);
            employeephoneLabel.TabIndex = 14;
            employeephoneLabel.Text = "Employee Phone:";
            // 
            // employeegenderLabel
            // 
            employeegenderLabel.AutoSize = true;
            employeegenderLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeegenderLabel.Location = new System.Drawing.Point(539, 288);
            employeegenderLabel.Name = "employeegenderLabel";
            employeegenderLabel.Size = new System.Drawing.Size(192, 27);
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
            // employeenameTextBox
            // 
            this.employeenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeename", true));
            this.employeenameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeenameTextBox.Location = new System.Drawing.Point(268, 189);
            this.employeenameTextBox.Name = "employeenameTextBox";
            this.employeenameTextBox.Size = new System.Drawing.Size(249, 29);
            this.employeenameTextBox.TabIndex = 5;
            // 
            // employeeemailTextBox
            // 
            this.employeeemailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeeemail", true));
            this.employeeemailTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeemailTextBox.Location = new System.Drawing.Point(268, 241);
            this.employeeemailTextBox.Name = "employeeemailTextBox";
            this.employeeemailTextBox.Size = new System.Drawing.Size(249, 29);
            this.employeeemailTextBox.TabIndex = 7;
            this.employeeemailTextBox.TextChanged += new System.EventHandler(this.employeeemailTextBox_TextChanged);
            // 
            // employeeaddressTextBox
            // 
            this.employeeaddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeeaddress", true));
            this.employeeaddressTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeaddressTextBox.Location = new System.Drawing.Point(268, 290);
            this.employeeaddressTextBox.Name = "employeeaddressTextBox";
            this.employeeaddressTextBox.Size = new System.Drawing.Size(249, 29);
            this.employeeaddressTextBox.TabIndex = 9;
            // 
            // employeedobDateTimePicker
            // 
            this.employeedobDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeedobDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeedobDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.employeedobDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.employeedobDateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeedobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "employeedob", true));
            this.employeedobDateTimePicker.Location = new System.Drawing.Point(793, 194);
            this.employeedobDateTimePicker.Name = "employeedobDateTimePicker";
            this.employeedobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.employeedobDateTimePicker.TabIndex = 13;
            this.employeedobDateTimePicker.ValueChanged += new System.EventHandler(this.employeedobDateTimePicker_ValueChanged);
            // 
            // employeephoneTextBox
            // 
            this.employeephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeephone", true));
            this.employeephoneTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeephoneTextBox.Location = new System.Drawing.Point(268, 339);
            this.employeephoneTextBox.Name = "employeephoneTextBox";
            this.employeephoneTextBox.Size = new System.Drawing.Size(249, 29);
            this.employeephoneTextBox.TabIndex = 15;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btninsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(846, 339);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(147, 51);
            this.btninsert.TabIndex = 18;
            this.btninsert.Text = "Insert Data";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Gray;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(793, 292);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 27);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(897, 292);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 27);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IT Department",
            "HR Department",
            "Account Department",
            "Marketing Department",
            "Sales Department"});
            this.comboBox1.Location = new System.Drawing.Point(793, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 29);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(918, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 42);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnclose2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 113);
            this.panel1.TabIndex = 25;
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
            this.btnclose2.Location = new System.Drawing.Point(1108, -2);
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
            this.label1.Size = new System.Drawing.Size(412, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert New Employee Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-4, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 38);
            this.panel2.TabIndex = 26;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1142, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(employeegenderLabel);
            this.Controls.Add(employeephoneLabel);
            this.Controls.Add(this.employeephoneTextBox);
            this.Controls.Add(employeedobLabel);
            this.Controls.Add(this.employeedobDateTimePicker);
            this.Controls.Add(employeedepartmentLabel);
            this.Controls.Add(employeeaddressLabel);
            this.Controls.Add(this.employeeaddressTextBox);
            this.Controls.Add(employeeemailLabel);
            this.Controls.Add(this.employeeemailTextBox);
            this.Controls.Add(employeenameLabel);
            this.Controls.Add(this.employeenameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox employeenameTextBox;
        private System.Windows.Forms.TextBox employeeemailTextBox;
        private System.Windows.Forms.TextBox employeeaddressTextBox;
        private System.Windows.Forms.DateTimePicker employeedobDateTimePicker;
        private System.Windows.Forms.TextBox employeephoneTextBox;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}