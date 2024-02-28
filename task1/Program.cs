// int[,] CreateMatrix(int rowCount, int columnsCount)
// {
//   int[,] matrix = new int[rowCount, columnsCount];

//   Random rnd = new Random();

//   for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) - требуем запросить кол-во строк в двумерном массиве
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) -- 1 - первое измерение 
//     {
//       matrix[i, j] = rnd.Next(1, 11);
//     }
//   }

//   return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) - требуем запросить кол-во строк в двумерном массиве
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) -- 1 - первое измерение 
//     {
//       Console.Write($"{matrix[i, j]} ");           // Интерполяция строк
//     }
//     Console.WriteLine();
//   }
// }

// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);

// Способы создания двумерного массива

// int[,] table1 = new int[2, 4] {
//   { 1, 1, 1, 1 },
//   { 2, 2, 2, 2 },
// };

// int[,] table2 = new int[,] {
//   { 1, 1, 1, 1 },
//   { 2, 2, 2, 2 },
// };

// int[,] table3 = {
//   { 1, 1, 1, 1 },
//   { 2, 2, 2, 2 },
// };


// Задача: Создать двумерный массив. Назовём число интересным, 
// если его сумма цифр чётная. Вывести "интересные" элементы

// Моё решение

int[,] arrayMy = {
  { 34, 34, 2, 53, 66, 87, 46, 2, 61, 67, 6, 26, 34, 21, 17, 78, 4 },
  { 34, 2, 1, 342, 67, 8, 87, 33, 576, 43, 22, 68, 465, 34, 767, 434, 2},
};

for (int i = 0; i < arrayMy.GetLength(0); i++)
{
  for (int j = 0; j < arrayMy.GetLength(1); j++)
  {

    int elm = arrayMy[i, j];
    int sum = 0;

    if(elm < 10) 
    {
      if(elm % 2 == 0)
      {
        Console.Write(elm); 
      }  
    }
    else
    {
      while (elm / 10 > 0)
      {
        sum += elm % 10;
        elm = elm / 10;

        if(elm < 10)
          sum += elm % 10;
      }
      if(sum % 2 == 0)
        Console.Write(sum); 
    }
    Console.Write(" "); 
  }
  Console.WriteLine("\t"); 
}

////////////////////////////
// Сумма чисел в числе

// int num = 5141;
// int count = 0;

// while (num / 10 > 0)
// {
//   count += num % 10;
//   num = num / 10;

//   if(num < 10)
//     count += num % 10;
// }

// Console.Write(count); 