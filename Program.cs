/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int [,] PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
        Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }return array;
}
for (int i = 0; i <array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        int max = array [i,j];
        for (int k = j; k < array.GetLength(1); k++){
            int position = 0;
            if(array[i,k]>max){
                max=array[i,k];
                position=k;
                }
        if(array [i,j]<max){
            int temp=array[i,j];
            array[i,j]=max;
            array[i,position]=temp;}
    }
}}
Console.WriteLine();
PrintArray(array);