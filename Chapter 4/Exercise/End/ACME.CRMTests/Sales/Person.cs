namespace ACME.CRMTests.Sales.Models
{
    internal class Person(int id, string name, string address, CustomerType type)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Address { get; set; } = address;
        public CustomerType Type { get; set; } = type;

    }
}