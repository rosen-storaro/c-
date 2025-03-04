double balance  = 0;
string input;
while ((input = Console.ReadLine()) != "NoMoreMoney")
{
    double amount = double .Parse(input);   
    if (amount < 0 )
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {amount:F2}");
    balance += amount;
}
Console.WriteLine($"Total: {balance:F2}");