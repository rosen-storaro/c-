using System.Collections.Generic;

string fruit = Console.ReadLine().Trim();
string days = Console.ReadLine().Trim();
double quantity = double.Parse(Console.ReadLine());

Dictionary<string, double> workingPrice = new Dictionary<string, double>()
{
     { "banana", 2.50 }, { "apple", 1.20 }, { "orange", 0.85 },
            { "grapefruit", 1.45 }, { "kiwi", 2.70 }, { "pineapple", 5.50 }, { "grapes", 3.85 }
};
Dictionary<string, double> weekendPrice = new Dictionary<string, double>()
{
     { "banana", 2.70 }, { "apple", 1.25 }, { "orange", 0.90 },
            { "grapefruit", 1.60 }, { "kiwi", 3.00 }, { "pineapple", 5.60 }, { "grapes", 4.20 }
};

double price = 0;
bool isValidDay = true;
bool isValidFruit = workingPrice.ContainsKey(fruit);

if (isValidFruit)
{
    if (days == "Monday" || days == "Tuesday" || days == "Wednesday" || days == "Thursday" || days == "Friday")
    {
        price = workingPrice[fruit];
    }
    else if (days == "Saturday" || days == "Sunday")
    {
        price = weekendPrice[fruit];
    }
    else
    {
        isValidDay = false;
    }
    if (isValidDay)
    {
        Console.WriteLine($"{(price * quantity):f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else
{
    Console.WriteLine("error");
}

