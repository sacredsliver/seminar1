Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sqr = num * num;
Console.WriteLine($"квадрат числа {num} равен = {sqr}");

sqr = Convert.ToInt32(Math.Pow(num,2));
Console.WriteLine($"квадрат числа {num} равен = {sqr}");