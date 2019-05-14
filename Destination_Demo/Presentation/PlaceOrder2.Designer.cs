namespace Destination_Demo
{
    partial class PlaceOrder2
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
            this.OrderLogout = new System.Windows.Forms.Button();
            this.OrderDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lnameerr = new System.Windows.Forms.Label();
            this.FnameErr = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FnameLabel = new System.Windows.Forms.Label();
            this.RcvPhone = new System.Windows.Forms.TextBox();
            this.RCVLname = new System.Windows.Forms.TextBox();
            this.RCVFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Order2Next = new System.Windows.Forms.Button();
            this.Order2Back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.OrderLogout);
            this.panel1.Controls.Add(this.OrderDash);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 33);
            this.panel1.TabIndex = 3;
            // 
            // OrderLogout
            // 
            this.OrderLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLogout.Location = new System.Drawing.Point(678, 3);
            this.OrderLogout.Name = "OrderLogout";
            this.OrderLogout.Size = new System.Drawing.Size(103, 27);
            this.OrderLogout.TabIndex = 2;
            this.OrderLogout.Text = "Log Out";
            this.OrderLogout.UseVisualStyleBackColor = true;
            this.OrderLogout.Click += new System.EventHandler(this.OrderLogout_Click);
            // 
            // OrderDash
            // 
            this.OrderDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDash.Location = new System.Drawing.Point(12, 3);
            this.OrderDash.Name = "OrderDash";
            this.OrderDash.Size = new System.Drawing.Size(103, 27);
            this.OrderDash.TabIndex = 0;
            this.OrderDash.Text = "DashBoard";
            this.OrderDash.UseVisualStyleBackColor = true;
            this.OrderDash.Click += new System.EventHandler(this.OrderDash_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Lnameerr);
            this.panel2.Controls.Add(this.FnameErr);
            this.panel2.Controls.Add(this.PhoneLabel);
            this.panel2.Controls.Add(this.LNameLabel);
            this.panel2.Controls.Add(this.FnameLabel);
            this.panel2.Controls.Add(this.RcvPhone);
            this.panel2.Controls.Add(this.RCVLname);
            this.panel2.Controls.Add(this.RCVFname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(25, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 266);
            this.panel2.TabIndex = 4;
            // 
            // Lnameerr
            // 
            this.Lnameerr.AutoSize = true;
            this.Lnameerr.ForeColor = System.Drawing.Color.Red;
            this.Lnameerr.Location = new System.Drawing.Point(217, 165);
            this.Lnameerr.Name = "Lnameerr";
            this.Lnameerr.Size = new System.Drawing.Size(220, 13);
            this.Lnameerr.TabIndex = 14;
            this.Lnameerr.Text = "* Last Name Can\'t be more than 40 character";
            this.Lnameerr.Visible = false;
            // 
            // FnameErr
            // 
            this.FnameErr.AutoSize = true;
            this.FnameErr.ForeColor = System.Drawing.Color.Red;
            this.FnameErr.Location = new System.Drawing.Point(217, 111);
            this.FnameErr.Name = "FnameErr";
            this.FnameErr.Size = new System.Drawing.Size(219, 13);
            this.FnameErr.TabIndex = 13;
            this.FnameErr.Text = "* First Name Can\'t be more than 40 character";
            this.FnameErr.Visible = false;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.ForeColor = System.Drawing.Color.Red;
            this.PhoneLabel.Location = new System.Drawing.Point(397, 218);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(131, 13);
            this.PhoneLabel.TabIndex = 12;
            this.PhoneLabel.Text = "* Phone Number not valid!";
            this.PhoneLabel.Visible = false;
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.ForeColor = System.Drawing.Color.Red;
            this.LNameLabel.Location = new System.Drawing.Point(431, 165);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(97, 13);
            this.LNameLabel.TabIndex = 11;
            this.LNameLabel.Text = "* Last Name Empty";
            this.LNameLabel.Visible = false;
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.ForeColor = System.Drawing.Color.Red;
            this.FnameLabel.Location = new System.Drawing.Point(431, 111);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(96, 13);
            this.FnameLabel.TabIndex = 10;
            this.FnameLabel.Text = "* First Name Empty";
            this.FnameLabel.Visible = false;
            // 
            // RcvPhone
            // 
            this.RcvPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcvPhone.Location = new System.Drawing.Point(220, 194);
            this.RcvPhone.Name = "RcvPhone";
            this.RcvPhone.Size = new System.Drawing.Size(307, 21);
            this.RcvPhone.TabIndex = 9;
            this.RcvPhone.Leave += new System.EventHandler(this.RcvPhone_Leave);
            // 
            // RCVLname
            // 
            this.RCVLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCVLname.Location = new System.Drawing.Point(220, 141);
            this.RCVLname.Name = "RCVLname";
            this.RCVLname.Size = new System.Drawing.Size(307, 21);
            this.RCVLname.TabIndex = 7;
            this.RCVLname.Leave += new System.EventHandler(this.RCVLname_Leave);
            // 
            // RCVFname
            // 
            this.RCVFname.Location = new System.Drawing.Point(220, 88);
            this.RCVFname.Name = "RCVFname";
            this.RCVFname.Size = new System.Drawing.Size(307, 20);
            this.RCVFname.TabIndex = 6;
            this.RCVFname.Leave += new System.EventHandler(this.RCVFname_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Receiver Deatils";
            // 
            // Order2Next
            // 
            this.Order2Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Order2Next.AutoSize = true;
            this.Order2Next.BackColor = System.Drawing.Color.Orange;
            this.Order2Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order2Next.Location = new System.Drawing.Point(620, 455);
            this.Order2Next.Name = "Order2Next";
            this.Order2Next.Size = new System.Drawing.Size(131, 36);
            this.Order2Next.TabIndex = 10;
            this.Order2Next.Text = "Next >";
            this.Order2Next.UseVisualStyleBackColor = false;
            this.Order2Next.Click += new System.EventHandler(this.Order2Next_Click);
            // 
            // Order2Back
            // 
            this.Order2Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Order2Back.AutoSize = true;
            this.Order2Back.BackColor = System.Drawing.Color.Red;
            this.Order2Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order2Back.Location = new System.Drawing.Point(25, 455);
            this.Order2Back.Name = "Order2Back";
            this.Order2Back.Size = new System.Drawing.Size(131, 36);
            this.Order2Back.TabIndex = 11;
            this.Order2Back.Text = "< Back ";
            this.Order2Back.UseVisualStyleBackColor = false;
            this.Order2Back.Click += new System.EventHandler(this.Order2Back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "+88";
            // 
            // PlaceOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.Order2Back);
            this.Controls.Add(this.Order2Next);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrder2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiver Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaceOrder2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderLogout;
        private System.Windows.Forms.Button OrderDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RCVFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RcvPhone;
        private System.Windows.Forms.TextBox RCVLname;
        private System.Windows.Forms.Button Order2Next;
        private System.Windows.Forms.Button Order2Back;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label Lnameerr;
        private System.Windows.Forms.Label FnameErr;
        private System.Windows.Forms.TextBox textBox1;
    }
}