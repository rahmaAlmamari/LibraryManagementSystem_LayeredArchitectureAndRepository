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

        //to add a new member ...
        public void AddMember(Member member)
        {
            var members = GetAllMembers();
            members.Add(member);
            FileContext.SaveMembers(members);
        }

        //to update member name ...
        public void UpdateMemberName(int memberId, string NewName) 
        {
            var members = GetAllMembers();
            var member = members.FirstOrDefault(m => m.MemberId == memberId);
            if (member != null)
            {
                member.Name = NewName;
                FileContext.SaveMembers(members);
            }
        }
    }
}
