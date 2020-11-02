using System;
namespace LibraryDueDateTracker.Models
{
    public class Book
    {
        public int ID { get; }
        public string Title { get; }
        public string Author { get;  }
        public DateTime PublicationDate { get;  }
        public DateTime CheckOutDate { get;  }

        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Book(int id, string title, string author, DateTime publicationDate, DateTime checkoutDate)
        {
            ID = id;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            CheckOutDate = checkoutDate;

            //DueDate = DateTime + 14;
            ReturnDate = null;
        }
    }
}
