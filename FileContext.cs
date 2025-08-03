using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository
{
    public static class FileContext
    {
        //set the path to the file where the data will be stored ...
        private static string BookFilePath = "books.json";
        private static string MemberFilePath = "members.json";
        private static string BorrowRecordFilePath = "BorrowRecords.json";

        //to load and save book data to file ...
        public static List<Book> LoadBooks()
        {
            if (!File.Exists(BookFilePath))
                return new List<Book>();

            var json = File.ReadAllText(BookFilePath);
            return JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
        }
        public static void SaveBooks(List<Book> books)
        {
            var json = JsonSerializer.Serialize(books);
            File.WriteAllText(BookFilePath, json);
        }
    }
}
