string input = Console.ReadLine();
int maxNumber = 0;
while (input != "Stop")
{
    int currentNumber = int.Parse (input);
    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber;
    }
    input = Console.ReadLine();
}
Console.WriteLine(maxNumber);