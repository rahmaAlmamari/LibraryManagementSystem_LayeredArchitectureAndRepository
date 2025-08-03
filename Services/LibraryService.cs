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
    }
}
