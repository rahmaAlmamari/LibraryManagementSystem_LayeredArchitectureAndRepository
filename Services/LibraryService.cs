using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;
using LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Services
{
    public class LibraryService 
    {
        private readonly IBookRepository _BookRepository;

        public LibraryService(IBookRepository book_repository)
        {
            _BookRepository = book_repository;
        }

        //to add new book ...
        public void AddBook(Book book)
        {
            _BookRepository.AddBook(book);
        }
    }
}
