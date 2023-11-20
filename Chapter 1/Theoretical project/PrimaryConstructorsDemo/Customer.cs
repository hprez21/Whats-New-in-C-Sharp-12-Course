public class Customer(string firstName, string lastName) : Entity(firstName)
{

    public Customer() : this("John", "Doe")
    {

    }

    public string FirstName => firstName;
    public string LastName { get; set; }
}


public class Entity(string name)
{
    public string Name => name;
}