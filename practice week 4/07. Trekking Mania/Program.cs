
int groups = int.Parse(Console.ReadLine());

int musala = 0, mountblanc = 0, kilimanjaro = 0, k2 = 0, everest = 0;
int totalClimbers = 0;

for (int i = 0; i < groups; i++)
{
    int people = int.Parse(Console.ReadLine());
    totalClimbers += people;

    switch(true)
    {
        case var _ when people <= 5:
            {
                musala += people;
                break;
            }
            case var _ when people <= 12:
            {
                mountblanc += people;
                break;
            }
            case var _ when people <= 25:
            {
                kilimanjaro += people;
                break;
            }
        case var _ when people <= 40:
            {
                k2 += people;
                break;
            }
            default:
            {
                everest += people;
                break;
            }
    }
}
Console.WriteLine($"{(musala * 100.0 / totalClimbers):F2}%");
Console.WriteLine($"{(mountblanc * 100.0 / totalClimbers):F2}%");
Console.WriteLine($"{(kilimanjaro * 100.0 / totalClimbers):F2}%");
Console.WriteLine($"{(k2 * 100.0 / totalClimbers):F2}%");
Console.WriteLine($"{(everest * 100.0 / totalClimbers):F2}%");