using LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories;
using LibraryManagementSystem_LayeredArchitectureAndRepository.Services;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();
            IMemberRepository memberRepository = new MemberRepository();
            IBorrowRecordRepository borrowRecordRepository = new BorrowRecordRepository();
            ILibraryService libraryService = new LibraryService(bookRepository, memberRepository, borrowRecordRepository);


        }
    }
}
