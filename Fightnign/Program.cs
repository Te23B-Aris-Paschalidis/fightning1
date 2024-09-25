
int hp = 100;
int MasterSandor = 100;
while (hp > 0 && MasterSandor > 0)
{
    Console.WriteLine($"Hjältens Hp: {hp}");
    hp -= Random.Shared.Next(14);

    Console.WriteLine($"MasterSandor Hp: {MasterSandor}");  
    MasterSandor -= Random.Shared.Next(14);

    Console.ReadLine();
}

Console.ReadLine();