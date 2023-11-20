namespace ACME.CRMTests.HR.BL
{
    internal class Processor
    {
        public ProcessorResult CalculatePayment(ProcessorInput data)
        {
            switch (data.role)
            {
                case Role.Boss: return (Guid.NewGuid().ToString(), data.daysWorked * 100);
                case Role.Employee: return (Guid.NewGuid().ToString(), data.daysWorked * 50);
            }
            return ("N/A", 0);
        }
    }
}
