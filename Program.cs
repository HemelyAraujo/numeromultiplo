Console.WriteLine("-- Números Múltiplos --");
Console.WriteLine("");
Console.WriteLine("Digite um número...");

int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um número para comparar se ele é múltiplo ou não...");

int multiplo = Convert.ToInt32(Console.ReadLine());

if (numero1 % multiplo == 0)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"O número {numero1} é múltiplo de {multiplo}!");
    Console.WriteLine("");
}

else
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"O número escrito ({numero1}) não é múltiplo do outro número escrito ({multiplo})!");
    Console.WriteLine("");
}
Console.ResetColor();
return;