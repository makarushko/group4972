// №29 Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

Console.WriteLine("Введите начальное значение диапазона: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное значение диапазона: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
    randomArray[i] = new Random().Next(minValue,maxValue);
    Console.Write(randomArray[i] + " ");
}