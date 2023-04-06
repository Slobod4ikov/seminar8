/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int m, n;
Console.WriteLine("Введите количество строк массива");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите количество столбцов массива");
int.TryParse(Console.ReadLine(), out n);
int [,] array = CreateArray(m,n);
int [,] CreateArray(int m, int n){
    int [,] array = new int [m,n]; 
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
        array [i,j]=new Random().Next(10);
        Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }return array;
}
int sum=0;
for (int j = 0; j < array.GetLength(1); j++){
    sum = sum + array [0,j];
}
int sumMin = sum;
int minRowPosition = 0;
for (int i = 1; i <array.GetLength(0); i++){
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++){
        sum = sum + array [i,j];}
    if(sum<sumMin){
        sumMin=sum; 
        minRowPosition=i;}
}
Console.WriteLine();
Console.WriteLine($"{minRowPosition +1} -я строка имеет наименьшую сумму элементов");
