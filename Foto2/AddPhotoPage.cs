namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AddPhotoPage : Form
    {
        private Image _loadedImage;
        private string _loadedImageExtension;

        private readonly BindingList<TextInstance> _albums = new BindingList<TextInstance>();
        private readonly BindingList<TextInstance> _tags = new BindingList<TextInstance>();
        private readonly BindingList<TextInstance> _categories = new BindingList<TextInstance>();

        public AddPhotoPage()
        {
            InitializeComponent();

            AlbumListBox.DataSource = _albums;
            TagListBox.DataSource = _tags;
            CategoryListBox.DataSource = _categories;

            LoadAlbums();
            LoadCategories();
        }

        private void add_photo_Load(object sender, EventArgs e)
        {
        }


        private void ChoosePhotoClicked(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Browse Images Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = @"Image Files(*.BMP;*.JPG)|*.BMP;*.JPG|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true

                // ReadOnlyChecked = true,
                //ShowReadOnly = true  
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _loadedImage = Image.FromFile(dialog.FileName);
                    _loadedImageExtension = Path.GetExtension(dialog.FileName);
                    FileNameTextBox.Text = Path.GetFileName(dialog.FileName);
                    PathTextBox.Text = dialog.FileName;
                    PreviewImage.Image = _loadedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddPhotoClicked(object sender, EventArgs e)
        {
            if (_loadedImage == null) return;
            var imageData = ImageToByteArray(_loadedImage);


            var constring = DBRequests.AddPhoto(PhotoNameTextBox.Text, imageData, (AlbumListBox.SelectedItems[0] as TextInstance).ID, (CategoryListBox.SelectedItems[0] as TextInstance).ID, LoginPage.LoggedUser, PhotoDescTextBox.Text,
                _tags.Select((instance, i) => instance.Name).ToArray(), _loadedImageExtension, _loadedImage.Size, imageData.Length);

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HMatuszewski.PhotoAlbum.Properties.Settings.BDFotoConnectionString"].ConnectionString))
            {
                using (var command = new SqlCommand(constring, connection))
                {
                    command.Parameters.Add("@image", SqlDbType.Binary).Value = imageData;
                    connection.Open();

                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }

     
            
        }


        private void ReturnClicked(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }


        private void LoadAlbums()
        {
            DBRequests.MakeRequest(DBRequests.LoadAlbums(), (connection, sqlCommand) =>
            {
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            _albums.Add(new TextInstance {Name = reader.GetString(0), ID = reader.GetInt32(1)});
                        }
                    }

                    AlbumListBox.Refresh();
                }
            });
        }


        private void LoadCategories()
        {
            DBRequests.MakeRequest(DBRequests.LoadCategories(), (connection, sqlCommand) =>
            {
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            _categories.Add(new TextInstance {Name = reader.GetString(0), ID = reader.GetInt32(1)});
                        }
                    }

                    CategoryListBox.Refresh();
                }
            });
        }

        private void AddTagBtn_Click(object sender, EventArgs e)
        {
            _tags.Add(new TextInstance {Name = TagTextBox.Text});
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}