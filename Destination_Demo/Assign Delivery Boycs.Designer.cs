namespace Destination_Demo
{
    partial class Assign_Delivery_Boy
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
            this.DeliveryBoyGrid = new System.Windows.Forms.DataGridView();
            this.catagory = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderLogout = new System.Windows.Forms.Button();
            this.OrderDash = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.AssignBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryBoyGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeliveryBoyGrid
            // 
            this.DeliveryBoyGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliveryBoyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryBoyGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliveryBoyGrid.Location = new System.Drawing.Point(12, 212);
            this.DeliveryBoyGrid.Name = "DeliveryBoyGrid";
            this.DeliveryBoyGrid.Size = new System.Drawing.Size(760, 365);
            this.DeliveryBoyGrid.TabIndex = 0;
            this.DeliveryBoyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryBoyGrid_CellClick);
            // 
            // catagory
            // 
            this.catagory.FormattingEnabled = true;
            this.catagory.Items.AddRange(new object[] {
            "City",
            "All List"});
            this.catagory.Location = new System.Drawing.Point(281, 143);
            this.catagory.Name = "catagory";
            this.catagory.Size = new System.Drawing.Size(151, 21);
            this.catagory.TabIndex = 1;
            this.catagory.SelectedIndexChanged += new System.EventHandler(this.catagory_SelectedIndexChanged);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(324, 167);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(108, 13);
            this.Error.TabIndex = 4;
            this.Error.Text = "*Select Catagory First";
            this.Error.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search BY:";
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(253, 33);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 133);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(253, 33);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(460, 145);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(184, 20);
            this.searchbox.TabIndex = 2;
            this.searchbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchbox_KeyUp);
            // 
            // AssignBtn
            // 
            this.AssignBtn.Location = new System.Drawing.Point(678, 145);
            this.AssignBtn.Name = "AssignBtn";
            this.AssignBtn.Size = new System.Drawing.Size(94, 23);
            this.AssignBtn.TabIndex = 9;
            this.AssignBtn.Text = "Assign";
            this.AssignBtn.UseVisualStyleBackColor = true;
            this.AssignBtn.Visible = false;
            this.AssignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            // 
            // Assign_Delivery_Boy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.AssignBtn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.catagory);
            this.Controls.Add(this.DeliveryBoyGrid);
            this.Name = "Assign_Delivery_Boy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign DeliveryBoy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Assign_Delivery_Boycs_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Assign_Delivery_Boycs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryBoyGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DeliveryBoyGrid;
        private System.Windows.Forms.ComboBox catagory;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderLogout;
        private System.Windows.Forms.Button OrderDash;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button AssignBtn;
    }
}