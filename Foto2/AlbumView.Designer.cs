namespace HMatuszewski.PhotoAlbum
{
    partial class AlbumView
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
            this.components = new System.ComponentModel.Container();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.PhotoList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PhotoList
            // 
            this.PhotoList.HideSelection = false;
            this.PhotoList.Location = new System.Drawing.Point(12, 12);
            this.PhotoList.Name = "PhotoList";
            this.PhotoList.Size = new System.Drawing.Size(776, 426);
            this.PhotoList.TabIndex = 0;
            this.PhotoList.UseCompatibleStateImageBehavior = false;
            this.PhotoList.SelectedIndexChanged += new System.EventHandler(this.PhotoList_SelectedIndexChanged);
            // 
            // AlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PhotoList);
            this.Name = "AlbumView";
            this.Text = "Podgląd Albumu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ListView PhotoList;
    }
}