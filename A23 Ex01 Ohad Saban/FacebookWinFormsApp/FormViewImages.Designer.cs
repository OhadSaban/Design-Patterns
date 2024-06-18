namespace BasicFacebookFeatures
{
    partial class FormViewImages
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
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.labelChooseAlbum = new System.Windows.Forms.Label();
            this.labelSortingBy = new System.Windows.Forms.Label();
            this.pictureBoxImageInAlbum = new System.Windows.Forms.PictureBox();
            this.buttonPrevPhoto = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxSortedBy = new System.Windows.Forms.ComboBox();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(16, 74);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(277, 216);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 1;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // labelChooseAlbum
            // 
            this.labelChooseAlbum.AutoSize = true;
            this.labelChooseAlbum.Location = new System.Drawing.Point(12, 310);
            this.labelChooseAlbum.Name = "labelChooseAlbum";
            this.labelChooseAlbum.Size = new System.Drawing.Size(113, 20);
            this.labelChooseAlbum.TabIndex = 3;
            this.labelChooseAlbum.Text = "Choose Album";
            this.labelChooseAlbum.Click += new System.EventHandler(this.labelChooseAlbum_Click);
            // 
            // labelSortingBy
            // 
            this.labelSortingBy.AutoSize = true;
            this.labelSortingBy.Location = new System.Drawing.Point(12, 387);
            this.labelSortingBy.Name = "labelSortingBy";
            this.labelSortingBy.Size = new System.Drawing.Size(144, 20);
            this.labelSortingBy.TabIndex = 7;
            this.labelSortingBy.Text = "Sort Images Order:";
            // 
            // pictureBoxImageInAlbum
            // 
            this.pictureBoxImageInAlbum.Location = new System.Drawing.Point(384, 74);
            this.pictureBoxImageInAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxImageInAlbum.Name = "pictureBoxImageInAlbum";
            this.pictureBoxImageInAlbum.Size = new System.Drawing.Size(280, 321);
            this.pictureBoxImageInAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageInAlbum.TabIndex = 8;
            this.pictureBoxImageInAlbum.TabStop = false;
            // 
            // buttonPrevPhoto
            // 
            this.buttonPrevPhoto.Location = new System.Drawing.Point(384, 403);
            this.buttonPrevPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrevPhoto.Name = "buttonPrevPhoto";
            this.buttonPrevPhoto.Size = new System.Drawing.Size(92, 39);
            this.buttonPrevPhoto.TabIndex = 9;
            this.buttonPrevPhoto.Text = "Previous";
            this.buttonPrevPhoto.UseVisualStyleBackColor = true;
            this.buttonPrevPhoto.Click += new System.EventHandler(this.buttonPrevPhoto_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(580, 403);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(84, 39);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(192, 417);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(105, 39);
            this.buttonApply.TabIndex = 12;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(16, 487);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 32);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxSortedBy
            // 
            this.comboBoxSortedBy.FormattingEnabled = true;
            this.comboBoxSortedBy.Items.AddRange(new object[] {
            "Newst First",
            "Older First"});
            this.comboBoxSortedBy.Location = new System.Drawing.Point(16, 423);
            this.comboBoxSortedBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSortedBy.Name = "comboBoxSortedBy";
            this.comboBoxSortedBy.Size = new System.Drawing.Size(140, 28);
            this.comboBoxSortedBy.TabIndex = 14;
            this.comboBoxSortedBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortedBy_SelectedIndexChanged);
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(16, 333);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(281, 28);
            this.comboBoxAlbums.TabIndex = 16;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(12, 29);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(107, 20);
            this.labelAlbumName.TabIndex = 17;
            this.labelAlbumName.Text = "Default Name";
            // 
            // FormViewImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 532);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.comboBoxAlbums);
            this.Controls.Add(this.comboBoxSortedBy);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevPhoto);
            this.Controls.Add(this.pictureBoxImageInAlbum);
            this.Controls.Add(this.labelSortingBy);
            this.Controls.Add(this.labelChooseAlbum);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormViewImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Label labelChooseAlbum;
        private System.Windows.Forms.Label labelSortingBy;
        private System.Windows.Forms.PictureBox pictureBoxImageInAlbum;
        private System.Windows.Forms.Button buttonPrevPhoto;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxSortedBy;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.Label labelAlbumName;
    }
}