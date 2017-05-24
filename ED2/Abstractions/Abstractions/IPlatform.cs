using SQLite.Net.Interop;

namespace Abstractions
{
    public interface IPlatform
    {
        string GetFilePath();

        ISQLitePlatform GetPlatform();
    }
}