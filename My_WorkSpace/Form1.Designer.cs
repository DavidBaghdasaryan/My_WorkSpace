namespace My_WorkSpace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvEmployeeWork = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDekete = new System.Windows.Forms.Button();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.datJoin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbOderTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewDay = new System.Windows.Forms.Button();
            this.btnchange1 = new System.Windows.Forms.Button();
            this.btnchange3 = new System.Windows.Forms.Button();
            this.btnchange2 = new System.Windows.Forms.Button();
            this.dgvEmloyess = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewEmploye = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmployeAll = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chbStart = new System.Windows.Forms.CheckBox();
            this.chbEnd = new System.Windows.Forms.CheckBox();
            this.hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeWork)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmloyess)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeWork
            // 
            this.dgvEmployeeWork.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvEmployeeWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hh});
            this.dgvEmployeeWork.Location = new System.Drawing.Point(273, 68);
            this.dgvEmployeeWork.Name = "dgvEmployeeWork";
            this.dgvEmployeeWork.ReadOnly = true;
            this.dgvEmployeeWork.RowHeadersVisible = false;
            this.dgvEmployeeWork.Size = new System.Drawing.Size(602, 652);
            this.dgvEmployeeWork.TabIndex = 0;
            this.dgvEmployeeWork.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvEmployeeWork_RowPostPaint);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 519);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(30, 563);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Անուն";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ազգանուն";
            // 
            // btnDekete
            // 
            this.btnDekete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDekete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDekete.Location = new System.Drawing.Point(229, 562);
            this.btnDekete.Name = "btnDekete";
            this.btnDekete.Size = new System.Drawing.Size(104, 32);
            this.btnDekete.TabIndex = 5;
            this.btnDekete.Text = "Հեռացնել";
            this.btnDekete.UseVisualStyleBackColor = false;
            this.btnDekete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddWork
            // 
            this.btnAddWork.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWork.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddWork.Location = new System.Drawing.Point(26, 601);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(185, 47);
            this.btnAddWork.TabIndex = 7;
            this.btnAddWork.Text = "Գրանցել";
            this.btnAddWork.UseVisualStyleBackColor = false;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // datJoin
            // 
            this.datJoin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datJoin.Location = new System.Drawing.Point(26, 423);
            this.datJoin.Name = "datJoin";
            this.datJoin.Size = new System.Drawing.Size(88, 20);
            this.datJoin.TabIndex = 8;
            this.datJoin.Value = new System.DateTime(2020, 5, 10, 19, 49, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Աշխատանքի  սկիզբ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 45);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Աշխատակիցներ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(23, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Աշխատանքի ավարտ";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateEnd.Location = new System.Drawing.Point(25, 474);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(89, 20);
            this.dateEnd.TabIndex = 14;
            // 
            // cmbOderTime
            // 
            this.cmbOderTime.FormattingEnabled = true;
            this.cmbOderTime.Location = new System.Drawing.Point(26, 536);
            this.cmbOderTime.Name = "cmbOderTime";
            this.cmbOderTime.Size = new System.Drawing.Size(88, 21);
            this.cmbOderTime.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(23, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Արտաժամ";
            // 
            // btnNewDay
            // 
            this.btnNewDay.BackColor = System.Drawing.Color.Orange;
            this.btnNewDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewDay.Location = new System.Drawing.Point(12, 84);
            this.btnNewDay.Name = "btnNewDay";
            this.btnNewDay.Size = new System.Drawing.Size(138, 47);
            this.btnNewDay.TabIndex = 17;
            this.btnNewDay.Text = "Նոր օր";
            this.btnNewDay.UseVisualStyleBackColor = false;
            // 
            // btnchange1
            // 
            this.btnchange1.BackColor = System.Drawing.Color.Orange;
            this.btnchange1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchange1.Location = new System.Drawing.Point(12, 142);
            this.btnchange1.Name = "btnchange1";
            this.btnchange1.Size = new System.Drawing.Size(138, 34);
            this.btnchange1.TabIndex = 18;
            this.btnchange1.Text = "Հերթափոխ 1";
            this.btnchange1.UseVisualStyleBackColor = false;
            // 
            // btnchange3
            // 
            this.btnchange3.BackColor = System.Drawing.Color.Orange;
            this.btnchange3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchange3.Location = new System.Drawing.Point(12, 221);
            this.btnchange3.Name = "btnchange3";
            this.btnchange3.Size = new System.Drawing.Size(138, 34);
            this.btnchange3.TabIndex = 19;
            this.btnchange3.Text = "Հերթափոխ 3";
            this.btnchange3.UseVisualStyleBackColor = false;
            // 
            // btnchange2
            // 
            this.btnchange2.BackColor = System.Drawing.Color.Orange;
            this.btnchange2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchange2.Location = new System.Drawing.Point(12, 181);
            this.btnchange2.Name = "btnchange2";
            this.btnchange2.Size = new System.Drawing.Size(138, 34);
            this.btnchange2.TabIndex = 20;
            this.btnchange2.Text = "Հերթափոխ 2";
            this.btnchange2.UseVisualStyleBackColor = false;
            // 
            // dgvEmloyess
            // 
            this.dgvEmloyess.AutoGenerateColumns = false;
            this.dgvEmloyess.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvEmloyess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmloyess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.name,
            this.lastName,
            this.idDataGridViewTextBoxColumn1});
            this.dgvEmloyess.DataSource = this.employeesBindingSource;
            this.dgvEmloyess.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmloyess.Location = new System.Drawing.Point(32, 18);
            this.dgvEmloyess.Name = "dgvEmloyess";
            this.dgvEmloyess.ReadOnly = true;
            this.dgvEmloyess.RowHeadersVisible = false;
            this.dgvEmloyess.Size = new System.Drawing.Size(297, 455);
            this.dgvEmloyess.TabIndex = 21;
            this.dgvEmloyess.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmloyess_CellMouseDoubleClick);
            this.dgvEmloyess.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvEmloyess_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "(none)";
            this.dataGridViewTextBoxColumn1.HeaderText = "հ\\հ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Անուն";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "Ազգանուն";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // btnNewEmploye
            // 
            this.btnNewEmploye.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmploye.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewEmploye.Location = new System.Drawing.Point(212, 504);
            this.btnNewEmploye.Name = "btnNewEmploye";
            this.btnNewEmploye.Size = new System.Drawing.Size(124, 47);
            this.btnNewEmploye.TabIndex = 22;
            this.btnNewEmploye.Text = "Գրանցել";
            this.btnNewEmploye.UseVisualStyleBackColor = false;
            this.btnNewEmploye.Click += new System.EventHandler(this.btnNewEmploye_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.dgvEmloyess);
            this.panel2.Controls.Add(this.btnNewEmploye);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDekete);
            this.panel2.Location = new System.Drawing.Point(904, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 610);
            this.panel2.TabIndex = 14;
            // 
            // txtEmployeAll
            // 
            this.txtEmployeAll.Location = new System.Drawing.Point(26, 369);
            this.txtEmployeAll.Name = "txtEmployeAll";
            this.txtEmployeAll.Size = new System.Drawing.Size(227, 20);
            this.txtEmployeAll.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Աշխատակից";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chbStart
            // 
            this.chbStart.BackColor = System.Drawing.Color.Transparent;
            this.chbStart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbStart.Image = ((System.Drawing.Image)(resources.GetObject("chbStart.Image")));
            this.chbStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbStart.Location = new System.Drawing.Point(117, 422);
            this.chbStart.Name = "chbStart";
            this.chbStart.Size = new System.Drawing.Size(38, 29);
            this.chbStart.TabIndex = 23;
            this.chbStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chbStart.UseVisualStyleBackColor = false;
            this.chbStart.CheckedChanged += new System.EventHandler(this.chbStart_CheckedChanged);
            // 
            // chbEnd
            // 
            this.chbEnd.BackColor = System.Drawing.Color.Transparent;
            this.chbEnd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbEnd.Image = ((System.Drawing.Image)(resources.GetObject("chbEnd.Image")));
            this.chbEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbEnd.Location = new System.Drawing.Point(118, 474);
            this.chbEnd.Name = "chbEnd";
            this.chbEnd.Size = new System.Drawing.Size(38, 28);
            this.chbEnd.TabIndex = 24;
            this.chbEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chbEnd.UseVisualStyleBackColor = false;
            this.chbEnd.CheckedChanged += new System.EventHandler(this.chbEnd_CheckedChanged);
            // 
            // hh
            // 
            this.hh.HeaderText = "հ/հ";
            this.hh.Name = "hh";
            this.hh.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(My_WorkSpace.Models.Employees);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1290, 751);
            this.Controls.Add(this.chbEnd);
            this.Controls.Add(this.chbStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeAll);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnchange2);
            this.Controls.Add(this.btnchange3);
            this.Controls.Add(this.btnchange1);
            this.Controls.Add(this.btnNewDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbOderTime);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datJoin);
            this.Controls.Add(this.btnAddWork);
            this.Controls.Add(this.dgvEmployeeWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeWork)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmloyess)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeWork;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDekete;
        private System.Windows.Forms.Button btnAddWork;
        private System.Windows.Forms.DateTimePicker datJoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox cmbOderTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewDay;
        private System.Windows.Forms.Button btnchange1;
        private System.Windows.Forms.Button btnchange3;
        private System.Windows.Forms.Button btnchange2;
        private System.Windows.Forms.DataGridView dgvEmloyess;
        private System.Windows.Forms.Button btnNewEmploye;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtEmployeAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chbStart;
        private System.Windows.Forms.CheckBox chbEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn hh;
    }
}

