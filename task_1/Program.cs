// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
string numberStr = Console.ReadLine();

if (numberStr.Length == 3)
{
	int number = Convert.ToInt32(numberStr);
	int digit2 = (number % 100) / 10;
	System.Console.WriteLine(digit2);
}
else
{
	System.Console.WriteLine("Вы ввели неверное число!");
}
