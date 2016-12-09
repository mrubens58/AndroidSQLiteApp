using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using FormsMenu.Android;
using SQLite;


[assembly: Dependency(typeof(SQLite_Android))]

namespace FormsMenu.Android
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
        }

        #region ISQLite implementation

        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "Contacts.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);

           // var platform = new SQLite.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.SQLiteConnection(path);

            return connection;
        }

        #endregion
        
    }
}