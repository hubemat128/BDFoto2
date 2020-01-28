namespace HMatuszewski.PhotoAlbum
{
    partial class PhotoSearcher
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
            this.SearchConditionGroup = new System.Windows.Forms.GroupBox();
            this.FormatTextBox = new System.Windows.Forms.TextBox();
            this.TagTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.AlbumTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.TagLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchResultGroup = new System.Windows.Forms.GroupBox();
            this.PhotoList = new System.Windows.Forms.ListView();
            this.SelectedPhotoLabel = new System.Windows.Forms.Label();
            this.PhotoPreview = new System.Windows.Forms.PictureBox();
            this.ManagePhotoBtn = new System.Windows.Forms.Button();
            this.ShowPhotoBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SearchConditionGroup.SuspendLayout();
            this.SearchResultGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchConditionGroup
            // 
            this.SearchConditionGroup.Controls.Add(this.FormatTextBox);
            this.SearchConditionGroup.Controls.Add(this.TagTextBox);
            this.SearchConditionGroup.Controls.Add(this.CategoryTextBox);
            this.SearchConditionGroup.Controls.Add(this.AlbumTextBox);
            this.SearchConditionGroup.Controls.Add(this.NameTextBox);
            this.SearchConditionGroup.Controls.Add(this.FormatLabel);
            this.SearchConditionGroup.Controls.Add(this.TagLabel);
            this.SearchConditionGroup.Controls.Add(this.CategoryLabel);
            this.SearchConditionGroup.Controls.Add(this.AlbumLabel);
            this.SearchConditionGroup.Controls.Add(this.NameLabel);
            this.SearchConditionGroup.Controls.Add(this.SearchBtn);
            this.SearchConditionGroup.Location = new System.Drawing.Point(11, 11);
            this.SearchConditionGroup.Margin = new System.Windows.Forms.Padding(2);
            this.SearchConditionGroup.Name = "SearchConditionGroup";
            this.SearchConditionGroup.Padding = new System.Windows.Forms.Padding(2);
            this.SearchConditionGroup.Size = new System.Drawing.Size(313, 195);
            this.SearchConditionGroup.TabIndex = 18;
            this.SearchConditionGroup.TabStop = false;
            this.SearchConditionGroup.Text = "Kryteria wyszukiwania";
            // 
            // FormatTextBox
            // 
            this.FormatTextBox.Location = new System.Drawing.Point(92, 115);
            this.FormatTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FormatTextBox.Name = "FormatTextBox";
            this.FormatTextBox.Size = new System.Drawing.Size(216, 20);
            this.FormatTextBox.TabIndex = 24;
            // 
            // TagTextBox
            // 
            this.TagTextBox.Location = new System.Drawing.Point(92, 92);
            this.TagTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TagTextBox.Name = "TagTextBox";
            this.TagTextBox.Size = new System.Drawing.Size(216, 20);
            this.TagTextBox.TabIndex = 23;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(92, 68);
            this.CategoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(216, 20);
            this.CategoryTextBox.TabIndex = 22;
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.Location = new System.Drawing.Point(92, 46);
            this.AlbumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.Size = new System.Drawing.Size(216, 20);
            this.AlbumTextBox.TabIndex = 21;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(92, 23);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(216, 20);
            this.NameTextBox.TabIndex = 20;
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(45, 117);
            this.FormatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(42, 13);
            this.FormatLabel.TabIndex = 19;
            this.FormatLabel.Text = "Format:";
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Location = new System.Drawing.Point(59, 94);
            this.TagLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(29, 13);
            this.TagLabel.TabIndex = 18;
            this.TagLabel.Text = "Tag:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(32, 71);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(55, 13);
            this.CategoryLabel.TabIndex = 17;
            this.CategoryLabel.Text = "Kategoria:";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(49, 48);
            this.AlbumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(39, 13);
            this.AlbumLabel.TabIndex = 16;
            this.AlbumLabel.Text = "Album:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 25);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Nazwa zdjęcia:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(10, 147);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(298, 36);
            this.SearchBtn.TabIndex = 14;
            this.SearchBtn.Text = "Szukaj";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchResultGroup
            // 
            this.SearchResultGroup.Controls.Add(this.PhotoList);
            this.SearchResultGroup.Controls.Add(this.SelectedPhotoLabel);
            this.SearchResultGroup.Controls.Add(this.PhotoPreview);
            this.SearchResultGroup.Controls.Add(this.ManagePhotoBtn);
            this.SearchResultGroup.Controls.Add(this.ShowPhotoBtn);
            this.SearchResultGroup.Location = new System.Drawing.Point(328, 11);
            this.SearchResultGroup.Margin = new System.Windows.Forms.Padding(2);
            this.SearchResultGroup.Name = "SearchResultGroup";
            this.SearchResultGroup.Padding = new System.Windows.Forms.Padding(2);
            this.SearchResultGroup.Size = new System.Drawing.Size(500, 297);
            this.SearchResultGroup.TabIndex = 17;
            this.SearchResultGroup.TabStop = false;
            this.SearchResultGroup.Text = "Wyniki wyszukiwania";
            // 
            // PhotoList
            // 
            this.PhotoList.HideSelection = false;
            this.PhotoList.Location = new System.Drawing.Point(17, 18);
            this.PhotoList.Name = "PhotoList";
            this.PhotoList.Size = new System.Drawing.Size(293, 232);
            this.PhotoList.TabIndex = 30;
            this.PhotoList.UseCompatibleStateImageBehavior = false;
            // 
            // SelectedPhotoLabel
            // 
            this.SelectedPhotoLabel.AutoSize = true;
            this.SelectedPhotoLabel.Location = new System.Drawing.Point(362, 172);
            this.SelectedPhotoLabel.Name = "SelectedPhotoLabel";
            this.SelectedPhotoLabel.Size = new System.Drawing.Size(88, 13);
            this.SelectedPhotoLabel.TabIndex = 26;
            this.SelectedPhotoLabel.Text = "Wybrane Zdjęcie";
            this.SelectedPhotoLabel.Click += new System.EventHandler(this.SelectedPhotoClicked);
            // 
            // PhotoPreview
            // 
            this.PhotoPreview.Location = new System.Drawing.Point(316, 15);
            this.PhotoPreview.Name = "PhotoPreview";
            this.PhotoPreview.Size = new System.Drawing.Size(179, 154);
            this.PhotoPreview.TabIndex = 17;
            this.PhotoPreview.TabStop = false;
            // 
            // ManagePhotoBtn
            // 
            this.ManagePhotoBtn.Location = new System.Drawing.Point(259, 255);
            this.ManagePhotoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ManagePhotoBtn.Name = "ManagePhotoBtn";
            this.ManagePhotoBtn.Size = new System.Drawing.Size(237, 36);
            this.ManagePhotoBtn.TabIndex = 15;
            this.ManagePhotoBtn.Text = "Zarządzaj zdjęciem";
            this.ManagePhotoBtn.UseVisualStyleBackColor = true;
            // 
            // ShowPhotoBtn
            // 
            this.ShowPhotoBtn.Location = new System.Drawing.Point(4, 255);
            this.ShowPhotoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPhotoBtn.Name = "ShowPhotoBtn";
            this.ShowPhotoBtn.Size = new System.Drawing.Size(238, 36);
            this.ShowPhotoBtn.TabIndex = 14;
            this.ShowPhotoBtn.Text = "Wyświetl zdjęcie";
            this.ShowPhotoBtn.UseVisualStyleBackColor = true;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(11, 210);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(313, 72);
            this.ReturnBtn.TabIndex = 13;
            this.ReturnBtn.Text = "Powrót";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // PhotoSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 325);
            this.Controls.Add(this.SearchConditionGroup);
            this.Controls.Add(this.SearchResultGroup);
            this.Controls.Add(this.ReturnBtn);
            this.Name = "PhotoSearcher";
            this.Text = "Wyszukiwanie zdjęć";
            this.SearchConditionGroup.ResumeLayout(false);
            this.SearchConditionGroup.PerformLayout();
            this.SearchResultGroup.ResumeLayout(false);
            this.SearchResultGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchConditionGroup;
        private System.Windows.Forms.TextBox FormatTextBox;
        private System.Windows.Forms.TextBox TagTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox AlbumTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox SearchResultGroup;
        private System.Windows.Forms.ListView PhotoList;
        private System.Windows.Forms.Label SelectedPhotoLabel;
        private System.Windows.Forms.PictureBox PhotoPreview;
        private System.Windows.Forms.Button ManagePhotoBtn;
        private System.Windows.Forms.Button ShowPhotoBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}