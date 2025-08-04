using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_LayeredArchitectureAndRepository.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public static int MemberCount = 0;
        public Member()
        {
            MemberCount++;
            MemberId = MemberCount;
        }
    }
}
