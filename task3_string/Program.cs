// Создание строк в C#

// string str = "Hello world!";
// Console.Write(str[0]); // H 

// Неизменяемый тип данных 
  // - Элементы строки не могут быть изменены
  // - Размер существующей строки не может быть изменён 

// Console.Write(str[7] = "W"); // Невозможно присвоить значение свойству 
// или индексатору "string.this[int]" — доступ только для чтения.

// Console.WriteLine(str[1]); // Операция индексации может быть применена для чтения строки // e


// Способы создания строк
// 1) 
// string s1 = "Hello";

// 2) Из символьного массива типа char
// char [] ch_array = { 'w', 'o', 'r', 'l', 'd' };
// string s2 = new String(ch_array);   // String - конструктор

// 2) Для создания строк из повторяющихся символов
// string s3 = new String('a', 6);   // String - конструктор
// Console.Write(s3); // aaaaaa

////////////////////
// Методы для работы со строками
// Contains - Определяет, содержится ли подстрока в строке
// EndsWith - Определяет, совпадает ли конец строки с подстрокой
// IndexOf - Находит индекс первого вхождения символа или подстроки в строке
// Insert - Вставляет строку в подстроку
// Replace - Замещает в строке символ или подстроку другим символом или подстрокой

// Insert и Replace для изменения строки, однако строка не меняется
// Они создают новую строку с выделением памяти и результат работы 
// помещается в эту новую строку, при этом исходная строка не изменяется

string GetLettersFromString(string s)
{
  string letters = "";

  foreach (char e in s)
  {
    if(char.IsAsciiLetter(e) == true)
    {
      letters += e;
    }
  }

  return letters;
}

Console.WriteLine("Enter stroke and spec simbols");
string str = (Console.ReadLine()!);
string result = GetLettersFromString(str);
Console.WriteLine(result);