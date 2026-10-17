

/*Assignment*/
int asks;

double total;
double allTotal = 0;
do
{
    Console.WriteLine("Enter product price");
    double productPrice = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter product quantity");
    int productQuantity = Convert.ToInt32(Console.ReadLine());
    total = productPrice * productQuantity;
    Console.WriteLine($"Total = {total}");

    Console.WriteLine($"Add another product? {1} = Yes , {0} = No");
    asks = Convert.ToInt32(Console.ReadLine());
    while (asks != 0 && asks != 1)
    {
        Console.WriteLine("Please enter 1 or 0:");
        asks = Convert.ToInt32(Console.ReadLine());

    }


    allTotal += total;

} while (asks != 0);

Console.WriteLine($"All Total = {allTotal}");