namespace Destination_Demo
{
    partial class SignUpUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PhEmpty = new System.Windows.Forms.Label();
            this.PHvalid = new System.Windows.Forms.Label();
            this.UserRPassword = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.UserPhoneNumber = new System.Windows.Forms.TextBox();
            this.UserLastName = new System.Windows.Forms.TextBox();
            this.UserFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserSignIn = new System.Windows.Forms.Button();
            this.UserBack = new System.Windows.Forms.Button();
            this.FnameErr = new System.Windows.Forms.Label();
            this.FnameVal = new System.Windows.Forms.Label();
            this.LnameErr = new System.Windows.Forms.Label();
            this.LnameVal = new System.Windows.Forms.Label();
            this.Passvld = new System.Windows.Forms.Label();
            this.Passemp = new System.Windows.Forms.Label();
            this.Emailvld = new System.Windows.Forms.Label();
            this.EmailErr = new System.Windows.Forms.Label();
            this.Rpasserr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up as an USER";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Rpasserr);
            this.panel2.Controls.Add(this.EmailErr);
            this.panel2.Controls.Add(this.Emailvld);
            this.panel2.Controls.Add(this.Passemp);
            this.panel2.Controls.Add(this.Passvld);
            this.panel2.Controls.Add(this.LnameVal);
            this.panel2.Controls.Add(this.LnameErr);
            this.panel2.Controls.Add(this.FnameVal);
            this.panel2.Controls.Add(this.FnameErr);
            this.panel2.Controls.Add(this.PhEmpty);
            this.panel2.Controls.Add(this.PHvalid);
            this.panel2.Controls.Add(this.UserRPassword);
            this.panel2.Controls.Add(this.UserPassword);
            this.panel2.Controls.Add(this.UserEmail);
            this.panel2.Controls.Add(this.UserPhoneNumber);
            this.panel2.Controls.Add(this.UserLastName);
            this.panel2.Controls.Add(this.UserFirstName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(34, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 287);
            this.panel2.TabIndex = 1;
            // 
            // PhEmpty
            // 
            this.PhEmpty.AutoSize = true;
            this.PhEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhEmpty.ForeColor = System.Drawing.Color.Red;
            this.PhEmpty.Location = new System.Drawing.Point(360, 123);
            this.PhEmpty.Name = "PhEmpty";
            this.PhEmpty.Size = new System.Drawing.Size(164, 13);
            this.PhEmpty.TabIndex = 13;
            this.PhEmpty.Text = "*Phone Number Field Empty";
            this.PhEmpty.Visible = false;
            // 
            // PHvalid
            // 
            this.PHvalid.AutoSize = true;
            this.PHvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHvalid.ForeColor = System.Drawing.Color.Red;
            this.PHvalid.Location = new System.Drawing.Point(203, 121);
            this.PHvalid.Name = "PHvalid";
            this.PHvalid.Size = new System.Drawing.Size(151, 13);
            this.PHvalid.TabIndex = 12;
            this.PHvalid.Text = "*Phone Number Not Valid";
            this.PHvalid.Visible = false;
            // 
            // UserRPassword
            // 
            this.UserRPassword.Location = new System.Drawing.Point(206, 222);
            this.UserRPassword.Multiline = true;
            this.UserRPassword.Name = "UserRPassword";
            this.UserRPassword.PasswordChar = '*';
            this.UserRPassword.Size = new System.Drawing.Size(297, 21);
            this.UserRPassword.TabIndex = 11;
            this.UserRPassword.Leave += new System.EventHandler(this.UserRPassword_Leave);
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(206, 180);
            this.UserPassword.Multiline = true;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.Size = new System.Drawing.Size(297, 21);
            this.UserPassword.TabIndex = 10;
            this.UserPassword.Leave += new System.EventHandler(this.UserPassword_Leave);
            // 
            // UserEmail
            // 
            this.UserEmail.Location = new System.Drawing.Point(206, 139);
            this.UserEmail.Multiline = true;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(297, 21);
            this.UserEmail.TabIndex = 9;
            this.UserEmail.Leave += new System.EventHandler(this.UserEmail_Leave);
            // 
            // UserPhoneNumber
            // 
            this.UserPhoneNumber.Location = new System.Drawing.Point(206, 96);
            this.UserPhoneNumber.Multiline = true;
            this.UserPhoneNumber.Name = "UserPhoneNumber";
            this.UserPhoneNumber.Size = new System.Drawing.Size(297, 21);
            this.UserPhoneNumber.TabIndex = 8;
            this.UserPhoneNumber.Leave += new System.EventHandler(this.UserPhoneNumber_Leave);
            // 
            // UserLastName
            // 
            this.UserLastName.Location = new System.Drawing.Point(206, 52);
            this.UserLastName.Multiline = true;
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.Size = new System.Drawing.Size(297, 21);
            this.UserLastName.TabIndex = 7;
            this.UserLastName.Leave += new System.EventHandler(this.UserLastName_Leave);
            // 
            // UserFirstName
            // 
            this.UserFirstName.Location = new System.Drawing.Point(206, 6);
            this.UserFirstName.Multiline = true;
            this.UserFirstName.Name = "UserFirstName";
            this.UserFirstName.Size = new System.Drawing.Size(297, 21);
            this.UserFirstName.TabIndex = 6;
            this.UserFirstName.Leave += new System.EventHandler(this.UserFirstName_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Repeat Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // UserSignIn
            // 
            this.UserSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserSignIn.AutoSize = true;
            this.UserSignIn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UserSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSignIn.Location = new System.Drawing.Point(620, 563);
            this.UserSignIn.Name = "UserSignIn";
            this.UserSignIn.Size = new System.Drawing.Size(131, 36);
            this.UserSignIn.TabIndex = 19;
            this.UserSignIn.Text = "Sign In";
            this.UserSignIn.UseVisualStyleBackColor = false;
            this.UserSignIn.Click += new System.EventHandler(this.UserSignIn_Click);
            // 
            // UserBack
            // 
            this.UserBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserBack.AutoSize = true;
            this.UserBack.BackColor = System.Drawing.Color.DarkGray;
            this.UserBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBack.Location = new System.Drawing.Point(12, 563);
            this.UserBack.Name = "UserBack";
            this.UserBack.Size = new System.Drawing.Size(131, 36);
            this.UserBack.TabIndex = 20;
            this.UserBack.Text = "< Back";
            this.UserBack.UseVisualStyleBackColor = false;
            this.UserBack.Click += new System.EventHandler(this.UserBack_Click);
            // 
            // FnameErr
            // 
            this.FnameErr.AutoSize = true;
            this.FnameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameErr.ForeColor = System.Drawing.Color.Red;
            this.FnameErr.Location = new System.Drawing.Point(203, 36);
            this.FnameErr.Name = "FnameErr";
            this.FnameErr.Size = new System.Drawing.Size(233, 13);
            this.FnameErr.TabIndex = 14;
            this.FnameErr.Text = "*FirstName Not More Than 40 character";
            this.FnameErr.Visible = false;
            // 
            // FnameVal
            // 
            this.FnameVal.AutoSize = true;
            this.FnameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameVal.ForeColor = System.Drawing.Color.Red;
            this.FnameVal.Location = new System.Drawing.Point(379, 36);
            this.FnameVal.Name = "FnameVal";
            this.FnameVal.Size = new System.Drawing.Size(145, 13);
            this.FnameVal.TabIndex = 15;
            this.FnameVal.Text = "*First Name  Field Empty";
            this.FnameVal.Visible = false;
            // 
            // LnameErr
            // 
            this.LnameErr.AutoSize = true;
            this.LnameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameErr.ForeColor = System.Drawing.Color.Red;
            this.LnameErr.Location = new System.Drawing.Point(203, 80);
            this.LnameErr.Name = "LnameErr";
            this.LnameErr.Size = new System.Drawing.Size(234, 13);
            this.LnameErr.TabIndex = 16;
            this.LnameErr.Text = "*LastName Not More Than 40 Character";
            this.LnameErr.Visible = false;
            // 
            // LnameVal
            // 
            this.LnameVal.AutoSize = true;
            this.LnameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameVal.ForeColor = System.Drawing.Color.Red;
            this.LnameVal.Location = new System.Drawing.Point(383, 80);
            this.LnameVal.Name = "LnameVal";
            this.LnameVal.Size = new System.Drawing.Size(141, 13);
            this.LnameVal.TabIndex = 17;
            this.LnameVal.Text = "*Last Name Field Empty";
            this.LnameVal.Visible = false;
            // 
            // Passvld
            // 
            this.Passvld.AutoSize = true;
            this.Passvld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passvld.ForeColor = System.Drawing.Color.Red;
            this.Passvld.Location = new System.Drawing.Point(203, 206);
            this.Passvld.Name = "Passvld";
            this.Passvld.Size = new System.Drawing.Size(226, 13);
            this.Passvld.TabIndex = 18;
            this.Passvld.Text = "Password Not More Than 40 character";
            this.Passvld.Visible = false;
            // 
            // Passemp
            // 
            this.Passemp.AutoSize = true;
            this.Passemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passemp.ForeColor = System.Drawing.Color.Red;
            this.Passemp.Location = new System.Drawing.Point(383, 204);
            this.Passemp.Name = "Passemp";
            this.Passemp.Size = new System.Drawing.Size(135, 13);
            this.Passemp.TabIndex = 19;
            this.Passemp.Text = "*Password Field Empty";
            this.Passemp.Visible = false;
            // 
            // Emailvld
            // 
            this.Emailvld.AutoSize = true;
            this.Emailvld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailvld.ForeColor = System.Drawing.Color.Red;
            this.Emailvld.Location = new System.Drawing.Point(203, 163);
            this.Emailvld.Name = "Emailvld";
            this.Emailvld.Size = new System.Drawing.Size(96, 13);
            this.Emailvld.TabIndex = 20;
            this.Emailvld.Text = "*Email not Valid";
            this.Emailvld.Visible = false;
            // 
            // EmailErr
            // 
            this.EmailErr.AutoSize = true;
            this.EmailErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailErr.ForeColor = System.Drawing.Color.Red;
            this.EmailErr.Location = new System.Drawing.Point(413, 164);
            this.EmailErr.Name = "EmailErr";
            this.EmailErr.Size = new System.Drawing.Size(111, 13);
            this.EmailErr.TabIndex = 21;
            this.EmailErr.Text = "*Email Field Empty";
            this.EmailErr.Visible = false;
            // 
            // Rpasserr
            // 
            this.Rpasserr.AutoSize = true;
            this.Rpasserr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rpasserr.ForeColor = System.Drawing.Color.Red;
            this.Rpasserr.Location = new System.Drawing.Point(326, 246);
            this.Rpasserr.Name = "Rpasserr";
            this.Rpasserr.Size = new System.Drawing.Size(198, 13);
            this.Rpasserr.TabIndex = 22;
            this.Rpasserr.Text = "*Reapeat Password doesnt match";
            this.Rpasserr.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(49, 21);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "+88";
            // 
            // SignUpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.UserBack);
            this.Controls.Add(this.UserSignIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SignUpUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpUser_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UserRPassword;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.TextBox UserPhoneNumber;
        private System.Windows.Forms.TextBox UserLastName;
        private System.Windows.Forms.TextBox UserFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserSignIn;
        private System.Windows.Forms.Button UserBack;
        private System.Windows.Forms.Label PhEmpty;
        private System.Windows.Forms.Label PHvalid;
        private System.Windows.Forms.Label Rpasserr;
        private System.Windows.Forms.Label EmailErr;
        private System.Windows.Forms.Label Emailvld;
        private System.Windows.Forms.Label Passemp;
        private System.Windows.Forms.Label Passvld;
        private System.Windows.Forms.Label LnameVal;
        private System.Windows.Forms.Label LnameErr;
        private System.Windows.Forms.Label FnameVal;
        private System.Windows.Forms.Label FnameErr;
        private System.Windows.Forms.TextBox textBox1;
    }
}