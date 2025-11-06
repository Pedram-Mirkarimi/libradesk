namespace Library
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrevPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveUserPass = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnReturnBackup = new System.Windows.Forms.Button();
            this.txtLastDateOfBackup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(347, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "رمز عبور قبلی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(342, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "رمز عبور جدید:";
            // 
            // txtPrevPassword
            // 
            this.txtPrevPassword.Location = new System.Drawing.Point(171, 48);
            this.txtPrevPassword.Name = "txtPrevPassword";
            this.txtPrevPassword.Size = new System.Drawing.Size(239, 25);
            this.txtPrevPassword.TabIndex = 6;
            this.txtPrevPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(171, 81);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(239, 25);
            this.txtNewPassword.TabIndex = 7;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveUserPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 194);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تغییر رمز عبور";
            // 
            // btnSaveUserPass
            // 
            this.btnSaveUserPass.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveUserPass.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUserPass.Image")));
            this.btnSaveUserPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUserPass.Location = new System.Drawing.Point(95, 133);
            this.btnSaveUserPass.Name = "btnSaveUserPass";
            this.btnSaveUserPass.Size = new System.Drawing.Size(170, 55);
            this.btnSaveUserPass.TabIndex = 9;
            this.btnSaveUserPass.Text = "ثبت";
            this.btnSaveUserPass.UseVisualStyleBackColor = true;
            this.btnSaveUserPass.Click += new System.EventHandler(this.btnSaveUserPass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBackup);
            this.groupBox2.Controls.Add(this.btnReturnBackup);
            this.groupBox2.Controls.Add(this.txtLastDateOfBackup);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 187);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "پایگاه داده";
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(226, 126);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(170, 55);
            this.btnBackup.TabIndex = 10;
            this.btnBackup.Text = "پشتیبان گیری";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnReturnBackup
            // 
            this.btnReturnBackup.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReturnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBackup.Image")));
            this.btnReturnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBackup.Location = new System.Drawing.Point(50, 126);
            this.btnReturnBackup.Name = "btnReturnBackup";
            this.btnReturnBackup.Size = new System.Drawing.Size(170, 55);
            this.btnReturnBackup.TabIndex = 11;
            this.btnReturnBackup.Text = "بازگردانی";
            this.btnReturnBackup.UseVisualStyleBackColor = true;
            this.btnReturnBackup.Click += new System.EventHandler(this.btnReturnBackup_Click);
            // 
            // txtLastDateOfBackup
            // 
            this.txtLastDateOfBackup.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLastDateOfBackup.Location = new System.Drawing.Point(62, 50);
            this.txtLastDateOfBackup.Name = "txtLastDateOfBackup";
            this.txtLastDateOfBackup.ReadOnly = true;
            this.txtLastDateOfBackup.Size = new System.Drawing.Size(239, 31);
            this.txtLastDateOfBackup.TabIndex = 1;
            this.txtLastDateOfBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(310, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاریخ آخرین پشتیبان:";
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtPrevPassword);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrevPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveUserPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLastDateOfBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnReturnBackup;
    }
}