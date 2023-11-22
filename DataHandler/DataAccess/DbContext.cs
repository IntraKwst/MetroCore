namespace DataHandler.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection.Emit;

    public class CustomerDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerInvoice> CustomerInvoices { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public string DbPath { get; }

        public CustomerDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "customers.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(x => x.CustomerInvoices)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CusCode)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().HasIndex(x => x.Username).IsUnique();

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CusCode = 324195, CusName = "XXXXXXX XXXXXXX", Phone = "9999999999", Address = "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", PostalCode = "14451" },
                new Customer { CusCode = 509989, CusName = "XXXXXXX XXXXXXX", Phone = "9999999999", Address = "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", PostalCode = "14451" },
                new Customer { CusCode = 687355, CusName = "XXXXXXX XXXXXXX", Phone = "9999999999", Address = "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", PostalCode = "14451" },
                new Customer { CusCode = 884663, CusName = "XXXXXXX XXXXXXX", Phone = "9999999999", Address = "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", PostalCode = "14451" },
                new Customer { CusCode = 893623, CusName = "XXXXXXX XXXXXXX", Phone = "9999999999", Address = "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", PostalCode = "14451" }
            );
            var cultureInfo = new CultureInfo("en-US");
            modelBuilder.Entity<CustomerInvoice>().HasData(
                new CustomerInvoice { CusCode = 324195, InvoiceNo = "000574", IssueDate = Convert.ToDateTime("10/14/2022", cultureInfo), TotalValue = 538.68  },
                new CustomerInvoice { CusCode = 324195, InvoiceNo = "000577", IssueDate = Convert.ToDateTime("10/14/2022", cultureInfo), TotalValue = 3437.15},
                new CustomerInvoice { CusCode = 324195, InvoiceNo = "000578", IssueDate = Convert.ToDateTime("10/14/2022", cultureInfo), TotalValue = 2471.16},
                new CustomerInvoice { CusCode = 324195, InvoiceNo = "000586", IssueDate = Convert.ToDateTime("10/20/2022", cultureInfo), TotalValue = 3370.51},
                new CustomerInvoice { CusCode = 509989, InvoiceNo = "000553", IssueDate = Convert.ToDateTime("9/30/2022" , cultureInfo), TotalValue = 6631.95},
                new CustomerInvoice { CusCode = 509989, InvoiceNo = "000568", IssueDate = Convert.ToDateTime("10/11/2022", cultureInfo), TotalValue = 8280.73},
                new CustomerInvoice { CusCode = 509989, InvoiceNo = "000569", IssueDate = Convert.ToDateTime("10/11/2022", cultureInfo), TotalValue = 2788.47},
                new CustomerInvoice { CusCode = 509989, InvoiceNo = "000584", IssueDate = Convert.ToDateTime("10/19/2022", cultureInfo), TotalValue = 1810.34},
                new CustomerInvoice { CusCode = 687355, InvoiceNo = "000542", IssueDate = Convert.ToDateTime("9/26/2022" , cultureInfo), TotalValue = 454.09  },
                new CustomerInvoice { CusCode = 687355, InvoiceNo = "000547", IssueDate = Convert.ToDateTime("9/28/2022" , cultureInfo), TotalValue = 4164.23},
                new CustomerInvoice { CusCode = 687355, InvoiceNo = "000548", IssueDate = Convert.ToDateTime("9/29/2022" , cultureInfo), TotalValue = 4097.95},
                new CustomerInvoice { CusCode = 687355, InvoiceNo = "000549", IssueDate = Convert.ToDateTime("9/29/2022" , cultureInfo), TotalValue = 7149.47},
                new CustomerInvoice { CusCode = 687355, InvoiceNo = "000550", IssueDate = Convert.ToDateTime("9/29/2022" , cultureInfo), TotalValue = 5091.24},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000543", IssueDate = Convert.ToDateTime("9/26/2022" , cultureInfo), TotalValue = 7423.38},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000561", IssueDate = Convert.ToDateTime("10/5/2022" , cultureInfo), TotalValue = 864.53  },
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000564", IssueDate = Convert.ToDateTime("10/7/2022" , cultureInfo), TotalValue = 1194.24},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000565", IssueDate = Convert.ToDateTime("10/10/2022", cultureInfo), TotalValue = 4451.14},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000566", IssueDate = Convert.ToDateTime("10/10/2022", cultureInfo), TotalValue = 4973.51},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000571", IssueDate = Convert.ToDateTime("10/12/2022", cultureInfo), TotalValue = 1506.18},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000572", IssueDate = Convert.ToDateTime("10/12/2022", cultureInfo), TotalValue = 6642.17},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000575", IssueDate = Convert.ToDateTime("10/14/2022", cultureInfo), TotalValue = 3749.29},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000576", IssueDate = Convert.ToDateTime("10/14/2022", cultureInfo), TotalValue = 1175.38},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000582", IssueDate = Convert.ToDateTime("10/17/2022", cultureInfo), TotalValue = 8325.22},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000583", IssueDate = Convert.ToDateTime("10/17/2022", cultureInfo), TotalValue = 9903.92},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000585", IssueDate = Convert.ToDateTime("10/19/2022", cultureInfo), TotalValue = 4530.15},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000587", IssueDate = Convert.ToDateTime("10/21/2022", cultureInfo), TotalValue = 9161.34},
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000588", IssueDate = Convert.ToDateTime("10/21/2022", cultureInfo), TotalValue = 542.69  },
                new CustomerInvoice { CusCode = 884663, InvoiceNo = "000593", IssueDate = Convert.ToDateTime("10/24/2022", cultureInfo), TotalValue = 1478.41},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000544", IssueDate = Convert.ToDateTime("9/27/2022" , cultureInfo), TotalValue = 1310.86},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000545", IssueDate = Convert.ToDateTime("9/27/2022" , cultureInfo), TotalValue = 7162.23},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000546", IssueDate = Convert.ToDateTime("9/27/2022" , cultureInfo), TotalValue = 571.64  },
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000555", IssueDate = Convert.ToDateTime("9/30/2022" , cultureInfo), TotalValue = 2950.76},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000556", IssueDate = Convert.ToDateTime("9/30/2022" , cultureInfo), TotalValue = 8889.80},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000557", IssueDate = Convert.ToDateTime("9/30/2022" , cultureInfo), TotalValue = 1903.26},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000579", IssueDate = Convert.ToDateTime("10/15/2022", cultureInfo), TotalValue = 3180.82},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000589", IssueDate = Convert.ToDateTime("10/22/2022", cultureInfo), TotalValue = 2131.12},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000590", IssueDate = Convert.ToDateTime("10/22/2022", cultureInfo), TotalValue = 1360.92},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000591", IssueDate = Convert.ToDateTime("10/22/2022", cultureInfo), TotalValue = 6451.25},
                new CustomerInvoice { CusCode = 893623, InvoiceNo = "000592", IssueDate = Convert.ToDateTime("10/22/2022", cultureInfo), TotalValue = 2989.95 }
            );
        }
    }
}
