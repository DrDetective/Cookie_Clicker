using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Cookie_Clicker
{
    internal class sqlite_stuff
    {
        [PrimaryKey, AutoIncrement]
        public string Name { get; set; }
        public int Bank { get; set; }

    }
}
