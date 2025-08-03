using LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IBankAccountRepository repo = new BankAccountRepository();
            //IBankService bankService = new BankService(repo);
            IBookRepository bookRepository = new BookRepository();
            IMemberRepository memberRepository = new MemberRepository();
            IBorrowRecordRepository borrowRecordRepository = new BorrowRecordRepository();
            ILibraryService libraryService = new LibraryService(bookRepository, memberRepository, borrowRecordRepository);


        }
    }
}
