using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Branch;
using VisibleOnePOS.Services.Branch;

namespace VisibleOnePOS.ViewModels.Branch
{
    internal class BranchViewModel : BaseViewModel
    {
        public ObservableCollection<BranchModel> Branches { get; set; }
        IBranchService BranchService;
        public BranchViewModel()
        {
            Branches = new ObservableCollection<BranchModel>();
            BranchService = DependencyService.Get<IBranchService>();
        }
        private string branchName;
        public string BranchName
        {
            get { return branchName; }
            set { SetProperty(ref branchName, value); }
        }
        BranchModel selectedBranch;
        public BranchModel SelectedBranch
        {
            get { return selectedBranch; }

            set { SetProperty(ref selectedBranch, value); }
        }
        public async Task ExcuetBranchListCommand()
        {
            Branches.Clear();
            var branches = await BranchService.GetBranches();
            foreach (var branch in branches)
            {
                Branches.Add(branch);
            }
        }
    }
}
