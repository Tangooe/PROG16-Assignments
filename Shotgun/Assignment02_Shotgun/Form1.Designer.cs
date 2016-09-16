namespace Assignment02_Shotgun
{
    partial class Form1
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
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblBullets = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.pnlOpponent = new System.Windows.Forms.Panel();
            this.lblAIBullets = new System.Windows.Forms.Label();
            this.btnAIBlock = new System.Windows.Forms.Button();
            this.lblAIName = new System.Windows.Forms.Label();
            this.btnAIReload = new System.Windows.Forms.Button();
            this.btnAIShoot = new System.Windows.Forms.Button();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPlayer.SuspendLayout();
            this.pnlOpponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPlayer.Controls.Add(this.lblBullets);
            this.pnlPlayer.Controls.Add(this.panel1);
            this.pnlPlayer.Controls.Add(this.lblName);
            this.pnlPlayer.Controls.Add(this.btnBlock);
            this.pnlPlayer.Controls.Add(this.btnReload);
            this.pnlPlayer.Controls.Add(this.btnShoot);
            this.pnlPlayer.Location = new System.Drawing.Point(11, 105);
            this.pnlPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(389, 260);
            this.pnlPlayer.TabIndex = 0;
            // 
            // lblBullets
            // 
            this.lblBullets.AutoSize = true;
            this.lblBullets.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBullets.Location = new System.Drawing.Point(48, 93);
            this.lblBullets.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBullets.Name = "lblBullets";
            this.lblBullets.Size = new System.Drawing.Size(262, 53);
            this.lblBullets.TabIndex = 9;
            this.lblBullets.Text = "Bullets: 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 458);
            this.panel1.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(389, 69);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Player";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBlock
            // 
            this.btnBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlock.BackgroundImage = global::Assignment02_Shotgun.Properties.Resources.Shield;
            this.btnBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock.FlatAppearance.BorderSize = 0;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Location = new System.Drawing.Point(0, 155);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(100, 100);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BackgroundImage = global::Assignment02_Shotgun.Properties.Resources.Reload1;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(283, 155);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 100);
            this.btnReload.TabIndex = 2;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShoot.BackgroundImage = global::Assignment02_Shotgun.Properties.Resources.GunRight;
            this.btnShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShoot.FlatAppearance.BorderSize = 0;
            this.btnShoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoot.Location = new System.Drawing.Point(139, 155);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(100, 100);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOpponent.Controls.Add(this.lblAIBullets);
            this.pnlOpponent.Controls.Add(this.btnAIBlock);
            this.pnlOpponent.Controls.Add(this.lblAIName);
            this.pnlOpponent.Controls.Add(this.btnAIReload);
            this.pnlOpponent.Controls.Add(this.btnAIShoot);
            this.pnlOpponent.Location = new System.Drawing.Point(557, 105);
            this.pnlOpponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(389, 260);
            this.pnlOpponent.TabIndex = 7;
            // 
            // lblAIBullets
            // 
            this.lblAIBullets.AutoSize = true;
            this.lblAIBullets.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIBullets.Location = new System.Drawing.Point(43, 93);
            this.lblAIBullets.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAIBullets.Name = "lblAIBullets";
            this.lblAIBullets.Size = new System.Drawing.Size(262, 53);
            this.lblAIBullets.TabIndex = 9;
            this.lblAIBullets.Text = "Bullets: 0";
            // 
            // btnAIBlock
            // 
            this.btnAIBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAIBlock.BackgroundImage = global::Assignment02_Shotgun.Properties.Resources.Shield;
            this.btnAIBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAIBlock.FlatAppearance.BorderSize = 0;
            this.btnAIBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAIBlock.Location = new System.Drawing.Point(280, 155);
            this.btnAIBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAIBlock.Name = "btnAIBlock";
            this.btnAIBlock.Size = new System.Drawing.Size(100, 100);
            this.btnAIBlock.TabIndex = 7;
            this.btnAIBlock.UseVisualStyleBackColor = true;
            // 
            // lblAIName
            // 
            this.lblAIName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAIName.BackColor = System.Drawing.Color.Salmon;
            this.lblAIName.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIName.Location = new System.Drawing.Point(0, 0);
            this.lblAIName.Name = "lblAIName";
            this.lblAIName.Size = new System.Drawing.Size(389, 69);
            this.lblAIName.TabIndex = 4;
            this.lblAIName.Text = "Opponent";
            this.lblAIName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAIReload
            // 
            this.btnAIReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAIReload.BackColor = System.Drawing.Color.Transparent;
            this.btnAIReload.BackgroundImage = global::Assignment02_Shotgun.Properties.Resources.Reload1;
            this.btnAIReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAIReload.FlatAppearance.BorderSize = 0;
            this.btnAIReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAIReload.Location = new System.Drawing.Point(8, 155);
            this.btnAIReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAIReload.Name = "btnAIReload";
            this.btnAIReload.Size = new System.Drawing.Size(100, 100);
            this.btnAIReload.TabIndex = 6;
            this.btnAIReload.UseVisualStyleBackColor = false;
            // 
            // btnAIShoot
            // 
            this.btnAIShoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAIShoot.BackgroundImage = global::Assignment02_Shotgun.Properties.Resources.GunLeft;
            this.btnAIShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAIShoot.FlatAppearance.BorderSize = 0;
            this.btnAIShoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAIShoot.Location = new System.Drawing.Point(133, 155);
            this.btnAIShoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAIShoot.Name = "btnAIShoot";
            this.btnAIShoot.Size = new System.Drawing.Size(100, 100);
            this.btnAIShoot.TabIndex = 5;
            this.btnAIShoot.UseVisualStyleBackColor = true;
            // 
            // lblVs
            // 
            this.lblVs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVs.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblVs.Font = new System.Drawing.Font("Stencil Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.Location = new System.Drawing.Point(412, 74);
            this.lblVs.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(136, 323);
            this.lblVs.TabIndex = 8;
            this.lblVs.Text = "VS";
            this.lblVs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitle.Font = new System.Drawing.Font("Stencil Std", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(982, 87);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Shotgun";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(893, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 54);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.pnlOpponent);
            this.Controls.Add(this.pnlPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.pnlOpponent.ResumeLayout(false);
            this.pnlOpponent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlOpponent;
        private System.Windows.Forms.Label lblAIName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnAIBlock;
        public System.Windows.Forms.Button btnAIReload;
        public System.Windows.Forms.Button btnAIShoot;
        public System.Windows.Forms.Button btnShoot;
        public System.Windows.Forms.Button btnReload;
        public System.Windows.Forms.Button btnBlock;
        public System.Windows.Forms.Label lblAIBullets;
        public System.Windows.Forms.Label lblBullets;
    }
}

