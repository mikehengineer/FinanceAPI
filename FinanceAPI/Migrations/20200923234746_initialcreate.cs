using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceAPI.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "FinanceManagers",
                columns: table => new
                {
                    FinanceManagerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceManagers", x => x.FinanceManagerId);
                });

            migrationBuilder.CreateTable(
                name: "FinanceOfficers",
                columns: table => new
                {
                    FinanceOfficerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FinanceManagerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceOfficers", x => x.FinanceOfficerId);
                    table.ForeignKey(
                        name: "FK_FinanceOfficers_FinanceManagers_FinanceManagerId",
                        column: x => x.FinanceManagerId,
                        principalTable: "FinanceManagers",
                        principalColumn: "FinanceManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    BankAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankAccountType = table.Column<string>(nullable: true),
                    BankAccountBalance = table.Column<int>(nullable: false),
                    FinanceOfficerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.BankAccountId);
                    table.ForeignKey(
                        name: "FK_BankAccounts_FinanceOfficers_FinanceOfficerId",
                        column: x => x.FinanceOfficerId,
                        principalTable: "FinanceOfficers",
                        principalColumn: "FinanceOfficerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CreditCardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditCardCompany = table.Column<string>(nullable: true),
                    CreditCardInterestRate = table.Column<int>(nullable: false),
                    CreditLimit = table.Column<int>(nullable: false),
                    CreditCardExpiration = table.Column<DateTime>(nullable: false),
                    CurrentBalance = table.Column<int>(nullable: false),
                    MinimumPayment = table.Column<int>(nullable: false),
                    AmountDue = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    FinanceOfficerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.CreditCardId);
                    table.ForeignKey(
                        name: "FK_CreditCards_FinanceOfficers_FinanceOfficerId",
                        column: x => x.FinanceOfficerId,
                        principalTable: "FinanceOfficers",
                        principalColumn: "FinanceOfficerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersFinanceOfficers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    FinanceOfficerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersFinanceOfficers", x => new { x.CustomerId, x.FinanceOfficerId });
                    table.ForeignKey(
                        name: "FK_CustomersFinanceOfficers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersFinanceOfficers_FinanceOfficers_FinanceOfficerId",
                        column: x => x.FinanceOfficerId,
                        principalTable: "FinanceOfficers",
                        principalColumn: "FinanceOfficerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    InsuranceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceType = table.Column<string>(nullable: true),
                    InsuredAmount = table.Column<int>(nullable: false),
                    InsurancePaymentAmount = table.Column<int>(nullable: false),
                    FinanceOfficerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.InsuranceId);
                    table.ForeignKey(
                        name: "FK_Insurances_FinanceOfficers_FinanceOfficerId",
                        column: x => x.FinanceOfficerId,
                        principalTable: "FinanceOfficers",
                        principalColumn: "FinanceOfficerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanType = table.Column<string>(nullable: true),
                    LoanAmount = table.Column<int>(nullable: false),
                    LoanBalance = table.Column<int>(nullable: false),
                    MinimumPayment = table.Column<int>(nullable: false),
                    AmountDue = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    FinanceOfficerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_Loans_FinanceOfficers_FinanceOfficerId",
                        column: x => x.FinanceOfficerId,
                        principalTable: "FinanceOfficers",
                        principalColumn: "FinanceOfficerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersBankAccounts",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    BankAccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersBankAccounts", x => new { x.CustomerId, x.BankAccountId });
                    table.ForeignKey(
                        name: "FK_CustomersBankAccounts_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "BankAccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersBankAccounts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersCreditCards",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    CreditCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersCreditCards", x => new { x.CustomerId, x.CreditCardId });
                    table.ForeignKey(
                        name: "FK_CustomersCreditCards_CreditCards_CreditCardId",
                        column: x => x.CreditCardId,
                        principalTable: "CreditCards",
                        principalColumn: "CreditCardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersCreditCards_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersInsurances",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    InsuranceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersInsurances", x => new { x.CustomerId, x.InsuranceId });
                    table.ForeignKey(
                        name: "FK_CustomersInsurances_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersInsurances_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "InsuranceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersLoans",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    LoanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersLoans", x => new { x.CustomerId, x.LoanId });
                    table.ForeignKey(
                        name: "FK_CustomersLoans_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersLoans_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
                        principalColumn: "LoanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_FinanceOfficerId",
                table: "BankAccounts",
                column: "FinanceOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_FinanceOfficerId",
                table: "CreditCards",
                column: "FinanceOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersBankAccounts_BankAccountId",
                table: "CustomersBankAccounts",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersCreditCards_CreditCardId",
                table: "CustomersCreditCards",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersFinanceOfficers_FinanceOfficerId",
                table: "CustomersFinanceOfficers",
                column: "FinanceOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersInsurances_InsuranceId",
                table: "CustomersInsurances",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersLoans_LoanId",
                table: "CustomersLoans",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceOfficers_FinanceManagerId",
                table: "FinanceOfficers",
                column: "FinanceManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_FinanceOfficerId",
                table: "Insurances",
                column: "FinanceOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_FinanceOfficerId",
                table: "Loans",
                column: "FinanceOfficerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersBankAccounts");

            migrationBuilder.DropTable(
                name: "CustomersCreditCards");

            migrationBuilder.DropTable(
                name: "CustomersFinanceOfficers");

            migrationBuilder.DropTable(
                name: "CustomersInsurances");

            migrationBuilder.DropTable(
                name: "CustomersLoans");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "FinanceOfficers");

            migrationBuilder.DropTable(
                name: "FinanceManagers");
        }
    }
}
