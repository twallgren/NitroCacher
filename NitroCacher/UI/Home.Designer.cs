﻿namespace NitroCacher.UI
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProfiles = new System.Windows.Forms.Label();
            this.lstProfiles = new System.Windows.Forms.ComboBox();
            this.lnkAddNewProfile = new System.Windows.Forms.LinkLabel();
            this.lstRules = new System.Windows.Forms.CheckedListBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.lnkAddNewRule = new System.Windows.Forms.LinkLabel();
            this.lnkEditRule = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProfleNRules = new System.Windows.Forms.Panel();
            this.lnkRemoveProfile = new System.Windows.Forms.LinkLabel();
            this.lnkClearAllCache = new System.Windows.Forms.LinkLabel();
            this.lnkClearCacheProfile = new System.Windows.Forms.LinkLabel();
            this.lnkClearCacheForRule = new System.Windows.Forms.LinkLabel();
            this.lnkRemoveRule = new System.Windows.Forms.LinkLabel();
            this.pnlRuleSummary = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.chkReplayDuration = new System.Windows.Forms.CheckBox();
            this.pnlProfleNRules.SuspendLayout();
            this.pnlRuleSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfiles
            // 
            this.lblProfiles.AutoSize = true;
            this.lblProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfiles.Location = new System.Drawing.Point(23, 31);
            this.lblProfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(124, 20);
            this.lblProfiles.TabIndex = 0;
            this.lblProfiles.Text = "Choose Profile:";
            // 
            // lstProfiles
            // 
            this.lstProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.Location = new System.Drawing.Point(27, 58);
            this.lstProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(577, 24);
            this.lstProfiles.TabIndex = 1;
            this.lstProfiles.SelectedIndexChanged += new System.EventHandler(this.lstProfiles_SelectedIndexChanged);
            // 
            // lnkAddNewProfile
            // 
            this.lnkAddNewProfile.AutoSize = true;
            this.lnkAddNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddNewProfile.Location = new System.Drawing.Point(201, 33);
            this.lnkAddNewProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkAddNewProfile.Name = "lnkAddNewProfile";
            this.lnkAddNewProfile.Size = new System.Drawing.Size(113, 18);
            this.lnkAddNewProfile.TabIndex = 2;
            this.lnkAddNewProfile.TabStop = true;
            this.lnkAddNewProfile.Text = "Add New Profile";
            this.lnkAddNewProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAddNewProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNewProfile_LinkClicked);
            // 
            // lstRules
            // 
            this.lstRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRules.FormattingEnabled = true;
            this.lstRules.Location = new System.Drawing.Point(27, 142);
            this.lstRules.Margin = new System.Windows.Forms.Padding(4);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(577, 346);
            this.lstRules.TabIndex = 3;
            this.lstRules.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstRules_ItemCheck);
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(23, 102);
            this.lblRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(57, 20);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = "Rules:";
            // 
            // lnkAddNewRule
            // 
            this.lnkAddNewRule.AutoSize = true;
            this.lnkAddNewRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddNewRule.Location = new System.Drawing.Point(23, 512);
            this.lnkAddNewRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkAddNewRule.Name = "lnkAddNewRule";
            this.lnkAddNewRule.Size = new System.Drawing.Size(67, 18);
            this.lnkAddNewRule.TabIndex = 2;
            this.lnkAddNewRule.TabStop = true;
            this.lnkAddNewRule.Text = "Add Rule";
            this.lnkAddNewRule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAddNewRule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNewRule_LinkClicked);
            // 
            // lnkEditRule
            // 
            this.lnkEditRule.AutoSize = true;
            this.lnkEditRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditRule.Location = new System.Drawing.Point(529, 512);
            this.lnkEditRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkEditRule.Name = "lnkEditRule";
            this.lnkEditRule.Size = new System.Drawing.Size(67, 18);
            this.lnkEditRule.TabIndex = 2;
            this.lnkEditRule.TabStop = true;
            this.lnkEditRule.Text = "Edit Rule";
            this.lnkEditRule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkEditRule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditRule_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Rule Summary:";
            // 
            // pnlProfleNRules
            // 
            this.pnlProfleNRules.Controls.Add(this.lnkRemoveProfile);
            this.pnlProfleNRules.Controls.Add(this.lblRules);
            this.pnlProfleNRules.Controls.Add(this.lnkClearAllCache);
            this.pnlProfleNRules.Controls.Add(this.lnkAddNewProfile);
            this.pnlProfleNRules.Controls.Add(this.lstRules);
            this.pnlProfleNRules.Controls.Add(this.lstProfiles);
            this.pnlProfleNRules.Controls.Add(this.lnkClearCacheProfile);
            this.pnlProfleNRules.Controls.Add(this.lnkClearCacheForRule);
            this.pnlProfleNRules.Controls.Add(this.lnkRemoveRule);
            this.pnlProfleNRules.Controls.Add(this.lnkAddNewRule);
            this.pnlProfleNRules.Controls.Add(this.lnkEditRule);
            this.pnlProfleNRules.Controls.Add(this.lblProfiles);
            this.pnlProfleNRules.Location = new System.Drawing.Point(19, 101);
            this.pnlProfleNRules.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProfleNRules.Name = "pnlProfleNRules";
            this.pnlProfleNRules.Size = new System.Drawing.Size(624, 587);
            this.pnlProfleNRules.TabIndex = 4;
            // 
            // lnkRemoveProfile
            // 
            this.lnkRemoveProfile.AutoSize = true;
            this.lnkRemoveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRemoveProfile.Location = new System.Drawing.Point(330, 33);
            this.lnkRemoveProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRemoveProfile.Name = "lnkRemoveProfile";
            this.lnkRemoveProfile.Size = new System.Drawing.Size(110, 18);
            this.lnkRemoveProfile.TabIndex = 4;
            this.lnkRemoveProfile.TabStop = true;
            this.lnkRemoveProfile.Text = "Remove Profile";
            this.lnkRemoveProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkRemoveProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRemoveProfile_LinkClicked);
            // 
            // lnkClearAllCache
            // 
            this.lnkClearAllCache.AutoSize = true;
            this.lnkClearAllCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClearAllCache.Location = new System.Drawing.Point(495, 102);
            this.lnkClearAllCache.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkClearAllCache.Name = "lnkClearAllCache";
            this.lnkClearAllCache.Size = new System.Drawing.Size(109, 18);
            this.lnkClearAllCache.TabIndex = 2;
            this.lnkClearAllCache.TabStop = true;
            this.lnkClearAllCache.Text = "Clear All Cache";
            this.lnkClearAllCache.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkClearAllCache.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearAllCache_LinkClicked);
            // 
            // lnkClearCacheProfile
            // 
            this.lnkClearCacheProfile.AutoSize = true;
            this.lnkClearCacheProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClearCacheProfile.Location = new System.Drawing.Point(456, 33);
            this.lnkClearCacheProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkClearCacheProfile.Name = "lnkClearCacheProfile";
            this.lnkClearCacheProfile.Size = new System.Drawing.Size(136, 18);
            this.lnkClearCacheProfile.TabIndex = 2;
            this.lnkClearCacheProfile.TabStop = true;
            this.lnkClearCacheProfile.Text = "Clear Profile Cache";
            this.lnkClearCacheProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkClearCacheProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearCacheProfile_LinkClicked);
            // 
            // lnkClearCacheForRule
            // 
            this.lnkClearCacheForRule.AutoSize = true;
            this.lnkClearCacheForRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClearCacheForRule.Location = new System.Drawing.Point(468, 551);
            this.lnkClearCacheForRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkClearCacheForRule.Name = "lnkClearCacheForRule";
            this.lnkClearCacheForRule.Size = new System.Drawing.Size(124, 18);
            this.lnkClearCacheForRule.TabIndex = 2;
            this.lnkClearCacheForRule.TabStop = true;
            this.lnkClearCacheForRule.Text = "Clear Rule Cache";
            this.lnkClearCacheForRule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkClearCacheForRule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearCacheForRule_LinkClicked);
            // 
            // lnkRemoveRule
            // 
            this.lnkRemoveRule.AutoSize = true;
            this.lnkRemoveRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRemoveRule.Location = new System.Drawing.Point(23, 551);
            this.lnkRemoveRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRemoveRule.Name = "lnkRemoveRule";
            this.lnkRemoveRule.Size = new System.Drawing.Size(98, 18);
            this.lnkRemoveRule.TabIndex = 2;
            this.lnkRemoveRule.TabStop = true;
            this.lnkRemoveRule.Text = "Remove Rule";
            this.lnkRemoveRule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkRemoveRule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRemoveRule_LinkClicked);
            // 
            // pnlRuleSummary
            // 
            this.pnlRuleSummary.Controls.Add(this.label1);
            this.pnlRuleSummary.Location = new System.Drawing.Point(667, 101);
            this.pnlRuleSummary.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRuleSummary.Name = "pnlRuleSummary";
            this.pnlRuleSummary.Size = new System.Drawing.Size(492, 587);
            this.pnlRuleSummary.TabIndex = 5;
            this.pnlRuleSummary.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 36);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "🚀 Nitro Cacher";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnabled.Location = new System.Drawing.Point(45, 74);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(91, 24);
            this.chkEnabled.TabIndex = 7;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // chkReplayDuration
            // 
            this.chkReplayDuration.AutoSize = true;
            this.chkReplayDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReplayDuration.Location = new System.Drawing.Point(156, 74);
            this.chkReplayDuration.Margin = new System.Windows.Forms.Padding(4);
            this.chkReplayDuration.Name = "chkReplayDuration";
            this.chkReplayDuration.Size = new System.Drawing.Size(151, 24);
            this.chkReplayDuration.TabIndex = 8;
            this.chkReplayDuration.Text = "Replay Duration";
            this.chkReplayDuration.UseVisualStyleBackColor = true;
            this.chkReplayDuration.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.chkReplayDuration);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlRuleSummary);
            this.Controls.Add(this.pnlProfleNRules);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1177, 767);
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlProfleNRules.ResumeLayout(false);
            this.pnlProfleNRules.PerformLayout();
            this.pnlRuleSummary.ResumeLayout(false);
            this.pnlRuleSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfiles;
        private System.Windows.Forms.ComboBox lstProfiles;
        private System.Windows.Forms.LinkLabel lnkAddNewProfile;
        private System.Windows.Forms.CheckedListBox lstRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.LinkLabel lnkAddNewRule;
        private System.Windows.Forms.LinkLabel lnkEditRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProfleNRules;
        private System.Windows.Forms.Panel pnlRuleSummary;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lnkClearCacheProfile;
        private System.Windows.Forms.LinkLabel lnkClearCacheForRule;
        private System.Windows.Forms.LinkLabel lnkClearAllCache;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.LinkLabel lnkRemoveRule;
        private System.Windows.Forms.LinkLabel lnkRemoveProfile;
        private System.Windows.Forms.CheckBox chkReplayDuration;
    }
}
