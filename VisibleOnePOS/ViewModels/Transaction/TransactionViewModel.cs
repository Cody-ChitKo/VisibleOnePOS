using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Transaction;
using VisibleOnePOS.Services.Members;
using VisibleOnePOS.Services.Transaction;

namespace VisibleOnePOS.ViewModels.Transaction
{
    internal class TransactionViewModel:BaseViewModel
    {
        public ObservableCollection<TransactionModel> TransactionList { get; set; }
        ITransactionService TransactionService;
        TransactionModel selectedTransaction;
        public TransactionModel SelectedTransaction
        {
            get
            {
                return selectedTransaction;
            }
            set
            {
                if (selectedTransaction != value)
                {
                    selectedTransaction = value;
                }
            }
        }
        public TransactionViewModel()
        {
            TransactionList = new ObservableCollection<TransactionModel>();
            TransactionService = DependencyService.Get<ITransactionService>();
        }
        public async Task ExcuteCommandTransactionList()
        {
            TransactionList.Clear();
            var transactionList = await TransactionService.GetTransactions();
            foreach (var transaction in transactionList)
            {
                TransactionList.Add(transaction);
            }
        }
    }
}
