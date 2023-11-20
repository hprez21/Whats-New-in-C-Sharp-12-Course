namespace ACME.CRMTests.HR.BL
{
    internal class Processor
    {
        public (string guid, double calculation) CalculatePayment((ACME.CRMTests.HR.Types.Role role, int daysWorked) data)
        {
            switch (data.role)
            {
                case ACME.CRMTests.HR.Types.Role.Boss: return (Guid.NewGuid().ToString(), data.daysWorked * 100);
                case ACME.CRMTests.HR.Types.Role.Employee: return (Guid.NewGuid().ToString(), data.daysWorked * 50);
            }
            return ("N/A", 0);
        }
    }
}
