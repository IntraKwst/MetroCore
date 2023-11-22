using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataHandler.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CusCode = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CusName = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CusCode);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInvoices",
                columns: table => new
                {
                    InvoiceNo = table.Column<string>(type: "TEXT", nullable: false),
                    CusCode = table.Column<int>(type: "INTEGER", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalValue = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInvoices", x => x.InvoiceNo);
                    table.ForeignKey(
                        name: "FK_CustomerInvoices_Customers_CusCode",
                        column: x => x.CusCode,
                        principalTable: "Customers",
                        principalColumn: "CusCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CusCode", "Address", "CusName", "Phone", "PostalCode" },
                values: new object[] { 324195, "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", "XXXXXXX XXXXXXX", "9999999999", "14451" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CusCode", "Address", "CusName", "Phone", "PostalCode" },
                values: new object[] { 509989, "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", "XXXXXXX XXXXXXX", "9999999999", "14451" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CusCode", "Address", "CusName", "Phone", "PostalCode" },
                values: new object[] { 687355, "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", "XXXXXXX XXXXXXX", "9999999999", "14451" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CusCode", "Address", "CusName", "Phone", "PostalCode" },
                values: new object[] { 884663, "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", "XXXXXXX XXXXXXX", "9999999999", "14451" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CusCode", "Address", "CusName", "Phone", "PostalCode" },
                values: new object[] { 893623, "ΣΩΡΟΥ 1 ΜΕΤΑΜΟΡΦΩΣΗ", "XXXXXXX XXXXXXX", "9999999999", "14451" });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000542", 687355, new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 454.08999999999997 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000543", 884663, new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7423.3800000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000544", 893623, new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1310.8599999999999 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000545", 893623, new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7162.2299999999996 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000546", 893623, new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 571.63999999999999 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000547", 687355, new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4164.2299999999996 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000548", 687355, new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4097.9499999999998 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000549", 687355, new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7149.4700000000003 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000550", 687355, new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5091.2399999999998 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000553", 509989, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6631.9499999999998 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000555", 893623, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2950.7600000000002 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000556", 893623, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8889.7999999999993 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000557", 893623, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1903.26 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000561", 884663, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 864.52999999999997 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000564", 884663, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1194.24 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000565", 884663, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4451.1400000000003 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000566", 884663, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4973.5100000000002 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000568", 509989, new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8280.7299999999996 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000569", 509989, new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2788.4699999999998 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000571", 884663, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1506.1800000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000572", 884663, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6642.1700000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000574", 324195, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 538.67999999999995 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000575", 884663, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3749.29 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000576", 884663, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1175.3800000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000577", 324195, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3437.1500000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000578", 324195, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2471.1599999999999 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000579", 893623, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3180.8200000000002 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000582", 884663, new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8325.2199999999993 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000583", 884663, new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9903.9200000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000584", 509989, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1810.3399999999999 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000585", 884663, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4530.1499999999996 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000586", 324195, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3370.5100000000002 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000587", 884663, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9161.3400000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000588", 884663, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 542.69000000000005 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000589", 893623, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2131.1199999999999 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000590", 893623, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1360.9200000000001 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000591", 893623, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6451.25 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000592", 893623, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2989.9499999999998 });

            migrationBuilder.InsertData(
                table: "CustomerInvoices",
                columns: new[] { "InvoiceNo", "CusCode", "IssueDate", "TotalValue" },
                values: new object[] { "000593", 884663, new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1478.4100000000001 });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoices_CusCode",
                table: "CustomerInvoices",
                column: "CusCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerInvoices");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
