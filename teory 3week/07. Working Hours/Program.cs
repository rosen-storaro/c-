int hours = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (hours >= 10 && hours <= 18)
{
    switch(day)
        {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            Console.WriteLine("Open");
            break;
        case "Sunday":
            Console.WriteLine("Closed");
            break;
        default:
            Console.WriteLine("invalid day");
            break;

    }
}
else
{
    Console.WriteLine("Closed");
}