float small_carpet_price = 25;
float large_carpet_price = 35;
float sales_tax_rate = 6;
int estimated_valid_per_days = 30;


Console.Write("Please Enter Number of small carpets: ");
int small_carpets_number= Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter Number of Large carpets: ");
int large_carpets_number= Convert.ToInt32(Console.ReadLine());

float cost = (small_carpets_number * small_carpet_price) + (large_carpets_number * large_carpet_price);

float tax = sales_tax_rate * cost/100;

Console.WriteLine($"Number of small carpets: { small_carpets_number }");
Console.WriteLine($"Number of large carpets: { large_carpets_number }");
Console.WriteLine($"Price per small carpet : { small_carpet_price } $");
Console.WriteLine($"Price per large carpet : { large_carpet_price } $");
Console.WriteLine($"Cost: { cost } $");
Console.WriteLine($"Tax: { tax } $");
Console.WriteLine("================================");
Console.WriteLine($"Total estimate: { cost + tax } $");
Console.WriteLine($"This estimate is valid for { estimated_valid_per_days } days");
