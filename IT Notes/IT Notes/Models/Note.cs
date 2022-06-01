﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace IT_Notes.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Picture { get; set; }

    }
}
