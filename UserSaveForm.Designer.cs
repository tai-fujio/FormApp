namespace WindowsFormApp
{
    partial class RegisterUser
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
            this.Plan = new System.Windows.Forms.GroupBox();
            this.Business = new System.Windows.Forms.RadioButton();
            this.Free = new System.Windows.Forms.RadioButton();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.EnableComboBox = new System.Windows.Forms.ComboBox();
            this.ButtomPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Plan.SuspendLayout();
            this.ButtomPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            // Plan
            // 
            this.Plan.Controls.Add(this.Business);
            this.Plan.Controls.Add(this.Free);
            this.Plan.Location = new System.Drawing.Point(36, 161);
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(373, 100);
            this.Plan.TabIndex = 5;
            this.Plan.TabStop = false;
            this.Plan.Text = "プラン";
            this.Plan.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Business
            // 
            this.Business.AutoSize = true;
            this.Business.Location = new System.Drawing.Point(191, 48);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(90, 22);
            this.Business.TabIndex = 7;
            this.Business.TabStop = true;
            this.Business.Text = "ビジネス";
            this.Business.UseVisualStyleBackColor = true;
            this.Business.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Free
            // 
            this.Free.AutoSize = true;
            this.Free.Location = new System.Drawing.Point(26, 48);
            this.Free.Name = "Free";
            this.Free.Size = new System.Drawing.Size(69, 22);
            this.Free.TabIndex = 6;
            this.Free.TabStop = true;
            this.Free.Text = "無料";
            this.Free.UseVisualStyleBackColor = true;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(33, 286);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(138, 18);
            this.NoteLabel.TabIndex = 6;
            this.NoteLabel.Text = "無制限で使えます";
            // 
            // EnableComboBox
            // 
            this.EnableComboBox.FormattingEnabled = true;
            this.EnableComboBox.Location = new System.Drawing.Point(36, 328);
            this.EnableComboBox.Name = "EnableComboBox";
            this.EnableComboBox.Size = new System.Drawing.Size(181, 26);
            this.EnableComboBox.TabIndex = 7;
            this.EnableComboBox.SelectedIndexChanged += new System.EventHandler(this.EnableComboBox_SelectedIndexChanged);
            // 
            // ButtomPanel
            // 
            this.ButtomPanel.Controls.Add(this.CloseButton);
            this.ButtomPanel.Controls.Add(this.SaveButton);
            this.ButtomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtomPanel.Location = new System.Drawing.Point(0, 368);
            this.ButtomPanel.Name = "ButtomPanel";
            this.ButtomPanel.Size = new System.Drawing.Size(800, 50);
            this.ButtomPanel.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CloseButton.Location = new System.Drawing.Point(131, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(124, 50);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(131, 50);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(181, 25);
            this.StatusLabel.Text = "toolStripStatusLabel1";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtomPanel);
            this.Controls.Add(this.EnableComboBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.Plan);
            this.Controls.Add(this.MailCheckBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.statusStrip1);
            this.Name = "RegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザ登録";
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.Plan.ResumeLayout(false);
            this.Plan.PerformLayout();
            this.ButtomPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.CheckBox MailCheckBox;
        private System.Windows.Forms.GroupBox Plan;
        private System.Windows.Forms.RadioButton Free;
        private System.Windows.Forms.RadioButton Business;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.ComboBox EnableComboBox;
        private System.Windows.Forms.Panel ButtomPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

