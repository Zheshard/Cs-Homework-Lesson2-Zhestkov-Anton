// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Ввдите число: ");
string number = Console.ReadLine();

if (number.Length > 2)
{
	System.Console.WriteLine(number[2]);
}
else
{
	System.Console.WriteLine("Третьей цифры нет");
}
