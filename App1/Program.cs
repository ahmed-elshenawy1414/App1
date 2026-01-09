
Console.WriteLine("=======================================");
Console.WriteLine("    Islam  Carpet Cleaning Services ");
Console.WriteLine("=======================================\n");

Console.Write("Enter the number of small rooms you would like cleaned: ");
int smallRooms = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of larg rooms you would like cleaned: ");
int largRooms = Convert.ToInt32(Console.ReadLine());

int costPerSmallRoom = 25;
int costPerLargRoom = 35;
double salesTaxRate = 0.06;
int totalCostSmallRooms = smallRooms * costPerSmallRoom;
int totalCostLargRooms = largRooms * costPerLargRoom;
int subtotal = totalCostSmallRooms + totalCostLargRooms;
double salesTax = subtotal * salesTaxRate;
double totalEstimate = subtotal + salesTax;

Console.WriteLine("=======================================");
Console.WriteLine($"per Small: {costPerSmallRoom:c}");
Console.WriteLine($"per Medium: {costPerLargRoom:c}");
Console.WriteLine($"Cost: {subtotal:c}");
Console.WriteLine($"Tax: {salesTax:c}");
Console.WriteLine("=======================================");
Console.WriteLine($"Total estimate: {totalEstimate}");
Console.WriteLine("This estimate is valid for 30 days.");