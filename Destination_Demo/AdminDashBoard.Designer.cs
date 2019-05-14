namespace Destination_Demo
{
    partial class AdminDashBoard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.UserListBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NewDBRequest = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.OrderLogout);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 33);
            this.panel1.TabIndex = 4;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.OrderBtn);
            this.panel2.Controls.Add(this.UserListBtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.NewDBRequest);
            this.panel2.Controls.Add(this.NewOrderButton);
            this.panel2.Location = new System.Drawing.Point(27, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 450);
            this.panel2.TabIndex = 5;
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.Teal;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.Location = new System.Drawing.Point(511, 276);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(200, 93);
            this.OrderBtn.TabIndex = 6;
            this.OrderBtn.Text = "Order List";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // UserListBtn
            // 
            this.UserListBtn.BackColor = System.Drawing.Color.Teal;
            this.UserListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListBtn.Location = new System.Drawing.Point(269, 276);
            this.UserListBtn.Name = "UserListBtn";
            this.UserListBtn.Size = new System.Drawing.Size(202, 93);
            this.UserListBtn.TabIndex = 5;
            this.UserListBtn.Text = "See User List";
            this.UserListBtn.UseVisualStyleBackColor = false;
            this.UserListBtn.Click += new System.EventHandler(this.UserListBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 93);
            this.button1.TabIndex = 4;
            this.button1.Text = "See DeliveryBoy List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewDBRequest
            // 
            this.NewDBRequest.BackColor = System.Drawing.Color.LimeGreen;
            this.NewDBRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDBRequest.Location = new System.Drawing.Point(157, 140);
            this.NewDBRequest.Name = "NewDBRequest";
            this.NewDBRequest.Size = new System.Drawing.Size(386, 93);
            this.NewDBRequest.TabIndex = 3;
            this.NewDBRequest.Text = "Check New DeliveryBoy Request";
            this.NewDBRequest.UseVisualStyleBackColor = false;
            this.NewDBRequest.Click += new System.EventHandler(this.NewDBRequest_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.LimeGreen;
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(157, 3);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(386, 93);
            this.NewOrderButton.TabIndex = 2;
            this.NewOrderButton.Text = "Check New Order";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash Board";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashBoard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashBoard_FormClosed);
            this.Shown += new System.EventHandler(this.AdminDashBoard_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button NewDBRequest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button UserListBtn;
    }
}