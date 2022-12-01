// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Hello, World!");

Console.Write("Приветствую Вас, введите Ваше имя :");
string username = Console.ReadLine();

Console.Write("Привет, "); 
Console.WriteLine(username);

Console.WriteLine("Введите три числа и я вам сообщю максимальное из этих чисел : ");

Console.Write("Введите первое число :");
int namb_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int namb_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число :");
int namb_3 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

int maxi = namb_1;

if (namb_1 - namb_2 + namb_3 == namb_1)
{
Console.WriteLine("числа равны");
}
else
{
  if (maxi < namb_2) 
  {
    maxi = namb_2;
  }
  if (maxi < namb_3)
  {
    maxi = namb_3;
  }
   Console.WriteLine("наибольшее число: " +maxi);
}

Console.ResetColor();

Console.WriteLine("Проверим второй вариант с помощью оператора Match :");

Console.Write("Введите первое число :");
int nam_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int nam_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число :");
int nam_3 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

if (nam_1 - nam_2 + nam_3 == nam_1)
{
Console.WriteLine("числа равны");
}
else
{
int max = Math.Max(nam_1, nam_2);
max = Math.Max(max, nam_3);

Console.Write("наибольшее число: " +max);
}
Console.ResetColor();
