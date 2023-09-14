/* №13 Напишите программу, которая выводит третью цифру
   заданного числа или сообщает, что третьей цифры нет.
   
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;
if (length >= 3) {
	while (number > 999)
	{
		number = number / 10;
	}
	int result = number % 10;
	Console.WriteLine("The third digit is " + result);
} else {
	Console.WriteLine("The number contains less than 3 digits");
}