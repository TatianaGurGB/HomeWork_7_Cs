// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArray(int[,] matr)
{
    int row_size = matr.GetLength(0);
    int column_size = matr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {matr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] matr = new int[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matr[i, j] = new Random().Next(from,to);      
    return matr;                                     
}                                                     

string NumPosition(int[,] matr, int num1, int num2)
{
    string text = "";
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    
    if (num1 > row || num1 <= 0 || num2 > column || num2 <= 0)
        text = $"{num1} {num2} -> don't belong to the array";

    for (int i = 0; i < row; i++)
       { for (int j = 0; j < column; j++)
            if (i + 1 == num1 && j + 1 == num2)
            {
                text = $"arr[{num1}, {num2}] = {matr[i, j]}  belongs to the array";
                break;
            }
       }    
    return text;
}

int[,] matr = FillArray(4, 5, 1, 10);
PrintArray(matr);

Console.Write("Enter the row position: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(NumPosition(matr, num1, num2));

