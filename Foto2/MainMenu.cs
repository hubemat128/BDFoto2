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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            CategoryBtn.Enabled = LoginPage.IsAdmin;
        }

        private void AddClicked(object sender, EventArgs e)
        {
            var view = new AddPhotoPage();
            view.Show();
            Hide();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            var view = new CategoryView();;
            view.Show();
            Hide();
        }

        private void AlbumBtn_Click(object sender, EventArgs e)
        {
            var view = new AlbumManager();
            view.Show();
            Hide();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            var view = new PhotoSearcher();
            view.Show();
            Hide();
        }
    }
}
