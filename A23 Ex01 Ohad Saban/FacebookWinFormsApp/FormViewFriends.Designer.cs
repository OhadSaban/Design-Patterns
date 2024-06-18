
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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelFilters = new System.Windows.Forms.Label();
            this.comboBoxHometown = new System.Windows.Forms.ComboBox();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelSingle = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxSingle = new System.Windows.Forms.ComboBox();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.labelFriendFrom = new System.Windows.Forms.Label();
            this.labelFriendLocation = new System.Windows.Forms.Label();
            this.labelFriendGender = new System.Windows.Forms.Label();
            this.labelFriendRelationship = new System.Windows.Forms.Label();
            this.labelFriendEmail = new System.Windows.Forms.Label();
            this.labelFriendBirthday = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(25, 76);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(270, 224);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(18, 19);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(195, 40);
            this.labelFriends.TabIndex = 1;
            this.labelFriends.Text = "My Friends";
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.Location = new System.Drawing.Point(35, 321);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(123, 25);
            this.labelFilters.TabIndex = 2;
            this.labelFilters.Text = "Filter Results";
            // 
            // comboBoxHometown
            // 
            this.comboBoxHometown.FormattingEnabled = true;
            this.comboBoxHometown.Items.AddRange(new object[] {
            "All",
            "Same",
            "Different"});
            this.comboBoxHometown.Location = new System.Drawing.Point(137, 371);
            this.comboBoxHometown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHometown.Name = "comboBoxHometown";
            this.comboBoxHometown.Size = new System.Drawing.Size(93, 28);
            this.comboBoxHometown.TabIndex = 3;
            this.comboBoxHometown.SelectedIndexChanged += new System.EventHandler(this.comboBoxHometown_SelectedIndexChanged);
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Location = new System.Drawing.Point(36, 379);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(86, 20);
            this.labelHometown.TabIndex = 4;
            this.labelHometown.Text = "Hometown";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(36, 431);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(70, 20);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Location";
            // 
            // labelSingle
            // 
            this.labelSingle.AutoSize = true;
            this.labelSingle.Location = new System.Drawing.Point(245, 428);
            this.labelSingle.Name = "labelSingle";
            this.labelSingle.Size = new System.Drawing.Size(53, 20);
            this.labelSingle.TabIndex = 6;
            this.labelSingle.Text = "Single";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(245, 379);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 20);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "Gender";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "All",
            "Same",
            "Different"});
            this.comboBoxLocation.Location = new System.Drawing.Point(137, 428);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(93, 28);
            this.comboBoxLocation.TabIndex = 8;
            this.comboBoxLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocation_SelectedIndexChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(314, 371);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(93, 28);
            this.comboBoxGender.TabIndex = 9;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // comboBoxSingle
            // 
            this.comboBoxSingle.FormattingEnabled = true;
            this.comboBoxSingle.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboBoxSingle.Location = new System.Drawing.Point(314, 425);
            this.comboBoxSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSingle.Name = "comboBoxSingle";
            this.comboBoxSingle.Size = new System.Drawing.Size(93, 28);
            this.comboBoxSingle.TabIndex = 10;
            this.comboBoxSingle.SelectedIndexChanged += new System.EventHandler(this.comboBoxSingle_SelectedIndexChanged);
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendName.Location = new System.Drawing.Point(480, 19);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(213, 37);
            this.labelFriendName.TabIndex = 11;
            this.labelFriendName.Text = "Default Name";
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(487, 76);
            this.pictureBoxFriendProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(332, 292);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfile.TabIndex = 12;
            this.pictureBoxFriendProfile.TabStop = false;
            // 
            // labelFriendFrom
            // 
            this.labelFriendFrom.AutoSize = true;
            this.labelFriendFrom.Location = new System.Drawing.Point(764, 399);
            this.labelFriendFrom.Name = "labelFriendFrom";
            this.labelFriendFrom.Size = new System.Drawing.Size(106, 20);
            this.labelFriendFrom.TabIndex = 13;
            this.labelFriendFrom.Text = "From: Default";
            // 
            // labelFriendLocation
            // 
            this.labelFriendLocation.AutoSize = true;
            this.labelFriendLocation.Location = new System.Drawing.Point(483, 446);
            this.labelFriendLocation.Name = "labelFriendLocation";
            this.labelFriendLocation.Size = new System.Drawing.Size(152, 20);
            this.labelFriendLocation.TabIndex = 14;
            this.labelFriendLocation.Text = "Currently At: Default";
            // 
            // labelFriendGender
            // 
            this.labelFriendGender.AutoSize = true;
            this.labelFriendGender.Location = new System.Drawing.Point(483, 399);
            this.labelFriendGender.Name = "labelFriendGender";
            this.labelFriendGender.Size = new System.Drawing.Size(123, 20);
            this.labelFriendGender.TabIndex = 15;
            this.labelFriendGender.Text = "Gender: Default";
            // 
            // labelFriendRelationship
            // 
            this.labelFriendRelationship.AutoSize = true;
            this.labelFriendRelationship.Location = new System.Drawing.Point(483, 498);
            this.labelFriendRelationship.Name = "labelFriendRelationship";
            this.labelFriendRelationship.Size = new System.Drawing.Size(208, 20);
            this.labelFriendRelationship.TabIndex = 16;
            this.labelFriendRelationship.Text = "Relationship Status: Default";
            // 
            // labelFriendEmail
            // 
            this.labelFriendEmail.AutoSize = true;
            this.labelFriendEmail.Location = new System.Drawing.Point(764, 498);
            this.labelFriendEmail.Name = "labelFriendEmail";
            this.labelFriendEmail.Size = new System.Drawing.Size(195, 20);
            this.labelFriendEmail.TabIndex = 17;
            this.labelFriendEmail.Text = "Email: Default@gmail.com";
            // 
            // labelFriendBirthday
            // 
            this.labelFriendBirthday.AutoSize = true;
            this.labelFriendBirthday.Location = new System.Drawing.Point(764, 446);
            this.labelFriendBirthday.Name = "labelFriendBirthday";
            this.labelFriendBirthday.Size = new System.Drawing.Size(127, 20);
            this.labelFriendBirthday.TabIndex = 18;
            this.labelFriendBirthday.Text = "Birthday: Default";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(25, 501);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 39);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(314, 468);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(93, 38);
            this.buttonApply.TabIndex = 20;
            this.buttonApply.Text = "Apply!";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FormViewFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 552);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelFriendBirthday);
            this.Controls.Add(this.labelFriendEmail);
            this.Controls.Add(this.labelFriendRelationship);
            this.Controls.Add(this.labelFriendGender);
            this.Controls.Add(this.labelFriendLocation);
            this.Controls.Add(this.labelFriendFrom);
            this.Controls.Add(this.pictureBoxFriendProfile);
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.comboBoxSingle);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelSingle);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.comboBoxHometown);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormViewFriends";
            this.Text = "FormViewFriends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.ComboBox comboBoxHometown;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelSingle;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxSingle;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.Label labelFriendFrom;
        private System.Windows.Forms.Label labelFriendLocation;
        private System.Windows.Forms.Label labelFriendGender;
        private System.Windows.Forms.Label labelFriendRelationship;
        private System.Windows.Forms.Label labelFriendEmail;
        private System.Windows.Forms.Label labelFriendBirthday;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonApply;
    }
}