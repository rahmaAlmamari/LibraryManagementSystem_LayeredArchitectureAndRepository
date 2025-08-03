using LibraryManagementSystem_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Repositories
{
    class MemberRepository
    {
        //to get all members ...
        public List<Member> GetAllMembers()
        {
            return FileContext.LoadMembers();
        }

        //to get a member by id ...
        public Member GetMemberById(int memberId)
        {
            return GetAllMembers().FirstOrDefault(m => m.MemberId == memberId);
        }
    }
}
