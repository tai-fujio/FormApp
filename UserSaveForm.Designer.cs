namespace WindowsFormApp
{
    partial class UserSaveForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.IdLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.MailCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(33, 34);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(24, 18);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(33, 116);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(105, 18);
            this.MailLabel.TabIndex = 1;
            this.MailLabel.Text = "メールアドレス";
            this.MailLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(152, 31);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(257, 25);
            this.IdTextBox.TabIndex = 2;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(152, 113);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(257, 25);
            this.MailTextBox.TabIndex = 3;
            // 
            // MailCheckBox
            // 
            this.MailCheckBox.AutoSize = true;
            this.MailCheckBox.Location = new System.Drawing.Point(36, 73);
            this.MailCheckBox.Name = "MailCheckBox";
            this.MailCheckBox.Size = new System.Drawing.Size(155, 22);
            this.MailCheckBox.TabIndex = 4;
            this.MailCheckBox.Text = "メールを送信する";
            this.MailCheckBox.UseVisualStyleBackColor = true;
            this.MailCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UserSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MailCheckBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "UserSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザ登録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.CheckBox MailCheckBox;
    }
}

