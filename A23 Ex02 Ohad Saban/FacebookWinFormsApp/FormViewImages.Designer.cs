
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
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.pictureBoxImageInAlbum = new System.Windows.Forms.PictureBox();
            this.comboBoxSortedBy = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonPrevPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(50, 249);
            this.comboBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(258, 24);
            this.comboBoxAlbums.TabIndex = 0;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxImageInAlbum
            // 
            this.pictureBoxImageInAlbum.Location = new System.Drawing.Point(364, 56);
            this.pictureBoxImageInAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImageInAlbum.Name = "pictureBoxImageInAlbum";
            this.pictureBoxImageInAlbum.Size = new System.Drawing.Size(297, 255);
            this.pictureBoxImageInAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageInAlbum.TabIndex = 1;
            this.pictureBoxImageInAlbum.TabStop = false;
            // 
            // comboBoxSortedBy
            // 
            this.comboBoxSortedBy.FormattingEnabled = true;
            this.comboBoxSortedBy.Items.AddRange(new object[] {
            "Newest",
            "Oldest"});
            this.comboBoxSortedBy.Location = new System.Drawing.Point(449, 24);
            this.comboBoxSortedBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortedBy.Name = "comboBoxSortedBy";
            this.comboBoxSortedBy.Size = new System.Drawing.Size(157, 24);
            this.comboBoxSortedBy.TabIndex = 2;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(572, 323);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(88, 27);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(39, 323);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 27);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(611, 22);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(65, 25);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonPrevPhoto
            // 
            this.buttonPrevPhoto.Location = new System.Drawing.Point(364, 323);
            this.buttonPrevPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrevPhoto.Name = "buttonPrevPhoto";
            this.buttonPrevPhoto.Size = new System.Drawing.Size(88, 27);
            this.buttonPrevPhoto.TabIndex = 8;
            this.buttonPrevPhoto.Text = "Prev";
            this.buttonPrevPhoto.UseVisualStyleBackColor = true;
            this.buttonPrevPhoto.Click += new System.EventHandler(this.buttonPrevPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sort By:";
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(50, 55);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(246, 189);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 10;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(47, 27);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(112, 16);
            this.labelAlbumName.TabIndex = 11;
            this.labelAlbumName.Text = "labelAlbumName";
            // 
            // FormViewImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 370);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrevPhoto);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.comboBoxSortedBy);
            this.Controls.Add(this.pictureBoxImageInAlbum);
            this.Controls.Add(this.comboBoxAlbums);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormViewImages";
            this.Text = "FromViewImages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxImageInAlbum;
        private System.Windows.Forms.ComboBox comboBoxSortedBy;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonPrevPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Label labelAlbumName;
    }
}