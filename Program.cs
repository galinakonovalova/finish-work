string[] vvodStrings()
{
      Console.WriteLine("Введите строки:");

      int count = 0;
      string[] AS = new string[count];
      string s;
      do
      {
        s = Console.ReadLine();

        if (s!="")
        {
          count++;

          string[] AS2 = new string[count];

          for (int i = 0; i < AS.Length; i++)
            AS2[i] = AS[i];

          AS2[count - 1] = s;

          AS = AS2;
        }
      } while (s != "");

      for (int i = 0; i < AS.Length; i++)
        Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
    return AS;
}


string[] A = vvodStrings();