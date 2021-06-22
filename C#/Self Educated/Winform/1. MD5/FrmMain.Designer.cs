namespace _1.MD5
{
    partial class FrmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDecryptFirst = new System.Windows.Forms.TextBox();
            this.lblDecryptFirst = new System.Windows.Forms.Label();
            this.lblDecryptOptions = new System.Windows.Forms.Label();
            this.lblEncryptFirst = new System.Windows.Forms.Label();
            this.txtEncryptFirst = new System.Windows.Forms.TextBox();
            this.lblEncrypt2nd = new System.Windows.Forms.Label();
            this.txtDecrypt2nd = new System.Windows.Forms.TextBox();
            this.lblEncryptOption = new System.Windows.Forms.Label();
            this.lblDecrypt2nd = new System.Windows.Forms.Label();
            this.txtEncrypt2nd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(128, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MD5 Winform Program";
            // 
            // txtDecryptFirst
            // 
            this.txtDecryptFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptFirst.Location = new System.Drawing.Point(133, 89);
            this.txtDecryptFirst.Multiline = true;
            this.txtDecryptFirst.Name = "txtDecryptFirst";
            this.txtDecryptFirst.Size = new System.Drawing.Size(373, 27);
            this.txtDecryptFirst.TabIndex = 1;
            this.txtDecryptFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDecryptFirst_KeyDown);
            // 
            // lblDecryptFirst
            // 
            this.lblDecryptFirst.AutoSize = true;
            this.lblDecryptFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecryptFirst.Location = new System.Drawing.Point(68, 90);
            this.lblDecryptFirst.Name = "lblDecryptFirst";
            this.lblDecryptFirst.Size = new System.Drawing.Size(59, 18);
            this.lblDecryptFirst.TabIndex = 2;
            this.lblDecryptFirst.Text = "Decrypt";
            // 
            // lblDecryptOptions
            // 
            this.lblDecryptOptions.AutoSize = true;
            this.lblDecryptOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecryptOptions.Location = new System.Drawing.Point(12, 57);
            this.lblDecryptOptions.Name = "lblDecryptOptions";
            this.lblDecryptOptions.Size = new System.Drawing.Size(139, 20);
            this.lblDecryptOptions.TabIndex = 3;
            this.lblDecryptOptions.Text = "Decrypt Option: ";
            // 
            // lblEncryptFirst
            // 
            this.lblEncryptFirst.AutoSize = true;
            this.lblEncryptFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptFirst.Location = new System.Drawing.Point(68, 132);
            this.lblEncryptFirst.Name = "lblEncryptFirst";
            this.lblEncryptFirst.Size = new System.Drawing.Size(58, 18);
            this.lblEncryptFirst.TabIndex = 5;
            this.lblEncryptFirst.Text = "Encrypt";
            // 
            // txtEncryptFirst
            // 
            this.txtEncryptFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEncryptFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptFirst.Location = new System.Drawing.Point(133, 131);
            this.txtEncryptFirst.Multiline = true;
            this.txtEncryptFirst.Name = "txtEncryptFirst";
            this.txtEncryptFirst.Size = new System.Drawing.Size(373, 27);
            this.txtEncryptFirst.TabIndex = 4;
            // 
            // lblEncrypt2nd
            // 
            this.lblEncrypt2nd.AutoSize = true;
            this.lblEncrypt2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypt2nd.Location = new System.Drawing.Point(69, 225);
            this.lblEncrypt2nd.Name = "lblEncrypt2nd";
            this.lblEncrypt2nd.Size = new System.Drawing.Size(58, 18);
            this.lblEncrypt2nd.TabIndex = 10;
            this.lblEncrypt2nd.Text = "Encrypt";
            // 
            // txtDecrypt2nd
            // 
            this.txtDecrypt2nd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDecrypt2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecrypt2nd.Location = new System.Drawing.Point(133, 266);
            this.txtDecrypt2nd.Multiline = true;
            this.txtDecrypt2nd.Name = "txtDecrypt2nd";
            this.txtDecrypt2nd.Size = new System.Drawing.Size(373, 27);
            this.txtDecrypt2nd.TabIndex = 9;
            // 
            // lblEncryptOption
            // 
            this.lblEncryptOption.AutoSize = true;
            this.lblEncryptOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptOption.Location = new System.Drawing.Point(12, 192);
            this.lblEncryptOption.Name = "lblEncryptOption";
            this.lblEncryptOption.Size = new System.Drawing.Size(138, 20);
            this.lblEncryptOption.TabIndex = 8;
            this.lblEncryptOption.Text = "Encrypt Option: ";
            // 
            // lblDecrypt2nd
            // 
            this.lblDecrypt2nd.AutoSize = true;
            this.lblDecrypt2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypt2nd.Location = new System.Drawing.Point(68, 266);
            this.lblDecrypt2nd.Name = "lblDecrypt2nd";
            this.lblDecrypt2nd.Size = new System.Drawing.Size(59, 18);
            this.lblDecrypt2nd.TabIndex = 7;
            this.lblDecrypt2nd.Text = "Decrypt";
            // 
            // txtEncrypt2nd
            // 
            this.txtEncrypt2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrypt2nd.Location = new System.Drawing.Point(133, 224);
            this.txtEncrypt2nd.Multiline = true;
            this.txtEncrypt2nd.Name = "txtEncrypt2nd";
            this.txtEncrypt2nd.Size = new System.Drawing.Size(373, 27);
            this.txtEncrypt2nd.TabIndex = 6;
            this.txtEncrypt2nd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEncrypt2nd_KeyDown);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.lblEncrypt2nd);
            this.Controls.Add(this.txtDecrypt2nd);
            this.Controls.Add(this.lblEncryptOption);
            this.Controls.Add(this.lblDecrypt2nd);
            this.Controls.Add(this.txtEncrypt2nd);
            this.Controls.Add(this.lblEncryptFirst);
            this.Controls.Add(this.txtEncryptFirst);
            this.Controls.Add(this.lblDecryptOptions);
            this.Controls.Add(this.lblDecryptFirst);
            this.Controls.Add(this.txtDecryptFirst);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMain";
            this.Text = "MD5 Demo Tutorials";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDecryptFirst;
        private System.Windows.Forms.Label lblDecryptFirst;
        private System.Windows.Forms.Label lblDecryptOptions;
        private System.Windows.Forms.Label lblEncryptFirst;
        private System.Windows.Forms.TextBox txtEncryptFirst;
        private System.Windows.Forms.Label lblEncrypt2nd;
        private System.Windows.Forms.TextBox txtDecrypt2nd;
        private System.Windows.Forms.Label lblEncryptOption;
        private System.Windows.Forms.Label lblDecrypt2nd;
        private System.Windows.Forms.TextBox txtEncrypt2nd;
    }
}

