static Func<int, Func<int, int>> Volume(int length)
{
  Func<int, Func<int, int>> func = width => {
    Func<int, int> func1 = height => length * width * height;

    return func1;
  };

  return func;
}

public static void Main(string[] args)
{
  Console.WriteLine(Volume(2)(3)(4)); // 24
}