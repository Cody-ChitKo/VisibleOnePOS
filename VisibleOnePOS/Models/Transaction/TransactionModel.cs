using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibleOnePOS.Models.Transaction
{
    internal class TransactionModel
    {
        public string TransactionCode { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public double SubTotal { get; set; }
        public string Status { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
    }
}
