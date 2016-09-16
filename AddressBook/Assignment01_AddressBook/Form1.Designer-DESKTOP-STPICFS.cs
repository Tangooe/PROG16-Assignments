namespace Assignment01_AddressBook
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
            this.buttonAddAddress = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTexbox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTexbox = new System.Windows.Forms.TextBox();
            this.areaCodeLabel = new System.Windows.Forms.Label();
            this.areaCodeTexbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.addressesListbox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddAddress
            // 
            this.buttonAddAddress.Location = new System.Drawing.Point(191, 468);
            this.buttonAddAddress.Name = "buttonAddAddress";
            this.buttonAddAddress.Size = new System.Drawing.Size(138, 50);
            this.buttonAddAddress.TabIndex = 0;
            this.buttonAddAddress.Text = "Add";
            this.buttonAddAddress.UseVisualStyleBackColor = true;
            this.buttonAddAddress.Click += new System.EventHandler(this.buttonAddAddress_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 44);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(317, 38);
            this.nameTextbox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 32);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 85);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(119, 32);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // addressTexbox
            // 
            this.addressTexbox.Location = new System.Drawing.Point(12, 120);
            this.addressTexbox.Name = "addressTexbox";
            this.addressTexbox.Size = new System.Drawing.Size(317, 38);
            this.addressTexbox.TabIndex = 3;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 237);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(64, 32);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City";
            // 
            // cityTexbox
            // 
            this.cityTexbox.Location = new System.Drawing.Point(12, 272);
            this.cityTexbox.Name = "cityTexbox";
            this.cityTexbox.Size = new System.Drawing.Size(317, 38);
            this.cityTexbox.TabIndex = 7;
            // 
            // areaCodeLabel
            // 
            this.areaCodeLabel.AutoSize = true;
            this.areaCodeLabel.Location = new System.Drawing.Point(12, 161);
            this.areaCodeLabel.Name = "areaCodeLabel";
            this.areaCodeLabel.Size = new System.Drawing.Size(150, 32);
            this.areaCodeLabel.TabIndex = 6;
            this.areaCodeLabel.Text = "Area Code";
            // 
            // areaCodeTexbox
            // 
            this.areaCodeTexbox.Location = new System.Drawing.Point(12, 196);
            this.areaCodeTexbox.Name = "areaCodeTexbox";
            this.areaCodeTexbox.Size = new System.Drawing.Size(317, 38);
            this.areaCodeTexbox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 389);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(87, 32);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(12, 424);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(317, 38);
            this.emailTextbox.TabIndex = 11;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 313);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(105, 32);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone ";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(12, 348);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(317, 38);
            this.phoneTextbox.TabIndex = 9;
            // 
            // addressesListbox
            // 
            this.addressesListbox.FormattingEnabled = true;
            this.addressesListbox.ItemHeight = 31;
            this.addressesListbox.Location = new System.Drawing.Point(402, 106);
            this.addressesListbox.Name = "addressesListbox";
            this.addressesListbox.Size = new System.Drawing.Size(382, 407);
            this.addressesListbox.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(663, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 45);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(402, 44);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(248, 38);
            this.searchTextbox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 648);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addressesListbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTexbox);
            this.Controls.Add(this.areaCodeLabel);
            this.Controls.Add(this.areaCodeTexbox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTexbox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.buttonAddAddress);
            this.Name = "Form1";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAddress;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTexbox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTexbox;
        private System.Windows.Forms.Label areaCodeLabel;
        private System.Windows.Forms.TextBox areaCodeTexbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.ListBox addressesListbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextbox;
    }
}

