// Напишите программу, которая на вход принимает два числа и выдает,
// какое исло большее и какое меньшее.

Console.Clear();
Console.Write("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n > n2)
   Console.WriteLine($"max{n}");
else
  Console.WriteLine($"max{n2}");   