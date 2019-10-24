using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BooksApp.Models;

namespace BooksApp.Controllers
{
    public class BooksController : ApiController
    {
        List<Book> booklist = new List<Book>()
        {
            new Book{Id=1001,Title="Programming in C",Year=2013,Price=999.99m,Genre="Programming"},
            new Book{Id=1002,Title="Programming in ASP.NET WEB API",Year=2014,Price=769.99m,Genre="Programming"},
            new Book{Id=1003,Title="MicroProcessors",Year=2013,Price=456.99m,Genre="Computers"},
            new Book{Id=1004,Title="CISCO CCNA",Year=2017,Price=1599.99m,Genre="Networking"}
        };
        
        public IEnumerable<Book> GetBooks()
        {
            return booklist;
        }

        public IHttpActionResult GetBooks(int id)
        {
            var book = booklist.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        
        public void PostBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentException("Invalid Object Passed");
            }
            booklist.Add(book);
        }

        public void DeleteBook(int id)
        {
            booklist.RemoveAll(b => b.Id == id);
        }
    }
}
