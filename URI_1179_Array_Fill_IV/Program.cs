using System;

namespace URI_1179_Array_Fill_IV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0, d, e, f, g, h, i, j, l = 0, m = 0, x = 0, n, p;

            int[] ArrayPar = new int[5];
            int[] ArrayImpar = new int[5];
            int[] ArrayAra = new int[15];

            for (b = 0; b < 15; b++)
            {
                ArrayAra[b] = int.Parse(Console.ReadLine());
            }
            for (a = 0; a < 15; a++)
            {
                if (l == 5)
                {
                    for (n = 0; n < 5; n++)

                        Console.WriteLine("impar[{0}] = {1}", n, ArrayImpar[n]);

                    l = 0;
                }
                if (m == 5)
                {
                    for (p = 0; p < 5; p++)
                        Console.WriteLine("par[{0}] = {1}", p, ArrayPar[p]);
                    m = 0;
                }

                if (ArrayAra[a] % 2 != 0)
                {
                    ArrayImpar[c] = ArrayAra[a];
                    ++c;
                    l++;
                    if (c == 5) c = 0;
                }
                if (ArrayAra[a] % 2 == 0)
                {
                    ArrayPar[x] = ArrayAra[a];
                    ++x;
                    m++;
                    if (x == 5) x = 0;
                }
            }
            for (i = 0; i < l; i++)
            {
                Console.WriteLine("impar[{0}] = {1}", i, ArrayImpar[i]);

            }
            for (j = 0; j < m; j++)
            {
                Console.WriteLine("par[{0}] = {1}", j, ArrayPar[j]);
            }

        }
    }
}
