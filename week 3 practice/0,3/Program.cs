string flower = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());    
int budget = int.Parse(Console.ReadLine());

double sum = 0;

switch (flower)
{
    case "Roses":
        sum = flowerCount * 5;
        if (flowerCount > 80)
        {
            sum *= 0.9;
        }
        break;
    case "Dahlias":
        sum = flowerCount * 3.8;
        if (flowerCount > 90)
        {
            sum *= 0.85;
        }
        break;
    case "Tulips":
        sum = flowerCount * 2.8;
        if (flowerCount > 80)
        {
            sum *= 0.85;
        }
        break;
    case "Narcissus":
        sum = flowerCount * 2;
        if (flowerCount > 120)
        {
            sum *= 1.15;
        }
        break;
    case "Gladiolus":
        sum = flowerCount * 2.5;
        if (flowerCount > 80)
        {
            sum *= 1.2;
        }
        break;
}
if (budget >= sum)
{
    Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - sum:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {sum-budget:f2} leva more");
}