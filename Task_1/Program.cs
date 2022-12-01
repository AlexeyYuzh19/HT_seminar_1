// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Hello, World!");
Console.Write("Приветствую Вас, введите Ваше имя :");
string username = Console.ReadLine();

Console.Write("Привет, "); 
Console.WriteLine(username);


Console.WriteLine("Введите два числа и я вам сообщю какое число большее, а какое меньшее : ");

Console.Write("Введите первое число :");
int nam_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int nam_2 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

if (nam_1 > nam_2)
{
Console.Write("наибольшее число: ");
Console.WriteLine(nam_1);
Console.Write("меньшее число: ");
Console.WriteLine(nam_2);
}

if (nam_1 == nam_2)
{
Console.WriteLine("числа равны");
}
else
{
Console.Write("наибольшее число: ");
Console.WriteLine(nam_2);
Console.Write("меньшее число: ");
Console.WriteLine(nam_1);
}

Console.ResetColor();

Console.WriteLine("Проверим второй вариант программы");

Console.Write("Введите первое число :");
int nam_3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int nam_4 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

string V = nam_3 > nam_4 ? ("наибольшее первое число, второе число меньше первого") : ("наибольшее второе число, первое число меньше второго");

Console.WriteLine(V);

Console.ResetColor();