Console.Write("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2 * num2) 
{
    Console.WriteLine($"число {num1} являеться квадратом числа {num2} ");
}
else
{
    Console.WriteLine($"число {num1} не являеться квадратом числа {num2} ");
}