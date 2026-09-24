string CharName;
int NumberOfBattle, ExpGained, TotalExp = 0;

Console.Write("input chracter's name: ");
CharName = Console.ReadLine();

Console.WriteLine("input the number of battles: ");
NumberOfBattle = int.Parse(Console.ReadLine());

Console.WriteLine("input the EXP gained per battle: ");
ExpGained = int.Parse(Console.ReadLine());

Console.WriteLine("---------------------------");

for (int i = 1; i <= NumberOfBattle; i++)
{
    TotalExp += ExpGained;
    Console.WriteLine($"Battle {i} [EXP gained: {ExpGained} ] Total EXP: {TotalExp}");
}

Console.WriteLine("\n=== BATTLE COMPLETE ===");
Console.WriteLine($"Character:\t{CharName}");
Console.WriteLine($"Battles:\t{NumberOfBattle}");
Console.WriteLine($"Total EXP:\t{TotalExp}");