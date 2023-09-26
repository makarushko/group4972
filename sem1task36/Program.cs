/*
№36 Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[3, 7, -2, 1] -> 8
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Enter size of array"); 
int size = Convert.ToInt32(Console.ReadLine()); //считываем введенную строку, конвертируем в число
int[] numbers = new int[size]; //инициализация масива
FillArrayRandomNumbers(numbers); //вызов функции заполнения массива рандомными числами
Console.WriteLine("Array: "); 
PrintArray(numbers); //вывод массива на экран
int sum = 0; // инициализация переменной для суммы элементов

for (int i = 1; i < numbers.Length; i = i+2) //проходимся по нечетным позициям
sum+=numbers[i]; // суммируем элементы

Console.WriteLine($"Sum = {sum}");

void FillArrayRandomNumbers(int[] numbers) //функция заполнения массива рандомными числами
{
    for(int i = 0; i < numbers.Length; i++) //проходимся по всему массиву
    {
        numbers[i] = new Random().Next(); //заполняем массив с помощью функции рандома
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