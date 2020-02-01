namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;


    public partial class PhotoSearcher : Form
    {
        private readonly BindingList<TextInstance> _categories = new BindingList<TextInstance>();
        private readonly BindingList<TextInstance> _albums = new BindingList<TextInstance>();
        private readonly List<Photo> _photos = new List<Photo>();

        public PhotoSearcher()
        {
            InitializeComponent();

            LoadCategories();
            LoadAlbums();
        }

        private void SelectedPhotoClicked(object sender, EventArgs e)
        {
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            _photos.Clear();
            var query = DBRequests.FindPhoto();
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text)) query = query.WithName(NameTextBox.Text);
            if (!string.IsNullOrWhiteSpace(CategoryCombo.Text)) query = query.WithCategory(_categories[CategoryCombo.SelectedIndex].ID);
            if (!string.IsNullOrWhiteSpace(AlbumCombo.Text)) query = query.WithAlbum(_albums[AlbumCombo.SelectedIndex].ID);
            if (!string.IsNullOrWhiteSpace(TagTextBox.Text)) query = query.WithTag(TagTextBox.Text);

            var queryString = query.ToString();
            var wherePosition = queryString.IndexOf("WHERE", 0);
            var firstPart = queryString.Substring(0, wherePosition+5);
            var secondPart = queryString.Substring(wherePosition + 5, queryString.Length-firstPart.Length);
            secondPart = secondPart.Replace("WHERE", "OR");
            var newQueryString = firstPart + secondPart;

            DBRequests.MakeRequest(newQueryString, (connection, command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine();

                            _photos.Add(new Photo
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Owner = reader.GetInt32(2),
                                Desc = reader.GetString(3),
                                Tags = reader.GetString(4),
                                Category = reader.GetInt32(5),
                                Album = reader.GetInt32(6),
                                Format = reader.GetString(7),
                                Resolution = reader.GetString(8),
                                CreationDate = reader.GetDateTime(9).ToLongDateString(),
                                Size = reader.GetInt32(10),
                                PhotoData = reader.GetValue(11) as byte[]
                            });
                        }

                        // Initialize myListView.
                        PhotoList.View = View.Tile;

                        // Initialize the tile size.
                        PhotoList.TileSize = new Size(200, 100);

                        // Initialize the item icons.
                        var ImageList = new ImageList();

                        foreach (var image in _photos)
                        {
                            var renFace = ImageFromByteArray(image.PhotoData);
                            ImageList.Images.Add(renFace);
                            PhotoList.Items.Add(new ListViewItem(new[] {image.Name}, PhotoList.Items.Count));
                        }


                        ImageList.ImageSize = new Size(100, 100);
                        PhotoList.LargeImageList = ImageList;

                        // Add column headers so the subitems will appear.
                        PhotoList.Columns.AddRange(new[]
                            {new ColumnHeader()});
                    }
                }
            });
        }

        public Image ImageFromByteArray(byte[] byteIn)
        {
            using (var ms = new MemoryStream())
            {
                ms.Write(byteIn, 0, byteIn.Length);
                var imageOut = Image.FromStream(ms);
                return imageOut;
            }
        }

        private void ShowPhotoBtn_Click(object sender, EventArgs e)
        {
            if (PhotoList.SelectedItems.Count != 1) return;

            var photo = _photos[PhotoList.SelectedIndices[0]];
            var photoManager = new PhotoManager(photo);
            photoManager.Show();
        }

        private void LoadCategories()
        {
            _categories.Clear();
            CategoryCombo.Items.Clear();
            DBRequests.MakeRequest(DBRequests.LoadCategories(), (connection, sqlCommand) =>
            {
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var textInstance = new TextInstance {ID = reader.GetInt32(1), Name = reader.GetString(0)};
                            _categories.Add(textInstance);
                        }
                    }


                    CategoryCombo.Items.AddRange(_categories.ToArray());
                }
            });
        }

        private void LoadAlbums()
        {
            _albums.Clear();
            AlbumCombo.Items.Clear();
            DBRequests.MakeRequest(DBRequests.LoadAlbums(), (connection, sqlCommand) =>
            {
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var textInstance = new TextInstance {ID = reader.GetInt32(1), Name = reader.GetString(0)};
                            _albums.Add(textInstance);
                        }
                    }


                    AlbumCombo.Items.AddRange(_albums.ToArray());
                }
            });
        }

        private void PhotoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhotoPreview.Image = ImageFromByteArray(_photos[PhotoList.SelectedIndices[0]].PhotoData);
            PhotoPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}