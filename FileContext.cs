using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository
{
    public static class FileContext
    {
        //set the path to the file where the data will be stored ...
        private static string BookFilePath = "books.json";
        private static string MemberFilePath = "members.json";
        private static string BorrowRecordFilePath = "BorrowRecords.json";
    }
}
