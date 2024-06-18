
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
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelNewPost = new System.Windows.Forms.Label();
            this.comboBoxSortPosts = new System.Windows.Forms.ComboBox();
            this.labelSortPosts = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.richTextBoxTextPost = new System.Windows.Forms.RichTextBox();
            this.listBoxCommentsInPost = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextPage.Location = new System.Drawing.Point(330, 272);
            this.buttonNextPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(128, 42);
            this.buttonNextPage.TabIndex = 32;
            this.buttonNextPage.Text = "Next";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click_1);
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevPage.Location = new System.Drawing.Point(17, 272);
            this.buttonPrevPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(128, 42);
            this.buttonPrevPage.TabIndex = 31;
            this.buttonPrevPage.Text = "Previous";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click_1);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(531, 16);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(129, 29);
            this.labelComments.TabIndex = 30;
            this.labelComments.Text = "Comments";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.Location = new System.Drawing.Point(21, 16);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(130, 32);
            this.labelPosts.TabIndex = 29;
            this.labelPosts.Text = "My Posts";
            // 
            // labelNewPost
            // 
            this.labelNewPost.AutoSize = true;
            this.labelNewPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPost.Location = new System.Drawing.Point(39, 346);
            this.labelNewPost.Name = "labelNewPost";
            this.labelNewPost.Size = new System.Drawing.Size(227, 32);
            this.labelNewPost.TabIndex = 28;
            this.labelNewPost.Text = "Create New Post";
            // 
            // comboBoxSortPosts
            // 
            this.comboBoxSortPosts.FormattingEnabled = true;
            this.comboBoxSortPosts.Items.AddRange(new object[] {
            "Newest",
            "Oldest"});
            this.comboBoxSortPosts.Location = new System.Drawing.Point(343, 23);
            this.comboBoxSortPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortPosts.Name = "comboBoxSortPosts";
            this.comboBoxSortPosts.Size = new System.Drawing.Size(115, 28);
            this.comboBoxSortPosts.TabIndex = 27;
            this.comboBoxSortPosts.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortPosts_SelectedIndexChanged);
            // 
            // labelSortPosts
            // 
            this.labelSortPosts.AutoSize = true;
            this.labelSortPosts.Location = new System.Drawing.Point(260, 27);
            this.labelSortPosts.Name = "labelSortPosts";
            this.labelSortPosts.Size = new System.Drawing.Size(65, 20);
            this.labelSortPosts.TabIndex = 26;
            this.labelSortPosts.Text = "Sort By:";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(37, 495);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(124, 48);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(796, 433);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 54);
            this.buttonSubmit.TabIndex = 24;
            this.buttonSubmit.Text = "Submit!";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click_1);
            // 
            // richTextBoxTextPost
            // 
            this.richTextBoxTextPost.Location = new System.Drawing.Point(37, 398);
            this.richTextBoxTextPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxTextPost.Name = "richTextBoxTextPost";
            this.richTextBoxTextPost.Size = new System.Drawing.Size(736, 89);
            this.richTextBoxTextPost.TabIndex = 23;
            this.richTextBoxTextPost.Text = "";
            // 
            // listBoxCommentsInPost
            // 
            this.listBoxCommentsInPost.FormattingEnabled = true;
            this.listBoxCommentsInPost.ItemHeight = 20;
            this.listBoxCommentsInPost.Location = new System.Drawing.Point(536, 62);
            this.listBoxCommentsInPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCommentsInPost.Name = "listBoxCommentsInPost";
            this.listBoxCommentsInPost.Size = new System.Drawing.Size(400, 204);
            this.listBoxCommentsInPost.TabIndex = 22;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(22, 62);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(436, 204);
            this.listBoxPosts.TabIndex = 21;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged_1);
            // 
            // FormViewPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 552);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonPrevPage);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.labelNewPost);
            this.Controls.Add(this.comboBoxSortPosts);
            this.Controls.Add(this.labelSortPosts);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.richTextBoxTextPost);
            this.Controls.Add(this.listBoxCommentsInPost);
            this.Controls.Add(this.listBoxPosts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormViewPosts";
            this.Text = "Form Create Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelNewPost;
        private System.Windows.Forms.ComboBox comboBoxSortPosts;
        private System.Windows.Forms.Label labelSortPosts;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RichTextBox richTextBoxTextPost;
        private System.Windows.Forms.ListBox listBoxCommentsInPost;
        private System.Windows.Forms.ListBox listBoxPosts;
    }
}