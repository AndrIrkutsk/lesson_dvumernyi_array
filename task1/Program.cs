int[,] CreateMatrix (int rowCount, int columnsCount) 
{
  int[,] matrix = new int[rowCount, columnsCount];

  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) - требуем запросить кол-во строк в двумерном массиве
  {
    for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) -- 1 - первое измерение 
    {
      matrix[i, j] = rnd.Next(1, 11);
    }
  }

  return matrix;
}

void ShowMatrix (int[,] matrix) 
{
  for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) - требуем запросить кол-во строк в двумерном массиве
  {
    for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) -- 1 - первое измерение 
    {
      Console.Write($"{matrix[i, j]} ");           // Интерполяция строк
    }
    Console.WriteLine();
  }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix (matrix);
