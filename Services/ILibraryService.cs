using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Services
{
    public interface ILibraryService
    {
        void AddBook(Book book);
        void RegisterMember(Member member);
    }
}