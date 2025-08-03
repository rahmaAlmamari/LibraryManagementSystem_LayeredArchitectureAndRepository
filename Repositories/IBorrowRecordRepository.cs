using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories
{
    internal interface IBorrowRecordRepository
    {
        void AddBorrowRecord(BorrowRecord borrowRecord);
        void DeleteBorrowRecord(int borrowRecordId);
        List<BorrowRecord> GetAllBorrowRecords();
        BorrowRecord GetBorrowRecordById(int borrowRecordId);
        void UpdateBorrowDate(int borrowRecordId, DateTime newBorrowDate);
        void UpdateReturnDate(int borrowRecordId, DateTime returnDate);
    }
}