
namespace ACME.CRMTests.Sales.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ACME.CRMTests.Sales.Types.CustomerType Type { get; set; }
        public Person(int id, string name, string address, Types.CustomerType type)
        {
            Id = id;
            Name = name;
            Address = address;
            Type = type;
        }
    }
}