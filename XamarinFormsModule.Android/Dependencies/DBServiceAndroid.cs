using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinFormsModule.Droid.Dependencies;
using XamarinFormsModule.Interfaces;

[assembly: Dependency(typeof(DBServiceAndroid))]
namespace XamarinFormsModule.Droid.Dependencies
{
    public class DBServiceAndroid : IDBService
    {
        public DBServiceAndroid()
        {
        }

        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var path = Path.Combine(documentsPath, "WorkshopDB.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
