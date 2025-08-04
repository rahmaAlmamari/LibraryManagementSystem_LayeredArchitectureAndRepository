using LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories;
using LibraryManagementSystem_LayeredArchitectureAndRepository.Services;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to create instances of repositories and services
            IBookRepository bookRepository = new BookRepository();
            IMemberRepository memberRepository = new MemberRepository();
            IBorrowRecordRepository borrowRecordRepository = new BorrowRecordRepository();
            ILibraryService libraryService = new LibraryService(bookRepository, memberRepository, borrowRecordRepository);
            //to create main menu ...
            char choice;
            bool exit = true;
            do
            {
                //to display menu options
                Console.WriteLine("Welcome to the Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Register Member");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. View All Books");
                Console.WriteLine("6. View All Members");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Please enter your choice: ");
                //to get user input
                choice = char.Parse(Console.ReadLine());
                //to call the appropriate method based on user choice
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Book Author: ");
                        string author = Console.ReadLine();
                        libraryService.AddBook(new Models.Book { Title = title, Author = author, IsAvailable = true });
                        Console.WriteLine("Book added successfully.");
                        break;



                }
                } while (exit) ;  
        }
    }
}
