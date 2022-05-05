
namespace RegistrationForm
{
    partial class Form5
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
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelStream = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.textBoxStream = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.Location = new System.Drawing.Point(100, 39);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(67, 13);
            this.labelRoll.TabIndex = 0;
            this.labelRoll.Text = "Enter RollNo";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(100, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Enter Name";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(100, 103);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(90, 13);
            this.labelPercentage.TabIndex = 2;
            this.labelPercentage.Text = "Enter Percentage";
            // 
            // labelStream
            // 
            this.labelStream.AutoSize = true;
            this.labelStream.Location = new System.Drawing.Point(100, 135);
            this.labelStream.Name = "labelStream";
            this.labelStream.Size = new System.Drawing.Size(68, 13);
            this.labelStream.TabIndex = 3;
            this.labelStream.Text = "Enter Stream";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(100, 167);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(52, 13);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "Enter City";
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Location = new System.Drawing.Point(279, 32);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoll.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(279, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Location = new System.Drawing.Point(279, 100);
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.Size = new System.Drawing.Size(100, 20);
            this.textBoxPercentage.TabIndex = 7;
            // 
            // textBoxStream
            // 
            this.textBoxStream.Location = new System.Drawing.Point(279, 135);
            this.textBoxStream.Name = "textBoxStream";
            this.textBoxStream.Size = new System.Drawing.Size(100, 20);
            this.textBoxStream.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(279, 167);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(151, 215);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 10;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(260, 215);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read  File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 281);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStream);
            this.Controls.Add(this.textBoxPercentage);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxRoll);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStream);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRoll);
            this.Name = "Form5";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelStream;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.TextBox textBoxStream;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
    }
}