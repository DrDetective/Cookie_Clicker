using Microsoft.Maui.Controls;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Clicker
{ 
    internal class SQLite__LOCAL_
    {
        static string DBpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"yadata.db");
        SQLiteConnection db = new SQLiteConnection(DBpath);
        public void DatabaseConfig()
        {
            db.CreateTable<sqlite_stuff>();
        }
    }
}
