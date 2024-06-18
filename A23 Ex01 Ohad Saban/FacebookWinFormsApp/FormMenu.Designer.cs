
namespace BasicFacebookFeatures
{
    partial class FormMenu
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
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.textBoxLoggedUser = new System.Windows.Forms.TextBox();
            this.labelLoggedUser = new System.Windows.Forms.Label();
            this.labelActivities = new System.Windows.Forms.Label();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonGallery = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(28, 101);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(274, 260);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 4;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // textBoxLoggedUser
            // 
            this.textBoxLoggedUser.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLoggedUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoggedUser.Enabled = false;
            this.textBoxLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoggedUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxLoggedUser.Location = new System.Drawing.Point(28, 51);
            this.textBoxLoggedUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoggedUser.Name = "textBoxLoggedUser";
            this.textBoxLoggedUser.Size = new System.Drawing.Size(263, 32);
            this.textBoxLoggedUser.TabIndex = 7;
            // 
            // labelLoggedUser
            // 
            this.labelLoggedUser.AutoSize = true;
            this.labelLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUser.Location = new System.Drawing.Point(22, 9);
            this.labelLoggedUser.Name = "labelLoggedUser";
            this.labelLoggedUser.Size = new System.Drawing.Size(141, 32);
            this.labelLoggedUser.TabIndex = 8;
            this.labelLoggedUser.Text = "Welcome,";
            this.labelLoggedUser.Click += new System.EventHandler(this.labelLoggedUser_Click);
            // 
            // labelActivities
            // 
            this.labelActivities.AutoSize = true;
            this.labelActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivities.Location = new System.Drawing.Point(371, 61);
            this.labelActivities.Name = "labelActivities";
            this.labelActivities.Size = new System.Drawing.Size(212, 29);
            this.labelActivities.TabIndex = 9;
            this.labelActivities.Text = "Choose an activity!";
            this.labelActivities.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPosts
            // 
            this.buttonPosts.Location = new System.Drawing.Point(380, 122);
            this.buttonPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(184, 36);
            this.buttonPosts.TabIndex = 10;
            this.buttonPosts.Text = "View My Posts";
            this.buttonPosts.UseVisualStyleBackColor = true;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // buttonGallery
            // 
            this.buttonGallery.Location = new System.Drawing.Point(380, 185);
            this.buttonGallery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGallery.Name = "buttonGallery";
            this.buttonGallery.Size = new System.Drawing.Size(181, 41);
            this.buttonGallery.TabIndex = 11;
            this.buttonGallery.Text = "View My Images";
            this.buttonGallery.UseVisualStyleBackColor = true;
            this.buttonGallery.Click += new System.EventHandler(this.buttonGallery_Click_1);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(382, 256);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(177, 44);
            this.buttonFriends.TabIndex = 12;
            this.buttonFriends.Text = "View My Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(28, 380);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 38);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonGallery);
            this.Controls.Add(this.buttonPosts);
            this.Controls.Add(this.labelActivities);
            this.Controls.Add(this.labelLoggedUser);
            this.Controls.Add(this.textBoxLoggedUser);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.TextBox textBoxLoggedUser;
        private System.Windows.Forms.Label labelLoggedUser;
        private System.Windows.Forms.Label labelActivities;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Button buttonGallery;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonClose;
    }
}