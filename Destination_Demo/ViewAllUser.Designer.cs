namespace Destination_Demo
{
    partial class ViewAllUser
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
            this.NotiLoogout = new System.Windows.Forms.Button();
            this.NotiDashBoard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.NotiLoogout);
            this.panel1.Controls.Add(this.NotiDashBoard);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 33);
            this.panel1.TabIndex = 2;
            // 
            // NotiLoogout
            // 
            this.NotiLoogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiLoogout.Location = new System.Drawing.Point(678, 3);
            this.NotiLoogout.Name = "NotiLoogout";
            this.NotiLoogout.Size = new System.Drawing.Size(103, 27);
            this.NotiLoogout.TabIndex = 2;
            this.NotiLoogout.Text = "Log Out";
            this.NotiLoogout.UseVisualStyleBackColor = true;
            this.NotiLoogout.Click += new System.EventHandler(this.NotiLoogout_Click);
            // 
            // NotiDashBoard
            // 
            this.NotiDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiDashBoard.Location = new System.Drawing.Point(12, 3);
            this.NotiDashBoard.Name = "NotiDashBoard";
            this.NotiDashBoard.Size = new System.Drawing.Size(103, 27);
            this.NotiDashBoard.TabIndex = 0;
            this.NotiDashBoard.Text = "DashBoard";
            this.NotiDashBoard.UseVisualStyleBackColor = true;
            this.NotiDashBoard.Click += new System.EventHandler(this.NotiDashBoard_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.UserGrid);
            this.panel2.Location = new System.Drawing.Point(12, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 388);
            this.panel2.TabIndex = 3;
            // 
            // UserGrid
            // 
            this.UserGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Location = new System.Drawing.Point(3, 3);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.Size = new System.Drawing.Size(754, 382);
            this.UserGrid.TabIndex = 0;
            // 
            // ViewAllUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAllUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllUser_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllUser_FormClosed);
            this.Shown += new System.EventHandler(this.ViewAllUser_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NotiLoogout;
        private System.Windows.Forms.Button NotiDashBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView UserGrid;
    }
}