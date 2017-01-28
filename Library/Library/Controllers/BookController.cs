using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<Book> listOfBooks = new List<Book>();
            BookContext db = new BookContext();
            using (db)
            {
                db.Books.Add(new Book() { Name = "C#", Description = "Programming Book", Price = 240 });
                db.SaveChanges();
                var books = from b in db.Books
                            select b;
                listOfBooks.AddRange(books);
            }         
            
            
            ViewBag.Message = "Страница отображения книг";
            return View(listOfBooks);
        }
    }
}