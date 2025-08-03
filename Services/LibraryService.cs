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

        public LibraryService(IBookRepository book_repository, IMemberRepository memberRepository)
        {
            _BookRepository = book_repository;
            _MemberRepository = memberRepository;
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
