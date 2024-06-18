
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.buttonMark = new System.Windows.Forms.Button();
            this.buttonUnmark = new System.Windows.Forms.Button();
            this.listBoxPhotosInAlbum = new System.Windows.Forms.ListBox();
            this.buttonFavoritePhotos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInAlbum)).BeginInit();
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
            this.pictureBoxImageInAlbum.Size = new System.Drawing.Size(312, 255);
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
            this.comboBoxSortedBy.Location = new System.Drawing.Point(448, 24);
            this.comboBoxSortedBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortedBy.Name = "comboBoxSortedBy";
            this.comboBoxSortedBy.Size = new System.Drawing.Size(157, 24);
            this.comboBoxSortedBy.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(50, 329);
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
            this.buttonApply.Size = new System.Drawing.Size(65, 30);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
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
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(47, 27);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(112, 16);
            this.labelAlbumName.TabIndex = 11;
            this.labelAlbumName.Text = "labelAlbumName";
            // 
            // buttonMark
            // 
            this.buttonMark.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonMark.Location = new System.Drawing.Point(588, 328);
            this.buttonMark.Name = "buttonMark";
            this.buttonMark.Size = new System.Drawing.Size(88, 27);
            this.buttonMark.TabIndex = 12;
            this.buttonMark.Text = "Mark";
            this.buttonMark.UseVisualStyleBackColor = false;
            this.buttonMark.Click += new System.EventHandler(this.buttonMark_Click);
            // 
            // buttonUnmark
            // 
            this.buttonUnmark.BackColor = System.Drawing.Color.Red;
            this.buttonUnmark.Location = new System.Drawing.Point(364, 327);
            this.buttonUnmark.Name = "buttonUnmark";
            this.buttonUnmark.Size = new System.Drawing.Size(88, 29);
            this.buttonUnmark.TabIndex = 13;
            this.buttonUnmark.Text = "UnMark";
            this.buttonUnmark.UseVisualStyleBackColor = false;
            this.buttonUnmark.Click += new System.EventHandler(this.buttonUnmark_Click);
            // 
            // listBoxPhotosInAlbum
            // 
            this.listBoxPhotosInAlbum.FormattingEnabled = true;
            this.listBoxPhotosInAlbum.ItemHeight = 16;
            this.listBoxPhotosInAlbum.Location = new System.Drawing.Point(50, 56);
            this.listBoxPhotosInAlbum.Name = "listBoxPhotosInAlbum";
            this.listBoxPhotosInAlbum.Size = new System.Drawing.Size(258, 180);
            this.listBoxPhotosInAlbum.TabIndex = 15;
            this.listBoxPhotosInAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosInAlbum_SelectedIndexChanged);
            // 
            // buttonFavoritePhotos
            // 
            this.buttonFavoritePhotos.Location = new System.Drawing.Point(50, 284);
            this.buttonFavoritePhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFavoritePhotos.Name = "buttonFavoritePhotos";
            this.buttonFavoritePhotos.Size = new System.Drawing.Size(258, 27);
            this.buttonFavoritePhotos.TabIndex = 16;
            this.buttonFavoritePhotos.Text = "Click On Favorite Photos";
            this.buttonFavoritePhotos.UseVisualStyleBackColor = true;
            this.buttonFavoritePhotos.Click += new System.EventHandler(this.buttonFavoritePhotos_Click);
            // 
            // FormViewImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 367);
            this.Controls.Add(this.buttonFavoritePhotos);
            this.Controls.Add(this.listBoxPhotosInAlbum);
            this.Controls.Add(this.buttonUnmark);
            this.Controls.Add(this.buttonMark);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxSortedBy);
            this.Controls.Add(this.pictureBoxImageInAlbum);
            this.Controls.Add(this.comboBoxAlbums);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormViewImages";
            this.Text = "FromViewImages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageInAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxImageInAlbum;
        private System.Windows.Forms.ComboBox comboBoxSortedBy;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Button buttonMark;
        private System.Windows.Forms.Button buttonUnmark;
        private System.Windows.Forms.ListBox listBoxPhotosInAlbum;
        private System.Windows.Forms.Button buttonFavoritePhotos;
    }
}