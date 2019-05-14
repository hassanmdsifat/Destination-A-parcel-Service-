namespace Destination_Demo
{
    partial class MemberDashBoard
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
            this.UserLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserHistoryButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.UserLogout);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 33);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.UserHistoryButton);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.NewOrderButton);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 322);
            this.panel2.TabIndex = 1;
            // 
            // UserHistoryButton
            // 
            this.UserHistoryButton.BackColor = System.Drawing.Color.LimeGreen;
            this.UserHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserHistoryButton.Location = new System.Drawing.Point(225, 190);
            this.UserHistoryButton.Name = "UserHistoryButton";
            this.UserHistoryButton.Size = new System.Drawing.Size(386, 93);
            this.UserHistoryButton.TabIndex = 3;
            this.UserHistoryButton.Text = "Check History";
            this.UserHistoryButton.UseVisualStyleBackColor = false;
            this.UserHistoryButton.Click += new System.EventHandler(this.UserHistoryButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Destination_Demo.Properties.Resources.history_318_48462;
            this.pictureBox3.Location = new System.Drawing.Point(60, 190);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.LimeGreen;
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(225, 42);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(386, 93);
            this.NewOrderButton.TabIndex = 1;
            this.NewOrderButton.Text = "Place New Order";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Destination_Demo.Properties.Resources.download__1_;
            this.pictureBox2.Location = new System.Drawing.Point(60, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MemberDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MemberDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberDashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberDashBoard_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UserLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button UserHistoryButton;
    }
}