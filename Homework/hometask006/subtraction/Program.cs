int[] x = { 1, 0, 0, 0, -9, -6 };
int[] y = { 0, 1, -2, -5, 0, 0, 7, 3 };

int[] Sub(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] - g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i] * (-1);
    else result[i] = f[i];
  }

  return result;
}

String Print(int[] f)
{
  string output = String.Empty;
  for(int i=0; i<f.Length; i++)
  {
    if(f[i] != 0) { output += $"{f[i]}*x^{i}"; }
    if(f[i] != 0 && i < f.Length -1) output += " + ";
  }

  return output;
}

Console.WriteLine(Print(x));
Console.WriteLine(Print(y));
int[] s = Sub(x, y);
Console.WriteLine(Print(s));
// for (int i = 0; i<s.Length;i++) Console.Write($"{s[i]} ");
System.Console.WriteLine();