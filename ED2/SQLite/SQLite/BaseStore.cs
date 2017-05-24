using System;
using System.Threading.Tasks;
using Abstractions;

namespace Stores
{
    public class BaseStore : IBaseStore
    {
        protected SQLite.Net.Async.SQLiteAsyncConnection _sqLiteAsyncConnection;
        protected IPlatform _platform;

        protected SQLite.Net.Async.SQLiteAsyncConnection GetConnection()
        {
            var filePath = _platform.GetFilePath();
            var platform = _platform.GetPlatform();

            var connectionFactory = new Func<SQLite.Net.SQLiteConnectionWithLock>(() => new SQLite.Net.SQLiteConnectionWithLock(platform, new SQLite.Net.SQLiteConnectionString(filePath, storeDateTimeAsTicks: false)));


            var asyncConnection = new SQLite.Net.Async.SQLiteAsyncConnection(connectionFactory);


            return asyncConnection;
        }

        public async Task<string> TableExists(String tableName)
        {


            var result = await _sqLiteAsyncConnection.ExecuteScalarAsync<string>("SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "'");


            return result;
        }
        
    }





}

