// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int j = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
j = j + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + j);
