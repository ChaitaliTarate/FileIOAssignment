
namespace RegistrationForm
{
    partial class Form6
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
            this.labelEmpId = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpDesignation = new System.Windows.Forms.Label();
            this.labelEmpSalary = new System.Windows.Forms.Label();
            this.labelEmpDepartment = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Location = new System.Drawing.Point(130, 56);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(65, 13);
            this.labelEmpId.TabIndex = 0;
            this.labelEmpId.Text = "Enter EmpId";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(130, 82);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(84, 13);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "Enter EmpName";
            // 
            // labelEmpDesignation
            // 
            this.labelEmpDesignation.AutoSize = true;
            this.labelEmpDesignation.Location = new System.Drawing.Point(130, 107);
            this.labelEmpDesignation.Name = "labelEmpDesignation";
            this.labelEmpDesignation.Size = new System.Drawing.Size(112, 13);
            this.labelEmpDesignation.TabIndex = 2;
            this.labelEmpDesignation.Text = "Enter EmpDesignation";
            // 
            // labelEmpSalary
            // 
            this.labelEmpSalary.AutoSize = true;
            this.labelEmpSalary.Location = new System.Drawing.Point(130, 135);
            this.labelEmpSalary.Name = "labelEmpSalary";
            this.labelEmpSalary.Size = new System.Drawing.Size(85, 13);
            this.labelEmpSalary.TabIndex = 3;
            this.labelEmpSalary.Text = "Enter EmpSalary";
            // 
            // labelEmpDepartment
            // 
            this.labelEmpDepartment.AutoSize = true;
            this.labelEmpDepartment.Location = new System.Drawing.Point(130, 164);
            this.labelEmpDepartment.Name = "labelEmpDepartment";
            this.labelEmpDepartment.Size = new System.Drawing.Size(111, 13);
            this.labelEmpDepartment.TabIndex = 4;
            this.labelEmpDepartment.Text = "Enter EmpDepartment";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(266, 48);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(266, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(266, 100);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesignation.TabIndex = 7;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(266, 132);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 8;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(266, 161);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartment.TabIndex = 9;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(154, 213);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 10;
            this.btnWrite.Text = "WriteToFile";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(253, 213);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 286);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelEmpDepartment);
            this.Controls.Add(this.labelEmpSalary);
            this.Controls.Add(this.labelEmpDesignation);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelEmpId);
            this.Name = "Form6";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpDesignation;
        private System.Windows.Forms.Label labelEmpSalary;
        private System.Windows.Forms.Label labelEmpDepartment;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
    }
}