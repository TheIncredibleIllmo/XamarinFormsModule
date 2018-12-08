using System;
using SQLite;

namespace XamarinFormsModule.Models
{
    [Table("ToDoEvents")]
    public class ToDoEvent
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        //[Ignore]
        //public Venue Dog { get; set; }
    }
}
