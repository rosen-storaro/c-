int targetSum = int.Parse(Console.ReadLine());
int sum  = 0;
while (sum < targetSum)
{
    sum += int.Parse(Console.ReadLine());
}
Console.WriteLine(sum);