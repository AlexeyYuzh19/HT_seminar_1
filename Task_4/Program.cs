// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Hello, World!");

Console.Write("Приветствую Вас, введите Ваше имя :");
string username = Console.ReadLine();

Console.Write("Привет, "); 
Console.WriteLine(username);

Console.WriteLine("Введите число и я выведу все четные числа от 1 до заданного числа : ");
int nam_1 = Convert.ToInt32(Console.ReadLine());
 
Console.ForegroundColor = ConsoleColor.Red;

for (int i = 1; i <= nam_1; i++)
{
   if (i % 2 == 0) 
   {
    Console.Write(i + " ");
   }
}

if (nam_1 < 0) Console.WriteLine("Вы ввели отрицательное число");
 
Console.ResetColor();