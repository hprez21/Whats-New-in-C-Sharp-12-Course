global using Role = ACME.CRMTests.HR.Types.Role;
global using ProcessorResult = (string GUID, double Total);
global using ProcessorInput = (ACME.CRMTests.HR.Types.Role role, int daysWorked);
global using CustomerType = ACME.CRMTests.Sales.Types.CustomerType;
global using QuotationResult = (double total, int totalProducts);
global using QuotationInput = (System.Collections.Generic.List<ACME.CRMTests.Sales.Products.BaseProduct> products, ACME.CRMTests.Sales.Types.CustomerType type, bool IsDiscountsDay);

using PersonHR = ACME.CRMTests.HR.Models.Person;
using PersonSales = ACME.CRMTests.Sales.Models.Person;
using ACME.CRMTests.HR.BL;
using ACME.CRMTests.Sales.Products;
using ACME.CRMTests.Sales.BL;

//--------------------- HR ---------------------

var person = new PersonHR(1, "John", Role.Boss);
var daysWorked = 20;
var payemntProcessor = new Processor();

ProcessorResult payment = payemntProcessor.CalculatePayment((person.Role, daysWorked));

Console.WriteLine($"Payment ID {payment.GUID}, Total: {payment.Total}");


//--------------------- SALES ---------------------

var customer = new PersonSales(1, "John", "Address", CustomerType.Gold);

var products = new List<BaseProduct>()
{
    new Product1() { Price = 10 },
    new Product2() { Price = 20 },
    new Product3() { Price = 30 }
};

var engine = new QuotationEngine();
engine.GenerateQuotation((products, customer.Type, true));