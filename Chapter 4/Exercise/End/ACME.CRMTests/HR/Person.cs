namespace ACME.CRMTests.HR.Models
{
    internal class Person(int id, string name, Role role)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public Role Role { get; set; } = role;
    }
}
