using Serenity.Navigation;
using static MVC.Views;

using Administration = SmartERP.Administration.Pages;
using Master = SmartERP.Masters.Pages;
using Meeting = SmartERP.Meeting.Pages;
using Inventory = SmartERP.Inventory.Pages;
using Sales = SmartERP.Sales.Pages;
using Purchase = SmartERP.Purchases.Pages;
using Service = SmartERP.Services.Pages;
using HR = SmartERP.HumanResource.Pages;
using Report = SmartERP.Reports.Pages;

using CountyDB = SmartERP.CountryDB.Pages;
using CustomerStatusDB = SmartERP.CustomerStatusDB.Pages;
using BusinessNatureDB = SmartERP.BusinessNatureDB.Pages;
using BusnessNatureGrpDB = SmartERP.BusnessNatureGrpDB.Pages;
using CompanyGroupDB = SmartERP.CompanyGroupDB.Pages;
using DealerDB = SmartERP.DealerDB.Pages;
using LeadSourceDB = SmartERP.LeadSourceDB.Pages;
using LeadStatusDB = SmartERP.LeadStatusDB.Pages;
using LicenseInfoDB = SmartERP.LicenseInfoDB.Pages;
using SalesPersonDB = SmartERP.SalesPersonDB.Pages;
using UserDB = SmartERP.UserDB.Pages;
using UserGroupDB = SmartERP.UserGroupDB.Pages;


[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationLink(1001, "License Info", typeof(LicenseInfoDB.LicenseInfoController), icon: "fa-duotone fa-id-card")]

[assembly: NavigationMenu(1010, "Settings", icon: "fa-regular fa-gear")]
[assembly: NavigationLink(int.MaxValue, "Settings/Business Nature", typeof(BusinessNatureDB.BusinessNatureController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Business Nature Group", typeof(BusnessNatureGrpDB.BusinessNatureGrpController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Company Group", typeof(CompanyGroupDB.CompanyGroupController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Country", typeof(CountyDB.CountryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Customer Status", typeof(CustomerStatusDB.CustomerStatusController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Dealer", typeof(DealerDB.DealerController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Lead Source", typeof(LeadSourceDB.LeadSourceController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Lead Status", typeof(LeadStatusDB.LeadStatusController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Sales Person", typeof(SalesPersonDB.SalesPersonController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/User", typeof(UserDB.UserController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/User Group", typeof(UserGroupDB.UserGroupController), icon: null)]


#region Master
[assembly: NavigationMenu(1900, "Masters", icon: "fa-list-alt")]


[assembly: NavigationLink(1900, "Masters/Countries", typeof(SmartERP.Administration.Pages.CountriesController), icon: null)]

[assembly: NavigationLink(1900, "Masters/Cities", typeof(SmartERP.Administration.Pages.CitiesController), icon: null)]
[assembly: NavigationLink(1900, "Masters/States", typeof(SmartERP.Administration.Pages.StatesController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Banks", typeof(SmartERP.Banks.Pages.BanksController), icon: "fa-university")]

[assembly: NavigationLink(1900, "Masters/Expense Types", typeof(SmartERP.Expenses.Pages.ExpenseTypesController), icon: "fa-money")]
[assembly: NavigationLink(1900, "Masters/Services", typeof(SmartERP.Services.Pages.ServicesController), icon: null)]

[assembly: NavigationLink(1900, "Masters/Territories", typeof(SmartERP.Administration.Pages.TerritoriesController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Regions", typeof(SmartERP.Administration.Pages.RegionsController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Shippers", typeof(SmartERP.Administration.Pages.ShippersController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Warehouses", typeof(SmartERP.Administration.Pages.WarehousesController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Customer Groups", typeof(Master.CustomerGroupsController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Supplier Groups", typeof(Master.SupplierGroupsController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Agenda Item Types", typeof(Master.AgendaItemTypesController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Meeting Types", typeof(Master.MeetingTypesController), icon: null)]
[assembly: NavigationLink(1900, "Masters/Locations", typeof(Master.LocationsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Attendance Statuses", typeof(Master.AttendanceStatusesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Attendee Types", typeof(Master.AttendeeTypesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Resolution Statuses", typeof(Master.ResolutionStatusesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Deductions", typeof(Master.DeductionsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Incomes", typeof(Master.IncomesController), icon: null)]

#endregion

#region Meeting
[assembly: NavigationMenu(1900, "Meeting", icon: "fa-comments")]
[assembly: NavigationLink(int.MaxValue, "Meeting/Meetings", typeof(Meeting.MeetingsController), icon: null)]
#endregion

#region Business Partner

[assembly: NavigationMenu(2000, "Business Partners", icon: "fa-address-card")]
[assembly: NavigationLink(2000, "Business Partners/New Customer", typeof(SmartERP.Customers.Pages.CustomersController), icon: null, Url = "/Customers/Customers#new")]
[assembly: NavigationLink(2000, "Business Partners/New Supplier", typeof(SmartERP.Suppliers.Pages.SuppliersController), icon: null, Url = "/Suppliers/Suppliers#new")]
[assembly: NavigationLink(2000, "Business Partners/Customers", typeof(SmartERP.Customers.Pages.CustomersController), icon: "fa-address-card")]
[assembly: NavigationLink(2000, "Business Partners/Suppliers", typeof(SmartERP.Suppliers.Pages.SuppliersController), icon: "fa-truck")]

#endregion

#region Inventory
[assembly: NavigationMenu(3000, "Inventory", icon: "fa-th")]
[assembly: NavigationLink(3000, "Inventory/Products", typeof(SmartERP.Products.Pages.ProductsController), icon: "fa-th")]
[assembly: NavigationLink(3000, "Inventory/Categories", typeof(SmartERP.Products.Pages.CategoriesController), icon: "fa-list")]
[assembly: NavigationLink(3000, "Inventory/Units", typeof(SmartERP.Products.Pages.UnitsController), icon: null)]
[assembly: NavigationLink(3000, "Inventory/Brands", typeof(SmartERP.Products.Pages.BrandsController), icon: null)]
[assembly: NavigationLink(3000, "Inventory/Damaged Products", typeof(Inventory.DamagedProductsController), icon: null)]
[assembly: NavigationLink(3000, "Inventory/Goods Receipt", typeof(Inventory.GoodsReceiptController), icon: null)]

[assembly: NavigationLink(3000, "Inventory/Goods Issue", typeof(Inventory.GoodsIssueController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Inventory/Update Stock", typeof(Inventory.UpdateStocksController), icon: null)]

#endregion

#region Sales

[assembly: NavigationMenu(4000, "Sales", icon: "fa-shopping-cart")]
[assembly: NavigationLink(4000, "Sales/New Sale Quotation", typeof(SmartERP.Quotations.Pages.QuotationsController), icon: null, Url = "/Quotations/Quotations#new")]
[assembly: NavigationLink(4000, "Sales/New Sale", typeof(Sales.SalesController), icon: null, Url = "/Sales/Sales#new")]
[assembly: NavigationLink(4000, "Sales/Sales", typeof(Sales.SalesController), icon: "fa-shopping-cart")]
[assembly: NavigationLink(4000, "Sales/Sales Quotation", typeof(SmartERP.Quotations.Pages.QuotationsController), icon: "fa-check-square")]

#endregion

#region Purchasing

[assembly: NavigationMenu(5000, "Purchasing", icon: "fa-file")]
[assembly: NavigationLink(5000, "Purchasing/New Purchase", typeof(Purchase.PurchasesController), icon: null, Url = "/Purchases/Purchases#new")]
[assembly: NavigationLink(5000, "Purchasing/Purchases", typeof(Purchase.PurchasesController), icon: "fa-file")]


#endregion

#region Services


[assembly: NavigationMenu(5100, "Services", icon: "fa-cogs")]

[assembly: NavigationLink(5100, "Services/New Invoice", typeof(Service.ServiceInvoicesController), icon: null, Url = "/Services/ServiceInvoices#new")]
[assembly: NavigationLink(5100, "Services/Invoices", typeof(Service.ServiceInvoicesController), icon: null)]


#endregion

#region Cash/Bank
[assembly: NavigationMenu(6000, "Cash//Bank", icon: "fa-university")]
[assembly: NavigationLink(6000, "Cash//Bank/Bank Transactions", typeof(SmartERP.Accounts.Pages.BankTransactionsController), icon: null)]

[assembly: NavigationLink(6000, "Cash//Bank/Expenses", typeof(SmartERP.Expenses.Pages.ExpensesController), icon: "fa-money")]

//[assembly: NavigationLink(6000, "Cash//Bank/Opening Balance", typeof(SmartERP.Accounts.Pages.OpeningBalanceController), icon: null)]
[assembly: NavigationLink(6000, "Cash//Bank/Customer Receive", typeof(SmartERP.Accounts.Pages.CustomerReceiveController), icon: null)]
[assembly: NavigationLink(6000, "Cash//Bank/Supplier Payment", typeof(SmartERP.Accounts.Pages.SupplierPaymentController), icon: null)]
[assembly: NavigationLink(6000, "Cash//Bank/Cash Adjustment", typeof(SmartERP.Accounts.Pages.CashAdjustmentController), icon: null)]
#endregion

#region Financial
[assembly: NavigationMenu(7000, "Financial", icon: "fa-briefcase")]
[assembly: NavigationLink(7000, "Financial/Chart Of Accounts", typeof(SmartERP.Accounts.Pages.AccountsController), icon: "fa-briefcase")]
//[assembly: NavigationLink(int.MaxValue, "Accounts/Transactions", typeof(MyPages.TransactionsController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Accounts/Customer Receive", typeof(MyPages.CustomerReceiveTransactionsController), icon: null)]
[assembly: NavigationLink(7000, "Financial/Opening Balance", typeof(SmartERP.Accounts.Pages.OpeningBalanceController), icon: null)]
//[assembly: NavigationLink(7000, "Financial/Customer Receive", typeof(SmartERP.Accounts.Pages.CustomerReceiveController), icon: null)]
//[assembly: NavigationLink(7000, "Financial/Supplier Payment", typeof(SmartERP.Accounts.Pages.SupplierPaymentController), icon: null)]
//[assembly: NavigationLink(7000, "Financial/Cash Adjustment", typeof(SmartERP.Accounts.Pages.CashAdjustmentController), icon: null)]
[assembly: NavigationLink(7000, "Financial/Debit Voucher", typeof(SmartERP.Accounts.Pages.DebitVoucherController), icon: null)]
[assembly: NavigationLink(7000, "Financial/Credit Voucher", typeof(SmartERP.Accounts.Pages.CreditVoucherController), icon: null)]
[assembly: NavigationLink(7000, "Financial/Contra Voucher", typeof(SmartERP.Accounts.Pages.ContraVoucherController), icon: null)]
[assembly: NavigationLink(7000, "Financial/Journal Voucher", typeof(SmartERP.Accounts.Pages.JournalVoucherController), icon: null)]
[assembly: NavigationMenu(7000, "Financial/Reports", icon: "fa-circle-o")]
#endregion

#region Human Resource


[assembly: NavigationMenu(8000, "Human Resource", icon: "fa-users")]
[assembly: NavigationLink(8000, "Human Resource/New Employee", typeof(HR.EmployeesController), icon: null, Url = "/HumanResource/Employees#new")]

[assembly: NavigationLink(8000, "Human Resource/Employees", typeof(HR.EmployeesController), icon: "fa-users")]
[assembly: NavigationLink(8000, "Human Resource/Departments", typeof(HR.DepartmentsController), icon: null)]
[assembly: NavigationLink(8000, "Human Resource/Designations", typeof(HR.DesignationsController), icon: null)]
[assembly: NavigationLink(8000, "Human Resource/Attendance", typeof(HR.AttendanceController), icon: "fa-calendar")]
[assembly: NavigationLink(int.MaxValue, "Human Resource/Payroll", typeof(SmartERP.Payroll.Pages.PayrollController), icon: null)]
#endregion

#region Reports
[assembly: NavigationMenu(8100, "Reports", icon: "fa-circle-o")]
[assembly: NavigationLink(8100, "Reports/Day Closing", typeof(Report.CloseDayController), icon: null)]
[assembly: NavigationLink(8100, "Reports/Today's Report", typeof(Report.TodaysReportController), icon: null)]
[assembly: NavigationLink(8100, "Reports/Daily Closing Report", typeof(Report.DailyClosingController), icon: null)]

//[assembly: NavigationLink(8100, "Reports/Closing Report", typeof(MyPages.ClosingReportController), icon: null)]

[assembly: NavigationLink(8100, "Reports/Stock Report", typeof(Report.StockReportController), icon: null)]
[assembly: NavigationLink(8100, "Reports/Sale Report", typeof(Report.SaleReportController), icon: null)]
[assembly: NavigationLink(8100, "Reports/Product Wise Sale Report", typeof(Report.ProductWiseSalesReportController), icon: null)]
[assembly: NavigationLink(8100, "Reports/Purchase Report", typeof(Report.PurchaseReporController), icon: null)]



[assembly: NavigationLink(8100, "Reports/Customer Receivable Report", typeof(Report.CustomerReceivableReportController), icon: null)]

[assembly: NavigationLink(8100, "Reports/Supplier Payable Report", typeof(Report.SupplierPayableReportController), icon: null)]
//[assembly: NavigationLink(8100, "Reports/Profit Report", typeof(MyPages.ProfitReportController), icon: null)]

#endregion

#region Administration
[assembly: NavigationMenu(9000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(9000, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(9000, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(9000, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(9000, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]
[assembly: NavigationLink(9000, "Administration/Currencies", typeof(Administration.CurrenciesController), icon: null)]
[assembly: NavigationLink(9000, "Administration/Settings", typeof(Administration.CompaniesController), icon: null)]
#endregion

