// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] matr)
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

double[,] FillArray(int row, int column, int from, int to)
{
    double[,] matr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matr[i, j] = new Random().Next(-12,3);      
    return matr;                                     
}                                                     

double[,] matr = FillArray(4, 5, -9, 10);
PrintArray(matr);

