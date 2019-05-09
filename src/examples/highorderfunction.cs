static void Repeat(int n, Action<int> predicate, int i = 0)
{
  if (i == n)
    return;

  predicate(i);

  Repeat(n, predicate, ++i);
}

public static void Main(string[] args)
{
  Repeat(3, Console.WriteLine);
  // 0
  // 1
  // 2
}