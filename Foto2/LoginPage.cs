namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Text;
    using System.Windows.Forms;

    public partial class LoginPage : Form
    {
        public static int LoggedUser = -1;
        public static bool IsAdmin = false;

        public LoginPage()
        {
            InitializeComponent();
        }


        private void Login(object sender, EventArgs e)
        {
            DBRequests.MakeRequest(DBRequests.Login(LoginTextBox.Text, PassTextBox.Text), (sqlConnetion,sqlCommand) =>
            {

                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        LoggedUser = (int) reader.GetValue(0);
                        IsAdmin = (int) reader.GetValue(1) == 1;
                        Console.WriteLine("Logged as User:" + LoggedUser);
                        var mainMenu = new MainMenu();
                        mainMenu.Show();
                        Hide();
                    }
                }
            });

         
        }
    }
}