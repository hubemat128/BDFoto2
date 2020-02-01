namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class PhotoManager : Form
    {
        private readonly Photo _activePhoto;
        private readonly BindingList<TextInstance> _categories = new BindingList<TextInstance>();

        public PhotoManager(Photo photo)
        {
            InitializeComponent();
            _activePhoto = photo;
            LoadCategories();
            PhotoPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoPreview.Image = ImageFromByteArray(photo.PhotoData);
            PhotoDescTextBox.Text = photo.Desc;
            PhotoDescriptionLabel.Text = photo.Desc;
            ResolutionLabel.Text += photo.Resolution;
            DBRequests.MakeRequest(DBRequests.GetAlbumName(photo.Album), (connection, command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            AlbumLabel.Text += reader.GetString(0);
                        }
                    }
                }
            });
            DBRequests.MakeRequest(DBRequests.GetCategoryName(photo.Category), (connection, command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CategoryLabel.Text += reader.GetString(0);
                        }
                    }
                }
            });
            FormatLabel.Text += photo.Format;
            SizeLabel.Text += GetBytesReadable(photo.Size);
            CreationDateLabel.Text += photo.CreationDate;
            NameLabel.Text += photo.Name;
            TagsLabel.Text = photo.Tags.Replace(",", ", ");
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

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        public string GetBytesReadable(long i)
        {
            var absoluteValue = i < 0 ? -i : i;
            string SizeName;
            double ReadableSize;
            if (absoluteValue >= 0x1000000000000000)
            {
                SizeName = "EB";
                ReadableSize = i >> 50;
            }
            else if (absoluteValue >= 0x4000000000000)
            {
                SizeName = "PB";
                ReadableSize = i >> 40;
            }
            else if (absoluteValue >= 0x10000000000)
            {
                SizeName = "TB";
                ReadableSize = i >> 30;
            }
            else if (absoluteValue >= 0x40000000)
            {
                SizeName = "GB";
                ReadableSize = i >> 20;
            }
            else if (absoluteValue >= 0x100000)
            {
                SizeName = "MB";
                ReadableSize = i >> 10;
            }
            else if (absoluteValue >= 0x400)
            {
                SizeName = "KB";
                ReadableSize = i;
            }
            else
            {
                return i.ToString("0 B");
            }

            ReadableSize = ReadableSize / 1024;
            return ReadableSize.ToString("0.### ") + SizeName;
        }

        private void ChangePhotoDesc_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.ChangePhotoDescription(_activePhoto.ID, PhotoDescTextBox.Text), (connection, command) =>
                {
                    using (var reader = command.ExecuteReader())
                    {
                        PhotoDescriptionLabel.Text = PhotoDescTextBox.Text;
                    }
                }
            );
        }

        private void ChangePhotoName_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.RenamePhoto(_activePhoto.ID, PhotoNameTextBox.Text), (connection, command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    NameLabel.Text = PhotoNameTextBox.Text;
                }
            });
        }

        private void SelectCategoryBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.ChangePhotoCategory(_activePhoto.ID, _categories[CategoryList.SelectedIndices[0]].ID), (connection, command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    CategoryLabel.Text = _categories[CategoryList.SelectedIndices[0]].Name;
                }
            });
        }

        private void LoadCategories()
        {
            var categories = new List<ListViewItem>();
            _categories.Clear();
            CategoryList.Items.Clear();
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
                            categories.Add(new ListViewItem(textInstance.Name));
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

        private void RemovePhotoBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.DeletePhoto(_activePhoto.ID), (connection, sqlCommand) =>
            {
                sqlCommand.ExecuteNonQuery();
                var view = new AlbumManager();
                view.Show();
                Hide();
            });
        }
    }
}