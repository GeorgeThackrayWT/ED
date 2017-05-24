using System;
using Abstractions;
using SQLite.Net.Interop;

namespace Stores
{
    public class AndroidPlatform : IPlatform
    {
        public string GetFilePath()
        {

            // look this up 
            return "";
        }

        public ISQLitePlatform GetPlatform()
        {
            throw new NotImplementedException();
        }
    }
}