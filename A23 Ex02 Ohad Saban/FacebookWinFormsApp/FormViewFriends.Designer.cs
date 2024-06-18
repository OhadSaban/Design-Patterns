
namespace BasicFacebookFeatures
{
    partial class FormViewFriends
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label hometownLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label relationshipLabel;
            this.labelFilterHometown = new System.Windows.Forms.Label();
            this.comboBoxHometown = new System.Windows.Forms.ComboBox();
            this.labelFilterGender = new System.Windows.Forms.Label();
            this.labelFilterLocation = new System.Windows.Forms.Label();
            this.labelFilterSingle = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxSingle = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.friendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.relationshipLabel1 = new System.Windows.Forms.Label();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.hometownLabel1 = new System.Windows.Forms.Label();
            this.genderLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            emailLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            hometownLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            relationshipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            emailLabel.Location = new System.Drawing.Point(16, 186);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 18);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            birthdayLabel.Location = new System.Drawing.Point(16, 16);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(65, 18);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            genderLabel.Location = new System.Drawing.Point(16, 125);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(61, 18);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            // 
            // hometownLabel
            // 
            hometownLabel.AutoSize = true;
            hometownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            hometownLabel.Location = new System.Drawing.Point(16, 55);
            hometownLabel.Name = "hometownLabel";
            hometownLabel.Size = new System.Drawing.Size(85, 18);
            hometownLabel.TabIndex = 6;
            hometownLabel.Text = "Hometown:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            locationLabel.Location = new System.Drawing.Point(16, 93);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(69, 18);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // relationshipLabel
            // 
            relationshipLabel.AutoSize = true;
            relationshipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            relationshipLabel.Location = new System.Drawing.Point(16, 156);
            relationshipLabel.Name = "relationshipLabel";
            relationshipLabel.Size = new System.Drawing.Size(93, 18);
            relationshipLabel.TabIndex = 10;
            relationshipLabel.Text = "Relationship:";
            // 
            // labelFilterHometown
            // 
            this.labelFilterHometown.AutoSize = true;
            this.labelFilterHometown.Location = new System.Drawing.Point(22, 166);
            this.labelFilterHometown.Name = "labelFilterHometown";
            this.labelFilterHometown.Size = new System.Drawing.Size(71, 16);
            this.labelFilterHometown.TabIndex = 0;
            this.labelFilterHometown.Text = "Hometown";
            // 
            // comboBoxHometown
            // 
            this.comboBoxHometown.FormattingEnabled = true;
            this.comboBoxHometown.Items.AddRange(new object[] {
            "All",
            "Same",
            "Different"});
            this.comboBoxHometown.Location = new System.Drawing.Point(104, 163);
            this.comboBoxHometown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHometown.Name = "comboBoxHometown";
            this.comboBoxHometown.Size = new System.Drawing.Size(145, 24);
            this.comboBoxHometown.TabIndex = 1;
            this.comboBoxHometown.SelectedIndexChanged += new System.EventHandler(this.comboBoxHometown_SelectedIndexChanged);
            // 
            // labelFilterGender
            // 
            this.labelFilterGender.AutoSize = true;
            this.labelFilterGender.Location = new System.Drawing.Point(22, 197);
            this.labelFilterGender.Name = "labelFilterGender";
            this.labelFilterGender.Size = new System.Drawing.Size(52, 16);
            this.labelFilterGender.TabIndex = 2;
            this.labelFilterGender.Text = "Gender";
            // 
            // labelFilterLocation
            // 
            this.labelFilterLocation.AutoSize = true;
            this.labelFilterLocation.Location = new System.Drawing.Point(22, 222);
            this.labelFilterLocation.Name = "labelFilterLocation";
            this.labelFilterLocation.Size = new System.Drawing.Size(58, 16);
            this.labelFilterLocation.TabIndex = 3;
            this.labelFilterLocation.Text = "Location";
            // 
            // labelFilterSingle
            // 
            this.labelFilterSingle.AutoSize = true;
            this.labelFilterSingle.Location = new System.Drawing.Point(22, 246);
            this.labelFilterSingle.Name = "labelFilterSingle";
            this.labelFilterSingle.Size = new System.Drawing.Size(45, 16);
            this.labelFilterSingle.TabIndex = 4;
            this.labelFilterSingle.Text = "Single";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(104, 190);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(144, 24);
            this.comboBoxGender.TabIndex = 5;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "All",
            "Same",
            "Different"});
            this.comboBoxLocation.Location = new System.Drawing.Point(104, 218);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(144, 24);
            this.comboBoxLocation.TabIndex = 6;
            this.comboBoxLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocation_SelectedIndexChanged);
            // 
            // comboBoxSingle
            // 
            this.comboBoxSingle.FormattingEnabled = true;
            this.comboBoxSingle.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboBoxSingle.Location = new System.Drawing.Point(104, 246);
            this.comboBoxSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSingle.Name = "comboBoxSingle";
            this.comboBoxSingle.Size = new System.Drawing.Size(144, 24);
            this.comboBoxSingle.TabIndex = 7;
            this.comboBoxSingle.SelectedIndexChanged += new System.EventHandler(this.comboBoxSingle_SelectedIndexChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(178, 292);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(70, 28);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Apply Filters";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(16, 293);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(85, 27);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.friendBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(16, 24);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(232, 116);
            this.listBoxFriends.TabIndex = 10;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // friendBindingSource
            // 
            this.friendBindingSource.DataSource = typeof(BasicFacebookFeatures.Friend);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(relationshipLabel);
            this.panel1.Controls.Add(this.relationshipLabel1);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationLabel1);
            this.panel1.Controls.Add(hometownLabel);
            this.panel1.Controls.Add(this.hometownLabel1);
            this.panel1.Controls.Add(genderLabel);
            this.panel1.Controls.Add(this.genderLabel1);
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(this.birthdayLabel1);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailLabel1);
            this.panel1.Location = new System.Drawing.Point(470, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 217);
            this.panel1.TabIndex = 19;
            // 
            // relationshipLabel1
            // 
            this.relationshipLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendBindingSource, "Relationship", true));
            this.relationshipLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.relationshipLabel1.Location = new System.Drawing.Point(121, 156);
            this.relationshipLabel1.Name = "relationshipLabel1";
            this.relationshipLabel1.Size = new System.Drawing.Size(193, 23);
            this.relationshipLabel1.TabIndex = 11;
            this.relationshipLabel1.Text = "label1";
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendBindingSource, "Location", true));
            this.locationLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.locationLabel1.Location = new System.Drawing.Point(121, 93);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(193, 23);
            this.locationLabel1.TabIndex = 9;
            this.locationLabel1.Text = "label1";
            // 
            // hometownLabel1
            // 
            this.hometownLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendBindingSource, "Hometown", true));
            this.hometownLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.hometownLabel1.Location = new System.Drawing.Point(121, 55);
            this.hometownLabel1.Name = "hometownLabel1";
            this.hometownLabel1.Size = new System.Drawing.Size(193, 23);
            this.hometownLabel1.TabIndex = 7;
            this.hometownLabel1.Text = "label1";
            // 
            // genderLabel1
            // 
            this.genderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendBindingSource, "Gender", true));
            this.genderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.genderLabel1.Location = new System.Drawing.Point(121, 125);
            this.genderLabel1.Name = "genderLabel1";
            this.genderLabel1.Size = new System.Drawing.Size(193, 23);
            this.genderLabel1.TabIndex = 5;
            this.genderLabel1.Text = "label1";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendBindingSource, "Birthday", true));
            this.birthdayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.birthdayLabel1.Location = new System.Drawing.Point(121, 16);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(193, 23);
            this.birthdayLabel1.TabIndex = 3;
            this.birthdayLabel1.Text = "label1";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendBindingSource, "Email", true));
            this.emailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.emailLabel1.Location = new System.Drawing.Point(121, 182);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(193, 23);
            this.emailLabel1.TabIndex = 1;
            this.emailLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(284, 24);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(279, 23);
            this.nameLabel1.TabIndex = 21;
            this.nameLabel1.Text = "label1";
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(287, 72);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(177, 180);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 22;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // FormViewFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 340);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxSingle);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelFilterSingle);
            this.Controls.Add(this.labelFilterLocation);
            this.Controls.Add(this.labelFilterGender);
            this.Controls.Add(this.comboBoxHometown);
            this.Controls.Add(this.labelFilterHometown);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormViewFriends";
            this.Text = "FormViewFriends";
            this.Load += new System.EventHandler(this.FormViewFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilterHometown;
        private System.Windows.Forms.ComboBox comboBoxHometown;
        private System.Windows.Forms.Label labelFilterGender;
        private System.Windows.Forms.Label labelFilterLocation;
        private System.Windows.Forms.Label labelFilterSingle;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxSingle;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label relationshipLabel1;
        private System.Windows.Forms.BindingSource friendBindingSource;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Label hometownLabel1;
        private System.Windows.Forms.Label genderLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
    }
}