namespace Destination_Demo
{
    partial class RequestForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Request = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cmpltbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RCVName = new System.Windows.Forms.TextBox();
            this.RCVPhone = new System.Windows.Forms.TextBox();
            this.RCVLoc = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RCVLoc);
            this.panel1.Controls.Add(this.RCVPhone);
            this.panel1.Controls.Add(this.RCVName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 205);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Request);
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 233);
            this.panel2.TabIndex = 1;
            // 
            // Request
            // 
            this.Request.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Request.Location = new System.Drawing.Point(0, 3);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(757, 227);
            this.Request.TabIndex = 0;
            this.Request.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Request_CellClick);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 33);
            this.panel5.TabIndex = 8;
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
            // Cmpltbtn
            // 
            this.Cmpltbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmpltbtn.Location = new System.Drawing.Point(679, 552);
            this.Cmpltbtn.Name = "Cmpltbtn";
            this.Cmpltbtn.Size = new System.Drawing.Size(93, 26);
            this.Cmpltbtn.TabIndex = 9;
            this.Cmpltbtn.Text = "Complete";
            this.Cmpltbtn.UseVisualStyleBackColor = true;
            this.Cmpltbtn.Visible = false;
            this.Cmpltbtn.Click += new System.EventHandler(this.Cmpltbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receiever Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiever Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receiever Address";
            // 
            // RCVName
            // 
            this.RCVName.Location = new System.Drawing.Point(243, 11);
            this.RCVName.Name = "RCVName";
            this.RCVName.ReadOnly = true;
            this.RCVName.Size = new System.Drawing.Size(197, 20);
            this.RCVName.TabIndex = 3;
            // 
            // RCVPhone
            // 
            this.RCVPhone.Location = new System.Drawing.Point(243, 65);
            this.RCVPhone.Name = "RCVPhone";
            this.RCVPhone.ReadOnly = true;
            this.RCVPhone.Size = new System.Drawing.Size(197, 20);
            this.RCVPhone.TabIndex = 4;
            // 
            // RCVLoc
            // 
            this.RCVLoc.Location = new System.Drawing.Point(243, 106);
            this.RCVLoc.Name = "RCVLoc";
            this.RCVLoc.ReadOnly = true;
            this.RCVLoc.Size = new System.Drawing.Size(197, 82);
            this.RCVLoc.TabIndex = 5;
            this.RCVLoc.Text = "";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.Cmpltbtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequestForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RequestForm_FormClosed);
            this.Shown += new System.EventHandler(this.RequestForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Request)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Request;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Cmpltbtn;
        private System.Windows.Forms.RichTextBox RCVLoc;
        private System.Windows.Forms.TextBox RCVPhone;
        private System.Windows.Forms.TextBox RCVName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}