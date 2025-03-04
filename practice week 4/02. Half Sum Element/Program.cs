int n = int.Parse(Console.ReadLine());
int sum = 0;
int maxNum = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
    if (num > maxNum)
    {
        maxNum = num;
    }
}
int sumWithoutMaxnum = sum - maxNum;

if (sumWithoutMaxnum == maxNum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs (maxNum - sumWithoutMaxnum)}");
}