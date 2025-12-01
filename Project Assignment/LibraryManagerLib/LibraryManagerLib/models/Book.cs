using System;

namespace LibraryManagerLib.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Category { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
