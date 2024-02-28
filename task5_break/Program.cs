// break - прерывает выполнение ближайшего внешнего цикла
// Ключевые слова: прерывает и внешнего 
// (while, for, foreach)

// break часто используется когда возникло условие, при котором цикл 
// нужно немедленно прервать 
// Распространённый случай - остановка цикла с условием true (бесконечный цикл)

// while (true)
// {
//   Console.WriteLine("I am in loop!");
//   break;
// }

//////////////////

// Пример: выдать на экран сообщение в случае наличия в массиве нечётного числа

Console.WriteLine("start");
int[] numbers = { 2, 4, 6, 7, 8, 10 };

foreach (var number in numbers)
{
  if(number % 2 == 1)
  {
    Console.WriteLine($"There is odd number! - {number}");
    break;
  }
}
Console.WriteLine("stop");
Console.WriteLine(" ");

////////////////

// Пример объяснения ближайший и внешний

int[,] table = {
  {1, -1, 1},
  {2, 2, 2},
  {3, 3, -3}
};

for (int i = 0; i < table.GetLength(0); i++)
{
  for (int j = 0; j < table.GetLength(1); j++)
  {
    if(table[i, j] < 0 )
    {
      Console.WriteLine($"There are negative elements in line {i}");
      break;
    }
  }
}
// There are negative elements in line 0
// There are negative elements in line 2

