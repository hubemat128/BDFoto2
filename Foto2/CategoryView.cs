namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class CategoryView : Form
    {
        public CategoryView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         LoadCategories();   
        }

        private void LoadCategories()
        {
            var categories = new List<ListViewItem>();
            CategoryList.Items.Clear();
            DBRequests.MakeRequest(DBRequests.LoadCategories(), (connection, sqlCommand) =>
            {
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            categories.Add(new ListViewItem(reader.GetString(0)));
                        }
                    }

                    CategoryList.Alignment = ListViewAlignment.Left;
                    CategoryList.Dock = DockStyle.Fill;
                    CategoryList.View = View.List;

                    // Initialize the tile size.
                    CategoryList.TileSize = new Size(100, 25);
                    CategoryList.Items.AddRange(categories.ToArray());

                }
            });
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.CreateCategory(NewCategoryNameTextBox.Text), (connection, sqlCommand) =>
            {
                Console.WriteLine(connection);
                Console.WriteLine(sqlCommand);
                using (var reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine(reader);
                    LoadCategories();
                }
            });
        }

        private void RemoveCategoryBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.DeleteCategory(CategoryList.SelectedItems[0].Text), (connection, sqlCommand) =>
            {
                Console.WriteLine(connection);
                Console.WriteLine(sqlCommand);
                using (var reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine(reader);
                    LoadCategories();
                }
            });
        }

        private void ChangeCategoryNameBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.RenameCategory(CategoryList.SelectedItems[0].Text,ChangeCategoryNameTextBox.Text), (connection, sqlCommand) =>
            {
                Console.WriteLine(connection);
                Console.WriteLine(sqlCommand);
                using (var reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine(reader);
                    LoadCategories();
                }
            });
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}