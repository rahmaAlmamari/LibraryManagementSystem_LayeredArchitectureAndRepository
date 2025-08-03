using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void DeleteBook(int bookId);
        List<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void UpdateBookAuthor(int bookId, string newAuthor);
        void UpdateBookAvailable(int bookId);
        void UpdateBookTitle(int bookId, string newTitle);
    }
}