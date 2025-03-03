int degrees = int.Parse(Console.ReadLine());
string partOfDay = Console.ReadLine();
string outfit = "";
string shoes = "";

if (degrees >= 10 && degrees <= 18)
{
    if(partOfDay == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else 
         {
        outfit = "Shirt";
        shoes = "Moccasins";
    }

}
else if ( degrees > 18 && degrees <= 24)
{
    if (partOfDay == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else
    {
        outfit = "Shirt";
        shoes = "Moccassins";
    }
}
else if ( degrees >= 25)
{
    if (partOfDay == "Morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (partOfDay == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else  (partOfDay == "Evning")
            {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.")