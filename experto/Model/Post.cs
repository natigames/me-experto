using System;
using SQLite;

namespace experto.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id {get; set;}

        [MaxLength(250)]
        public string Experience { get; set; }
    }
}
