namespace Destination_Demo
{
    partial class DBlist
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
            this.dbgrid = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.catagory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dltbutton = new System.Windows.Forms.Button();
            this.slabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).BeginInit();
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
            this.panel1.TabIndex = 8;
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
            // dbgrid
            // 
            this.dbgrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dbgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrid.Location = new System.Drawing.Point(12, 158);
            this.dbgrid.Name = "dbgrid";
            this.dbgrid.ReadOnly = true;
            this.dbgrid.Size = new System.Drawing.Size(760, 452);
            this.dbgrid.TabIndex = 9;
            this.dbgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrid_CellClick);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(406, 107);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(175, 20);
            this.SearchBox.TabIndex = 10;
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // catagory
            // 
            this.catagory.FormattingEnabled = true;
            this.catagory.Items.AddRange(new object[] {
            "Name",
            "City",
            "ID",
            "AllList"});
            this.catagory.Location = new System.Drawing.Point(204, 106);
            this.catagory.Name = "catagory";
            this.catagory.Size = new System.Drawing.Size(149, 21);
            this.catagory.TabIndex = 11;
            this.catagory.SelectedIndexChanged += new System.EventHandler(this.catagory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search BY:";
            // 
            // dltbutton
            // 
            this.dltbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltbutton.Location = new System.Drawing.Point(666, 107);
            this.dltbutton.Name = "dltbutton";
            this.dltbutton.Size = new System.Drawing.Size(106, 27);
            this.dltbutton.TabIndex = 13;
            this.dltbutton.Text = "Delete";
            this.dltbutton.UseVisualStyleBackColor = true;
            this.dltbutton.Visible = false;
            this.dltbutton.Click += new System.EventHandler(this.dltbutton_Click);
            // 
            // slabel
            // 
            this.slabel.AutoSize = true;
            this.slabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slabel.ForeColor = System.Drawing.Color.Red;
            this.slabel.Location = new System.Drawing.Point(230, 142);
            this.slabel.Name = "slabel";
            this.slabel.Size = new System.Drawing.Size(123, 13);
            this.slabel.TabIndex = 14;
            this.slabel.Text = "*Select Catgory First";
            this.slabel.Visible = false;
            // 
            // DBlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.slabel);
            this.Controls.Add(this.dltbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catagory);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.dbgrid);
            this.Controls.Add(this.panel1);
            this.Name = "DBlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Boy List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBlist_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBlist_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderLogout;
        private System.Windows.Forms.Button OrderDash;
        private System.Windows.Forms.DataGridView dbgrid;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox catagory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dltbutton;
        private System.Windows.Forms.Label slabel;
    }
}