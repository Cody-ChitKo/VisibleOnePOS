using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Member;
using VisibleOnePOS.Services.Members;

namespace VisibleOnePOS.ViewModels.Member
{
    internal class MemberViewModel
    {
        public ObservableCollection<MemberModel> MembersList { get; set; }
        IMemberService MemberService;
        public MemberViewModel()
        {
            MembersList = new ObservableCollection<MemberModel>();
            MemberService = DependencyService.Get<IMemberService>();
            //selectedMember = MembersList.Skip(3).FirstOrDefault();
        }
        MemberModel selectedMember;
        public MemberModel SelectedMember
        {
            get
            {
                return selectedMember;
            }
            set
            {
                if (selectedMember != value)
                {
                    selectedMember = value;
                }
            }
        }
        public async Task ExcuteCommandMemberList()
        {
            MembersList.Clear();
            var memberlist = await MemberService.GetMembers();
            foreach (var member in memberlist)
            {
                MembersList.Add(member);
            }
        }
    }
}
