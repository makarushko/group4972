/*  Напишите программу, которая принимает на вход цифру,
    обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Enter a day of week: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <=7) {
	if (day >= 6) {
		Console.Write("Yes.");
	} else {
		Console.Write("No.");
	}
} else {
	Console.Write("Invalid symbol. Try again and enter a day between 1 and 7.");
}