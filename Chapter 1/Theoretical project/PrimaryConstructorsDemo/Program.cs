//var customer = new Customer
//{
//    FirstName = "John",
//    LastName = "Doe"
//};

using Microsoft.Extensions.DependencyInjection;

var customer = new Customer("John", "Doe");

var customer2 = new Customer();

var employee = new Employee();


Console.WriteLine($"{customer.FirstName} {customer.LastName}");


var services = new ServiceCollection();
services.AddSingleton<ITranslation, GoogleTranslation>()
    .AddSingleton<MainPage>()
    .BuildServiceProvider()
    .GetService<MainPage>()
    ?.Button_Clicked();




public struct Employee(string name, string lastName, bool isTrue)
{
}