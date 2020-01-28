namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AlbumView : Form
    {
        private readonly List<Photo> _photos = new List<Photo>();

        public AlbumView(string album)
        {
            InitializeComponent();

            // Initialize myListView.
            PhotoList.Dock = DockStyle.Fill;
            PhotoList.View = View.Tile;

            // Initialize the tile size.
            PhotoList.TileSize = new Size(200, 100);

            // Initialize the item icons.
            ImageList = new ImageList();

            if (album == "PreImportedPhotos")
            {
                var root = Application.StartupPath;
                var preImported = Path.Combine(root, "PreImportedPhotos");

                var images = Directory.EnumerateFiles(preImported).ToList();


                foreach (var image in images)
                {
                    var renFace = Image.FromFile(image);
                    ImageList.Images.Add(renFace);
                    PhotoList.Items.Add(new ListViewItem(new[] {Path.GetFileName(image)}, PhotoList.Items.Count));
                }


                ImageList.ImageSize = new Size(100, 100);
                PhotoList.LargeImageList = ImageList;

                // Add column headers so the subitems will appear.
                PhotoList.Columns.AddRange(new[]
                    {new ColumnHeader()});
            }

            var albumID = -1;
            DBRequests.MakeRequest(DBRequests.GetAlbumIndex(album), (connection, command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            albumID = reader.GetInt32(0);
                        }
                    }
                }
            });
            DBRequests.MakeRequest(DBRequests.GetPhotos(albumID), (connection, command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
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
                    }
                }
            });


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


        public Image ImageFromByteArray(byte[] byteIn)
        {
            using (var ms = new MemoryStream())
            {
                ms.Write(byteIn, 0, byteIn.Length);
                var imageOut = Image.FromStream(ms);
                return imageOut;
            }
        }

        private void PhotoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var photo = _photos[PhotoList.SelectedIndices[0]];
            var photoManager = new PhotoManager(ImageFromByteArray(photo.PhotoData));
            photoManager.Show();
        }
    }
}