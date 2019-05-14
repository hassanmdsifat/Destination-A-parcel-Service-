namespace Destination_Demo
{
    partial class SignUp
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
            this.SignUpBack = new System.Windows.Forms.Button();
            this.SignUpUser = new System.Windows.Forms.Button();
            this.SignUpDelveryboy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.SignUpBack);
            this.panel1.Controls.Add(this.SignUpUser);
            this.panel1.Controls.Add(this.SignUpDelveryboy);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 611);
            this.panel1.TabIndex = 0;
            // 
            // SignUpBack
            // 
            this.SignUpBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBack.Location = new System.Drawing.Point(12, 542);
            this.SignUpBack.Name = "SignUpBack";
            this.SignUpBack.Size = new System.Drawing.Size(106, 32);
            this.SignUpBack.TabIndex = 4;
            this.SignUpBack.Text = "< Back";
            this.SignUpBack.UseVisualStyleBackColor = true;
            this.SignUpBack.Click += new System.EventHandler(this.SignUpBack_Click);
            // 
            // SignUpUser
            // 
            this.SignUpUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignUpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpUser.Location = new System.Drawing.Point(325, 320);
            this.SignUpUser.Name = "SignUpUser";
            this.SignUpUser.Size = new System.Drawing.Size(239, 104);
            this.SignUpUser.TabIndex = 3;
            this.SignUpUser.Text = "Sign Up as a User";
            this.SignUpUser.UseVisualStyleBackColor = false;
            this.SignUpUser.Click += new System.EventHandler(this.SignUpUser_Click);
            // 
            // SignUpDelveryboy
            // 
            this.SignUpDelveryboy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpDelveryboy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SignUpDelveryboy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpDelveryboy.Location = new System.Drawing.Point(325, 137);
            this.SignUpDelveryboy.Name = "SignUpDelveryboy";
            this.SignUpDelveryboy.Size = new System.Drawing.Size(239, 104);
            this.SignUpDelveryboy.TabIndex = 2;
            this.SignUpDelveryboy.Text = "Sign Up as a Delivery Boy";
            this.SignUpDelveryboy.UseVisualStyleBackColor = false;
            this.SignUpDelveryboy.Click += new System.EventHandler(this.SignUpDelveryboy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Destination_Demo.Properties.Resources.img_2689291;
            this.pictureBox2.Location = new System.Drawing.Point(111, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Destination_Demo.Properties.Resources._6d79a9a0f7baac6f913a6306b3246240;
            this.pictureBox1.Location = new System.Drawing.Point(111, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SignUpUser;
        private System.Windows.Forms.Button SignUpDelveryboy;
        private System.Windows.Forms.Button SignUpBack;
    }
}