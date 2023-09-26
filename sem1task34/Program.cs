/* №34 Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
[845, 222, 367, 123 -> 1
*/
Console.WriteLine("Enter size of array"); 
int size = Convert.ToInt32(Console.ReadLine()); //считываем введенную строку, конвертируем в число
int[] numbers = new int[size]; //инициализация масива
FillArrayRandomNumbers(numbers); //вызов функции заполнения массива рандомными числами
Console.WriteLine("Array: "); 
PrintArray(numbers); //вывод массива на экран
int count = 0; // счетчик для количества четных чисел в массиве

for (int i = 0; i < numbers.Length; i++) //проходимся по всему массиву
if (numbers[i] % 2 == 0) // если число четное
count++; // то инкрементируем счетчик

Console.WriteLine($"{count} even numbers");

void FillArrayRandomNumbers(int[] numbers) //функция заполнения массива рандомными положительными трехзначными числами
{
    for(int i = 0; i < numbers.Length; i++) //проходимся по всему массиву
    {
        numbers[i] = new Random().Next(100,1000); //заполняем массив с помощью функции рандома
    }
}
void PrintArray(int[] numbers) //функция вывода на экран массива
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}