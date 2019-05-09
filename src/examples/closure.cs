static Func<int, int> MakeAdder(int x)
{
  Func<int, int> func = y => x + y;
  
  return func;
}

public static void Main(string[] args)
{
  var add5 = MakeAdder(5);
  var add10 = MakeAdder(10);

  Console.WriteLine(add5(7));  // 12
  Console.WriteLine(add10(7)); // 17
}