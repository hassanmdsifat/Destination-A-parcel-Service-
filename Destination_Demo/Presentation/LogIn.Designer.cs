namespace Destination_Demo
{
    partial class LogIn
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
            this.LoginBack = new System.Windows.Forms.Button();
            this.UserLogInbutton = new System.Windows.Forms.Button();
            this.PasswordUserTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LoginBack);
            this.panel1.Controls.Add(this.UserLogInbutton);
            this.panel1.Controls.Add(this.PasswordUserTextbox);
            this.panel1.Controls.Add(this.UsernameTextbox);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Location = new System.Drawing.Point(133, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 231);
            this.panel1.TabIndex = 0;
            // 
            // LoginBack
            // 
            this.LoginBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBack.AutoSize = true;
            this.LoginBack.BackColor = System.Drawing.Color.DarkGray;
            this.LoginBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBack.Location = new System.Drawing.Point(49, 180);
            this.LoginBack.Name = "LoginBack";
            this.LoginBack.Size = new System.Drawing.Size(128, 36);
            this.LoginBack.TabIndex = 4;
            this.LoginBack.Text = "< Back";
            this.LoginBack.UseVisualStyleBackColor = false;
            this.LoginBack.Click += new System.EventHandler(this.LoginBack_Click);
            // 
            // UserLogInbutton
            // 
            this.UserLogInbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserLogInbutton.AutoSize = true;
            this.UserLogInbutton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UserLogInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogInbutton.Location = new System.Drawing.Point(330, 180);
            this.UserLogInbutton.Name = "UserLogInbutton";
            this.UserLogInbutton.Size = new System.Drawing.Size(131, 36);
            this.UserLogInbutton.TabIndex = 3;
            this.UserLogInbutton.Text = "LogIn";
            this.UserLogInbutton.UseVisualStyleBackColor = false;
            this.UserLogInbutton.Click += new System.EventHandler(this.UserLogInbutton_Click);
            // 
            // PasswordUserTextbox
            // 
            this.PasswordUserTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordUserTextbox.Location = new System.Drawing.Point(156, 101);
            this.PasswordUserTextbox.Multiline = true;
            this.PasswordUserTextbox.Name = "PasswordUserTextbox";
            this.PasswordUserTextbox.PasswordChar = '*';
            this.PasswordUserTextbox.Size = new System.Drawing.Size(232, 27);
            this.PasswordUserTextbox.TabIndex = 2;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextbox.Location = new System.Drawing.Point(156, 37);
            this.UsernameTextbox.Multiline = true;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(232, 27);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(33, 110);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(83, 18);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(66, 38);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(50, 18);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Destination_Demo.Properties.Resources.f2db5b1fae65676bfd1ecae1dbfdc3a2;
            this.pictureBox1.Location = new System.Drawing.Point(278, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.Shown += new System.EventHandler(this.LogIn_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordUserTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Button UserLogInbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoginBack;
    }
}