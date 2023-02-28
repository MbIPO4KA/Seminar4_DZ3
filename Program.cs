/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] resultArray = GetArray(8);

int[] GetArray(int size)
{
    int[] array = new int[size];     
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100); 
    }
    return array;
}
Console.WriteLine($"Массив на 8 цифр диапозоном от 0 до 99: [ {String.Join(", ", resultArray)} ]");
