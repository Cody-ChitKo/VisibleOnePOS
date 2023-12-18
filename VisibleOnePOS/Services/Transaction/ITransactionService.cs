using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Transaction;

namespace VisibleOnePOS.Services.Transaction
{
    internal interface ITransactionService
    {
        Task<ObservableCollection<TransactionModel>> GetTransactions();
    }
}
