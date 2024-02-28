int[,] CreateMatrix(int rowCount, int columnsCount)
{
  int[,] matrix = new int[rowCount, columnsCount];

  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) - требуем запросить кол-во строк в двумерном массиве
  {
    for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) -- 1 - первое измерение 
    {
      matrix[i, j] = rnd.Next(1, 1000);
    }
  }

  return matrix;
}

void ShowMatrix(int[,] matrix)
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

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
Console.WriteLine("\t");

foreach (var e in matrix)
{
  if(IsInteresting(e) == true){
    Console.WriteLine(e);
  }
}

bool IsInteresting(int value) 
{
  int SumOfDigits = GetSumOfDigits(value);

  return (SumOfDigits % 2 == 0) ? true : false;
}

int GetSumOfDigits(int value) 
{
  int sum = 0;

  while(value > 0)
  {
    sum += value % 10;
    value = value / 10;
  }

  return sum;
}