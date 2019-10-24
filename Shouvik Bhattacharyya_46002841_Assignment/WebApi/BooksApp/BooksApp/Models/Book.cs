﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

    }
}