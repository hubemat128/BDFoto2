namespace HMatuszewski.PhotoAlbum
{
    partial class AddPhotoPage
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
            this.CategoryGroup = new System.Windows.Forms.GroupBox();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.AlbumGroup = new System.Windows.Forms.GroupBox();
            this.AlbumListBox = new System.Windows.Forms.ListBox();
            this.TagGroup = new System.Windows.Forms.GroupBox();
            this.TagAddGroup = new System.Windows.Forms.GroupBox();
            this.TagTextBox = new System.Windows.Forms.TextBox();
            this.AddTagBtn = new System.Windows.Forms.Button();
            this.RemoveTagBtn = new System.Windows.Forms.Button();
            this.TagListBox = new System.Windows.Forms.ListBox();
            this.PreviewImage = new System.Windows.Forms.PictureBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.ChoosePhotoBtn = new System.Windows.Forms.Button();
            this.AddPhotoBtn = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.PhotoDescTextBox = new System.Windows.Forms.TextBox();
            this.PhotoDescLabel = new System.Windows.Forms.Label();
            this.PhotoNameTextBox = new System.Windows.Forms.TextBox();
            this.PhotoNameLabel = new System.Windows.Forms.Label();
            this.CategoryGroup.SuspendLayout();
            this.AlbumGroup.SuspendLayout();
            this.TagGroup.SuspendLayout();
            this.TagAddGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryGroup
            // 
            this.CategoryGroup.Controls.Add(this.CategoryListBox);
            this.CategoryGroup.Location = new System.Drawing.Point(11, 22);
            this.CategoryGroup.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryGroup.Name = "CategoryGroup";
            this.CategoryGroup.Padding = new System.Windows.Forms.Padding(2);
            this.CategoryGroup.Size = new System.Drawing.Size(173, 164);
            this.CategoryGroup.TabIndex = 16;
            this.CategoryGroup.TabStop = false;
            this.CategoryGroup.Text = "Wybierz kategorię dla zdjęcia";
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(11, 24);
            this.CategoryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(148, 121);
            this.CategoryListBox.TabIndex = 1;
            // 
            // AlbumGroup
            // 
            this.AlbumGroup.Controls.Add(this.AlbumListBox);
            this.AlbumGroup.Location = new System.Drawing.Point(11, 210);
            this.AlbumGroup.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumGroup.Name = "AlbumGroup";
            this.AlbumGroup.Padding = new System.Windows.Forms.Padding(2);
            this.AlbumGroup.Size = new System.Drawing.Size(168, 164);
            this.AlbumGroup.TabIndex = 17;
            this.AlbumGroup.TabStop = false;
            this.AlbumGroup.Text = "Wybierz album dla zdjęcia";
            // 
            // AlbumListBox
            // 
            this.AlbumListBox.FormattingEnabled = true;
            this.AlbumListBox.Location = new System.Drawing.Point(11, 24);
            this.AlbumListBox.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumListBox.Name = "AlbumListBox";
            this.AlbumListBox.Size = new System.Drawing.Size(148, 121);
            this.AlbumListBox.TabIndex = 0;
            // 
            // TagGroup
            // 
            this.TagGroup.Controls.Add(this.TagAddGroup);
            this.TagGroup.Controls.Add(this.RemoveTagBtn);
            this.TagGroup.Controls.Add(this.TagListBox);
            this.TagGroup.Location = new System.Drawing.Point(201, 22);
            this.TagGroup.Margin = new System.Windows.Forms.Padding(2);
            this.TagGroup.Name = "TagGroup";
            this.TagGroup.Padding = new System.Windows.Forms.Padding(2);
            this.TagGroup.Size = new System.Drawing.Size(349, 147);
            this.TagGroup.TabIndex = 34;
            this.TagGroup.TabStop = false;
            this.TagGroup.Text = "Lista tagów";
            // 
            // TagAddGroup
            // 
            this.TagAddGroup.Controls.Add(this.TagTextBox);
            this.TagAddGroup.Controls.Add(this.AddTagBtn);
            this.TagAddGroup.Location = new System.Drawing.Point(192, 17);
            this.TagAddGroup.Margin = new System.Windows.Forms.Padding(2);
            this.TagAddGroup.Name = "TagAddGroup";
            this.TagAddGroup.Padding = new System.Windows.Forms.Padding(2);
            this.TagAddGroup.Size = new System.Drawing.Size(142, 85);
            this.TagAddGroup.TabIndex = 2;
            this.TagAddGroup.TabStop = false;
            this.TagAddGroup.Text = "Dodaj";
            // 
            // TagTextBox
            // 
            this.TagTextBox.Location = new System.Drawing.Point(13, 22);
            this.TagTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TagTextBox.Name = "TagTextBox";
            this.TagTextBox.Size = new System.Drawing.Size(118, 20);
            this.TagTextBox.TabIndex = 17;
            this.TagTextBox.Text = "Wpisz nowy tag";
            // 
            // AddTagBtn
            // 
            this.AddTagBtn.Location = new System.Drawing.Point(13, 48);
            this.AddTagBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddTagBtn.Name = "AddTagBtn";
            this.AddTagBtn.Size = new System.Drawing.Size(117, 25);
            this.AddTagBtn.TabIndex = 16;
            this.AddTagBtn.Text = "Dodaj";
            this.AddTagBtn.UseVisualStyleBackColor = true;
            this.AddTagBtn.Click += new System.EventHandler(this.AddTagBtn_Click);
            // 
            // RemoveTagBtn
            // 
            this.RemoveTagBtn.Location = new System.Drawing.Point(192, 106);
            this.RemoveTagBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveTagBtn.Name = "RemoveTagBtn";
            this.RemoveTagBtn.Size = new System.Drawing.Size(142, 24);
            this.RemoveTagBtn.TabIndex = 1;
            this.RemoveTagBtn.Text = "Usuń";
            this.RemoveTagBtn.UseVisualStyleBackColor = true;
            // 
            // TagListBox
            // 
            this.TagListBox.FormattingEnabled = true;
            this.TagListBox.Location = new System.Drawing.Point(14, 24);
            this.TagListBox.Margin = new System.Windows.Forms.Padding(2);
            this.TagListBox.Name = "TagListBox";
            this.TagListBox.Size = new System.Drawing.Size(159, 108);
            this.TagListBox.TabIndex = 0;
            // 
            // PreviewImage
            // 
            this.PreviewImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PreviewImage.Location = new System.Drawing.Point(609, 22);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(200, 200);
            this.PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewImage.TabIndex = 50;
            this.PreviewImage.TabStop = false;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(245, 293);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(68, 13);
            this.FileNameLabel.TabIndex = 49;
            this.FileNameLabel.Text = "Nazwa pliku:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(315, 314);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(270, 20);
            this.PathTextBox.TabIndex = 48;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Enabled = false;
            this.FileNameTextBox.Location = new System.Drawing.Point(315, 290);
            this.FileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.FileNameTextBox.TabIndex = 47;
            // 
            // ChoosePhotoBtn
            // 
            this.ChoosePhotoBtn.Location = new System.Drawing.Point(315, 262);
            this.ChoosePhotoBtn.Name = "ChoosePhotoBtn";
            this.ChoosePhotoBtn.Size = new System.Drawing.Size(270, 23);
            this.ChoosePhotoBtn.TabIndex = 46;
            this.ChoosePhotoBtn.Text = "Wybierz zdjęcie";
            this.ChoosePhotoBtn.UseVisualStyleBackColor = true;
            this.ChoosePhotoBtn.Click += new System.EventHandler(this.ChoosePhotoClicked);
            // 
            // AddPhotoBtn
            // 
            this.AddPhotoBtn.Location = new System.Drawing.Point(237, 338);
            this.AddPhotoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddPhotoBtn.Name = "AddPhotoBtn";
            this.AddPhotoBtn.Size = new System.Drawing.Size(171, 36);
            this.AddPhotoBtn.TabIndex = 45;
            this.AddPhotoBtn.Text = "Dodaj";
            this.AddPhotoBtn.UseVisualStyleBackColor = true;
            this.AddPhotoBtn.Click += new System.EventHandler(this.AddPhotoClicked);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(263, 317);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(48, 13);
            this.PathLabel.TabIndex = 44;
            this.PathLabel.Text = "Ścieżka:";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(417, 338);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(170, 36);
            this.ReturnButton.TabIndex = 43;
            this.ReturnButton.Text = "Powrót";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnClicked);
            // 
            // PhotoDescTextBox
            // 
            this.PhotoDescTextBox.Location = new System.Drawing.Point(315, 237);
            this.PhotoDescTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoDescTextBox.Name = "PhotoDescTextBox";
            this.PhotoDescTextBox.Size = new System.Drawing.Size(270, 20);
            this.PhotoDescTextBox.TabIndex = 42;
            // 
            // PhotoDescLabel
            // 
            this.PhotoDescLabel.AutoSize = true;
            this.PhotoDescLabel.Location = new System.Drawing.Point(245, 239);
            this.PhotoDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhotoDescLabel.Name = "PhotoDescLabel";
            this.PhotoDescLabel.Size = new System.Drawing.Size(68, 13);
            this.PhotoDescLabel.TabIndex = 41;
            this.PhotoDescLabel.Text = "Opis słowny:";
            // 
            // PhotoNameTextBox
            // 
            this.PhotoNameTextBox.Location = new System.Drawing.Point(315, 214);
            this.PhotoNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoNameTextBox.Name = "PhotoNameTextBox";
            this.PhotoNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.PhotoNameTextBox.TabIndex = 40;
            // 
            // PhotoNameLabel
            // 
            this.PhotoNameLabel.AutoSize = true;
            this.PhotoNameLabel.Location = new System.Drawing.Point(234, 217);
            this.PhotoNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhotoNameLabel.Name = "PhotoNameLabel";
            this.PhotoNameLabel.Size = new System.Drawing.Size(79, 13);
            this.PhotoNameLabel.TabIndex = 39;
            this.PhotoNameLabel.Text = "Nazwa zdjęcia:";
            // 
            // AddPhotoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 388);
            this.Controls.Add(this.PreviewImage);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.ChoosePhotoBtn);
            this.Controls.Add(this.AddPhotoBtn);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.PhotoDescTextBox);
            this.Controls.Add(this.PhotoDescLabel);
            this.Controls.Add(this.PhotoNameTextBox);
            this.Controls.Add(this.PhotoNameLabel);
            this.Controls.Add(this.TagGroup);
            this.Controls.Add(this.AlbumGroup);
            this.Controls.Add(this.CategoryGroup);
            this.Name = "AddPhotoPage";
            this.Text = "Dodaj nowe Zdjęcie";
            this.Load += new System.EventHandler(this.add_photo_Load);
            this.CategoryGroup.ResumeLayout(false);
            this.AlbumGroup.ResumeLayout(false);
            this.TagGroup.ResumeLayout(false);
            this.TagAddGroup.ResumeLayout(false);
            this.TagAddGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CategoryGroup;
        private System.Windows.Forms.GroupBox AlbumGroup;
        private System.Windows.Forms.ListBox AlbumListBox;
        private System.Windows.Forms.GroupBox TagGroup;
        private System.Windows.Forms.GroupBox TagAddGroup;
        private System.Windows.Forms.TextBox TagTextBox;
        private System.Windows.Forms.Button AddTagBtn;
        private System.Windows.Forms.Button RemoveTagBtn;
        private System.Windows.Forms.ListBox TagListBox;
        private System.Windows.Forms.PictureBox PreviewImage;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button ChoosePhotoBtn;
        private System.Windows.Forms.Button AddPhotoBtn;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox PhotoDescTextBox;
        private System.Windows.Forms.Label PhotoDescLabel;
        private System.Windows.Forms.TextBox PhotoNameTextBox;
        private System.Windows.Forms.Label PhotoNameLabel;
        private System.Windows.Forms.ListBox CategoryListBox;
    }
}