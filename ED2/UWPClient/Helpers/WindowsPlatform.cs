
using Abstractions;
using SQLite.Net.Interop;
using SQLite.Net.Platform.WinRT;

namespace SQLite
{
    public class WindowsPlatform : IPlatform
    {

        public string GetFilePath()
        {
            var path = global::Windows.Storage.ApplicationData.Current.LocalFolder.Path;

            return System.IO.Path.Combine(path, "estate.sqlite3");
        }

        public ISQLitePlatform GetPlatform()
        {
            // return null;
            return new SQLitePlatformWinRT();
        }
    }
}