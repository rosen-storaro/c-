string name = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int countJury = int.Parse(Console.ReadLine());
double givenPoints = points;
for (int i = 1; i <= countJury; i++)
{
    string nameJury = Console.ReadLine();
    double pointsJury = double.Parse(Console.ReadLine());
    givenPoints += nameJury.Length * pointsJury / 2;
    if (givenPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {givenPoints:F1}!");
        break;
    }
}
if  (givenPoints < 1250.5)
{
    Console.WriteLine($"Sorry, {name} you need {1250.5 -  givenPoints:F1} more!");
}