using LibraryManagementSystem_LayeredArchitectureAndRepository.Helper;
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
                        //to get user input for adding a book ...
                        string title = Validation.StringNamingValidation("book title");
                        string author = Validation.StringNamingValidation("book author");
                        //to create a new book object ...
                        Models.Book NewBook = new Models.Book();
                        NewBook.Title = title;
                        NewBook.Author = author;
                        NewBook.IsAvailable = true;
                        //to add the book using library service
                        libraryService.AddBook(NewBook);
                        Console.WriteLine("Book added successfully.");
                        break;
                    case '2':
                        //to get user input for registering a member ...
                        string memberName = Validation.StringNamingValidation("member name");
                        //to create a new member object ...
                        Models.Member NewMember = new Models.Member();
                        NewMember.Name = memberName;
                        //to register the member using library service
                        libraryService.RegisterMember(NewMember);
                        Console.WriteLine("Member registered successfully.");
                        break;


                }
                } while (exit) ;  
        }
    }
}
