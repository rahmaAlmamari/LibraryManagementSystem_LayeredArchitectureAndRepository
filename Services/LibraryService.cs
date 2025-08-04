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
        public void BorrowBook(string bookId, string memberId)
        {
            var book = _BookRepository.GetBookById(int.Parse(bookId));
            var member = _MemberRepository.GetMemberById(int.Parse(memberId));
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
        public void ReturnBook(string bookId, string memberId)
        {
            var book = _BookRepository.GetBookById(int.Parse(bookId));
            var member = _MemberRepository.GetMemberById(int.Parse(memberId));
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
    }
}
