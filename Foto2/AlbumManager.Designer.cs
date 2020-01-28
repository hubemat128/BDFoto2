namespace HMatuszewski.PhotoAlbum
{
    partial class AlbumManager
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
            this.AlbumListGroup = new System.Windows.Forms.GroupBox();
            this.AlbumList = new System.Windows.Forms.ListBox();
            this.AlbumEditGroup = new System.Windows.Forms.GroupBox();
            this.RemoveAlbumBtn = new System.Windows.Forms.Button();
            this.SelectAlbumBtn = new System.Windows.Forms.Button();
            this.AddAlbumGroup = new System.Windows.Forms.GroupBox();
            this.AddAlbumBtn = new System.Windows.Forms.Button();
            this.AlbumNameTextBox = new System.Windows.Forms.TextBox();
            this.AlbumChangeNameGroup = new System.Windows.Forms.GroupBox();
            this.ChangeNameBtn = new System.Windows.Forms.Button();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.AlbumListGroup.SuspendLayout();
            this.AlbumEditGroup.SuspendLayout();
            this.AddAlbumGroup.SuspendLayout();
            this.AlbumChangeNameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlbumListGroup
            // 
            this.AlbumListGroup.Controls.Add(this.AlbumList);
            this.AlbumListGroup.Location = new System.Drawing.Point(12, 12);
            this.AlbumListGroup.Name = "AlbumListGroup";
            this.AlbumListGroup.Size = new System.Drawing.Size(137, 308);
            this.AlbumListGroup.TabIndex = 0;
            this.AlbumListGroup.TabStop = false;
            this.AlbumListGroup.Text = "Lista albumów";
            // 
            // AlbumList
            // 
            this.AlbumList.FormattingEnabled = true;
            this.AlbumList.Location = new System.Drawing.Point(6, 19);
            this.AlbumList.Name = "AlbumList";
            this.AlbumList.Size = new System.Drawing.Size(125, 277);
            this.AlbumList.TabIndex = 0;
            // 
            // AlbumEditGroup
            // 
            this.AlbumEditGroup.Controls.Add(this.RemoveAlbumBtn);
            this.AlbumEditGroup.Controls.Add(this.SelectAlbumBtn);
            this.AlbumEditGroup.Location = new System.Drawing.Point(155, 12);
            this.AlbumEditGroup.Name = "AlbumEditGroup";
            this.AlbumEditGroup.Size = new System.Drawing.Size(194, 107);
            this.AlbumEditGroup.TabIndex = 1;
            this.AlbumEditGroup.TabStop = false;
            this.AlbumEditGroup.Text = "Album";
            // 
            // RemoveAlbumBtn
            // 
            this.RemoveAlbumBtn.Location = new System.Drawing.Point(29, 56);
            this.RemoveAlbumBtn.Name = "RemoveAlbumBtn";
            this.RemoveAlbumBtn.Size = new System.Drawing.Size(143, 31);
            this.RemoveAlbumBtn.TabIndex = 1;
            this.RemoveAlbumBtn.Text = "Usuń";
            this.RemoveAlbumBtn.UseVisualStyleBackColor = true;
            this.RemoveAlbumBtn.Click += new System.EventHandler(this.RemoveAlbumBtn_Click);
            // 
            // SelectAlbumBtn
            // 
            this.SelectAlbumBtn.Location = new System.Drawing.Point(29, 19);
            this.SelectAlbumBtn.Name = "SelectAlbumBtn";
            this.SelectAlbumBtn.Size = new System.Drawing.Size(143, 31);
            this.SelectAlbumBtn.TabIndex = 0;
            this.SelectAlbumBtn.Text = "Przeglądaj";
            this.SelectAlbumBtn.UseVisualStyleBackColor = true;
            this.SelectAlbumBtn.Click += new System.EventHandler(this.SelectAlbum_Click);
            // 
            // AddAlbumGroup
            // 
            this.AddAlbumGroup.Controls.Add(this.AddAlbumBtn);
            this.AddAlbumGroup.Controls.Add(this.AlbumNameTextBox);
            this.AddAlbumGroup.Location = new System.Drawing.Point(155, 164);
            this.AddAlbumGroup.Name = "AddAlbumGroup";
            this.AddAlbumGroup.Size = new System.Drawing.Size(200, 144);
            this.AddAlbumGroup.TabIndex = 2;
            this.AddAlbumGroup.TabStop = false;
            this.AddAlbumGroup.Text = "Dodawanie albumu";
            // 
            // AddAlbumBtn
            // 
            this.AddAlbumBtn.Location = new System.Drawing.Point(29, 66);
            this.AddAlbumBtn.Name = "AddAlbumBtn";
            this.AddAlbumBtn.Size = new System.Drawing.Size(143, 46);
            this.AddAlbumBtn.TabIndex = 1;
            this.AddAlbumBtn.Text = "Dodaj";
            this.AddAlbumBtn.UseVisualStyleBackColor = true;
            this.AddAlbumBtn.Click += new System.EventHandler(this.AddAlbumBtn_Click);
            // 
            // AlbumNameTextBox
            // 
            this.AlbumNameTextBox.Location = new System.Drawing.Point(29, 40);
            this.AlbumNameTextBox.Name = "AlbumNameTextBox";
            this.AlbumNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.AlbumNameTextBox.TabIndex = 0;
            this.AlbumNameTextBox.Text = "Wpisz nazwę";
            // 
            // AlbumChangeNameGroup
            // 
            this.AlbumChangeNameGroup.Controls.Add(this.ChangeNameBtn);
            this.AlbumChangeNameGroup.Controls.Add(this.ChangeNameTextBox);
            this.AlbumChangeNameGroup.Location = new System.Drawing.Point(155, 337);
            this.AlbumChangeNameGroup.Name = "AlbumChangeNameGroup";
            this.AlbumChangeNameGroup.Size = new System.Drawing.Size(200, 100);
            this.AlbumChangeNameGroup.TabIndex = 3;
            this.AlbumChangeNameGroup.TabStop = false;
            this.AlbumChangeNameGroup.Text = "Zmiana nazwy";
            // 
            // ChangeNameBtn
            // 
            this.ChangeNameBtn.Location = new System.Drawing.Point(29, 71);
            this.ChangeNameBtn.Name = "ChangeNameBtn";
            this.ChangeNameBtn.Size = new System.Drawing.Size(143, 23);
            this.ChangeNameBtn.TabIndex = 1;
            this.ChangeNameBtn.Text = "Zmień nazwę";
            this.ChangeNameBtn.UseVisualStyleBackColor = true;
            this.ChangeNameBtn.Click += new System.EventHandler(this.ChangeNameBtn_Click);
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Location = new System.Drawing.Point(29, 40);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.ChangeNameTextBox.TabIndex = 0;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(18, 511);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(331, 23);
            this.ReturnBtn.TabIndex = 4;
            this.ReturnBtn.Text = "Powrót";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // AlbumManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 556);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.AlbumChangeNameGroup);
            this.Controls.Add(this.AddAlbumGroup);
            this.Controls.Add(this.AlbumEditGroup);
            this.Controls.Add(this.AlbumListGroup);
            this.Name = "AlbumManager";
            this.Text = "Menadżer Albumów";
            this.Load += new System.EventHandler(this.AlbumManagerLoaded);
            this.AlbumListGroup.ResumeLayout(false);
            this.AlbumEditGroup.ResumeLayout(false);
            this.AddAlbumGroup.ResumeLayout(false);
            this.AddAlbumGroup.PerformLayout();
            this.AlbumChangeNameGroup.ResumeLayout(false);
            this.AlbumChangeNameGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AlbumListGroup;
        private System.Windows.Forms.ListBox AlbumList;
        private System.Windows.Forms.GroupBox AlbumEditGroup;
        private System.Windows.Forms.Button RemoveAlbumBtn;
        private System.Windows.Forms.Button SelectAlbumBtn;
        private System.Windows.Forms.GroupBox AddAlbumGroup;
        private System.Windows.Forms.Button AddAlbumBtn;
        private System.Windows.Forms.TextBox AlbumNameTextBox;
        private System.Windows.Forms.GroupBox AlbumChangeNameGroup;
        private System.Windows.Forms.Button ChangeNameBtn;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.Button ReturnBtn;
    }
}