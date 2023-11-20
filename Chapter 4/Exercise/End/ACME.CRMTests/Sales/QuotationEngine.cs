namespace ACME.CRMTests.Sales.BL
{
    internal class QuotationEngine
    {
        public QuotationResult GenerateQuotation(
            QuotationInput processInformation)
        {
            int discount = 0;
            decimal total = 0;
            if (processInformation.type == CustomerType.Gold)
            {
                discount = 5;
            }

            if (processInformation.IsDiscountsDay)
            {
                discount += 5;
            }

            foreach (var product in processInformation.products)
            {
                total += product.Price;
            }

            total = total - total * discount / 100;

            return ((double)total, processInformation.products.Count);
        }
    }
}