namespace Destination_Demo
{
    partial class PlaceOrder1
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
            this.pickcityvalid = new System.Windows.Forms.Label();
            this.pickaddval = new System.Windows.Forms.Label();
            this.Pcitylabel = new System.Windows.Forms.Label();
            this.PAddressLabel = new System.Windows.Forms.Label();
            this.PickUpCity = new System.Windows.Forms.TextBox();
            this.Pickupaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rcvcityvalid = new System.Windows.Forms.Label();
            this.Rcvaddval = new System.Windows.Forms.Label();
            this.RcityLabel = new System.Windows.Forms.Label();
            this.Rcbaddresslabel = new System.Windows.Forms.Label();
            this.RCVCity = new System.Windows.Forms.TextBox();
            this.RCVAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Order1Next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.pickcityvalid);
            this.panel2.Controls.Add(this.pickaddval);
            this.panel2.Controls.Add(this.Pcitylabel);
            this.panel2.Controls.Add(this.PAddressLabel);
            this.panel2.Controls.Add(this.PickUpCity);
            this.panel2.Controls.Add(this.Pickupaddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(28, 87);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(716, 219);
            this.panel2.TabIndex = 3;
            // 
            // pickcityvalid
            // 
            this.pickcityvalid.AutoSize = true;
            this.pickcityvalid.ForeColor = System.Drawing.Color.Red;
            this.pickcityvalid.Location = new System.Drawing.Point(130, 193);
            this.pickcityvalid.Name = "pickcityvalid";
            this.pickcityvalid.Size = new System.Drawing.Size(221, 13);
            this.pickcityvalid.TabIndex = 8;
            this.pickcityvalid.Text = "*PickUp City Can\'t be more than 14 character";
            this.pickcityvalid.Visible = false;
            // 
            // pickaddval
            // 
            this.pickaddval.AutoSize = true;
            this.pickaddval.ForeColor = System.Drawing.Color.Red;
            this.pickaddval.Location = new System.Drawing.Point(130, 123);
            this.pickaddval.Name = "pickaddval";
            this.pickaddval.Size = new System.Drawing.Size(241, 13);
            this.pickaddval.TabIndex = 7;
            this.pickaddval.Text = "*PickUp Address can\'t be more then 75 character";
            this.pickaddval.Visible = false;
            // 
            // Pcitylabel
            // 
            this.Pcitylabel.AutoSize = true;
            this.Pcitylabel.ForeColor = System.Drawing.Color.Red;
            this.Pcitylabel.Location = new System.Drawing.Point(438, 193);
            this.Pcitylabel.Name = "Pcitylabel";
            this.Pcitylabel.Size = new System.Drawing.Size(107, 13);
            this.Pcitylabel.TabIndex = 6;
            this.Pcitylabel.Text = "*PickUp City is empty";
            this.Pcitylabel.Visible = false;
            // 
            // PAddressLabel
            // 
            this.PAddressLabel.AutoSize = true;
            this.PAddressLabel.ForeColor = System.Drawing.Color.Red;
            this.PAddressLabel.Location = new System.Drawing.Point(438, 123);
            this.PAddressLabel.Name = "PAddressLabel";
            this.PAddressLabel.Size = new System.Drawing.Size(128, 13);
            this.PAddressLabel.TabIndex = 5;
            this.PAddressLabel.Text = "*PickUp Address is empty";
            this.PAddressLabel.Visible = false;
            // 
            // PickUpCity
            // 
            this.PickUpCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpCity.Location = new System.Drawing.Point(133, 155);
            this.PickUpCity.Multiline = true;
            this.PickUpCity.Name = "PickUpCity";
            this.PickUpCity.Size = new System.Drawing.Size(433, 26);
            this.PickUpCity.TabIndex = 4;
            this.PickUpCity.Leave += new System.EventHandler(this.PickUpCity_Leave);
            // 
            // Pickupaddress
            // 
            this.Pickupaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pickupaddress.Location = new System.Drawing.Point(133, 83);
            this.Pickupaddress.Multiline = true;
            this.Pickupaddress.Name = "Pickupaddress";
            this.Pickupaddress.Size = new System.Drawing.Size(433, 24);
            this.Pickupaddress.TabIndex = 3;
            this.Pickupaddress.Leave += new System.EventHandler(this.Pickupaddress_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Up Information";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.rcvcityvalid);
            this.panel3.Controls.Add(this.Rcvaddval);
            this.panel3.Controls.Add(this.RcityLabel);
            this.panel3.Controls.Add(this.Rcbaddresslabel);
            this.panel3.Controls.Add(this.RCVCity);
            this.panel3.Controls.Add(this.RCVAddress);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(28, 328);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(716, 219);
            this.panel3.TabIndex = 5;
            // 
            // rcvcityvalid
            // 
            this.rcvcityvalid.AutoSize = true;
            this.rcvcityvalid.ForeColor = System.Drawing.Color.Red;
            this.rcvcityvalid.Location = new System.Drawing.Point(130, 203);
            this.rcvcityvalid.Name = "rcvcityvalid";
            this.rcvcityvalid.Size = new System.Drawing.Size(235, 13);
            this.rcvcityvalid.TabIndex = 10;
            this.rcvcityvalid.Text = "*Receiever City Can\'t be more than 14 character";
            this.rcvcityvalid.Visible = false;
            // 
            // Rcvaddval
            // 
            this.Rcvaddval.AutoSize = true;
            this.Rcvaddval.ForeColor = System.Drawing.Color.Red;
            this.Rcvaddval.Location = new System.Drawing.Point(130, 125);
            this.Rcvaddval.Name = "Rcvaddval";
            this.Rcvaddval.Size = new System.Drawing.Size(254, 13);
            this.Rcvaddval.TabIndex = 9;
            this.Rcvaddval.Text = "*Receiever address can\'t be more then 75 character";
            this.Rcvaddval.Visible = false;
            // 
            // RcityLabel
            // 
            this.RcityLabel.AutoSize = true;
            this.RcityLabel.ForeColor = System.Drawing.Color.Red;
            this.RcityLabel.Location = new System.Drawing.Point(417, 203);
            this.RcityLabel.Name = "RcityLabel";
            this.RcityLabel.Size = new System.Drawing.Size(121, 13);
            this.RcityLabel.TabIndex = 8;
            this.RcityLabel.Text = "*Receiever City is empty";
            this.RcityLabel.Visible = false;
            // 
            // Rcbaddresslabel
            // 
            this.Rcbaddresslabel.AutoSize = true;
            this.Rcbaddresslabel.ForeColor = System.Drawing.Color.Red;
            this.Rcbaddresslabel.Location = new System.Drawing.Point(417, 125);
            this.Rcbaddresslabel.Name = "Rcbaddresslabel";
            this.Rcbaddresslabel.Size = new System.Drawing.Size(142, 13);
            this.Rcbaddresslabel.TabIndex = 7;
            this.Rcbaddresslabel.Text = "*Receiever Address is empty";
            this.Rcbaddresslabel.Visible = false;
            // 
            // RCVCity
            // 
            this.RCVCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCVCity.Location = new System.Drawing.Point(133, 155);
            this.RCVCity.Multiline = true;
            this.RCVCity.Name = "RCVCity";
            this.RCVCity.Size = new System.Drawing.Size(433, 26);
            this.RCVCity.TabIndex = 4;
            this.RCVCity.Leave += new System.EventHandler(this.RCVCity_Leave);
            // 
            // RCVAddress
            // 
            this.RCVAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCVAddress.Location = new System.Drawing.Point(133, 83);
            this.RCVAddress.Multiline = true;
            this.RCVAddress.Name = "RCVAddress";
            this.RCVAddress.Size = new System.Drawing.Size(433, 24);
            this.RCVAddress.TabIndex = 3;
            this.RCVAddress.Leave += new System.EventHandler(this.RCVAddress_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Receiver Address";
            // 
            // Order1Next
            // 
            this.Order1Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Order1Next.AutoSize = true;
            this.Order1Next.BackColor = System.Drawing.Color.Orange;
            this.Order1Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order1Next.Location = new System.Drawing.Point(290, 563);
            this.Order1Next.Name = "Order1Next";
            this.Order1Next.Size = new System.Drawing.Size(131, 36);
            this.Order1Next.TabIndex = 6;
            this.Order1Next.Text = "Next >";
            this.Order1Next.UseVisualStyleBackColor = false;
            this.Order1Next.Click += new System.EventHandler(this.Order1Next_Click);
            // 
            // PlaceOrder1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.Order1Next);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrder1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaceOrder1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderLogout;
        private System.Windows.Forms.Button OrderDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pickupaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PickUpCity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox RCVCity;
        private System.Windows.Forms.TextBox RCVAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Order1Next;
        private System.Windows.Forms.Label Pcitylabel;
        private System.Windows.Forms.Label PAddressLabel;
        private System.Windows.Forms.Label RcityLabel;
        private System.Windows.Forms.Label Rcbaddresslabel;
        private System.Windows.Forms.Label pickcityvalid;
        private System.Windows.Forms.Label pickaddval;
        private System.Windows.Forms.Label rcvcityvalid;
        private System.Windows.Forms.Label Rcvaddval;
    }
}