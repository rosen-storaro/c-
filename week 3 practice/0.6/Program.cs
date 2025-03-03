using System.ComponentModel.Design;

int startHour = int.Parse(Console.ReadLine());
int startMin =  int.Parse(Console.ReadLine()); 
int arriveHours = int.Parse(Console.ReadLine());
int arriveMin = int.Parse(Console.ReadLine());

int startTime = startHour * 60 + startMin;
int arriveTime = arriveHours * 60 + arriveMin;
int diffrenceTime = Math.Abs(startTime - arriveTime);
int differnceHour = diffrenceTime / 60;
int differnceMin = diffrenceTime % 60;

if (startTime < arriveTime)
{
    Console.WriteLine("Late");
    if (differnceHour == 0)
    {
        Console.WriteLine($"{differnceMin} minutes after the start");
    }
    else
    {
        Console.WriteLine($"{differnceHour}:{differnceMin:d2} hours after the start");
    }
}
else if (diffrenceTime <= 30)
{
    Console.WriteLine("On time");
    if (differnceMin != 0)
    {
        Console.WriteLine($"{differnceMin} minutes before the start");
    }
}
else
{
    Console.WriteLine("Early");
    if (differnceHour == 0) ;
    {
        Console.WriteLine($"{differnceMin} minutes before the start");
    }
    else
    {
        Console.WriteLine($"{differnceHour}:{differnceMin:d2} hours before the start");
    }

}