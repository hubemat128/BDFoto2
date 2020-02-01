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
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.AlbumCombo = new System.Windows.Forms.ComboBox();
            this.TagTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TagLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchResultGroup = new System.Windows.Forms.GroupBox();
            this.PhotoList = new System.Windows.Forms.ListView();
            this.SelectedPhotoLabel = new System.Windows.Forms.Label();
            this.PhotoPreview = new System.Windows.Forms.PictureBox();
            this.ShowPhotoBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SearchConditionGroup.SuspendLayout();
            this.SearchResultGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchConditionGroup
            // 
            this.SearchConditionGroup.Controls.Add(this.CategoryCombo);
            this.SearchConditionGroup.Controls.Add(this.AlbumCombo);
            this.SearchConditionGroup.Controls.Add(this.TagTextBox);
            this.SearchConditionGroup.Controls.Add(this.NameTextBox);
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
            // CategoryCombo
            // 
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(92, 68);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(216, 21);
            this.CategoryCombo.TabIndex = 25;
            // 
            // AlbumCombo
            // 
            this.AlbumCombo.FormattingEnabled = true;
            this.AlbumCombo.Location = new System.Drawing.Point(92, 45);
            this.AlbumCombo.Name = "AlbumCombo";
            this.AlbumCombo.Size = new System.Drawing.Size(216, 21);
            this.AlbumCombo.TabIndex = 24;
            // 
            // TagTextBox
            // 
            this.TagTextBox.Location = new System.Drawing.Point(92, 92);
            this.TagTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TagTextBox.Name = "TagTextBox";
            this.TagTextBox.Size = new System.Drawing.Size(216, 20);
            this.TagTextBox.TabIndex = 23;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(92, 23);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(216, 20);
            this.NameTextBox.TabIndex = 20;
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
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchResultGroup
            // 
            this.SearchResultGroup.Controls.Add(this.PhotoList);
            this.SearchResultGroup.Controls.Add(this.SelectedPhotoLabel);
            this.SearchResultGroup.Controls.Add(this.PhotoPreview);
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
            this.PhotoList.SelectedIndexChanged += new System.EventHandler(this.PhotoList_SelectedIndexChanged);
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
            // ShowPhotoBtn
            // 
            this.ShowPhotoBtn.Location = new System.Drawing.Point(17, 255);
            this.ShowPhotoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPhotoBtn.Name = "ShowPhotoBtn";
            this.ShowPhotoBtn.Size = new System.Drawing.Size(293, 36);
            this.ShowPhotoBtn.TabIndex = 14;
            this.ShowPhotoBtn.Text = "Wyświetl zdjęcie";
            this.ShowPhotoBtn.UseVisualStyleBackColor = true;
            this.ShowPhotoBtn.Click += new System.EventHandler(this.ShowPhotoBtn_Click);
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
        private System.Windows.Forms.TextBox TagTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox SearchResultGroup;
        private System.Windows.Forms.ListView PhotoList;
        private System.Windows.Forms.Label SelectedPhotoLabel;
        private System.Windows.Forms.PictureBox PhotoPreview;
        private System.Windows.Forms.Button ShowPhotoBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.ComboBox AlbumCombo;
    }
}