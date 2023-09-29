/* №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Enter size of array"); 
int size = Convert.ToInt32(Console.ReadLine()); //считываем введенную строку, конвертируем в число
int[] numbers = new int[size]; //инициализация масива
InputArray(numbers); //вызов функции заполнения массива рандомными числами
Console.WriteLine("Array: "); 
PrintArray(numbers); //вывод массива на экран
int count = 0; // счетчик для количества чисел > 0 в массиве 

for (int i = 0; i < numbers.Length; i++) {//проходимся по всему массиву
    if (numbers[i] > 0) // если число больше нуля
        count++; // то инкрементируем счетчик
}
Console.WriteLine($"{count}");

void InputArray(int[] numbers) //функция заполнения массива введенными пользователем числами
{
    string temp; 
    for(int i = 0; i < numbers.Length; i++) {
        Console.WriteLine($"Enter {i + 1} value");
        temp = Console.ReadLine(); 
        numbers[i] = Convert.ToInt32(temp);
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