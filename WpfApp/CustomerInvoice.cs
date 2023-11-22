using System;

namespace WpfApp
{
    public class CustomerInvoice
    {
        public virtual string InvoiceNo { get; set; }
        public int CusCode { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime IssueDate { get; set; }
        public double TotalValue { get; set; }
    }
}