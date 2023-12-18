using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Branch;

namespace VisibleOnePOS.Services.Branch
{
    interface IBranchService
    {
        Task<ObservableCollection<BranchModel>> GetBranches();
    }
}
