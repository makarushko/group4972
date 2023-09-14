/* Напишите программу, которая принимает на вход трёхзначное число
   и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Enter a 3-digit number: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000) {
	int result = (number / 10) % 10;
	Console.WriteLine($"The second digit is {result}");
} else {
	Console.WriteLine("Not a 3-digit number. Please try again");
}