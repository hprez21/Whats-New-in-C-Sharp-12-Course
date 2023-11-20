namespace ACME.CRMTests.HR.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ACME.CRMTests.HR.Types.Role Role { get; set; }

        public Person(int id, string name, ACME.CRMTests.HR.Types.Role role)
        {
            Id = id;
            Name = name;
            Role = role;
        }
    }
}
