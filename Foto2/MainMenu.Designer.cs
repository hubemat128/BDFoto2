namespace HMatuszewski.PhotoAlbum
{
    partial class MainMenu
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
            this.AlbumBtn = new System.Windows.Forms.Button();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // AlbumBtn
            // 
            this.AlbumBtn.Location = new System.Drawing.Point(124, 282);
            this.AlbumBtn.Name = "AlbumBtn";
            this.AlbumBtn.Size = new System.Drawing.Size(181, 41);
            this.AlbumBtn.TabIndex = 1;
            this.AlbumBtn.Text = "Albumy";
            this.AlbumBtn.UseVisualStyleBackColor = true;
            this.AlbumBtn.Click += new System.EventHandler(this.AlbumBtn_Click);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.Location = new System.Drawing.Point(124, 224);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(181, 41);
            this.CategoryBtn.TabIndex = 0;
            this.CategoryBtn.Text = "Kategorie";
            this.CategoryBtn.UseVisualStyleBackColor = true;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(124, 164);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(181, 41);
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "Wyszukaj Zdjęcie";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(124, 104);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(181, 41);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Dodaj ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddClicked);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 433);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.AlbumBtn);
            this.Controls.Add(this.CategoryBtn);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.helpProvider2.SetShowHelp(this, true);
            this.Text = "HMatuszewski - PhotoAlbum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AlbumBtn;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.HelpProvider helpProvider2;
    }
    
}