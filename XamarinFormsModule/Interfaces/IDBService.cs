using System;
using SQLite;

namespace XamarinFormsModule.Interfaces
{
    public interface IDBService
    {
        SQLiteAsyncConnection GetConnection();
    }
}
