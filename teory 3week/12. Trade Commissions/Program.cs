string city = Console.ReadLine().Trim();
double sales = double.Parse(Console.ReadLine());

double commission = 0;
bool isValid = true;

if (sales < 0)
{
    isValid = false;
}
else
{
   switch(city)
    {
        case "Sofia":
            if (sales <= 500) commission = 0.05;
            else if (sales <= 1000) commission = 0.07;
            else if (sales <= 10000) commission = 0.08;
            else commission = 0.12;
            break;
        case "Varna":
            if (sales <= 500) commission = 0.045;
            else if (sales <= 1000) commission = 0.075;
            else if (sales <= 10000) commission = 0.10;
            else commission = 0.13;
            break;

        case "Plovdiv":
            if (sales <= 500) commission = 0.055;
            else if (sales <= 1000) commission = 0.08;
            else if (sales <= 10000) commission = 0.12;
            else commission = 0.145;
            break;

        default:
            isValid = false;
            break;
    }
}
if (isValid)
{
    Console.WriteLine($"{(sales * commission):f2}");
}
else
{
    Console.WriteLine("error");
}
