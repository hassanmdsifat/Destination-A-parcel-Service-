namespace Destination_Demo
{
    partial class DeliverDashboard
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
            this.OrderHistory = new System.Windows.Forms.Button();
            this.NewRequest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserLogout = new System.Windows.Forms.Button();
            this.Mydetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Mydetails);
            this.panel1.Controls.Add(this.OrderHistory);
            this.panel1.Controls.Add(this.NewRequest);
            this.panel1.Location = new System.Drawing.Point(38, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 380);
            this.panel1.TabIndex = 0;
            // 
            // OrderHistory
            // 
            this.OrderHistory.BackColor = System.Drawing.Color.Lime;
            this.OrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistory.Location = new System.Drawing.Point(178, 201);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Size = new System.Drawing.Size(306, 46);
            this.OrderHistory.TabIndex = 1;
            this.OrderHistory.Text = "Check Order History";
            this.OrderHistory.UseVisualStyleBackColor = false;
            this.OrderHistory.Click += new System.EventHandler(this.OrderHistory_Click);
            // 
            // NewRequest
            // 
            this.NewRequest.BackColor = System.Drawing.Color.Lime;
            this.NewRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRequest.Location = new System.Drawing.Point(178, 118);
            this.NewRequest.Name = "NewRequest";
            this.NewRequest.Size = new System.Drawing.Size(306, 46);
            this.NewRequest.TabIndex = 0;
            this.NewRequest.Text = "Check Pending Request";
            this.NewRequest.UseVisualStyleBackColor = false;
            this.NewRequest.Click += new System.EventHandler(this.NewRequest_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.UserLogout);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 33);
            this.panel2.TabIndex = 1;
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
            // Mydetails
            // 
            this.Mydetails.BackColor = System.Drawing.Color.Lime;
            this.Mydetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mydetails.Location = new System.Drawing.Point(178, 278);
            this.Mydetails.Name = "Mydetails";
            this.Mydetails.Size = new System.Drawing.Size(306, 46);
            this.Mydetails.TabIndex = 2;
            this.Mydetails.Text = "My Details";
            this.Mydetails.UseVisualStyleBackColor = false;
            this.Mydetails.Click += new System.EventHandler(this.Mydetails_Click);
            // 
            // DeliverDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DeliverDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeliverDashboard_FormClosed);
            this.Shown += new System.EventHandler(this.DeliverDashboard_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderHistory;
        private System.Windows.Forms.Button NewRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UserLogout;
        private System.Windows.Forms.Button Mydetails;
    }
}