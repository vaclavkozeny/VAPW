/*
Napiste konzolovou aplikaci, kde:

   1) nadefinujete a inicializujete (staci 10 prvku, kde alespon 2 prvky budou mit hodnotu null) jednorozmerne pole, kde prvky jsou typu int?

   2) napisete alg. trideni vkladanim, kde plati, ze null je nejvyssi hodnota (po setrideni budou prvky na konci pole)

   3) do nove definovaneho pole prekopirujete setridene pole bez polozek s hodnotou null

   Pole po jednotlivych krocich vypisujte do konzole

   Pozn.:
   - pro vypis do konzole pouzivejte Console.Write, Console.WriteLine
*/
int?[] InsertSort(int?[] arr)
{
   for (int i = 1; i < arr.Length; i++)
   {
      int? prvek = arr[i];
      int j = i - 1;
      while (j >= 0 && (arr[j] > prvek || arr[j] == null))
      {
         arr[j + 1] = arr[j];
         j--;
      }
      arr[j + 1] = prvek;
      foreach (var p in arr)
      {
         Console.Write(p.HasValue ? p+" " : "null ");
      }
      Console.Write(("\n"));
   }
   return arr;
}


int?[] pole = { 8, null, 5, 4, 5, null, 6, 7, null, 8 };
pole = InsertSort(pole);
foreach (var i in pole)
{
   Console.Write(i.HasValue ? i+" " : "null ");
}

int?[] newarr = pole.Where(x => x != null).ToArray();
Console.Write("\n");
foreach (var i in newarr)
{
   Console.Write(i + " ");
}

