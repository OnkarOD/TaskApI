using System;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;


public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Book> Books { get; set; }
    }


