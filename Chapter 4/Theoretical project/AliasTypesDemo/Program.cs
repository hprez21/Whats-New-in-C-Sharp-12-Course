//using Contoso.Controls.MaterialDesign;
//using Contoso.Controls.Cupertino;

using Cupertino = Contoso.Controls.Cupertino;
using Material = Contoso.Controls.MaterialDesign;

using MButton = Contoso.Controls.MaterialDesign.Button;

using ComparisonDelegate = System.Func<double, double, bool>;

using User = (string Name, int Age, string Email, bool IsActive);


var button = new Cupertino.Button();
var button2 = new Material.Button();

var button3 = new MButton();

ComparisonDelegate RatingValidator = (rating, threshold) => rating >= threshold;


Console.WriteLine(RatingValidator(4.5, 5.0));

var userDetails = 
    (Name: "John Doe", Age: 30, Email: "john@gmail.com", IsActive: true);


User anotherUser =
    ("JoJohn Doe", 28, "otheremail@hotmail.com", false);

//var anotherUser =
//    ("John Doe", 28, "otheremail@hotmail.com", false);

Console.WriteLine(anotherUser.Name);


void Process(User data)
{

}

Process(anotherUser);

namespace Contoso.Controls.MaterialDesign
{
    class Button
    {

    }
}

namespace Contoso.Controls.Cupertino
{
    class Button
    {

    }
}