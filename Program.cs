string[] resizeAndAdd(string[] AS, string s)
{
  string[] AS2 = new string[AS.Length + 1];

  // скопировать старый массив в новый
  for (int i = 0; i < AS.Length; i++)
    AS2[i] = AS[i];

  // добавить последнюю введенную строку в массив AS2
  AS2[AS2.Length - 1] = s;
  return AS2;
}

string[] readStrings()
{
      // Ввод строк с клавиатуры
      // и образование нового массива
 
      Console.WriteLine("Введите строки:");

      int count = 0;
      string[] AS = new string[count];

      string s;
      do
      {
        // Ввести строку
        s = Console.ReadLine();

        // Проверка, пустая ли строка
        if (s!="")
        {
          AS = resizeAndAdd(AS, s);

          count++;
        }
      } while (s != "");

    return AS;
}

void print(string[] array)
{
  foreach (string v in array)
  {
    Console.Write($"{v} ");
  }
  Console.WriteLine();
}


string[] A = readStrings();
print(A);

string[] result = new string[0];

// смотрим на значения массива
foreach (string v in A)
{
  if (v.Length <= 3)
  {
    // если длина меньше или равна 3, добавляем в результат
    result = resizeAndAdd(result, v);
  }
}

Console.WriteLine("Результат: ");
print(result);