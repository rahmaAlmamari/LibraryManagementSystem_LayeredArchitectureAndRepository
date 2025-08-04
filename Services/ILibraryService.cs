using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Services
{
    public interface ILibraryService
    {
        void AddBook(Book book);
        void BorrowBook(string bookId, string memberId);
        void RegisterMember(Member member);
        void ReturnBook(string bookId, string memberId);
    }
}