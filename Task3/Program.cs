// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

void Average(int[,] matr)
{
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    double result = 0;

    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < row; j++) 
        result += matr[j, i];
        Console.Write($"{Math.Round(result / row, 1)}; ");
    }

}    

int[,] matr = FillArray(4, 3, 2, 10);
PrintArray(matr);
Average(matr);