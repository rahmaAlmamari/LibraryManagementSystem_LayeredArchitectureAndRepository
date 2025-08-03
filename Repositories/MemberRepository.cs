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
    }
}
