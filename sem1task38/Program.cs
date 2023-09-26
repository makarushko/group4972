/*
№38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
[2 0,4 9 7,2 78] -> 77,6
*/
Console.WriteLine("Enter size of array"); 
int size = Convert.ToInt32(Console.ReadLine()); //считываем введенную строку, конвертируем в число
int[] numbers = new int[size]; //инициализация масива
FillArrayRandomNumbers(numbers); //вызов функции заполнения массива рандомными числами
Console.WriteLine("Array: "); 
PrintArray(numbers); //вывод массива на экран
double num = 0; // инициализация переменной для разницы максимального и минимального элементов
double max = numbers[0]; // инициализация максимального элемента
double min = numbers[0]; // инициализация минимального элемента

for (int i = 0; i < numbers.Length; i++) { //проходимся по всему массиву
    if (numbers[i] > max) { //если текущий элемент больше максимального
        max = numbers[i]; // то максимальному присвоить текущее значение
    }
    if (numbers[i] < min) { //если текущий элемент меньше минимального
        min = numbers[i]; // то минимальному присвоить текущее значение
    }
}
num = max-min; //вычисляем разницу между минимальным и максимальным
Console.WriteLine($"{num}");

void FillArrayRandomNumbers(int[] numbers) //функция заполнения массива рандомными числами
{
    for(int i = 0; i < numbers.Length; i++) //проходимся по всему массиву
    {
        numbers[i] = new Random().Next(1, 20); //заполняем массив с помощью функции рандома
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
