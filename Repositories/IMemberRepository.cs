using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories
{
    public interface IMemberRepository
    {
        void AddMember(Member member);
        void DeleteMember(int memberId);
        List<Member> GetAllMembers();
        Member GetMemberById(int memberId);
        void UpdateMemberName(int memberId, string NewName);
    }
}