namespace Destination_Demo
{
    partial class OrderHistoryForm
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
            this.OrderDetailsGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DashBoardButton = new System.Windows.Forms.Button();
            this.UserLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.OrderDetailsGrid);
            this.panel1.Location = new System.Drawing.Point(27, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 306);
            this.panel1.TabIndex = 0;
            // 
            // OrderDetailsGrid
            // 
            this.OrderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsGrid.Location = new System.Drawing.Point(3, 3);
            this.OrderDetailsGrid.Name = "OrderDetailsGrid";
            this.OrderDetailsGrid.ReadOnly = true;
            this.OrderDetailsGrid.Size = new System.Drawing.Size(666, 299);
            this.OrderDetailsGrid.TabIndex = 0;
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
            this.panel2.TabIndex = 4;
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
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order History";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderHistoryForm_FormClosed);
            this.Shown += new System.EventHandler(this.OrderHistoryForm_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DashBoardButton;
        private System.Windows.Forms.Button UserLogout;
        private System.Windows.Forms.DataGridView OrderDetailsGrid;
    }
}