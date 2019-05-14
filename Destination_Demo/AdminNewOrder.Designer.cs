namespace Destination_Demo
{
    partial class AdminNewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewOrderGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Addressbox = new System.Windows.Forms.RichTextBox();
            this.RCVPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RCVname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddInfo = new System.Windows.Forms.RichTextBox();
            this.OrderType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AssignDB = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewOrderGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*Click on row to see details";
            // 
            // NewOrderGrid
            // 
            this.NewOrderGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewOrderGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewOrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewOrderGrid.Location = new System.Drawing.Point(12, 93);
            this.NewOrderGrid.Name = "NewOrderGrid";
            this.NewOrderGrid.ReadOnly = true;
            this.NewOrderGrid.Size = new System.Drawing.Size(753, 196);
            this.NewOrderGrid.TabIndex = 10;
            this.NewOrderGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewOrderGrid_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.Addressbox);
            this.panel3.Controls.Add(this.RCVPhone);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.RCVname);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(12, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 154);
            this.panel3.TabIndex = 13;
            // 
            // Addressbox
            // 
            this.Addressbox.Location = new System.Drawing.Point(161, 68);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.ReadOnly = true;
            this.Addressbox.Size = new System.Drawing.Size(282, 42);
            this.Addressbox.TabIndex = 17;
            this.Addressbox.Text = "";
            // 
            // RCVPhone
            // 
            this.RCVPhone.Location = new System.Drawing.Point(161, 128);
            this.RCVPhone.Name = "RCVPhone";
            this.RCVPhone.ReadOnly = true;
            this.RCVPhone.Size = new System.Drawing.Size(282, 20);
            this.RCVPhone.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiever Information";
            // 
            // RCVname
            // 
            this.RCVname.Location = new System.Drawing.Point(161, 39);
            this.RCVname.Name = "RCVname";
            this.RCVname.ReadOnly = true;
            this.RCVname.Size = new System.Drawing.Size(282, 20);
            this.RCVname.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.AddInfo);
            this.panel4.Controls.Add(this.OrderType);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 145);
            this.panel4.TabIndex = 14;
            // 
            // AddInfo
            // 
            this.AddInfo.Location = new System.Drawing.Point(158, 93);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.ReadOnly = true;
            this.AddInfo.Size = new System.Drawing.Size(282, 42);
            this.AddInfo.TabIndex = 18;
            this.AddInfo.Text = "";
            // 
            // OrderType
            // 
            this.OrderType.Location = new System.Drawing.Point(158, 48);
            this.OrderType.Name = "OrderType";
            this.OrderType.ReadOnly = true;
            this.OrderType.Size = new System.Drawing.Size(282, 20);
            this.OrderType.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Additional Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Order Type ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order Information";
            // 
            // AssignDB
            // 
            this.AssignDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignDB.Location = new System.Drawing.Point(600, 60);
            this.AssignDB.Name = "AssignDB";
            this.AssignDB.Size = new System.Drawing.Size(165, 27);
            this.AssignDB.TabIndex = 3;
            this.AssignDB.Text = "Assign DeliveryBoy";
            this.AssignDB.UseVisualStyleBackColor = true;
            this.AssignDB.Visible = false;
            this.AssignDB.Click += new System.EventHandler(this.AssignDB_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrder.Location = new System.Drawing.Point(265, 60);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(165, 27);
            this.CancelOrder.TabIndex = 15;
            this.CancelOrder.Text = "Cancel Order";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Visible = false;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // AdminNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.CancelOrder);
            this.Controls.Add(this.AssignDB);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewOrderGrid);
            this.Controls.Add(this.panel1);
            this.Name = "AdminNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminNewOrder_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminNewOrder_FormClosed);
            this.Shown += new System.EventHandler(this.AdminNewOrder_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewOrderGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderLogout;
        private System.Windows.Forms.Button OrderDash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView NewOrderGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox Addressbox;
        private System.Windows.Forms.TextBox RCVPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RCVname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox AddInfo;
        private System.Windows.Forms.TextBox OrderType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AssignDB;
        private System.Windows.Forms.Button CancelOrder;
    }
}