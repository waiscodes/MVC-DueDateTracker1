using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDueDateTracker.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryDueDateTracker.Controllers
{
    public class BookController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public static List<Book> Books = new List<Book>();

        public IActionResult Create(int id, string title, string author, DateTime publicationDate, DateTime checkoutDate)
        {
            try
            {
                CreateBook(id, title.Trim(), author.Trim(), publicationDate, checkoutDate);
                ViewBag.Success = "Book successfully added";
            }
            catch (Exception e)
            {
                ViewBag.Fail = e.Message;
            }
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Books = Books;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public void CreateBook(int id, string title, string author, DateTime publicationDate, DateTime checkoutDate)
        {
            string anyIds = Books.Where(x => x.ID == id).ToString();

            if (anyIds.Any())
            {
                Books.Add(new Book(id, title, author, publicationDate, checkoutDate));
            }
            else
            {
                throw new Exception("Id already exists bro");
            }
        }

        public void GetBookById(int id)
        {
        }
        public void ExtendDueDateForBookByID(int id)
        {
        }
        public void ReturnBookByID(int id)
        {
        }
        public void DeleteBookByID(int id)
        {
        }


    }
}
