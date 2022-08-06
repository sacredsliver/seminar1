Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

int num2 = -num1;
int count = num2;
int num3 = num2;

while (count < (num1+1))
{
Console.WriteLine(num3);
num3++;
count++;
}

