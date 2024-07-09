namespace ESign_Desktop
{
    partial class frmMain
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
            this.cbbList_Cert = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPathChooseSign = new System.Windows.Forms.Button();
            this.txtPathSign = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImgLogo = new System.Windows.Forms.TextBox();
            this.btnImgLogo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImgSignature = new System.Windows.Forms.TextBox();
            this.btnImgSignature = new System.Windows.Forms.Button();
            this.txtContentSign = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbList_Cert
            // 
            this.cbbList_Cert.FormattingEnabled = true;
            this.cbbList_Cert.Location = new System.Drawing.Point(91, 37);
            this.cbbList_Cert.Name = "cbbList_Cert";
            this.cbbList_Cert.Size = new System.Drawing.Size(292, 21);
            this.cbbList_Cert.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn chữ ký số";
            // 
            // btnPathChooseSign
            // 
            this.btnPathChooseSign.Enabled = false;
            this.btnPathChooseSign.Location = new System.Drawing.Point(389, 62);
            this.btnPathChooseSign.Name = "btnPathChooseSign";
            this.btnPathChooseSign.Size = new System.Drawing.Size(97, 23);
            this.btnPathChooseSign.TabIndex = 2;
            this.btnPathChooseSign.Text = "Chọn File để ký";
            this.btnPathChooseSign.UseVisualStyleBackColor = true;
            this.btnPathChooseSign.Click += new System.EventHandler(this.btnPathChooseSign_Click);
            // 
            // txtPathSign
            // 
            this.txtPathSign.Location = new System.Drawing.Point(91, 64);
            this.txtPathSign.Name = "txtPathSign";
            this.txtPathSign.Size = new System.Drawing.Size(292, 20);
            this.txtPathSign.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đường dẫn file";
            // 
            // btnSign
            // 
            this.btnSign.Enabled = false;
            this.btnSign.Location = new System.Drawing.Point(411, 415);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "Ký";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(330, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(9, 420);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(35, 13);
            this.lblNotification.TabIndex = 7;
            this.lblNotification.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File ảnh logo";
            // 
            // txtImgLogo
            // 
            this.txtImgLogo.Location = new System.Drawing.Point(91, 91);
            this.txtImgLogo.Name = "txtImgLogo";
            this.txtImgLogo.Size = new System.Drawing.Size(292, 20);
            this.txtImgLogo.TabIndex = 9;
            this.txtImgLogo.Text = "Samples/logo.png";
            // 
            // btnImgLogo
            // 
            this.btnImgLogo.Enabled = false;
            this.btnImgLogo.Location = new System.Drawing.Point(389, 89);
            this.btnImgLogo.Name = "btnImgLogo";
            this.btnImgLogo.Size = new System.Drawing.Size(97, 23);
            this.btnImgLogo.TabIndex = 8;
            this.btnImgLogo.Text = "Chọn ảnh logo";
            this.btnImgLogo.UseVisualStyleBackColor = true;
            this.btnImgLogo.Click += new System.EventHandler(this.btnImgLogo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "File ảnh cks";
            // 
            // txtImgSignature
            // 
            this.txtImgSignature.Location = new System.Drawing.Point(91, 117);
            this.txtImgSignature.Name = "txtImgSignature";
            this.txtImgSignature.Size = new System.Drawing.Size(292, 20);
            this.txtImgSignature.TabIndex = 12;
            this.txtImgSignature.Text = "Samples/signature.png";
            // 
            // btnImgSignature
            // 
            this.btnImgSignature.Enabled = false;
            this.btnImgSignature.Location = new System.Drawing.Point(389, 115);
            this.btnImgSignature.Name = "btnImgSignature";
            this.btnImgSignature.Size = new System.Drawing.Size(97, 23);
            this.btnImgSignature.TabIndex = 11;
            this.btnImgSignature.Text = "Chọn ảnh cks";
            this.btnImgSignature.UseVisualStyleBackColor = true;
            this.btnImgSignature.Click += new System.EventHandler(this.btnImgSignature_Click);
            // 
            // txtContentSign
            // 
            this.txtContentSign.Location = new System.Drawing.Point(91, 143);
            this.txtContentSign.Name = "txtContentSign";
            this.txtContentSign.Size = new System.Drawing.Size(292, 20);
            this.txtContentSign.TabIndex = 14;
            this.txtContentSign.Text = "Test ký số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nội dung cks";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContentSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImgSignature);
            this.Controls.Add(this.btnImgSignature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImgLogo);
            this.Controls.Add(this.btnImgLogo);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathSign);
            this.Controls.Add(this.btnPathChooseSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbList_Cert);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbList_Cert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPathChooseSign;
        private System.Windows.Forms.TextBox txtPathSign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImgLogo;
        private System.Windows.Forms.Button btnImgLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImgSignature;
        private System.Windows.Forms.Button btnImgSignature;
        private System.Windows.Forms.TextBox txtContentSign;
        private System.Windows.Forms.Label label5;
    }
}