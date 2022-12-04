// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
string numberStr = Console.ReadLine();

while (numberStr.Length != 3)
{
	Console.WriteLine("Для выполенния программы, необходимо ввести трехзначное число: ");
	numberStr = Console.ReadLine();
}
int number = Convert.ToInt32(numberStr);
int digit2 = (number % 100) / 10;
System.Console.WriteLine(digit2);

