namespace ACME.CRMTests.Sales.Products
{
    internal class BaseProduct
    {
        public decimal Price
        {
            get; set;
        }      
    }
    internal class Product1 : BaseProduct { }
    internal class Product2 : BaseProduct { }
    internal class Product3 : BaseProduct { }
}