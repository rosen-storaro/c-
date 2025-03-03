double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

switch(operation)
{
    case '+':
        if((num1 + num2)%2 == 0)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2} - even");
        }
        else if ((num1 + num2) % 2 == 1)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2} - odd");
        }
        break;
    case '-':
        if ((num1 + num2) % 2 == 0)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2} - even");
        }
        else if ((num1 + num2) %2 == 1)    
        {
            Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2} - odd");
        }
        break;
    case '*':
        if ((num1 + num2) % 2 == 0)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {num1 * num2} - even");
        }
        else if ((num1 + num2) % 2 == 1)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {num1 * num2} - odd");
        }
        break;
    case '/':
        if (num2 == 0)
        {
            Console.WriteLine($"Cannot divide {num1} by zero");
        }
        else if
            {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2:f2}");
        }
       
        break;
    case '%':
        if (num2 == 0)
        {
            Console.WriteLine($"Cannot divide {num1} by zero");
        }
        else if
            {
            Console.WriteLine($"{num1} / {num2} = {num1 % num2}");
        }

        break;
    default:
        break;
}