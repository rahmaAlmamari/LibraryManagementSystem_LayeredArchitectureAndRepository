using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;
using LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IBookRepository _BookRepository;
        private readonly IMemberRepository _MemberRepository;
        private readonly IBorrowRecordRepository _BorrowRecordRepository;

        public LibraryService(IBookRepository book_repository, IMemberRepository memberRepository, IBorrowRecordRepository borrowRecordRepository)
        {
            _BookRepository = book_repository;
            _MemberRepository = memberRepository;
            _BorrowRecordRepository = borrowRecordRepository;
        }

        //to add new book ...
        public void AddBook(Book book)
        {
            _BookRepository.AddBook(book);
        }

        //to register new member ...
        public void RegisterMember(Member member)
        {
            _MemberRepository.AddMember(member);
        }

        //to borrow a book ...
        public void BorrowBook(int bookId, int memberId)
        {
            var book = _BookRepository.GetBookById(bookId);
            var member = _MemberRepository.GetMemberById(memberId);
            if (book != null && member != null && book.IsAvailable)
            {
                var borrowRecord = new BorrowRecord
                {
                    BookId = book.BookId,
                    MemberId = member.MemberId,
                    BorrowDate = DateTime.Now,
                    ReturnDate = null
                };
                _BorrowRecordRepository.AddBorrowRecord(borrowRecord);
                _BookRepository.UpdateBookAvailable(book.BookId);
                Console.WriteLine($"Book '{book.Title}' borrowed by member '{member.Name}'.");
            }
            else
            {
                throw new Exception("Book is not available or member does not exist.");
            }
        }

        //to return a book ...
        public void ReturnBook(int bookId, int memberId)
        {
            var book = _BookRepository.GetBookById(bookId);
            var member = _MemberRepository.GetMemberById(memberId);
            if (book != null && member != null)
            {
                var borrowRecord = _BorrowRecordRepository.GetAllBorrowRecords()
                    .FirstOrDefault(br => br.BookId == book.BookId && br.MemberId == member.MemberId && br.ReturnDate == null);
                if (borrowRecord != null)
                {
                    _BorrowRecordRepository.UpdateReturnDate(borrowRecord.BorrowRecordId, DateTime.Now);
                    _BookRepository.UpdateBookAvailable(book.BookId);
                    Console.WriteLine($"Book '{book.Title}' returned by member '{member.Name}'.");
                }
                else
                {
                    throw new Exception("No active borrow record found for this book and member.");
                }
            }
            else
            {
                throw new Exception("Book or member does not exist.");
            }
        }

        //to print all books details ...
        public void PrintAllBooks()
        {
            var books = _BookRepository.GetAllBooks();
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
            }
            else
            {
                Console.WriteLine("Books in the library:");
                foreach (var book in books)
                {
                    Console.WriteLine($"ID: {book.BookId}\n" +
                                      $"Title: {book.Title}\n" +
                                      $"Author: {book.Author}\n" +
                                      $"Available: {book.IsAvailable}");
                }
            }
        }

        //to print all members details ...
        public void PrintAllMembers()
        {
            var members = _MemberRepository.GetAllMembers();
            if (members.Count == 0)
            {
                Console.WriteLine("No members registered in the library.");
            }
            else
            {
                Console.WriteLine("Registered members:");
                foreach (var member in members)
                {
                    Console.WriteLine($"ID: {member.MemberId}\n" +
                                      $"Name: {member.Name}");
                }
            }

        }
    }
}
