using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Jokes
{
    class Constants
    {
        public const string DatabaseFilename = "JokeSQLite.db3";
        public const SQLite.SQLiteOpenFlags Flags = 
            //Open in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite | 
            //Create if none exists
            SQLite.SQLiteOpenFlags.Create | 
            //enable multithreaded access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}
