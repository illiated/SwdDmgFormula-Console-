
using SwdDmgFormula;

SwordDamage swdDamage = new SwordDamage();
Random random = new Random();

Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
char input = Console.ReadKey().KeyChar;

if (input != '0' && input != '1' && input != '2' && input != '3') return;
swdDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + (random.Next(1, 7));

swdDamage.SetMagic(input == '1' || input == '3');
swdDamage.SetFlaming(input == '2' || input == '3');

Console.WriteLine($"\nRolled {swdDamage.Roll} for {swdDamage.Damage} HP\n");