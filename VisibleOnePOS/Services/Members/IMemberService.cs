using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Member;

namespace VisibleOnePOS.Services.Members
{
    internal interface IMemberService
    {
        Task<ObservableCollection<MemberModel>> GetMembers();
        Task<ObservableCollection<MemberModel>> GetMembersByName();

    }
}
