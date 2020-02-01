namespace HMatuszewski.PhotoAlbum
{
    partial class PhotoManager
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
            this.PhotoPreview = new System.Windows.Forms.PictureBox();
            this.DescriptionGroup = new System.Windows.Forms.GroupBox();
            this.PhotoDescriptionLabel = new System.Windows.Forms.Label();
            this.PhotoDataGroup = new System.Windows.Forms.GroupBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TagsGroup = new System.Windows.Forms.GroupBox();
            this.TagsLabel = new System.Windows.Forms.Label();
            this.ManageGroup = new System.Windows.Forms.GroupBox();
            this.ChangeDescGroup = new System.Windows.Forms.GroupBox();
            this.PhotoDescTextBox = new System.Windows.Forms.RichTextBox();
            this.ChangePhotoDesc = new System.Windows.Forms.Button();
            this.ChangeNameGroup = new System.Windows.Forms.GroupBox();
            this.PhotoNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangePhotoName = new System.Windows.Forms.Button();
            this.ChangeCategoryGroup = new System.Windows.Forms.GroupBox();
            this.CategoryList = new System.Windows.Forms.ListView();
            this.SelectCategoryBtn = new System.Windows.Forms.Button();
            this.RemovePhotoBtn = new System.Windows.Forms.Button();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPreview)).BeginInit();
            this.DescriptionGroup.SuspendLayout();
            this.PhotoDataGroup.SuspendLayout();
            this.TagsGroup.SuspendLayout();
            this.ManageGroup.SuspendLayout();
            this.ChangeDescGroup.SuspendLayout();
            this.ChangeNameGroup.SuspendLayout();
            this.ChangeCategoryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhotoPreview
            // 
            this.PhotoPreview.Location = new System.Drawing.Point(39, 44);
            this.PhotoPreview.Name = "PhotoPreview";
            this.PhotoPreview.Size = new System.Drawing.Size(341, 227);
            this.PhotoPreview.TabIndex = 0;
            this.PhotoPreview.TabStop = false;
            // 
            // DescriptionGroup
            // 
            this.DescriptionGroup.Controls.Add(this.PhotoDescriptionLabel);
            this.DescriptionGroup.Location = new System.Drawing.Point(39, 289);
            this.DescriptionGroup.Name = "DescriptionGroup";
            this.DescriptionGroup.Size = new System.Drawing.Size(605, 88);
            this.DescriptionGroup.TabIndex = 1;
            this.DescriptionGroup.TabStop = false;
            this.DescriptionGroup.Text = "Opis zdjęcia";
            // 
            // PhotoDescriptionLabel
            // 
            this.PhotoDescriptionLabel.AutoSize = true;
            this.PhotoDescriptionLabel.Location = new System.Drawing.Point(6, 16);
            this.PhotoDescriptionLabel.Name = "PhotoDescriptionLabel";
            this.PhotoDescriptionLabel.Size = new System.Drawing.Size(28, 13);
            this.PhotoDescriptionLabel.TabIndex = 0;
            this.PhotoDescriptionLabel.Text = "Opis";
            // 
            // PhotoDataGroup
            // 
            this.PhotoDataGroup.Controls.Add(this.ResolutionLabel);
            this.PhotoDataGroup.Controls.Add(this.FormatLabel);
            this.PhotoDataGroup.Controls.Add(this.SizeLabel);
            this.PhotoDataGroup.Controls.Add(this.CreationDateLabel);
            this.PhotoDataGroup.Controls.Add(this.CategoryLabel);
            this.PhotoDataGroup.Controls.Add(this.AlbumLabel);
            this.PhotoDataGroup.Controls.Add(this.NameLabel);
            this.PhotoDataGroup.Location = new System.Drawing.Point(417, 44);
            this.PhotoDataGroup.Name = "PhotoDataGroup";
            this.PhotoDataGroup.Size = new System.Drawing.Size(222, 116);
            this.PhotoDataGroup.TabIndex = 2;
            this.PhotoDataGroup.TabStop = false;
            this.PhotoDataGroup.Text = "Paramtetry";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(6, 100);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(78, 13);
            this.ResolutionLabel.TabIndex = 6;
            this.ResolutionLabel.Text = "Rozdzielczość:";
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(7, 85);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(42, 13);
            this.FormatLabel.TabIndex = 5;
            this.FormatLabel.Text = "Format:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(7, 72);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(48, 13);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Rozmiar:";
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Location = new System.Drawing.Point(6, 59);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(87, 13);
            this.CreationDateLabel.TabIndex = 3;
            this.CreationDateLabel.Text = "Data wykonania:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(7, 46);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(55, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Kategoria:";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(7, 33);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(39, 13);
            this.AlbumLabel.TabIndex = 1;
            this.AlbumLabel.Text = "Album:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nazwa zdjęcia:";
            // 
            // TagsGroup
            // 
            this.TagsGroup.Controls.Add(this.TagsLabel);
            this.TagsGroup.Location = new System.Drawing.Point(417, 170);
            this.TagsGroup.Name = "TagsGroup";
            this.TagsGroup.Size = new System.Drawing.Size(222, 100);
            this.TagsGroup.TabIndex = 3;
            this.TagsGroup.TabStop = false;
            this.TagsGroup.Text = "Tagi";
            // 
            // TagsLabel
            // 
            this.TagsLabel.AutoSize = true;
            this.TagsLabel.Location = new System.Drawing.Point(7, 16);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(36, 13);
            this.TagsLabel.TabIndex = 1;
            this.TagsLabel.Text = "TAGS";
            // 
            // ManageGroup
            // 
            this.ManageGroup.Controls.Add(this.ChangeDescGroup);
            this.ManageGroup.Controls.Add(this.ChangeNameGroup);
            this.ManageGroup.Controls.Add(this.ChangeCategoryGroup);
            this.ManageGroup.Controls.Add(this.RemovePhotoBtn);
            this.ManageGroup.Location = new System.Drawing.Point(39, 393);
            this.ManageGroup.Name = "ManageGroup";
            this.ManageGroup.Size = new System.Drawing.Size(605, 120);
            this.ManageGroup.TabIndex = 4;
            this.ManageGroup.TabStop = false;
            this.ManageGroup.Text = "Zarządzanie";
            // 
            // ChangeDescGroup
            // 
            this.ChangeDescGroup.Controls.Add(this.PhotoDescTextBox);
            this.ChangeDescGroup.Controls.Add(this.ChangePhotoDesc);
            this.ChangeDescGroup.Location = new System.Drawing.Point(319, 13);
            this.ChangeDescGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeDescGroup.Name = "ChangeDescGroup";
            this.ChangeDescGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ChangeDescGroup.Size = new System.Drawing.Size(147, 98);
            this.ChangeDescGroup.TabIndex = 8;
            this.ChangeDescGroup.TabStop = false;
            this.ChangeDescGroup.Text = "Zmiana opisu zdjęcia";
            // 
            // PhotoDescTextBox
            // 
            this.PhotoDescTextBox.Location = new System.Drawing.Point(9, 18);
            this.PhotoDescTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoDescTextBox.Name = "PhotoDescTextBox";
            this.PhotoDescTextBox.Size = new System.Drawing.Size(131, 43);
            this.PhotoDescTextBox.TabIndex = 20;
            this.PhotoDescTextBox.Text = "Wpisz nowy opis";
            // 
            // ChangePhotoDesc
            // 
            this.ChangePhotoDesc.Location = new System.Drawing.Point(9, 66);
            this.ChangePhotoDesc.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePhotoDesc.Name = "ChangePhotoDesc";
            this.ChangePhotoDesc.Size = new System.Drawing.Size(130, 21);
            this.ChangePhotoDesc.TabIndex = 19;
            this.ChangePhotoDesc.Text = "Zastosuj";
            this.ChangePhotoDesc.UseVisualStyleBackColor = true;
            this.ChangePhotoDesc.Click += new System.EventHandler(this.ChangePhotoDesc_Click);
            // 
            // ChangeNameGroup
            // 
            this.ChangeNameGroup.Controls.Add(this.PhotoNameTextBox);
            this.ChangeNameGroup.Controls.Add(this.ChangePhotoName);
            this.ChangeNameGroup.Location = new System.Drawing.Point(168, 13);
            this.ChangeNameGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeNameGroup.Name = "ChangeNameGroup";
            this.ChangeNameGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ChangeNameGroup.Size = new System.Drawing.Size(147, 98);
            this.ChangeNameGroup.TabIndex = 7;
            this.ChangeNameGroup.TabStop = false;
            this.ChangeNameGroup.Text = "Zmiana nazwy zdjęcia";
            // 
            // PhotoNameTextBox
            // 
            this.PhotoNameTextBox.Location = new System.Drawing.Point(8, 18);
            this.PhotoNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoNameTextBox.Name = "PhotoNameTextBox";
            this.PhotoNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.PhotoNameTextBox.TabIndex = 18;
            this.PhotoNameTextBox.Text = "Wpisz nową nazwę";
            // 
            // ChangePhotoName
            // 
            this.ChangePhotoName.Location = new System.Drawing.Point(8, 41);
            this.ChangePhotoName.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePhotoName.Name = "ChangePhotoName";
            this.ChangePhotoName.Size = new System.Drawing.Size(130, 46);
            this.ChangePhotoName.TabIndex = 17;
            this.ChangePhotoName.Text = "Zastosuj";
            this.ChangePhotoName.UseVisualStyleBackColor = true;
            this.ChangePhotoName.Click += new System.EventHandler(this.ChangePhotoName_Click);
            // 
            // ChangeCategoryGroup
            // 
            this.ChangeCategoryGroup.Controls.Add(this.SelectCategoryBtn);
            this.ChangeCategoryGroup.Controls.Add(this.CategoryList);
            this.ChangeCategoryGroup.Location = new System.Drawing.Point(13, 13);
            this.ChangeCategoryGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeCategoryGroup.Name = "ChangeCategoryGroup";
            this.ChangeCategoryGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ChangeCategoryGroup.Size = new System.Drawing.Size(147, 98);
            this.ChangeCategoryGroup.TabIndex = 6;
            this.ChangeCategoryGroup.TabStop = false;
            this.ChangeCategoryGroup.Text = "Zmiana kategorii";
            // 
            // CategoryList
            // 
            this.CategoryList.HideSelection = false;
            this.CategoryList.Location = new System.Drawing.Point(5, 15);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(137, 53);
            this.CategoryList.TabIndex = 18;
            this.CategoryList.UseCompatibleStateImageBehavior = false;
            this.CategoryList.View = System.Windows.Forms.View.List;
            // 
            // SelectCategoryBtn
            // 
            this.SelectCategoryBtn.Location = new System.Drawing.Point(4, 73);
            this.SelectCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SelectCategoryBtn.Name = "SelectCategoryBtn";
            this.SelectCategoryBtn.Size = new System.Drawing.Size(139, 21);
            this.SelectCategoryBtn.TabIndex = 17;
            this.SelectCategoryBtn.Text = "Wybierz";
            this.SelectCategoryBtn.UseVisualStyleBackColor = true;
            this.SelectCategoryBtn.Click += new System.EventHandler(this.SelectCategoryBtn_Click);
            // 
            // RemovePhotoBtn
            // 
            this.RemovePhotoBtn.Location = new System.Drawing.Point(478, 67);
            this.RemovePhotoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RemovePhotoBtn.Name = "RemovePhotoBtn";
            this.RemovePhotoBtn.Size = new System.Drawing.Size(122, 44);
            this.RemovePhotoBtn.TabIndex = 5;
            this.RemovePhotoBtn.Text = "Usuń zdjęcie";
            this.RemovePhotoBtn.UseVisualStyleBackColor = true;
            this.RemovePhotoBtn.Click += new System.EventHandler(this.RemovePhotoBtn_Click);
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Location = new System.Drawing.Point(43, 25);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(46, 13);
            this.PreviewLabel.TabIndex = 5;
            this.PreviewLabel.Text = "Podgląd";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(39, 526);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(605, 35);
            this.ReturnBtn.TabIndex = 13;
            this.ReturnBtn.Text = "Powrót";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // PhotoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 572);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.ManageGroup);
            this.Controls.Add(this.TagsGroup);
            this.Controls.Add(this.PhotoDataGroup);
            this.Controls.Add(this.DescriptionGroup);
            this.Controls.Add(this.PhotoPreview);
            this.Name = "PhotoManager";
            this.Text = "Podgląd Zdjęcia";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPreview)).EndInit();
            this.DescriptionGroup.ResumeLayout(false);
            this.DescriptionGroup.PerformLayout();
            this.PhotoDataGroup.ResumeLayout(false);
            this.PhotoDataGroup.PerformLayout();
            this.TagsGroup.ResumeLayout(false);
            this.TagsGroup.PerformLayout();
            this.ManageGroup.ResumeLayout(false);
            this.ChangeDescGroup.ResumeLayout(false);
            this.ChangeNameGroup.ResumeLayout(false);
            this.ChangeNameGroup.PerformLayout();
            this.ChangeCategoryGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoPreview;
        private System.Windows.Forms.GroupBox DescriptionGroup;
        private System.Windows.Forms.Label PhotoDescriptionLabel;
        private System.Windows.Forms.GroupBox PhotoDataGroup;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.GroupBox TagsGroup;
        private System.Windows.Forms.GroupBox ManageGroup;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.GroupBox ChangeDescGroup;
        private System.Windows.Forms.RichTextBox PhotoDescTextBox;
        private System.Windows.Forms.Button ChangePhotoDesc;
        private System.Windows.Forms.GroupBox ChangeNameGroup;
        private System.Windows.Forms.TextBox PhotoNameTextBox;
        private System.Windows.Forms.Button ChangePhotoName;
        private System.Windows.Forms.GroupBox ChangeCategoryGroup;
        private System.Windows.Forms.Button SelectCategoryBtn;
        private System.Windows.Forms.Button RemovePhotoBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label TagsLabel;
        private System.Windows.Forms.ListView CategoryList;
    }
}