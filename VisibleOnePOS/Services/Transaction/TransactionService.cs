using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibleOnePOS.Models.Transaction;

namespace VisibleOnePOS.Services.Transaction
{
    internal class TransactionService : ITransactionService
    {
        public async Task<ObservableCollection<TransactionModel>> GetTransactions()
        {
            ObservableCollection<TransactionModel> Transactions = new ObservableCollection<TransactionModel>
            {
                new TransactionModel
                {
                    TransactionCode ="1010201920029",
                    ReferenceNo = "0830041",
                    TransactionDate = Convert.ToDateTime("10/10/2022 12:01:38"),
                    SubTotal = 8625.00,
                    Status = "Success",
                    Discount = 952.49,
                    Total = 7672.50,
                },
                new TransactionModel
                {
                    TransactionCode ="1010201920029",
                    ReferenceNo = "0830041",
                    TransactionDate = Convert.ToDateTime("10/10/2022 12:01:38"),
                    SubTotal = 8625.00,
                    Status = "Success",
                    Discount = 952.49,
                    Total = 7672.50,
                },
                new TransactionModel
                {
                   TransactionCode ="1010201920029",
                    ReferenceNo = "0830041",
                    TransactionDate = Convert.ToDateTime("10/10/2022 12:01:38"),
                    SubTotal = 8625.00,
                    Status = "Success",
                    Discount = 952.49,
                    Total = 7672.50,
                },
            };

            return Transactions;
        }
    }
}
