int n = int.Parse(Console.ReadLine());
int p1Count = 0;
int p2Count = 0;
int p3Count = 0;
int p4Count = 0;
int p5Count = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    switch(num)
    {
        case < 200:
            p1Count++;
            break;
        case < 400:
            p2Count++;
            break;
        case < 600:
            p3Count++;
            break;
        case < 800:
            p4Count++;
            break;
        case >= 800:
            p5Count++;
            break;

        default:
            break;
    }
}
Console.WriteLine($"{((double)p1Count / n * 100):F2}%");
Console.WriteLine($"{((double)p2Count / n * 100):F2}%");
Console.WriteLine($"{((double)p3Count / n * 100):F2}%");
Console.WriteLine($"{((double)p4Count / n * 100):F2}%");
Console.WriteLine($"{((double)p5Count / n * 100):F2}%");
