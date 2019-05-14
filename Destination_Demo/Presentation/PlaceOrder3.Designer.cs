namespace Destination_Demo
{
    partial class PlaceOrder3
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
            this.Addinfo = new System.Windows.Forms.RichTextBox();
            this.PaymentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Order2Next = new System.Windows.Forms.Button();
            this.Order2Back = new System.Windows.Forms.Button();
            this.inavlid = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.inavlid);
            this.panel2.Controls.Add(this.Addinfo);
            this.panel2.Controls.Add(this.PaymentType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(29, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 314);
            this.panel2.TabIndex = 5;
            // 
            // Addinfo
            // 
            this.Addinfo.Location = new System.Drawing.Point(266, 193);
            this.Addinfo.Name = "Addinfo";
            this.Addinfo.Size = new System.Drawing.Size(310, 84);
            this.Addinfo.TabIndex = 8;
            this.Addinfo.Text = "";
            // 
            // PaymentType
            // 
            this.PaymentType.FormattingEnabled = true;
            this.PaymentType.Items.AddRange(new object[] {
            "Cash On PickUp",
            "Cash From Receiver"});
            this.PaymentType.Location = new System.Drawing.Point(266, 105);
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Size = new System.Drawing.Size(310, 21);
            this.PaymentType.TabIndex = 7;
            this.PaymentType.Text = "Cash On PickUp";
            this.PaymentType.Leave += new System.EventHandler(this.PaymentType_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Additional Information\r\n(Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Information";
            // 
            // Order2Next
            // 
            this.Order2Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Order2Next.AutoSize = true;
            this.Order2Next.BackColor = System.Drawing.Color.Green;
            this.Order2Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order2Next.Location = new System.Drawing.Point(619, 534);
            this.Order2Next.Name = "Order2Next";
            this.Order2Next.Size = new System.Drawing.Size(131, 36);
            this.Order2Next.TabIndex = 11;
            this.Order2Next.Text = "Confirm Order";
            this.Order2Next.UseVisualStyleBackColor = false;
            this.Order2Next.Click += new System.EventHandler(this.Order2Next_Click);
            // 
            // Order2Back
            // 
            this.Order2Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Order2Back.AutoSize = true;
            this.Order2Back.BackColor = System.Drawing.Color.Red;
            this.Order2Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order2Back.Location = new System.Drawing.Point(29, 534);
            this.Order2Back.Name = "Order2Back";
            this.Order2Back.Size = new System.Drawing.Size(131, 36);
            this.Order2Back.TabIndex = 12;
            this.Order2Back.Text = "< Back ";
            this.Order2Back.UseVisualStyleBackColor = false;
            this.Order2Back.Click += new System.EventHandler(this.Order2Back_Click);
            // 
            // inavlid
            // 
            this.inavlid.AutoSize = true;
            this.inavlid.ForeColor = System.Drawing.Color.Red;
            this.inavlid.Location = new System.Drawing.Point(263, 144);
            this.inavlid.Name = "inavlid";
            this.inavlid.Size = new System.Drawing.Size(134, 13);
            this.inavlid.TabIndex = 10;
            this.inavlid.Text = "* Payment Method Invalid!!";
            this.inavlid.Visible = false;
            // 
            // PlaceOrder3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.Order2Back);
            this.Controls.Add(this.Order2Next);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrder3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaceOrder3_FormClosing);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Addinfo;
        private System.Windows.Forms.ComboBox PaymentType;
        private System.Windows.Forms.Button Order2Next;
        private System.Windows.Forms.Button Order2Back;
        private System.Windows.Forms.Label inavlid;
    }
}