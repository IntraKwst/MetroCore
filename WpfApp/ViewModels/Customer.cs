using System.Collections.Generic;

namespace WpfApp
{
    public class Customer
    {
        public virtual int CusCode { get; set; }
        public string CusName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public virtual ICollection<CustomerInvoice> CustomerInvoices { get; set; }
    }
}
