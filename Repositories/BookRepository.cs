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
    }
}
