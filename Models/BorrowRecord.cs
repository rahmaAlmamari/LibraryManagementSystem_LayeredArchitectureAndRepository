using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Models
{
    public class BorrowRecord
    {
        public int BorrowRecordId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable to allow for books that haven't been returned yet
        public static int BorrowRecordCount = 0;
        public BorrowRecord()
        {
            BorrowRecordCount++;
            BorrowRecordId = BorrowRecordCount;
        }
    }
}
