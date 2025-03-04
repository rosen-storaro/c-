int n = int.Parse(Console.ReadLine());

int left = 0;
for (int i = 1; i <= n; i++)
{
    int number = int.Parse(Console.ReadLine());
    left += number;
}

int right = 0;  
for (int i = 1; i <= n; i++)
{
    int number = int.Parse(Console.ReadLine());
    right += number;
}
if (left == right)
{
    Console.WriteLine($"Yes, sum = {left}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(left-right)}");
}