namespace Destination_Demo
{
    partial class OrderHistory
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
            this.OrderHistoryGrid = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DBPhone = new System.Windows.Forms.TextBox();
            this.DBname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddInfo = new System.Windows.Forms.RichTextBox();
            this.OrderType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Addressbox = new System.Windows.Forms.RichTextBox();
            this.RCVPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RCVname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderHistoryGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderHistoryGrid
            // 
            this.OrderHistoryGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderHistoryGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderHistoryGrid.Location = new System.Drawing.Point(499, 105);
            this.OrderHistoryGrid.Name = "OrderHistoryGrid";
            this.OrderHistoryGrid.ReadOnly = true;
            this.OrderHistoryGrid.Size = new System.Drawing.Size(273, 440);
            this.OrderHistoryGrid.TabIndex = 0;
            this.OrderHistoryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderHistoryGrid_CellClick);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(0, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 33);
            this.panel5.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(678, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 27);
            this.button3.TabIndex = 0;
            this.button3.Text = "DashBoard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(27, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 440);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.DBPhone);
            this.panel2.Controls.Add(this.DBname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 111);
            this.panel2.TabIndex = 19;
            // 
            // DBPhone
            // 
            this.DBPhone.Location = new System.Drawing.Point(158, 76);
            this.DBPhone.Name = "DBPhone";
            this.DBPhone.ReadOnly = true;
            this.DBPhone.Size = new System.Drawing.Size(282, 20);
            this.DBPhone.TabIndex = 19;
            // 
            // DBname
            // 
            this.DBname.Location = new System.Drawing.Point(158, 33);
            this.DBname.Name = "DBname";
            this.DBname.ReadOnly = true;
            this.DBname.Size = new System.Drawing.Size(282, 20);
            this.DBname.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "DeliveryBoy Information";
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
            this.panel4.Location = new System.Drawing.Point(3, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 147);
            this.panel4.TabIndex = 9;
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
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 167);
            this.panel3.TabIndex = 8;
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
            this.RCVname.Location = new System.Drawing.Point(161, 42);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Click on row to see details";
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.OrderHistoryGrid);
            this.Name = "OrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderHistory_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderHistory_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.OrderHistoryGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderHistoryGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox RCVPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RCVname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox Addressbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox AddInfo;
        private System.Windows.Forms.TextBox OrderType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DBPhone;
        private System.Windows.Forms.TextBox DBname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}