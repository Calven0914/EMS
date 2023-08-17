namespace RoomBookingSystem
{
    partial class Form4
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
            System.Windows.Forms.Label employeedepartmentLabel;
            System.Windows.Forms.Label employeephoneLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeidTextBox = new System.Windows.Forms.TextBox();
            this.employeenameTextBox = new System.Windows.Forms.TextBox();
            this.employeedepartmentTextBox = new System.Windows.Forms.TextBox();
            this.employeephoneTextBox = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            employeeidLabel = new System.Windows.Forms.Label();
            employeenameLabel = new System.Windows.Forms.Label();
            employeedepartmentLabel = new System.Windows.Forms.Label();
            employeephoneLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
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
            employeeidLabel.Location = new System.Drawing.Point(12, 405);
            employeeidLabel.Name = "employeeidLabel";
            employeeidLabel.Size = new System.Drawing.Size(112, 21);
            employeeidLabel.TabIndex = 27;
            employeeidLabel.Text = "Employee ID:";
            // 
            // employeenameLabel
            // 
            employeenameLabel.AutoSize = true;
            employeenameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeenameLabel.Location = new System.Drawing.Point(12, 445);
            employeenameLabel.Name = "employeenameLabel";
            employeenameLabel.Size = new System.Drawing.Size(136, 21);
            employeenameLabel.TabIndex = 28;
            employeenameLabel.Text = "Employee Name:";
            // 
            // employeedepartmentLabel
            // 
            employeedepartmentLabel.AutoSize = true;
            employeedepartmentLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeedepartmentLabel.Location = new System.Drawing.Point(12, 486);
            employeedepartmentLabel.Name = "employeedepartmentLabel";
            employeedepartmentLabel.Size = new System.Drawing.Size(179, 21);
            employeedepartmentLabel.TabIndex = 29;
            employeedepartmentLabel.Text = "Employee Department:";
            // 
            // employeephoneLabel
            // 
            employeephoneLabel.AutoSize = true;
            employeephoneLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeephoneLabel.Location = new System.Drawing.Point(365, 405);
            employeephoneLabel.Name = "employeephoneLabel";
            employeephoneLabel.Size = new System.Drawing.Size(140, 21);
            employeephoneLabel.TabIndex = 30;
            employeephoneLabel.Text = "Employee Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(365, 445);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 21);
            label2.TabIndex = 35;
            label2.Text = "Salary per Hour:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(365, 486);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 21);
            label3.TabIndex = 36;
            label3.Text = "Work Hour:";
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
            this.employeeDataGridView.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnclose2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 105);
            this.panel1.TabIndex = 27;
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
            this.label1.Size = new System.Drawing.Size(368, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Salary System";
            // 
            // employeeidTextBox
            // 
            this.employeeidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeeid", true));
            this.employeeidTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeidTextBox.Location = new System.Drawing.Point(192, 397);
            this.employeeidTextBox.Name = "employeeidTextBox";
            this.employeeidTextBox.Size = new System.Drawing.Size(167, 29);
            this.employeeidTextBox.TabIndex = 28;
            // 
            // employeenameTextBox
            // 
            this.employeenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeename", true));
            this.employeenameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeenameTextBox.Location = new System.Drawing.Point(192, 437);
            this.employeenameTextBox.Name = "employeenameTextBox";
            this.employeenameTextBox.Size = new System.Drawing.Size(167, 29);
            this.employeenameTextBox.TabIndex = 29;
            // 
            // employeedepartmentTextBox
            // 
            this.employeedepartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeedepartment", true));
            this.employeedepartmentTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeedepartmentTextBox.Location = new System.Drawing.Point(192, 478);
            this.employeedepartmentTextBox.Name = "employeedepartmentTextBox";
            this.employeedepartmentTextBox.Size = new System.Drawing.Size(167, 29);
            this.employeedepartmentTextBox.TabIndex = 30;
            // 
            // employeephoneTextBox
            // 
            this.employeephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employeephone", true));
            this.employeephoneTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeephoneTextBox.Location = new System.Drawing.Point(511, 402);
            this.employeephoneTextBox.Name = "employeephoneTextBox";
            this.employeephoneTextBox.Size = new System.Drawing.Size(163, 29);
            this.employeephoneTextBox.TabIndex = 31;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(800, 394);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(104, 43);
            this.btncalculate.TabIndex = 32;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(800, 454);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(104, 43);
            this.btnprint.TabIndex = 33;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 38);
            this.panel2.TabIndex = 34;
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12",
            "15",
            "18",
            "25"});
            this.comboBox1.Location = new System.Drawing.Point(511, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 29);
            this.comboBox1.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(511, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 29);
            this.textBox1.TabIndex = 38;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(920, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 269);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1150, 589);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(employeephoneLabel);
            this.Controls.Add(this.employeephoneTextBox);
            this.Controls.Add(employeedepartmentLabel);
            this.Controls.Add(this.employeedepartmentTextBox);
            this.Controls.Add(employeenameLabel);
            this.Controls.Add(this.employeenameTextBox);
            this.Controls.Add(employeeidLabel);
            this.Controls.Add(this.employeeidTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employeeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeidTextBox;
        private System.Windows.Forms.TextBox employeenameTextBox;
        private System.Windows.Forms.TextBox employeedepartmentTextBox;
        private System.Windows.Forms.TextBox employeephoneTextBox;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}