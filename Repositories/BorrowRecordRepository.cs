using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories
{
    public class BorrowRecordRepository : IBorrowRecordRepository
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

        //to add a new BorrowRecord ...
        public void AddBorrowRecord(BorrowRecord borrowRecord)
        {
            var borrowRecords = GetAllBorrowRecords();
            borrowRecords.Add(borrowRecord);
            FileContext.SaveBorrowRecords(borrowRecords);
        }

        //to update BorrowDate for BorrowRecord ...
        public void UpdateBorrowDate(int borrowRecordId, DateTime newBorrowDate)
        {
            var borrowRecords = GetAllBorrowRecords();
            var borrowRecord = borrowRecords.FirstOrDefault(br => br.BorrowRecordId == borrowRecordId);
            if (borrowRecord != null)
            {
                borrowRecord.BorrowDate = newBorrowDate;
                FileContext.SaveBorrowRecords(borrowRecords);
            }
        }

        //to update ReturnDate for BorrowRecord ...
        public void UpdateReturnDate(int borrowRecordId, DateTime returnDate)
        {
            var borrowRecords = GetAllBorrowRecords();
            var borrowRecord = borrowRecords.FirstOrDefault(br => br.BorrowRecordId == borrowRecordId);
            if (borrowRecord != null)
            {
                borrowRecord.ReturnDate = returnDate;
                FileContext.SaveBorrowRecords(borrowRecords);
            }
        }

        //to delete BorrowRecord by id ...
        public void DeleteBorrowRecord(int borrowRecordId)
        {
            var borrowRecords = GetAllBorrowRecords();
            var borrowRecord = borrowRecords.FirstOrDefault(br => br.BorrowRecordId == borrowRecordId);
            if (borrowRecord != null)
            {
                borrowRecords.Remove(borrowRecord);
                FileContext.SaveBorrowRecords(borrowRecords);
            }
        }
    }
}
