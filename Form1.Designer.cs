namespace SM64SampleTuner
{
    partial class CalculateKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateKey));
            this.lblBitRate = new System.Windows.Forms.Label();
            this.txtTargetBitrate = new System.Windows.Forms.TextBox();
            this.txtTargetRootKey = new System.Windows.Forms.TextBox();
            this.lblTargetKey = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.Result = new System.Windows.Forms.TextBox();
            this.ghRepoLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblBitRate
            // 
            this.lblBitRate.AutoSize = true;
            this.lblBitRate.Font = new System.Drawing.Font("Mario64", 18F);
            this.lblBitRate.Location = new System.Drawing.Point(43, 15);
            this.lblBitRate.Name = "lblBitRate";
            this.lblBitRate.Size = new System.Drawing.Size(84, 28);
            this.lblBitRate.TabIndex = 0;
            this.lblBitRate.Text = "Bitrate";
            this.lblBitRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTargetBitrate
            // 
            this.txtTargetBitrate.Font = new System.Drawing.Font("Mario64", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetBitrate.Location = new System.Drawing.Point(31, 48);
            this.txtTargetBitrate.Name = "txtTargetBitrate";
            this.txtTargetBitrate.Size = new System.Drawing.Size(108, 32);
            this.txtTargetBitrate.TabIndex = 0;
            this.txtTargetBitrate.Text = "32000";
            this.txtTargetBitrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTargetBitrate.TextChanged += new System.EventHandler(this.txtTargetBitrate_TextChanged);
            // 
            // txtTargetRootKey
            // 
            this.txtTargetRootKey.Font = new System.Drawing.Font("Mario64", 15.75F);
            this.txtTargetRootKey.Location = new System.Drawing.Point(207, 48);
            this.txtTargetRootKey.Name = "txtTargetRootKey";
            this.txtTargetRootKey.Size = new System.Drawing.Size(60, 32);
            this.txtTargetRootKey.TabIndex = 3;
            this.txtTargetRootKey.Text = "60";
            this.txtTargetRootKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTargetRootKey.TextChanged += new System.EventHandler(this.txtTargetRootKey_TextChanged);
            // 
            // lblTargetKey
            // 
            this.lblTargetKey.AutoSize = true;
            this.lblTargetKey.Font = new System.Drawing.Font("Mario64", 18F);
            this.lblTargetKey.Location = new System.Drawing.Point(195, 15);
            this.lblTargetKey.Name = "lblTargetKey";
            this.lblTargetKey.Size = new System.Drawing.Size(90, 28);
            this.lblTargetKey.TabIndex = 2;
            this.lblTargetKey.Text = "Root Key";
            this.lblTargetKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTargetKey.Click += new System.EventHandler(this.lblTargetKey_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Mario64", 18F);
            this.btnMain.Location = new System.Drawing.Point(83, 90);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(148, 45);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Calculate";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGithub.Location = new System.Drawing.Point(6, 172);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(76, 39);
            this.linkGithub.TabIndex = 7;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Credits:\r\n- PablosCorner\r\n- ThisMight";
            this.linkGithub.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.linkGithub.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Font = new System.Drawing.Font("Mario64", 18F);
            this.Result.Location = new System.Drawing.Point(83, 141);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(148, 35);
            this.Result.TabIndex = 8;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ghRepoLink
            // 
            this.ghRepoLink.AutoSize = true;
            this.ghRepoLink.Location = new System.Drawing.Point(242, 198);
            this.ghRepoLink.Name = "ghRepoLink";
            this.ghRepoLink.Size = new System.Drawing.Size(69, 13);
            this.ghRepoLink.TabIndex = 9;
            this.ghRepoLink.TabStop = true;
            this.ghRepoLink.Text = "GitHub Repo";
            this.ghRepoLink.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ghRepoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ghRepoLink_LinkClicked);
            // 
            // CalculateKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 217);
            this.Controls.Add(this.ghRepoLink);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.txtTargetRootKey);
            this.Controls.Add(this.lblTargetKey);
            this.Controls.Add(this.txtTargetBitrate);
            this.Controls.Add(this.lblBitRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculateKey";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SM64 Sample Tuner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBitRate;
        private System.Windows.Forms.TextBox txtTargetBitrate;
        private System.Windows.Forms.TextBox txtTargetRootKey;
        private System.Windows.Forms.Label lblTargetKey;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.LinkLabel ghRepoLink;
    }
}

