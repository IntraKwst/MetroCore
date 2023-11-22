namespace DataHandler.DataAccess
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CustomerInvoice
    {
        [Key]
        public virtual string InvoiceNo { get; set; }
        public int CusCode { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime IssueDate { get; set; }
        public double TotalValue { get; set; }

        public CustomerInvoice(){ }

        public CustomerInvoice(CustomerInvoice original)
        {
            InvoiceNo = original.InvoiceNo;
            IssueDate = original.IssueDate;
            TotalValue = original.TotalValue;
            CusCode = original.CusCode;
            Customer = null;
        }
    }
}
