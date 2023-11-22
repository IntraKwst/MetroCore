namespace DataHandler.DataAccess
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        [Key]
        public virtual int CusCode { get; set; }
        public string CusName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public virtual ICollection<CustomerInvoice> CustomerInvoices { get; set; }

        public Customer(){ }

        public Customer(Customer original)
        {
            CusCode = original.CusCode;
            CusName = original.CusName;
            Phone = original.Phone;
            Address = original.Address;
            PostalCode = original.PostalCode;
            CustomerInvoices = new List<CustomerInvoice>();
        }
    }
}
