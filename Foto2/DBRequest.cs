namespace HMatuszewski.PhotoAlbum
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;

    public static class DBRequests
    {
        #region Connection

        public static void MakeRequest(string request, Action<SqlConnection, SqlCommand> callback)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HMatuszewski.PhotoAlbum.Properties.Settings.BDFotoConnectionString"].ConnectionString))
            {
                using (var command = new SqlCommand(request, connection))
                {
                    connection.Open();
                    callback.Invoke(connection,command);
                    connection.Close();

                }
            }
        }

        #endregion

        #region Login

        public static string Login(string username, string pass)
        {
            var sb = new StringBuilder();
            sb.Append("SELECT ID,Admin ");
            sb.Append("FROM [dbo].[Users]");
            sb.Append("WHERE Login = '" + username + "' AND Password = '" + pass + "'");

            return sb.ToString();
        }

        #endregion

        #region Category

        public static string CreateCategory(string name)
        {
            var sb = new StringBuilder();
            sb.Append("INSERT INTO [dbo].[Categories] ([Name]) ");
            sb.Append("VALUES ('" + name + "');");

            return sb.ToString();
        }

        public static string DeleteCategory(string name)
        {
            var sb = new StringBuilder();
            sb.Append("DELETE FROM [dbo].[Categories]");
            sb.Append("WHERE [Name] ='" + name + "';");

            return sb.ToString();
        }

        public static string RenameCategory(string oldName,string newName)
        {
            var sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[Categories]");
            sb.Append("SET [Name] = '"+newName+"'");
            sb.Append("WHERE [Name] = '"+oldName+"'");

            return sb.ToString();
        }

        public static string LoadCategories()
        {
            var sb = new StringBuilder();
            sb.Append("SELECT ALL [Name],[ID] ");
            sb.Append("FROM [dbo].[Categories]");
            sb.Append("ORDER BY [ID] ASC;");
            

            return sb.ToString();
        }

        #endregion

        #region Albums

        public static string CreateAlbum(string name)
        {
            var sb = new StringBuilder();
            sb.Append("INSERT INTO [dbo].[Albums] ([Name]) ");
            sb.Append("VALUES ('" + name + "');");

            return sb.ToString();
        }

        public static string DeleteAlbum(string name)
        {
            var sb = new StringBuilder();
            sb.Append("DELETE FROM [dbo].[Albums]");
            sb.Append("WHERE [Name] ='" + name + "';");

            return sb.ToString();
        }

        public static string RenameAlbum(string oldName, string newName)
        {
            var sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[Album]");
            sb.Append("SET [Name] = '" + newName + "'");
            sb.Append("WHERE [Name] = '" + oldName + "'");

            return sb.ToString();
        }

        public static string LoadAlbums()
        {
            var sb = new StringBuilder();
            sb.Append("SELECT ALL [Name],[ID] ");
            sb.Append("FROM [dbo].[Albums]");
            sb.Append("ORDER BY [ID] ASC;");


            return sb.ToString();
        }

        public static string GetAlbumIndex(string name)
        {
            var sb = new StringBuilder();
            sb.Append("SELECT  [ID] ");
            sb.Append("FROM [dbo].[Albums]");
            sb.Append($"WHERE Name = '{name}';");


            return sb.ToString();
        }

        public static string GetPhotos(int albumID)
        {
            var sb = new StringBuilder();
            sb.Append("SELECT ALL * ");
            sb.Append("FROM [dbo].[Photos]");
            sb.Append($"WHERE Album = '{albumID}';");


            return sb.ToString();
        }

        #endregion

        #region Photos

        public static string AddPhoto(string name, byte[] image, int albumID, int categoryID, int ownerID, string description, string[] tags, string format, Size resolution, int size)
        {
            var sb = new StringBuilder();
  

            sb.Append("INSERT INTO [dbo].[Photos] ([Name],[Owner],[Description],[Tags],[Category],[Album],[Format],[Resolution],[Size],[PhotoData]) ");
            sb.Append($"VALUES ('{name}','{ownerID}','{description}','{string.Join(",",tags)}','{categoryID}','{albumID}','{format}','{resolution.Width}x{resolution.Height}','{size}',@image);");

            return sb.ToString();
        }

        #endregion
    }
}