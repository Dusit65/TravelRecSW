namespace TravelRecSW
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTravellerEmail = new System.Windows.Forms.TextBox();
            this.tbTravellerPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbToFrmRegister = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Travel Rec SW V.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(76, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อผู้ใช้";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(76, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "รหัสผ่าน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTravellerEmail
            // 
            this.tbTravellerEmail.Location = new System.Drawing.Point(76, 338);
            this.tbTravellerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbTravellerEmail.Name = "tbTravellerEmail";
            this.tbTravellerEmail.Size = new System.Drawing.Size(249, 22);
            this.tbTravellerEmail.TabIndex = 4;
            this.tbTravellerEmail.Text = "D@gmail.com";
            // 
            // tbTravellerPassword
            // 
            this.tbTravellerPassword.Location = new System.Drawing.Point(76, 401);
            this.tbTravellerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbTravellerPassword.Name = "tbTravellerPassword";
            this.tbTravellerPassword.PasswordChar = '*';
            this.tbTravellerPassword.Size = new System.Drawing.Size(249, 22);
            this.tbTravellerPassword.TabIndex = 5;
            this.tbTravellerPassword.Text = "123456";
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(76, 447);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(251, 42);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "เข้าใช้งานระบบ";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbToFrmRegister
            // 
            this.lbToFrmRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToFrmRegister.ForeColor = System.Drawing.Color.Blue;
            this.lbToFrmRegister.Location = new System.Drawing.Point(72, 506);
            this.lbToFrmRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbToFrmRegister.Name = "lbToFrmRegister";
            this.lbToFrmRegister.Size = new System.Drawing.Size(255, 30);
            this.lbToFrmRegister.TabIndex = 7;
            this.lbToFrmRegister.Text = "ลงทะเบียนผู้ใช้งานใหม่";
            this.lbToFrmRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbToFrmRegister.Click += new System.EventHandler(this.lbToFrmRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelRecSW.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(124, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 572);
            this.Controls.Add(this.lbToFrmRegister);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbTravellerPassword);
            this.Controls.Add(this.tbTravellerEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เข้าใช้งานระบบ - Travel Rec SW V.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTravellerEmail;
        private System.Windows.Forms.TextBox tbTravellerPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbToFrmRegister;
    }
}

