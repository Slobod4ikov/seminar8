/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int N =4;
int M =4;
int [,] array = new int [N,M];
int Ibeg = 0; 
int Ifin = 0;
int Jbeg = 0;
int Jfin = 0;
int k = 0;
int i = 0;
int j = 0;

while (k<=N*M){
    array[i,j]=k;
    if(i==Ibeg && j<M-Jfin-1) 
        j++;
    else if (j==M-Jfin-1 && i<N-Ifin-1)
        i++;
    else if (i==N-Ifin - 1 && j>Jbeg)
        j--;
    else
        i--;
    if ((i==Jbeg+1) && (j==Jbeg) && (j!=M-Jfin -1)){
        ++Jbeg;
        ++Jfin;
        ++Ibeg;
        ++Ifin;
    }
    ++k;
}

for (int r = 0; r < array.GetLength(0); r++)
{
    for (int c = 0; c < array.GetLength(1); c++){
        Console.Write($"{array[r,c]:d2} ");
    }
    Console.WriteLine();
}