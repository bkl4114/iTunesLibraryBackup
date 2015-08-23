namespace iTunesLibraryBackup
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.backupButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.restorePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.restoreWarningLabel = new System.Windows.Forms.Label();
            this.restoreExplainLabel = new System.Windows.Forms.Label();
            this.lastBackupVariable = new System.Windows.Forms.Label();
            this.backupLabelStatic = new System.Windows.Forms.Label();
            this.backupPanel = new System.Windows.Forms.Panel();
            this.backupExplainLabel = new System.Windows.Forms.Label();
            this.driveStaticLabel = new System.Windows.Forms.Label();
            this.driveLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.restorePanel.SuspendLayout();
            this.backupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(23, 17);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(161, 23);
            this.backupButton.TabIndex = 0;
            this.backupButton.Text = "Create New Backup File";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(23, 15);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(119, 23);
            this.restoreButton.TabIndex = 1;
            this.restoreButton.Text = "Restore From Backup";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // restorePanel
            // 
            this.restorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restorePanel.Controls.Add(this.label1);
            this.restorePanel.Controls.Add(this.restoreWarningLabel);
            this.restorePanel.Controls.Add(this.restoreExplainLabel);
            this.restorePanel.Controls.Add(this.restoreButton);
            this.restorePanel.Location = new System.Drawing.Point(25, 81);
            this.restorePanel.Name = "restorePanel";
            this.restorePanel.Size = new System.Drawing.Size(711, 81);
            this.restorePanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click \"Create New Backup File\" to make a new backup before restoring an old one a" +
    "nd note the date and time.";
            // 
            // restoreWarningLabel
            // 
            this.restoreWarningLabel.AutoSize = true;
            this.restoreWarningLabel.Location = new System.Drawing.Point(149, 37);
            this.restoreWarningLabel.Name = "restoreWarningLabel";
            this.restoreWarningLabel.Size = new System.Drawing.Size(323, 13);
            this.restoreWarningLabel.TabIndex = 3;
            this.restoreWarningLabel.Text = "Caution:  This will completely remove the library currently in iTunes! ";
            // 
            // restoreExplainLabel
            // 
            this.restoreExplainLabel.AutoSize = true;
            this.restoreExplainLabel.Location = new System.Drawing.Point(148, 20);
            this.restoreExplainLabel.Name = "restoreExplainLabel";
            this.restoreExplainLabel.Size = new System.Drawing.Size(349, 13);
            this.restoreExplainLabel.TabIndex = 2;
            this.restoreExplainLabel.Text = "Restores the iTunes library to a previous saved version of your choosing.";
            this.restoreExplainLabel.Click += new System.EventHandler(this.restoreExplainLabel_Click);
            // 
            // lastBackupVariable
            // 
            this.lastBackupVariable.AutoSize = true;
            this.lastBackupVariable.Location = new System.Drawing.Point(98, 33);
            this.lastBackupVariable.Name = "lastBackupVariable";
            this.lastBackupVariable.Size = new System.Drawing.Size(35, 13);
            this.lastBackupVariable.TabIndex = 10;
            this.lastBackupVariable.Text = "label1";
            // 
            // backupLabelStatic
            // 
            this.backupLabelStatic.AutoSize = true;
            this.backupLabelStatic.Location = new System.Drawing.Point(22, 33);
            this.backupLabelStatic.Name = "backupLabelStatic";
            this.backupLabelStatic.Size = new System.Drawing.Size(69, 13);
            this.backupLabelStatic.TabIndex = 9;
            this.backupLabelStatic.Text = "Last backup:";
            // 
            // backupPanel
            // 
            this.backupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backupPanel.Controls.Add(this.backupExplainLabel);
            this.backupPanel.Controls.Add(this.backupButton);
            this.backupPanel.Location = new System.Drawing.Point(25, 168);
            this.backupPanel.Name = "backupPanel";
            this.backupPanel.Size = new System.Drawing.Size(711, 55);
            this.backupPanel.TabIndex = 12;
            // 
            // backupExplainLabel
            // 
            this.backupExplainLabel.AutoSize = true;
            this.backupExplainLabel.Location = new System.Drawing.Point(190, 22);
            this.backupExplainLabel.Name = "backupExplainLabel";
            this.backupExplainLabel.Size = new System.Drawing.Size(225, 13);
            this.backupExplainLabel.TabIndex = 1;
            this.backupExplainLabel.Text = "Creates a backup of the current iTunes library.";
            // 
            // driveStaticLabel
            // 
            this.driveStaticLabel.AutoSize = true;
            this.driveStaticLabel.Location = new System.Drawing.Point(22, 55);
            this.driveStaticLabel.Name = "driveStaticLabel";
            this.driveStaticLabel.Size = new System.Drawing.Size(94, 13);
            this.driveStaticLabel.TabIndex = 15;
            this.driveStaticLabel.Text = "Primary hard drive:";
            // 
            // driveLabel
            // 
            this.driveLabel.AutoSize = true;
            this.driveLabel.Location = new System.Drawing.Point(122, 55);
            this.driveLabel.Name = "driveLabel";
            this.driveLabel.Size = new System.Drawing.Size(56, 13);
            this.driveLabel.TabIndex = 14;
            this.driveLabel.Text = "driveLabel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 235);
            this.Controls.Add(this.restorePanel);
            this.Controls.Add(this.lastBackupVariable);
            this.Controls.Add(this.backupLabelStatic);
            this.Controls.Add(this.backupPanel);
            this.Controls.Add(this.driveStaticLabel);
            this.Controls.Add(this.driveLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "iTunes Library Backup";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.restorePanel.ResumeLayout(false);
            this.restorePanel.PerformLayout();
            this.backupPanel.ResumeLayout(false);
            this.backupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Panel restorePanel;
        private System.Windows.Forms.Label restoreExplainLabel;
        private System.Windows.Forms.Label lastBackupVariable;
        private System.Windows.Forms.Label backupLabelStatic;
        private System.Windows.Forms.Panel backupPanel;
        private System.Windows.Forms.Label backupExplainLabel;
        private System.Windows.Forms.Label driveStaticLabel;
        private System.Windows.Forms.Label driveLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label restoreWarningLabel;
        private System.Windows.Forms.Label label1;
    }
}

