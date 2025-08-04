using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Services
{
    public interface ILibraryService
    {
        void AddBook(Book book);
        void BorrowBook(int bookId, int memberId);
        void RegisterMember(Member member);
        void ReturnBook(int bookId, int memberId);
        public void PrintAllBooks();
        public void PrintAllMembers();
        public void PrintAllBorrowRecords();
    }
}