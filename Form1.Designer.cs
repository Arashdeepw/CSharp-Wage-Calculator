namespace Assignment1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHourWorked = new System.Windows.Forms.TextBox();
            this.txtHourWage = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblHourWorked = new System.Windows.Forms.Label();
            this.lblHourWage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNetEarn = new System.Windows.Forms.TextBox();
            this.txtLessFWT = new System.Windows.Forms.TextBox();
            this.txtGrossEarn = new System.Windows.Forms.TextBox();
            this.lblNetEarn = new System.Windows.Forms.Label();
            this.lblLessFWT = new System.Windows.Forms.Label();
            this.lblGrossEarn = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtHourWorked);
            this.groupBox1.Controls.Add(this.txtHourWage);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.lblHourWorked);
            this.groupBox1.Controls.Add(this.lblHourWage);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please input the employee information:";
            // 
            // txtHourWorked
            // 
            this.txtHourWorked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHourWorked.Location = new System.Drawing.Point(106, 74);
            this.txtHourWorked.Name = "txtHourWorked";
            this.txtHourWorked.Size = new System.Drawing.Size(194, 20);
            this.txtHourWorked.TabIndex = 5;
            // 
            // txtHourWage
            // 
            this.txtHourWage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHourWage.Location = new System.Drawing.Point(106, 47);
            this.txtHourWage.Name = "txtHourWage";
            this.txtHourWage.Size = new System.Drawing.Size(194, 20);
            this.txtHourWage.TabIndex = 4;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpName.Location = new System.Drawing.Point(106, 20);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(194, 20);
            this.txtEmpName.TabIndex = 3;
            // 
            // lblHourWorked
            // 
            this.lblHourWorked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHourWorked.AutoSize = true;
            this.lblHourWorked.Location = new System.Drawing.Point(7, 76);
            this.lblHourWorked.Name = "lblHourWorked";
            this.lblHourWorked.Size = new System.Drawing.Size(79, 13);
            this.lblHourWorked.TabIndex = 2;
            this.lblHourWorked.Text = "Hours Worked:";
            // 
            // lblHourWage
            // 
            this.lblHourWage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHourWage.AutoSize = true;
            this.lblHourWage.Location = new System.Drawing.Point(7, 47);
            this.lblHourWage.Name = "lblHourWage";
            this.lblHourWage.Size = new System.Drawing.Size(72, 13);
            this.lblHourWage.TabIndex = 1;
            this.lblHourWage.Text = "Hourly Wage:";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(38, 149);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(79, 31);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(248, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtNetEarn);
            this.groupBox2.Controls.Add(this.txtLessFWT);
            this.groupBox2.Controls.Add(this.txtGrossEarn);
            this.groupBox2.Controls.Add(this.lblNetEarn);
            this.groupBox2.Controls.Add(this.lblLessFWT);
            this.groupBox2.Controls.Add(this.lblGrossEarn);
            this.groupBox2.Location = new System.Drawing.Point(28, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculated Wage";
            // 
            // txtNetEarn
            // 
            this.txtNetEarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetEarn.Location = new System.Drawing.Point(106, 93);
            this.txtNetEarn.Name = "txtNetEarn";
            this.txtNetEarn.Size = new System.Drawing.Size(193, 20);
            this.txtNetEarn.TabIndex = 5;
            // 
            // txtLessFWT
            // 
            this.txtLessFWT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLessFWT.Location = new System.Drawing.Point(105, 58);
            this.txtLessFWT.Name = "txtLessFWT";
            this.txtLessFWT.Size = new System.Drawing.Size(194, 20);
            this.txtLessFWT.TabIndex = 4;
            // 
            // txtGrossEarn
            // 
            this.txtGrossEarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrossEarn.Location = new System.Drawing.Point(105, 29);
            this.txtGrossEarn.Name = "txtGrossEarn";
            this.txtGrossEarn.Size = new System.Drawing.Size(194, 20);
            this.txtGrossEarn.TabIndex = 3;
            // 
            // lblNetEarn
            // 
            this.lblNetEarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetEarn.AutoSize = true;
            this.lblNetEarn.Location = new System.Drawing.Point(8, 96);
            this.lblNetEarn.Name = "lblNetEarn";
            this.lblNetEarn.Size = new System.Drawing.Size(71, 13);
            this.lblNetEarn.TabIndex = 2;
            this.lblNetEarn.Text = "Net Earnings:";
            // 
            // lblLessFWT
            // 
            this.lblLessFWT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLessFWT.AutoSize = true;
            this.lblLessFWT.Location = new System.Drawing.Point(10, 61);
            this.lblLessFWT.Name = "lblLessFWT";
            this.lblLessFWT.Size = new System.Drawing.Size(59, 13);
            this.lblLessFWT.TabIndex = 1;
            this.lblLessFWT.Text = "Less FWT:";
            // 
            // lblGrossEarn
            // 
            this.lblGrossEarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrossEarn.AutoSize = true;
            this.lblGrossEarn.Location = new System.Drawing.Point(10, 29);
            this.lblGrossEarn.Name = "lblGrossEarn";
            this.lblGrossEarn.Size = new System.Drawing.Size(81, 13);
            this.lblGrossEarn.TabIndex = 0;
            this.lblGrossEarn.Text = "Gross Earnings:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(41, 366);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(61, 13);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Employees:";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(133, 363);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(194, 21);
            this.cmbEmployees.TabIndex = 5;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(248, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(28, 406);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(376, 458);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(450, 550);
            this.MinimumSize = new System.Drawing.Size(390, 490);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wage Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHourWorked;
        private System.Windows.Forms.TextBox txtHourWage;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblHourWorked;
        private System.Windows.Forms.Label lblHourWage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNetEarn;
        private System.Windows.Forms.TextBox txtLessFWT;
        private System.Windows.Forms.TextBox txtGrossEarn;
        private System.Windows.Forms.Label lblNetEarn;
        private System.Windows.Forms.Label lblLessFWT;
        private System.Windows.Forms.Label lblGrossEarn;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblError;
    }
}

