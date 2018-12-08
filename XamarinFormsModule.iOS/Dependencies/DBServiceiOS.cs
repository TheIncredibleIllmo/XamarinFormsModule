using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinFormsModule.Interfaces;
using XamarinFormsModule.iOS.Dependencies;

[assembly: Dependency(typeof(DBServiceiOS))]
namespace XamarinFormsModule.iOS.Dependencies
{
    public class DBServiceiOS : IDBService
    {
        public DBServiceiOS()
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
