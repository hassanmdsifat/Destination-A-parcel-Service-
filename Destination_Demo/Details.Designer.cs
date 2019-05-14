namespace Destination_Demo
{
    partial class Details
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DashBoardButton = new System.Windows.Forms.Button();
            this.UserLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.match = new System.Windows.Forms.Label();
            this.UP = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Cpass = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.DashBoardButton);
            this.panel2.Controls.Add(this.UserLogout);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 33);
            this.panel2.TabIndex = 5;
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardButton.Location = new System.Drawing.Point(20, 6);
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.Size = new System.Drawing.Size(103, 24);
            this.DashBoardButton.TabIndex = 3;
            this.DashBoardButton.Text = "Dash Board";
            this.DashBoardButton.UseVisualStyleBackColor = true;
            this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // UserLogout
            // 
            this.UserLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogout.Location = new System.Drawing.Point(678, 3);
            this.UserLogout.Name = "UserLogout";
            this.UserLogout.Size = new System.Drawing.Size(103, 27);
            this.UserLogout.TabIndex = 2;
            this.UserLogout.Text = "Log Out";
            this.UserLogout.UseVisualStyleBackColor = true;
            this.UserLogout.Click += new System.EventHandler(this.UserLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.match);
            this.panel1.Controls.Add(this.UP);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.Cpass);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 404);
            this.panel1.TabIndex = 6;
            // 
            // match
            // 
            this.match.AutoSize = true;
            this.match.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.match.Location = new System.Drawing.Point(265, 301);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(197, 13);
            this.match.TabIndex = 13;
            this.match.Text = "*Repeat Password Doesn\'t Match";
            this.match.Visible = false;
            // 
            // UP
            // 
            this.UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP.Location = new System.Drawing.Point(491, 374);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(75, 27);
            this.UP.TabIndex = 12;
            this.UP.Text = "Update";
            this.UP.UseVisualStyleBackColor = true;
            this.UP.Visible = false;
            this.UP.Click += new System.EventHandler(this.UP_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(268, 266);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '*';
            this.textBox6.Size = new System.Drawing.Size(214, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // Cpass
            // 
            this.Cpass.Location = new System.Drawing.Point(268, 219);
            this.Cpass.Name = "Cpass";
            this.Cpass.PasswordChar = '*';
            this.Cpass.Size = new System.Drawing.Size(214, 20);
            this.Cpass.TabIndex = 10;
            this.Cpass.Leave += new System.EventHandler(this.Cpass_Leave);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(268, 170);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(214, 20);
            this.pass.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Repeat Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Details_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Details_FormClosed);
            this.Shown += new System.EventHandler(this.Details_Shown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DashBoardButton;
        private System.Windows.Forms.Button UserLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Cpass;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Label match;
    }
}