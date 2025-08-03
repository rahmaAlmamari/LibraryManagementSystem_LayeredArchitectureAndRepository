using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories
{
    class BookRepository
    {
        //to get all books ...
        public List<Book> GetAllBooks()
        {
            return FileContext.LoadBooks();
        }

        //to get a book by id ...
        public Book GetBookById(int bookId)
        {
            return GetAllBooks().FirstOrDefault(b => b.BookId == bookId);
        }

        //to add a new book ...
        public void AddBook(Book book)
        {
            var books = GetAllBooks();
            books.Add(book);
            FileContext.SaveBooks(books);
        }

        //to update book IsAvailable ...
        public void UpdateBookAvailable(int bookId)
        {
            var books = GetAllBooks();
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)
            {
                book.IsAvailable = !book.IsAvailable; // Toggle availability
                FileContext.SaveBooks(books);
            }
        }

    }
}
