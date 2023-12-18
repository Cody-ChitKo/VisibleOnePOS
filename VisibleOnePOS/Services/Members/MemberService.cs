using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Member;

namespace VisibleOnePOS.Services.Members
{
    internal class MemberService : IMemberService
    {
        public async Task<ObservableCollection<MemberModel>> GetMembers()
        {
            ObservableCollection<MemberModel> Members = new ObservableCollection<MemberModel>
            {
                new MemberModel
                {
                    MemberId = 1,
                    MemberName = "John Doe",
                    Email = "john@example.com",
                    Phone = "0999999999",
                    TotalPoints = "100",
                    RedeemedPoints = 20,
                    Status = "Active",
                    RegistrationDate = DateTime.Now
                },
                new MemberModel
                {
                    MemberId = 1,
                    MemberName = "Cody",
                    Email = "Cody@example.com",
                    Phone = "09791820886",
                    TotalPoints = "100",
                    RedeemedPoints = 20,
                    Status = "Active",
                    RegistrationDate = DateTime.Now
                },
                new MemberModel
                {
                    MemberId = 1,
                    MemberName = "Zak",
                    Email = "Zak@example.com",
                    Phone = "0988888888",
                    TotalPoints = "100",
                    RedeemedPoints = 20,
                    Status = "Active",
                    RegistrationDate = DateTime.Now
                },
            };

            return Members;
        }

        public Task<ObservableCollection<MemberModel>> GetMembersByName()
        {
            throw new NotImplementedException();
        }
    }
}
