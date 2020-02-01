using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMatuszewski.PhotoAlbum
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    public partial class AlbumManager : Form
    {
        private BindingList<TextInstance> _albums = new BindingList<TextInstance>();

        public AlbumManager()
        {
            InitializeComponent();
       

        }

        private void AlbumManagerLoaded(object sender, EventArgs e)
        {
            AlbumList.DataSource = _albums;

            LoadPreImportedPhotos();

            LoadAlbums();
        }

        private void LoadPreImportedPhotos()
        {

            AlbumList.Refresh();
        }



        private void SelectAlbum_Click(object sender, EventArgs e)
        {
            var albumView =  new AlbumView(AlbumList.SelectedItem.ToString());
            albumView.Show();
            Hide();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
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
                            _albums.Add(new TextInstance{Name = reader.GetString(0)});
                        }
                    }
                    AlbumList.Refresh();

                }
            });
        }

        private void RemoveAlbumBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.DeleteAlbum(AlbumList.SelectedItems[0].ToString()), (connection, sqlCommand) =>
            {
                Console.WriteLine(connection);
                Console.WriteLine(sqlCommand);
                using (var reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine(reader);
                    LoadAlbums();
                }
            });
        }

        private void AddAlbumBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.CreateAlbum(AlbumNameTextBox.Text), (connection, sqlCommand) =>
            {
                Console.WriteLine(connection);
                Console.WriteLine(sqlCommand);
                using (var reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine(reader);
                    LoadAlbums();
                }
            });
        }

        private void ChangeNameBtn_Click(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.RenameAlbum(AlbumList.SelectedItems[0].ToString(), ChangeNameTextBox.Text), (connection, sqlCommand) =>
            {
                Console.WriteLine(connection);
                Console.WriteLine(sqlCommand);
                using (var reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine(reader);
                    LoadAlbums();
                }
            });
        }
    }

    public class TextInstance
    {
        public string Name;
        public int ID;
        public override string ToString()
        {
            return Name;
        }
    }
}
