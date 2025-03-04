int countTour = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());
int winPoints = 0;
int countWinTour = 0; 
for (int i = 1; i <= countTour; i++)
{
    string result = Console.ReadLine();
    if (result == "W")
    {
        winPoints += 2000;
        countWinTour++;
    }
    else if (result == "F")
    {
        winPoints += 1200;
    }
    else
    {
        winPoints += 720;
    }
}
Console.WriteLine($"Final points: {winPoints +  startPoints}");
Console.WriteLine($"Average points: {Math.Floor((double)winPoints / countTour)}");
Console.WriteLine($"{(double)countWinTour / countTour * 100:F2}%");