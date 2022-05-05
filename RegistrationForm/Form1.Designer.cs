
namespace RegistrationForm
{
    partial class RegisterForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(121, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Enter Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(121, 83);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 17);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Enter Email";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(121, 118);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(116, 17);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Enter Contact No";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(121, 152);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(99, 17);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Enter Addrees";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(306, 46);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(306, 82);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 23);
            this.textEmail.TabIndex = 5;
            // 
            // textContact
            // 
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContact.Location = new System.Drawing.Point(306, 115);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(100, 23);
            this.textContact.TabIndex = 6;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.ForeColor = System.Drawing.Color.Black;
            this.textAddress.Location = new System.Drawing.Point(306, 151);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 23);
            this.textAddress.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(124, 205);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(331, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 277);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "RegisterForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
    }
}

