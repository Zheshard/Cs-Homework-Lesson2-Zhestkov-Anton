// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели");
int numberDay = Convert.ToInt32(Console.ReadLine());

while ((numberDay < 1) || (numberDay > 7))
{
	System.Console.WriteLine("Неверное значение. Введите цифру от 1 до 7: ");
	numberDay = Convert.ToInt32(Console.ReadLine());
}

if (numberDay == 6 || numberDay == 7)
{
	System.Console.WriteLine("Да");
}
else
{
	System.Console.WriteLine("Нет");
}
