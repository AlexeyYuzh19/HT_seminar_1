// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Hello, World!");

Console.Write("Приветствую Вас, введите Ваше имя :");
string username = Console.ReadLine();

Console.Write("Привет, "); 
Console.WriteLine(username);

Console.WriteLine("Введите число и я сообщю четное оно или нечетное : ");
int nam_1 = Convert.ToInt32(Console.ReadLine());
 
Console.ForegroundColor = ConsoleColor.Green;

if (nam_1 % 2 == 0) Console.WriteLine("четное число  " +nam_1);
else Console.WriteLine("нечетное число  " +nam_1);

Console.ResetColor();
