using CsvHelper.Configuration.Attributes;
using System;

namespace WpfApp
{
    [Delimiter(";")]
    public class CustomerInvoice
    {
        [Exportable(Alias = "Invoice Number")]
        public virtual string InvoiceNo { get; set; }
        [Exportable(Alias = "Customer Code")]
        public int CusCode { get; set; }
        public virtual Customer Customer { get; set; }
        [Exportable(Alias = "Issue Date")]
        public DateTime IssueDate { get; set; }
        [Exportable(Alias = "Total Value")]
        public double TotalValue { get; set; }
    }
}