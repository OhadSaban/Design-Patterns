
namespace BasicFacebookFeatures
{
    partial class FormViewPosts
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
            this.richTextBoxTextPost = new System.Windows.Forms.RichTextBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxCommentsInPost = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxSortPosts = new System.Windows.Forms.ComboBox();
            this.labelMyPosts = new System.Windows.Forms.Label();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelNewPost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxTextPost
            // 
            this.richTextBoxTextPost.Location = new System.Drawing.Point(434, 217);
            this.richTextBoxTextPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxTextPost.Name = "richTextBoxTextPost";
            this.richTextBoxTextPost.Size = new System.Drawing.Size(351, 107);
            this.richTextBoxTextPost.TabIndex = 0;
            this.richTextBoxTextPost.Text = "";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(35, 80);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(352, 244);
            this.listBoxPosts.TabIndex = 1;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxCommentsInPost
            // 
            this.listBoxCommentsInPost.FormattingEnabled = true;
            this.listBoxCommentsInPost.ItemHeight = 16;
            this.listBoxCommentsInPost.Location = new System.Drawing.Point(434, 80);
            this.listBoxCommentsInPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCommentsInPost.Name = "listBoxCommentsInPost";
            this.listBoxCommentsInPost.Size = new System.Drawing.Size(351, 84);
            this.listBoxCommentsInPost.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(31, 346);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 37);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(693, 342);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(92, 37);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxSortPosts
            // 
            this.comboBoxSortPosts.FormattingEnabled = true;
            this.comboBoxSortPosts.Items.AddRange(new object[] {
            "Newest",
            "Oldest",
            "Most Likes",
            "Most Comments"});
            this.comboBoxSortPosts.Location = new System.Drawing.Point(283, 52);
            this.comboBoxSortPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortPosts.Name = "comboBoxSortPosts";
            this.comboBoxSortPosts.Size = new System.Drawing.Size(104, 24);
            this.comboBoxSortPosts.TabIndex = 7;
            this.comboBoxSortPosts.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortPosts_SelectedIndexChanged);
            // 
            // labelMyPosts
            // 
            this.labelMyPosts.AutoSize = true;
            this.labelMyPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyPosts.Location = new System.Drawing.Point(28, 27);
            this.labelMyPosts.Name = "labelMyPosts";
            this.labelMyPosts.Size = new System.Drawing.Size(162, 38);
            this.labelMyPosts.TabIndex = 8;
            this.labelMyPosts.Text = "My Posts!";
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(224, 55);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(53, 16);
            this.labelSortBy.TabIndex = 10;
            this.labelSortBy.Text = "Sort By:";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(429, 34);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(135, 29);
            this.labelComments.TabIndex = 11;
            this.labelComments.Text = "Comments:";
            // 
            // labelNewPost
            // 
            this.labelNewPost.AutoSize = true;
            this.labelNewPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPost.Location = new System.Drawing.Point(428, 183);
            this.labelNewPost.Name = "labelNewPost";
            this.labelNewPost.Size = new System.Drawing.Size(201, 31);
            this.labelNewPost.TabIndex = 12;
            this.labelNewPost.Text = "Write New Post";
            // 
            // FormViewPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 390);
            this.Controls.Add(this.labelNewPost);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.labelSortBy);
            this.Controls.Add(this.labelMyPosts);
            this.Controls.Add(this.comboBoxSortPosts);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxCommentsInPost);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.richTextBoxTextPost);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormViewPosts";
            this.Text = "FormViewPosts";
            this.Load += new System.EventHandler(this.FormViewPosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxTextPost;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxCommentsInPost;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboBoxSortPosts;
        private System.Windows.Forms.Label labelMyPosts;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelNewPost;
    }
}