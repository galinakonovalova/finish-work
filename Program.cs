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



void print(int[] array)
{
  foreach (int v in array)
  {
    System.Console.Write($"{v} ");
  }
  System.Console.WriteLine();
}


string[] A = readStrings();
print(A);