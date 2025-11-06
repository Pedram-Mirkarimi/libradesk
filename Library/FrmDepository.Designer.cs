namespace Library
{
    partial class FrmDepository
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepository));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveDepository = new System.Windows.Forms.Button();
            this.btnDateNow = new System.Windows.Forms.Button();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtDateNow = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReturn.Location = new System.Drawing.Point(339, 123);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "تاریخ برگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSaveDepository
            // 
            this.btnSaveDepository.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveDepository.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDepository.Image")));
            this.btnSaveDepository.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDepository.Location = new System.Drawing.Point(163, 194);
            this.btnSaveDepository.Name = "btnSaveDepository";
            this.btnSaveDepository.Size = new System.Drawing.Size(170, 55);
            this.btnSaveDepository.TabIndex = 14;
            this.btnSaveDepository.Text = "ثبت";
            this.btnSaveDepository.UseVisualStyleBackColor = true;
            this.btnSaveDepository.Click += new System.EventHandler(this.btnSaveDepository_Click);
            // 
            // btnDateNow
            // 
            this.btnDateNow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDateNow.Location = new System.Drawing.Point(339, 84);
            this.btnDateNow.Name = "btnDateNow";
            this.btnDateNow.Size = new System.Drawing.Size(75, 28);
            this.btnDateNow.TabIndex = 10;
            this.btnDateNow.Text = "تاریخ امروز";
            this.btnDateNow.UseVisualStyleBackColor = true;
            this.btnDateNow.Click += new System.EventHandler(this.btnDateNow_Click);
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtReturnDate.Location = new System.Drawing.Point(126, 123);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReturnDate.Size = new System.Drawing.Size(207, 28);
            this.txtReturnDate.TabIndex = 15;
            this.txtReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateNow
            // 
            this.txtDateNow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDateNow.Location = new System.Drawing.Point(126, 84);
            this.txtDateNow.Name = "txtDateNow";
            this.txtDateNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateNow.Size = new System.Drawing.Size(207, 28);
            this.txtDateNow.TabIndex = 16;
            this.txtDateNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(126, 48);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserId.Size = new System.Drawing.Size(288, 25);
            this.txtUserId.TabIndex = 8;
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserId.Leave += new System.EventHandler(this.txtUserId_Leave);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(126, 12);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBookId.Size = new System.Drawing.Size(288, 25);
            this.txtBookId.TabIndex = 6;
            this.txtBookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBookId.Leave += new System.EventHandler(this.txtBookId_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(35, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "تاریخ برگشت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(35, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "تاریخ امانت:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "شناسه کاربر:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "شناسه کتاب:";
            // 
            // FrmDepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSaveDepository);
            this.Controls.Add(this.btnDateNow);
            this.Controls.Add(this.txtReturnDate);
            this.Controls.Add(this.txtDateNow);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDepository";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "امانت";
            this.Load += new System.EventHandler(this.FrmDepository_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSaveDepository;
        private System.Windows.Forms.Button btnDateNow;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtDateNow;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}