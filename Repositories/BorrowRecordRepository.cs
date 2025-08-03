using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories
{
    class BorrowRecordRepository
    {
        //to get all BorrowRecord ..
        public List<BorrowRecord> GetAllBorrowRecords()
        {
            return FileContext.LoadBorrowRecords();
        }
    }
}
