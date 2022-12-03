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

int[] s = Sub(x, y);
for (int i = 0; i<s.Length;i++) Console.Write($"{s[i]} ");
System.Console.WriteLine();