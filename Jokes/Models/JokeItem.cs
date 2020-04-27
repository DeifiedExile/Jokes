using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jokes.Models
{
    public class JokeItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
