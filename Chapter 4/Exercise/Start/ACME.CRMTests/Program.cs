

//--------------------- HR ---------------------

var person = new ACME.CRMTests.HR.Models.Person(1, "John", ACME.CRMTests.HR.Types.Role.Boss);
var daysWorked = 20;
var payemntProcessor = new ACME.CRMTests.HR.BL.Processor();

(string GUID, double Total) payment = payemntProcessor.CalculatePayment((person.Role, daysWorked));

Console.WriteLine($"Payment ID {payment.GUID}, Total: {payment.Total}");


//--------------------- SALES ---------------------

var customer = new ACME.CRMTests.Sales.Models.Person(1, "John", "Address", ACME.CRMTests.Sales.Types.CustomerType.Gold);

var products = new List<ACME.CRMTests.Sales.Products.BaseProduct>()
{
    new ACME.CRMTests.Sales.Products.Product1() { Price = 10 },
    new ACME.CRMTests.Sales.Products.Product2() { Price = 20 },
    new ACME.CRMTests.Sales.Products.Product3() { Price = 30 }
};

var engine = new ACME.CRMTests.Sales.BL.QuotationEngine();
engine.GenerateQuotation((products, customer.Type, true));