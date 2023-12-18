using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Branch;

namespace VisibleOnePOS.Services.Branch
{
    class BranchService : IBranchService
    {
        public async Task<ObservableCollection<BranchModel>> GetBranches()
        {
            ObservableCollection<BranchModel> branches = new ObservableCollection<BranchModel>
            {
                new BranchModel
                {
                    BranchName = "Branch1",
                    Phone = "0999999999",
                    ContactPerson = "ContactPerson1",
                    Address = "YGN",
                },
                new BranchModel
                {
                    BranchName = "Branch2",
                    Phone = "0999999999",
                    ContactPerson = "ContactPerson1",
                    Address = "YGN",
                },
                new BranchModel
                {
                    BranchName = "Branch3",
                    Phone = "0999999999",
                    ContactPerson = "ContactPerson1",
                    Address = "YGN",
                },
            };

            return branches;
        }
    }
}
