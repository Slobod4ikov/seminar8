/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int m, n, h;
Console.WriteLine("Введите количество строк первой матрицы");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите количество столбцов первой матрицы");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine("Введите количество строк второй матрицы");
int.TryParse(Console.ReadLine(), out h);
int [,] matrix1 = CreateArray(m,n);
Console.WriteLine();
int [,] matrix2 = CreateArray(n,h);
Console.WriteLine();
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
int [,] matrix3 = new int [m,h];
for (int i = 0; i < n-1; i++){
    for (int j = 0; j < h-1; j++){
        int temp = 0;
        for (int k = 0; k < h-1; k++){
            temp= temp+matrix1[i,k]*matrix2[k,i];
    }
    matrix3[i,j]= temp;
    Console.Write($"{matrix3[i,j]} ");}
    Console.WriteLine();
}
