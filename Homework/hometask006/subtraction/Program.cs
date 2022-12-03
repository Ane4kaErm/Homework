int[] x = { 1, 0, 0, 0, -9, -6 };
int[] y = { 1, 1, -2, -5, 0, 0, 7, 3 };

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

string Print(int[] f) 
{
  Console.OutputEncoding = System.Text.Encoding.UTF8;
  string[] pows = { "⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹"};
  string output = String.Empty;
  for (int i = 0; i < f.Length; i++)
  {

    int t = f[i];
    if (f[i] == 0)  continue;
    if (f[i] < 0) { output += " - "; }
    else if (i != 0) { output += " + "; }

    if (t < 0) t = -t;
    if (i == 1) { output += $"{t}x"; }
    if (i == 0) { output += $"{t}"; }
    if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x{pows[i]}"; }
    // if (flag && f[i] != 0 && i < f.Length - 1) output += " + ";
  }

  return output;
}


Console.WriteLine(Print(x));
Console.WriteLine(Print(y));
int[] s = Sub(x, y);
Console.WriteLine(Print(s));
// for (int i = 0; i<s.Length;i++) Console.Write($"{s[i]} ");
System.Console.WriteLine();