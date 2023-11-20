var incrementBy = (int source, int increment = 1) =>
{
    source += increment;
};


void Save(string text, string path)
{
    if(string.IsNullOrEmpty(path))
    {
        if(!File.Exists(path))
        {
            File.Create(path);
        }
    }
    Console.WriteLine($"Text saved at: {path}");
}

//var lambda = Save;

var lambda2 = (string msg, string path = "D:\\default.txt") => Save(msg, path);


lambda2("test", "D:\\text.txt");

lambda2("test 2");



void ProcessOrders(params int[] orders)
{
    foreach (int order in orders)
    {
        Console.WriteLine($"Cancelling order {order}");
    }
}

var ordersHandler = (params int[] orders) => ProcessOrders;

ordersHandler([2,4,5,6]);