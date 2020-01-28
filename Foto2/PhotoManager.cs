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
    public partial class PhotoManager : Form
    {
        public PhotoManager(Image photo)
        {
            InitializeComponent();
            PhotoPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoPreview.Image = photo;
        }

        private void DescriptionGroupEnter(object sender, EventArgs e)
        {

        }

        private void AlbumLabelClicked(object sender, EventArgs e)
        {

        }

        private void CreationDateClicked(object sender, EventArgs e)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}
