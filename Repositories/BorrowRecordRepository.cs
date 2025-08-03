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

        //to get BorrowRecord by id ...
        public BorrowRecord GetBorrowRecordById(int borrowRecordId)
        {
            return GetAllBorrowRecords().FirstOrDefault(br => br.BorrowRecordId == borrowRecordId);
        }
    }
}
