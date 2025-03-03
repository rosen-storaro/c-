double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
double price = 0;
string typeOfHoliday = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        price = 0.3 * budget;
        typeOfHoliday = "Camp";
    }
    else if (season == "Winter")
    {
        price = 0.7 * budget;
        typeOfHoliday = "Hotel";

    }
}
else if (budget > 100 && budget <= 1000)
{
    destination = "Balkan";
    if (season == "summer")
    {
        price = 0.4 * budget;
        typeOfHoliday = "Camp";
    }
    else if (season == "Winter")
    {
        price = 0.8 * budget;
        typeOfHoliday = "Hotel";

    }

}
else
{
    destination = "Europa";
    price = 0.9 * budget;
    typeOfHoliday = "Hotel";

}
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeOfHoliday} - {price:f2}"); 