namespace Destination_Demo
{
    partial class NewDeliveryBoyRequest
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
            this.DBRequest = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DltButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBRequest)).BeginInit();
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
            this.panel1.TabIndex = 7;
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
            // DBRequest
            // 
            this.DBRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DBRequest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DBRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBRequest.Location = new System.Drawing.Point(50, 175);
            this.DBRequest.Name = "DBRequest";
            this.DBRequest.ReadOnly = true;
            this.DBRequest.Size = new System.Drawing.Size(688, 376);
            this.DBRequest.TabIndex = 8;
            this.DBRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBRequest_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.DltButton);
            this.panel2.Location = new System.Drawing.Point(50, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 79);
            this.panel2.TabIndex = 9;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(580, 15);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(95, 46);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DltButton
            // 
            this.DltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DltButton.Location = new System.Drawing.Point(3, 15);
            this.DltButton.Name = "DltButton";
            this.DltButton.Size = new System.Drawing.Size(95, 46);
            this.DltButton.TabIndex = 0;
            this.DltButton.Text = "Delete";
            this.DltButton.UseVisualStyleBackColor = true;
            this.DltButton.Visible = false;
            this.DltButton.Click += new System.EventHandler(this.DltButton_Click);
            // 
            // NewDeliveryBoyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DBRequest);
            this.Controls.Add(this.panel1);
            this.Name = "NewDeliveryBoyRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requsts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDeliveryBoyRequest_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDeliveryBoyRequest_FormClosed);
            this.Shown += new System.EventHandler(this.NewDeliveryBoyRequest_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DBRequest)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderLogout;
        private System.Windows.Forms.Button OrderDash;
        private System.Windows.Forms.DataGridView DBRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DltButton;
    }
}