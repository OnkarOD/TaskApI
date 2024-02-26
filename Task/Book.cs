
using System;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;


public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Quantity { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Author Author { get; set; }
    }


