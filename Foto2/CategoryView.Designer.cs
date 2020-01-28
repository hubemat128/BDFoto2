namespace HMatuszewski.PhotoAlbum
{
    partial class CategoryView
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
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.CategoryListGroup = new System.Windows.Forms.GroupBox();
            this.RemoveCategoryGroup = new System.Windows.Forms.GroupBox();
            this.RemoveCategoryBtn = new System.Windows.Forms.Button();
            this.AddCategoryGroup = new System.Windows.Forms.GroupBox();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.NewCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeCategoryNameGroup = new System.Windows.Forms.GroupBox();
            this.ChangeCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeCategoryNameBtn = new System.Windows.Forms.Button();
            this.CategoryList = new System.Windows.Forms.ListView();
            this.CategoryListGroup.SuspendLayout();
            this.RemoveCategoryGroup.SuspendLayout();
            this.AddCategoryGroup.SuspendLayout();
            this.ChangeCategoryNameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(148, 242);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(191, 36);
            this.ReturnBtn.TabIndex = 10;
            this.ReturnBtn.Text = "Powrót";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CategoryListGroup
            // 
            this.CategoryListGroup.Controls.Add(this.CategoryList);
            this.CategoryListGroup.Location = new System.Drawing.Point(11, 11);
            this.CategoryListGroup.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryListGroup.Name = "CategoryListGroup";
            this.CategoryListGroup.Padding = new System.Windows.Forms.Padding(2);
            this.CategoryListGroup.Size = new System.Drawing.Size(133, 267);
            this.CategoryListGroup.TabIndex = 9;
            this.CategoryListGroup.TabStop = false;
            this.CategoryListGroup.Text = "Lista kategorii";
            // 
            // RemoveCategoryGroup
            // 
            this.RemoveCategoryGroup.Controls.Add(this.RemoveCategoryBtn);
            this.RemoveCategoryGroup.Location = new System.Drawing.Point(148, 98);
            this.RemoveCategoryGroup.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCategoryGroup.Name = "RemoveCategoryGroup";
            this.RemoveCategoryGroup.Padding = new System.Windows.Forms.Padding(2);
            this.RemoveCategoryGroup.Size = new System.Drawing.Size(191, 50);
            this.RemoveCategoryGroup.TabIndex = 8;
            this.RemoveCategoryGroup.TabStop = false;
            this.RemoveCategoryGroup.Text = "Usunięcie kategorii";
            // 
            // RemoveCategoryBtn
            // 
            this.RemoveCategoryBtn.Location = new System.Drawing.Point(12, 19);
            this.RemoveCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCategoryBtn.Name = "RemoveCategoryBtn";
            this.RemoveCategoryBtn.Size = new System.Drawing.Size(170, 23);
            this.RemoveCategoryBtn.TabIndex = 3;
            this.RemoveCategoryBtn.Text = "Usuń kategorię";
            this.RemoveCategoryBtn.UseVisualStyleBackColor = true;
            this.RemoveCategoryBtn.Click += new System.EventHandler(this.RemoveCategoryBtn_Click);
            // 
            // AddCategoryGroup
            // 
            this.AddCategoryGroup.Controls.Add(this.AddCategoryBtn);
            this.AddCategoryGroup.Controls.Add(this.NewCategoryNameTextBox);
            this.AddCategoryGroup.Location = new System.Drawing.Point(148, 154);
            this.AddCategoryGroup.Margin = new System.Windows.Forms.Padding(2);
            this.AddCategoryGroup.Name = "AddCategoryGroup";
            this.AddCategoryGroup.Padding = new System.Windows.Forms.Padding(2);
            this.AddCategoryGroup.Size = new System.Drawing.Size(191, 84);
            this.AddCategoryGroup.TabIndex = 7;
            this.AddCategoryGroup.TabStop = false;
            this.AddCategoryGroup.Text = "Dodawanie kategorii";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(12, 52);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(168, 22);
            this.AddCategoryBtn.TabIndex = 1;
            this.AddCategoryBtn.Text = "Dodaj kategorię";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // NewCategoryNameTextBox
            // 
            this.NewCategoryNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.NewCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewCategoryNameTextBox.Name = "NewCategoryNameTextBox";
            this.NewCategoryNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.NewCategoryNameTextBox.TabIndex = 0;
            // 
            // ChangeCategoryNameGroup
            // 
            this.ChangeCategoryNameGroup.Controls.Add(this.ChangeCategoryNameTextBox);
            this.ChangeCategoryNameGroup.Controls.Add(this.ChangeCategoryNameBtn);
            this.ChangeCategoryNameGroup.Location = new System.Drawing.Point(148, 10);
            this.ChangeCategoryNameGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeCategoryNameGroup.Name = "ChangeCategoryNameGroup";
            this.ChangeCategoryNameGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ChangeCategoryNameGroup.Size = new System.Drawing.Size(191, 84);
            this.ChangeCategoryNameGroup.TabIndex = 6;
            this.ChangeCategoryNameGroup.TabStop = false;
            this.ChangeCategoryNameGroup.Text = "Zmiana nazwy kategorii";
            // 
            // ChangeCategoryNameTextBox
            // 
            this.ChangeCategoryNameTextBox.Location = new System.Drawing.Point(12, 24);
            this.ChangeCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeCategoryNameTextBox.Name = "ChangeCategoryNameTextBox";
            this.ChangeCategoryNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.ChangeCategoryNameTextBox.TabIndex = 3;
            // 
            // ChangeCategoryNameBtn
            // 
            this.ChangeCategoryNameBtn.Location = new System.Drawing.Point(12, 51);
            this.ChangeCategoryNameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeCategoryNameBtn.Name = "ChangeCategoryNameBtn";
            this.ChangeCategoryNameBtn.Size = new System.Drawing.Size(170, 23);
            this.ChangeCategoryNameBtn.TabIndex = 2;
            this.ChangeCategoryNameBtn.Text = "Zmień nazwę";
            this.ChangeCategoryNameBtn.UseVisualStyleBackColor = true;
            this.ChangeCategoryNameBtn.Click += new System.EventHandler(this.ChangeCategoryNameBtn_Click);
            // 
            // CategoryList
            // 
            this.CategoryList.HideSelection = false;
            this.CategoryList.Location = new System.Drawing.Point(4, 24);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(124, 238);
            this.CategoryList.TabIndex = 7;
            this.CategoryList.UseCompatibleStateImageBehavior = false;
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 296);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CategoryListGroup);
            this.Controls.Add(this.RemoveCategoryGroup);
            this.Controls.Add(this.AddCategoryGroup);
            this.Controls.Add(this.ChangeCategoryNameGroup);
            this.Name = "CategoryView";
            this.Text = "Menadżer Kategorii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CategoryListGroup.ResumeLayout(false);
            this.RemoveCategoryGroup.ResumeLayout(false);
            this.AddCategoryGroup.ResumeLayout(false);
            this.AddCategoryGroup.PerformLayout();
            this.ChangeCategoryNameGroup.ResumeLayout(false);
            this.ChangeCategoryNameGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.GroupBox CategoryListGroup;
        private System.Windows.Forms.GroupBox RemoveCategoryGroup;
        private System.Windows.Forms.Button RemoveCategoryBtn;
        private System.Windows.Forms.GroupBox AddCategoryGroup;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.TextBox NewCategoryNameTextBox;
        private System.Windows.Forms.GroupBox ChangeCategoryNameGroup;
        private System.Windows.Forms.TextBox ChangeCategoryNameTextBox;
        private System.Windows.Forms.Button ChangeCategoryNameBtn;
        private System.Windows.Forms.ListView CategoryList;
    }
}